using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw; // Esta directiva importa SolidLine


namespace ABM2
{
    public partial class frm8_vender : Form
    {
        public MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password='' ");
        public DataTable artab = new DataTable();
        public DataTable pedtab = new DataTable();
        public DataTable datosclientes = new DataTable();
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private string nomcomercio = "";
        private string direccion = "";
        private string telefono = "";
        private string cuit = "";
        private string numFactura = "";
        private decimal pagosdebito = 1.0m;
        private decimal pagoscredito = 1.0m;

        public static frm8_vender Instancia { get; private set; }

        public frm8_vender()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.WindowState = FormWindowState.Maximized;
            Instancia = this; // Guardar referencia estática de esta instancia clientes consum final
        }

        private void frm8_vender_Load(object sender, EventArgs e)
        {
            CargarDatosComercio();
        } 
        private void frm8_vender_Activated(object sender, EventArgs e)
        {


            if (pedtab.Columns.Count == 0)
            {
                pedtab.Columns.Add("idproducto", typeof(int));
                pedtab.Columns.Add("Cantidad", typeof(int));
                pedtab.Columns.Add("Articulo", typeof(string));
                pedtab.Columns.Add("Importe", typeof(decimal));
                // pedtab.Columns.Add("Cobrar", typeof(bool));
            }
            dgvpedido.RowHeadersVisible = false;

            foreach (DataGridViewColumn column in dgvpedido.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            // Artículos
            artab.Clear();
            con.Open();
            MySqlDataAdapter artadapt = new MySqlDataAdapter("SELECT idproducto, codigo, stock,stockmin, articulos, precio_venta FROM productos", con);
            artadapt.Fill(artab);
            dgvarts.DataSource = artab;
            dgvarts.ClearSelection();

            //---------------------------------------------------------------------------------------------------------------------------------

            dgvarts.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle encabezado = new DataGridViewCellStyle();
            encabezado.BackColor = Color.LightGoldenrodYellow;
            encabezado.ForeColor = Color.Black;
            encabezado.Font = new Font("Bradley Hand ITC", 15, FontStyle.Bold);
            encabezado.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvarts.ColumnHeadersDefaultCellStyle = encabezado;
            dgvarts.RowHeadersVisible = false;
            //Encabezados de las columnas
            dgvarts.Columns["idproducto"].Visible = false;
            dgvarts.Columns["codigo"].Visible = false;
            dgvarts.Columns["stockmin"].Visible = false;
            dgvarts.Columns["stock"].HeaderText = "Stock";
            dgvarts.Columns["articulos"].HeaderText = "Artículos";
            dgvarts.Columns["precio_venta"].HeaderText = "P.Venta";
            dgvarts.Columns["stock"].Width = 70;
            dgvarts.Columns["articulos"].Width = 250;
            dgvarts.Columns["precio_venta"].Width = 100;
            // Centrar contenido
            foreach (DataGridViewColumn column in dgvarts.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
             foreach (DataGridViewColumn column in dgvpedido.Columns)
              {
                  column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                  column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
              }

             dgvpedido.EnableHeadersVisualStyles = false;
             DataGridViewCellStyle encabezado2 = new DataGridViewCellStyle();
              encabezado2.BackColor = Color.LightGoldenrodYellow;
              encabezado2.ForeColor = Color.Black;
              encabezado2.Font = new Font("Bradley Hand ITC", 15, FontStyle.Bold);

              dgvpedido.ColumnHeadersDefaultCellStyle = encabezado2;
                  
            dgvpedido.DataSource = pedtab;
            dgvpedido.RowHeadersVisible = false;
            dgvpedido.Columns["idproducto"].Visible = false;
            dgvpedido.Columns["Cantidad"].Width = 90;
            dgvpedido.Columns["Articulo"].Width = 250;
            dgvpedido.Columns["Importe"].Width = 100;


            con.Close();

        }
        private void busartxt_TextChanged(object sender, EventArgs e)
        {
            artab.DefaultView.RowFilter = "articulos LIKE '%" + busartxt.Text + "%' ";//&& codigo LIKE '" + busartxt.Text + "'
            coincidtxt.Text = "Encontrados: " + artab.DefaultView.Count.ToString();
        }

        //-----------------------------------------------------------------
        private string nfc() // Función nueva factura
        {
            // Genera el número de factura usando la fecha y hora actual
            string nuevafac = DateTime.Now.ToString("yyyyMMddHHmmss"); // AñoMesDíaHoraMinutoSegundo

            return nuevafac;
        }
        //--------------------------------------------------------------------------

        decimal subtotal = 0;
        decimal debacum = 0;
        decimal credacum = 0;

        private void imprimir_Click(object sender, EventArgs e)
        {       //Cargar productos
            numFactura = nfc(); // Ahora es un string
            nfactxt.Text = "N° " + numFactura;

            if (dgvarts.SelectedRows.Count != 0 && busartxt.Text == "")
            {
                MessageBox.Show("Por favor, selecciona un artículo.");
               
            }

            if (string.IsNullOrWhiteSpace(cantxt.Text))
            {
                MessageBox.Show("Por favor, ingresa una cantidad.");
                return;
            }

            int cantidad = Convert.ToInt32(cantxt.Text);
            cantxt.Text = cantidad.ToString();
            int idproducto = Convert.ToInt32(dgvarts.CurrentRow.Cells["idproducto"].Value);
            int stockmin = dgvarts.CurrentRow.Cells["stockmin"].Value != DBNull.Value ? Convert.ToInt32(dgvarts.CurrentRow.Cells["stockmin"].Value) : 0;
            int stockDisponible = Convert.ToInt32(dgvarts.CurrentRow.Cells["stock"].Value);

            if (stockDisponible <= stockmin)
            {
                MessageBox.Show("Stock mínimo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (stockDisponible < cantidad ||  stockDisponible == 0)
            {
                MessageBox.Show("No hay  stock para este producto.");
                busartxt.Focus(); busartxt.Clear(); cantxt.Clear(); preciounitxt.Clear(); imptxt.Clear();
                return;
            }

            string articulo = dgvarts.CurrentRow.Cells["articulos"].Value.ToString();
            string mosdebpor = pagosdebito.ToString() ;
            string moscredpor = pagoscredito.ToString();


            // Verificar si el precio de venta es DBNull.Value
            if (dgvarts.CurrentRow.Cells["precio_venta"].Value == DBNull.Value)
            {
                MessageBox.Show("El precio de venta no está disponible para el artículo seleccionado.");
                return;
            }

            decimal pventa = Convert.ToDecimal(dgvarts.CurrentRow.Cells["precio_venta"].Value);
            decimal importe = cantidad * pventa;
            imptxt.Text = importe.ToString("C");
            decimal deb = importe + (importe * pagosdebito / 100);
            decimal cred = importe + (importe * pagoscredito / 100);

            subtotal += importe;
            debacum += deb;
            credacum += cred;
            int nuevoStock = stockDisponible - cantidad;
            dgvarts.CurrentRow.Cells["stock"].Value = nuevoStock;

            // Agregar articulo a la lista de compra
            pedtab.Rows.Add(idproducto, cantidad, articulo, importe);

            subtotaltxt.Text = subtotal.ToString("C");
            efectivotxt.Text = subtotal.ToString("C");
            debitotxt.Text = debacum.ToString("C");  deb_porcent.Text = mosdebpor;
            creditotxt.Text = credacum.ToString("C"); cred_porcent.Text = moscredpor;
            
            busartxt.Focus(); busartxt.Clear(); cantxt.Clear(); preciounitxt.Clear(); imptxt.Clear();

        }

        private void vendido_Click(object sender, EventArgs e)
        {
            if (dgvpedido.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea confirmar la venta?", "Confirmar Venta", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Validar método de pago
                    if (!rb_efectivo.Checked && !rb_deb.Checked && !rb_cred.Checked)
                    {
                        MessageBox.Show("Por favor, selecciona un método de pago antes de continuar.", "Método de Pago Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string numfac = nfc(); // Genera el número de factura
                    string efectivo = null;
                    string debito = null;
                    string credito = null;

                    decimal totalVenta = 0; // Variable para almacenar el total ajustado de la venta

                    // Validar método de pago y configurar valores
                    if (rb_efectivo.Checked)
                    {
                        efectivo = "PAGADO";
                        MessageBox.Show("Pago en EFECTIVO confirmado.");
                    }
                    else if (rb_deb.Checked)
                    {
                        debito = "PAGADO";
                        MessageBox.Show("Pago con DÉBITO confirmado.");
                    }
                    else if (rb_cred.Checked)
                    {
                        credito = "PAGADO";
                        MessageBox.Show("Pago con CRÉDITO confirmado.");
                    }

                    // Procesar los productos de la venta
                    foreach (DataRow row in pedtab.Rows)
                    {
                        int idproducto = Convert.ToInt32(row["idproducto"]);
                        int cantidad = Convert.ToInt32(row["Cantidad"]);
                        string articulo = row["Articulo"].ToString();
                        decimal importe = Convert.ToDecimal(row["Importe"]);
                        decimal importeAjustado = importe; // Por defecto, sin ajuste
                        if (rb_deb.Checked)
                        {
                            importeAjustado = importe * (1 + pagosdebito / 100); // Ajuste según porcentaje de débito
                        }
                        else if (rb_cred.Checked)
                        {
                            importeAjustado = importe * (1 + pagoscredito / 100); // Ajuste según porcentaje de crédito
                        }

                        totalVenta += importeAjustado;
                        string metodoPago = rb_efectivo.Checked ? "efectivo" :
                        rb_deb.Checked ? "débito" : "crédito";
                        con.Open();
                        MySqlCommand venta = new MySqlCommand(
                            "INSERT INTO ventas (idart, fecha, cantidad, articulos, total, num_fact, met_pago) " +
                            "VALUES (@idart, @fecha, @cantidad, @articulos, @total, @num_fact, @met_pago)", con);

                        venta.Parameters.AddWithValue("@num_fact", numfac);
                        venta.Parameters.AddWithValue("@articulos", articulo);
                        venta.Parameters.AddWithValue("@cantidad", cantidad);
                        venta.Parameters.AddWithValue("@idart", idproducto);
                        venta.Parameters.AddWithValue("@total", importeAjustado); // Guardar el precio ajustado
                        venta.Parameters.AddWithValue("@met_pago", metodoPago);
                        venta.Parameters.AddWithValue("@fecha", DateTime.Now);
                        

                        venta.ExecuteNonQuery();
                        con.Close();

                        // Actualizar el stock
                        con.Open();
                        MySqlCommand actualizarStock = new MySqlCommand("UPDATE productos SET stock = stock - @cantidad WHERE idproducto = @idproducto", con);
                        actualizarStock.Parameters.AddWithValue("@cantidad", cantidad);
                        actualizarStock.Parameters.AddWithValue("@idproducto", idproducto);
                        actualizarStock.ExecuteNonQuery();
                        con.Close();
                    }

                    // Preguntar si desea guardar la factura
                    DialogResult facturaResult = MessageBox.Show(
                        "¿Desea guardar o imprimir la factura?",
                        "Opciones de Factura",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (facturaResult == DialogResult.Yes)
                    {
                        guardarpdf_Click(sender, e);
                    }

                    // Limpiar los campos
                    pedtab.Clear(); efectivotxt.Text = "";debitotxt.Clear();creditotxt.Clear();subtotaltxt.Clear();imptxt.Clear();subtotal = 0;
                    debacum = 0;credacum = 0;rb_efectivo.Checked = false;rb_deb.Checked = false;rb_cred.Checked = false;apenomtxt.Text = "";
                    dnitxt.Text = "";teltxt.Text = "";directxt.Text = ""; datosclientes.Clear();
                    nfactxt.Text = "";

                    // Actualizar tabla de productos
                    artab.Clear();
                    con.Open();
                    MySqlDataAdapter artadapt = new MySqlDataAdapter("SELECT idproducto, codigo, stock, stockmin, articulos, precio_venta FROM productos", con);
                    artadapt.Fill(artab);
                    dgvarts.DataSource = artab;
                    con.Close();

                    // Mostrar el total ajustado de la venta
                    MessageBox.Show($"Venta confirmada. Total: {totalVenta:C2}", "Venta Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }





        private void cancelar_Click(object sender, EventArgs e)
        {//ELIMINA TODA LA VENTA. CANCELA
            if (dgvpedido.CurrentRow != null) //(dgvpedido.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea cancelar la venta completa?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < pedtab.Rows.Count; i++)
                    {
                        DataRow row = pedtab.Rows[i];
                        int idproducto = Convert.ToInt32(row["idproducto"]);
                        int cantidad = Convert.ToInt32(row["Cantidad"]);

                        // Iterar sobre las filas de dgvarts usando un bucle for
                        for (int j = 0; j < dgvarts.Rows.Count; j++)
                        {
                            DataGridViewRow articrow = dgvarts.Rows[j];

                            // Buscar el producto en dgvarts para restaurar el stock
                            if (Convert.ToInt32(articrow.Cells["idproducto"].Value) == idproducto)
                            {
                                int stockActual = Convert.ToInt32(articrow.Cells["stock"].Value);
                                articrow.Cells["stock"].Value = stockActual + cantidad;
                                break;
                            }
                        }
                    }

                    pedtab.Clear(); efectivotxt.Text = ""; debitotxt.Clear(); creditotxt.Clear(); subtotaltxt.Clear(); imptxt.Clear();
                    subtotal = 0; debacum = 0; credacum = 0; apenomtxt.Text = ""; dnitxt.Text = "";  teltxt.Text = ""; // SUPR PARA ELIMINAR
                    directxt.Text = ""; datosclientes.Clear();
                }
                busartxt.Focus();

                MessageBox.Show("Venta cancelada");
            }
            else
            {
                MessageBox.Show("No hay articulos");
            }

        }
        private void dgvpedido_KeyDown(object sender, KeyEventArgs e)// SUPR PARA ELIMINAR
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvpedido.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar artículo de la lista?", "Confirmar", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dgvpedido.Rows.RemoveAt(dgvpedido.CurrentRow.Index);
                    }
                    busartxt.Focus();
                    MessageBox.Show("Artículo eliminado de la venta.");
                }

            }
        }

        private void dgvarts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idartxt.Text = dgvarts.CurrentRow.Cells[0].Value.ToString();
        }
        private void dgvarts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cantxt.Focus();
            busartxt.Text = dgvarts.CurrentRow.Cells["articulos"].Value.ToString();
            preciounitxt.Text = dgvarts.CurrentRow.Cells["precio_venta"].Value.ToString();
            cantxt.Text = "1";


        }

        private void dgvarts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvarts.CurrentRow != null)
                {
                    busartxt.Text = dgvarts.CurrentRow.Cells["articulos"].Value.ToString();
                    preciounitxt.Text = dgvarts.CurrentRow.Cells["precio_venta"].Value.ToString();
                    cantxt.Text = "1";
                    cantxt.Focus();
                    e.SuppressKeyPress = true;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                dgvarts.Focus();
                busartxt.Text = "";
                preciounitxt.Text = "";
            }
        }
        private void cantxt_TextChanged(object sender, EventArgs e)
        {
            
            if (decimal.TryParse(preciounitxt.Text, out decimal precioUnitario))
            {
                if (decimal.TryParse(cantxt.Text, out decimal cantidad))
                {

                    decimal importe = cantidad * precioUnitario;
                    imptxt.Text = importe.ToString("F2");
                }
                else
                {
                    imptxt.Text = "";
                }
            }
            else
            {
                imptxt.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)// boton de volver 
        {
           frm01_menu volver = new frm01_menu();
           this.Close();
        }

        private void idartxt_Click(object sender, EventArgs e)
        {
            frm3_modificar modificar = new frm3_modificar();
            modificar.idtxt2.Text = idartxt.Text;
            modificar.Show();
        }
      
        private void cantxt_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                imprimir_Click(sender, e);
                e.SuppressKeyPress = true;

            }
            else if (e.KeyCode == Keys.Escape)
            {
               //dgvarts.Focus();
                busartxt.Focus();
                busartxt.Clear(); preciounitxt.Clear(); cantxt.Clear(); imptxt.Clear();
            }
        }

        private void idc3txt_TextChanged(object sender, EventArgs e)
        {   //Tabla : Datos de clientes, en caso de que la venta requiera de un consumidor final
            con.Open();
            string idc = idc3txt.Text;
            MySqlDataAdapter adap = new MySqlDataAdapter("Select * from clientes where idcliente = @idcliente", con);
            adap.SelectCommand.Parameters.AddWithValue("@idcliente", idc);
            adap.Fill(datosclientes);
            if (datosclientes.Rows.Count > 0)
            {
                apenomtxt.Text= Convert.ToString(datosclientes.Rows[0][2]);
                dnitxt.Text =   Convert.ToString(datosclientes.Rows[0]["DNI"]);
                teltxt.Text =   Convert.ToString(datosclientes.Rows[0][3]);
                directxt.Text = Convert.ToString(datosclientes.Rows[0][4]);
            
            }
            else
            {
                MessageBox.Show("No se encontró el cliente con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void nuevclientbut_Click(object sender, EventArgs e)// (+)
        {
                // Ocultar el formulario de ventas mientras abres el de clientes
                this.Hide();
                frm5_clientes formClientes = new frm5_clientes();
                formClientes.ShowDialog();
                this.Show(); // Mostrar de nuevo el formulario al cerrar el de clientes
         

            
            

        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            numFactura = nfc(); // Genera el número de factura
            nfactxt.Text = "N° " + numFactura.ToString(); // Mostrar el número de factura
                                                          // Margen de inicio de impresión
            int startX = 20;
            int startY = 20;
            int offsetY = 20;

            // Fuente para la impresión
            Font fontHeader = new Font("Arial", 14, FontStyle.Bold);
            Font fontRegular = new Font("Arial", 10);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);

            // Dibujar encabezado
            e.Graphics.DrawString(nomcomercio, fontHeader, Brushes.Black, startX, startY);
            offsetY += 40;
            e.Graphics.DrawString($"Dirección: {direccion}", fontRegular, Brushes.Black, startX, startY + offsetY);
            offsetY += 20;
            e.Graphics.DrawString($"Teléfono: {telefono}", fontRegular, Brushes.Black, startX, startY + offsetY);
            offsetY += 20;
            e.Graphics.DrawString($"CUIT: {cuit}", fontRegular, Brushes.Black, startX, startY + offsetY);
            offsetY += 20;
            e.Graphics.DrawString($"Fecha: {DateTime.Now.ToShortDateString()}", fontRegular, Brushes.Black, startX + 300, startY + offsetY);
            offsetY += 40;

            // Dibujar encabezado de cliente
            e.Graphics.DrawString($"Cliente: {apenomtxt.Text}", fontRegular, Brushes.Black, startX, startY + offsetY);
            offsetY += 20;
            e.Graphics.DrawString($"DNI: {dnitxt.Text}", fontRegular, Brushes.Black, startX, startY + offsetY);
            offsetY += 20;
            e.Graphics.DrawString($"Teléfono: {teltxt.Text}", fontRegular, Brushes.Black, startX, startY + offsetY);
            offsetY += 20;
            e.Graphics.DrawString($"Dirección: {directxt.Text}", fontRegular, Brushes.Black, startX, startY + offsetY);
            offsetY += 40;

            // Determinar el método de pago y calcular ajustes
            string metodoPago = "Efectivo";
            decimal ajustePorcentaje = 0;

            if (rb_deb.Checked)
            {
                metodoPago = "Débito (10%)";
                ajustePorcentaje = 0.10m; // 10% para débito
            }
            else if (rb_cred.Checked)
            {
                metodoPago = "Crédito (20%)";
                ajustePorcentaje = 0.20m; // 20% para crédito
            }

            // Mostrar el método de pago
            e.Graphics.DrawString($"Método de Pago: {metodoPago}", fontBold, Brushes.Black, startX, startY + offsetY);
            offsetY += 40;

            // Dibujar líneas de encabezado para productos
            e.Graphics.DrawString("Cantidad", fontBold, Brushes.Black, startX, startY + offsetY);
            e.Graphics.DrawString("Artículo", fontBold, Brushes.Black, startX + 100, startY + offsetY);
            e.Graphics.DrawString("P. Unit.", fontBold, Brushes.Black, startX + 300, startY + offsetY);
            e.Graphics.DrawString("Importe", fontBold, Brushes.Black, startX + 400, startY + offsetY);
            offsetY += 20;

            // Recorrer la tabla de productos y agregar al documento
            decimal totalAjustado = 0;
            foreach (DataRow row in pedtab.Rows)
            {
                int cantidad = Convert.ToInt32(row["Cantidad"]);
                string articulo = row["Articulo"].ToString();
                decimal importe = Convert.ToDecimal(row["Importe"]);
                decimal precioUnitario = importe / cantidad;

                // Calcular precio ajustado
                decimal precioUnitarioAjustado = precioUnitario * (1 + ajustePorcentaje);
                decimal importeAjustado = importe * (1 + ajustePorcentaje);
                totalAjustado += importeAjustado;

                e.Graphics.DrawString(cantidad.ToString(), fontRegular, Brushes.Black, startX, startY + offsetY);
                e.Graphics.DrawString(articulo, fontRegular, Brushes.Black, startX + 100, startY + offsetY);
                e.Graphics.DrawString(precioUnitarioAjustado.ToString("C2"), fontRegular, Brushes.Black, startX + 300, startY + offsetY);
                e.Graphics.DrawString(importeAjustado.ToString("C2"), fontRegular, Brushes.Black, startX + 400, startY + offsetY);
                offsetY += 20;
            }

            // Dibujar total ajustado
            offsetY += 20;
            e.Graphics.DrawString($"Total: {totalAjustado:C2}", fontBold, Brushes.Black, startX + 300, startY + offsetY);
        }





        private void guardarpdf_Click(object sender, EventArgs e)
        {
            numFactura = nfc(); // Genera el número de factura
            nfactxt.Text = "N° " + numFactura.ToString(); // Muestra el número en el formulario, si es necesario

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar Factura como PDF";
                saveFileDialog.FileName = $"factura_{numFactura}.pdf"; // Nombre de archivo con número de factura

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveFileDialog.FileName;

                    using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        PdfWriter writer = new PdfWriter(fs);
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf);

                        // Agrega los datos del comercio y número de factura
                        document.Add(new Paragraph(nomcomercio).SetFontSize(16).SetBold());
                        document.Add(new Paragraph(direccion));
                        document.Add(new Paragraph($"Teléfono: {telefono}"));
                        document.Add(new Paragraph($"CUIT: {cuit}"));
                        document.Add(new Paragraph($"Factura N°: {numFactura}"));
                        document.Add(new Paragraph($"Fecha: {DateTime.Now.ToShortDateString()}"));
                        document.Add(new LineSeparator(new SolidLine()).SetMarginTop(10));

                        // Agrega los datos del cliente
                        document.Add(new Paragraph($"Cliente: {apenomtxt.Text}"));
                        document.Add(new Paragraph($"DNI: {dnitxt.Text}"));
                        document.Add(new Paragraph($"Teléfono: {teltxt.Text}"));
                        document.Add(new Paragraph($"Dirección: {directxt.Text}"));
                        document.Add(new LineSeparator(new SolidLine()).SetMarginTop(10));

                        // Agrega un encabezado para los artículos
                        document.Add(new Paragraph("Detalles de la compra").SetBold().SetMarginTop(10));

                        // Determinar el método de pago
                        string metodoPago = "Efectivo";
                        decimal ajustePorcentaje = 0;

                        if (rb_deb.Checked)
                        {
                            metodoPago = "Débito";
                            ajustePorcentaje = 0.10m; // 10% para débito
                        }
                        else if (rb_cred.Checked)
                        {
                            metodoPago = "Crédito";
                            ajustePorcentaje = 0.20m; // 20% para crédito
                        }

                        // Mostrar el método de pago
                        document.Add(new Paragraph($"Método de Pago: {metodoPago}").SetBold());
                        document.Add(new LineSeparator(new SolidLine()).SetMarginTop(10));

                        // Crea una tabla de artículos
                        Table table = new Table(4); // Número de columnas
                        table.AddHeaderCell("Cantidad");
                        table.AddHeaderCell("Artículo");
                        table.AddHeaderCell("P. Unitario ");
                        table.AddHeaderCell("Importe");

                        // Recorrer la tabla `pedtab` para agregar los artículos
                        decimal totalAjustado = 0;
                        foreach (DataRow row in pedtab.Rows)
                        {
                            int cantidad = Convert.ToInt32(row["Cantidad"]);
                            string articulo = row["Articulo"].ToString();
                            decimal importe = Convert.ToDecimal(row["Importe"]);
                            decimal precioUnitario = importe / cantidad;

                            // Calcular precio ajustado
                            decimal precioUnitarioAjustado = precioUnitario * (1 + ajustePorcentaje);
                            decimal importeAjustado = importe * (1 + ajustePorcentaje);
                            totalAjustado += importeAjustado;

                            // Cantidad
                            table.AddCell(cantidad.ToString());
                            // Artículo
                            table.AddCell(articulo);
                            // Precio Unitario Ajustado
                            table.AddCell(precioUnitarioAjustado.ToString("C2"));
                            // Importe Ajustado
                            table.AddCell(importeAjustado.ToString("C2"));
                        }

                        document.Add(table);

                        // Agrega el total ajustado de la factura
                        document.Add(new Paragraph($"Total : {totalAjustado:C2}").SetBold().SetMarginTop(10));

                        document.Close();
                    }
                }
                else
                {
                    MessageBox.Show("La operación de guardado fue cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)  // BOTON IMPRIMIR
        {         
            numFactura = nfc(); // Genera el número de factura
            nfactxt.Text = "N° " + numFactura.ToString();

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        
        
        private void CargarDatosComercio()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM config WHERE idconfig = 1", con);//nomcomercio, direccion, telefono, cuit
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                nomcomercio= reader["nomcomercio"].ToString();
                direccion = reader["direccion"].ToString();
                telefono = reader["telefono"].ToString();
                cuit = reader["cuit"].ToString();
                pagosdebito = Convert.ToDecimal(reader["pagosdebito"]);
                pagoscredito = Convert.ToDecimal(reader["pagoscredito"]);
             //   pagoscredito = reader["pagoscredito"].ToString();

            }
            else
            {
                MessageBox.Show("No se encontraron los datos del comercio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reader.Close();
            con.Close();
        }

    
    }
        
}




/* */