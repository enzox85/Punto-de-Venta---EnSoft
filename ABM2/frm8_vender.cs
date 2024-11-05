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


namespace ABM2
{
    public partial class frm8_vender : Form
    {
        public MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password= ");
        public DataTable artab = new DataTable();
        public DataTable pedtab = new DataTable();

        public frm8_vender()
        {
            InitializeComponent();
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
            //---------------------------------------------------------------------------------------------------------------------------------
            dgvarts.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle encabezado = new DataGridViewCellStyle();
            encabezado.BackColor = Color.LightGoldenrodYellow;
            encabezado.ForeColor = Color.DarkOliveGreen;
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
            dgvarts.Columns["articulos"].Width = 250;
            dgvarts.Columns["stock"].Width = 80;
            /*dgvarts.Columns["precio_costo"].Width = 100;
            dgvarts.Columns["iva"].Width = 50;*/
            dgvarts.Columns["precio_venta"].Width = 100;
            // Centrar contenido
            foreach (DataGridViewColumn column in dgvarts.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvpedido.DataSource = pedtab;
            dgvpedido.RowHeadersVisible = false;
            dgvpedido.Columns["idproducto"].Visible = false;

            con.Close();

        }

        private void busartxt_TextChanged(object sender, EventArgs e)
        {
            artab.DefaultView.RowFilter = "articulos LIKE '%" + busartxt.Text + "%' ";//&& codigo LIKE '" + busartxt.Text + "'
            coincidtxt.Text = "Encontrados: " + artab.DefaultView.Count.ToString();
        }

        //-----------------------------------------------------------------
        private int nfc()                //func nueva factura
        {
            int nuevafac = 1;

            using (var cmd = new MySqlCommand("SELECT COALESCE(MAX(num_fact), 0) + 1 FROM ventas", con))
            {
                con.Open();
                nuevafac = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            return nuevafac;
        }
        //--------------------------------------------------------------------------


        decimal subtotal = 0;
        decimal debacum = 0;
        decimal credacum = 0;

        private void imprimir_Click(object sender, EventArgs e)
        {
            int nfac = nfc();
            nfactxt.Text = "N° " + nfac.ToString();

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
            string mosdebpor = "10";
            string moscredpor = "20";


            // Verificar si el precio de venta es DBNull.Value
            if (dgvarts.CurrentRow.Cells["precio_venta"].Value == DBNull.Value)
            {
                MessageBox.Show("El precio de venta no está disponible para el artículo seleccionado.");
                return;
            }

            decimal pventa = Convert.ToDecimal(dgvarts.CurrentRow.Cells["precio_venta"].Value);
            decimal importe = cantidad * pventa;
            imptxt.Text = importe.ToString("C");
            decimal deb = (importe * 10 / 100) + importe;
            decimal cred = (importe * 20 / 100) + importe;

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
                    int numfac = nfc();
                    string efectivo = null;
                    string debito = null;
                    string credito = null;
                    if (rb_efectivo.Checked)

                    {
                        efectivo = "PAGADO";
                        MessageBox.Show("Pago en EFECTIVO confirmado.");
                    }
                    else if (rb_deb.Checked)
                    {

                        debito = "PAGADO";
                        MessageBox.Show("Pago con DEBITO confirmado.");
                    }
                    else if (rb_cred.Checked)
                    {
                        credito = "PAGADO";
                        MessageBox.Show("Pago en CREDITO confirmado.");
                    }


                    foreach (DataRow row in pedtab.Rows)
                    {
                        int cantidad = Convert.ToInt32(row["Cantidad"]);
                        string articulo = row["Articulo"].ToString();
                        decimal importe = Convert.ToDecimal(row["Importe"]);
                        int idproducto = Convert.ToInt32(row["idproducto"]); // Función para obtener el id del producto

                        con.Open();
                        MySqlCommand venta = new MySqlCommand(
                            "INSERT INTO ventas (idart, fecha, cantidad, articulos, total, num_fact, efectivo, debito, credito) " +
                            "VALUES (@idart, @fecha, @cantidad, @articulos, @total, @num_fact, @efectivo, @debito, @credito)", con);

                        // Insertar los valores en la base de datos
                        venta.Parameters.AddWithValue("@fecha", DateTime.Now); // Fecha y hora actuales
                        venta.Parameters.AddWithValue("@idart", idproducto);
                        venta.Parameters.AddWithValue("@cantidad", cantidad);
                        venta.Parameters.AddWithValue("@articulos", articulo);
                        venta.Parameters.AddWithValue("@total", importe);
                        venta.Parameters.AddWithValue("@num_fact", numfac);

                        // Insertar solo el método de pago seleccionado, los demás serán null
                        venta.Parameters.AddWithValue("@efectivo", efectivo);
                        venta.Parameters.AddWithValue("@debito", debito);
                        venta.Parameters.AddWithValue("@credito", credito);

                        venta.ExecuteNonQuery();
                        con.Close();


                        artab.Clear();
                        con.Open();
                        MySqlDataAdapter artadapt = 
                            new MySqlDataAdapter("SELECT idproducto, codigo, stock,stockmin, articulos, precio_venta FROM productos", con);
                        artadapt.Fill(artab);
                        dgvarts.DataSource = artab;
                        // Actualizar stock
                        MySqlCommand actualizarStock = new MySqlCommand("UPDATE productos SET stock = stock - @cantidad WHERE idproducto = @idproducto", con);
                        actualizarStock.Parameters.AddWithValue("@cantidad", cantidad);
                        actualizarStock.Parameters.AddWithValue("@idproducto", idproducto);

                        actualizarStock.ExecuteNonQuery();
                        con.Close();

                    
                    }
                    pedtab.Clear(); efectivotxt.Clear(); debitotxt.Clear(); creditotxt.Clear(); subtotaltxt.Clear(); imptxt.Clear();//subtotaltxt.Text = subtotal.ToString("C"); 
                    rb_efectivo.Checked = false;
                    rb_cred.Checked = false;
                    rb_deb.Checked = false;
                    
                }


            }
            else
            {
                MessageBox.Show("Elija un articulo para vender");
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
                    subtotal = 0; debacum = 0; credacum = 0;

                    //subtotaltxt.Text = subtotal.ToString("C");     
                }
                busartxt.Focus();

                MessageBox.Show("Venta cancelada");
            }
            else
            {
                MessageBox.Show("No hay articulos");
            }

        }
        private void dgvpedido_KeyDown(object sender, KeyEventArgs e)
        {// SUPR o ENTER PARA ELIMINAR
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

            if (dgvarts.CurrentRow.Cells["precio_venta"].Value == DBNull.Value)
            {
                MessageBox.Show("El precio de venta no está disponible para el artículo seleccionado.");
                DialogResult result = MessageBox.Show("¿Está seguro de que desea modificar el artículo de la lista?", "Confirmar", MessageBoxButtons.YesNo);
                idartxt.Text = dgvarts.CurrentRow.Cells[0].Value.ToString();

                if (result == DialogResult.Yes)
                {

                    frm3_modificar modificar = new frm3_modificar();
                    modificar.idtxt2.Text = dgvarts.CurrentRow.Cells[0].Value.ToString();
                    modificar.Show();
                }
            }

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
            //decimal precioUnitario = Convert.ToDecimal(preciounitxt.Text);
            if (decimal.TryParse(preciounitxt.Text, out decimal precioUnitario))//precioUnitario > 0 
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

        private void button2_Click(object sender, EventArgs e)
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
      
        private void frm8_vender_Load(object sender, EventArgs e)
        {

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
                // dgvarts.Focus();
                busartxt.Focus();
                busartxt.Clear(); preciounitxt.Clear(); cantxt.Clear(); imptxt.Clear();
            }
        }

     
    }

}



