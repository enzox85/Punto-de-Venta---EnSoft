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

    public partial class frm8_CuentaCorriente : Form
    {
        public MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password= ");
        public DataTable artab = new DataTable();
        public DataTable nuevaventa = new DataTable();
        public DataTable datoscliente = new DataTable();
        public DataTable cuentcor = new DataTable();
        decimal totalMonto = 0;

        public frm8_CuentaCorriente()
        {
            InitializeComponent();
        }

        private void frm8_CuentaCorriente_Load_1(object sender, EventArgs e)
        { }
        private void frm8_CuentaCorriente_Activated(object sender, EventArgs e)//----------------------------------------------------
        {
            /// Articulos
            artab.Clear();
            con.Open();
            MySqlDataAdapter artadapt = new MySqlDataAdapter("SELECT idproducto, codigo, stock,stockmin, articulos, precio_venta FROM productos", con);
            artadapt.Fill(artab);
            dgvartcc.DataSource = artab;
            con.Close();
            dgvartcc.ClearSelection();
            Estilo1(dgvartcc, artab);

            // Revisar si hay elementos en nuevaventa antes de reasignar dgvcc-----------------------------
            /* if (!nuevaventa.Columns.Contains("idproducto"))
                 nuevaventa.Columns.Add("idproducto", typeof(int));*/

            if (!nuevaventa.Columns.Contains("idproductofk"))
                nuevaventa.Columns.Add("idproductofk", typeof(string));

            if (!nuevaventa.Columns.Contains("Artículos"))
                nuevaventa.Columns.Add("Artículos", typeof(string));

           
            if (!nuevaventa.Columns.Contains("P.Unidad"))
                nuevaventa.Columns.Add("P.Unidad", typeof(decimal));

            if (!nuevaventa.Columns.Contains("Cantidad"))
                nuevaventa.Columns.Add("Cantidad", typeof(int));



            if (!nuevaventa.Columns.Contains("Importe"))
                nuevaventa.Columns.Add("Importe", typeof(decimal));


            cuentcor.Clear();
                con.Open();
                string idCliente = idcctxt2.Text;
                MySqlDataAdapter detadapt = new MySqlDataAdapter(
                 "SELECT cuentcor.idcuenta, cuentcor.idclientefk, cuentcor.idproductofk, cuentcor.descripcion, " +
                 " cuentcor.cantidad, cuentcor.debe, cuentcor.haber, cuentcor.saldo, cuentcor.fecha " +
                 "FROM cuentcor WHERE cuentcor.idclientefk = @idCliente", con);

                detadapt.SelectCommand.Parameters.AddWithValue("@idCliente", idCliente);
                detadapt.Fill(cuentcor);
                dgvcc.RowHeadersVisible = false;
                dgvcc.DataSource = cuentcor.DefaultView;
                dgvcc.Columns["idcuenta"].Visible = false;
                dgvcc.Columns["idclientefk"].Visible = false;
                dgvcc.Columns["idproductofk"].Visible = false;
                dgvcc.Columns["debe"].Visible = false;
                dgvcc.Columns["haber"].Visible = false;
             //   dgvcc.Columns["fecha"].Visible = false;
                
                dgvcc.Columns["descripcion"].HeaderText = "Artículos";
                dgvcc.Columns["cantidad"].HeaderText = "Cantidad";
                dgvcc.Columns["saldo"].HeaderText = "Importe";
                dgvcc.Columns["cantidad"].Width = 60;
                dgvcc.Columns["descripcion"].Width = 200;
                dgvcc.Columns["saldo"].Width = 100;
                foreach (DataGridViewColumn column in dgvcc.Columns)
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            if (dgvcc.Rows.Count > 0)
            {
                // Muestra la última fila cargada
                dgvcc.FirstDisplayedScrollingRowIndex = dgvcc.Rows.Count - 1;

                // Opcional: selecciona la última fila
                dgvcc.Rows[dgvcc.Rows.Count - 1].Selected = true;
            }

            con.Close();

          //  }
            dgvcc.ClearSelection();
            CalcularTotalMonto();
        }

        //---------------------------------------------------------------------------------------------------------------------------------
        bool enNuevaVenta = true; 

        decimal sumatotnuven = 0;
        private void imprimir_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cantxt.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida.");
                return;
            }

            if (dgvartcc.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un artículo en la tabla.");
                return;
            }

            int stockmin = dgvartcc.CurrentRow.Cells["stockmin"].Value != DBNull.Value ? Convert.ToInt32(dgvartcc.CurrentRow.Cells["stockmin"].Value) : 0;
            int stockDisponible = Convert.ToInt32(dgvartcc.CurrentRow.Cells["stock"].Value);

            if (stockDisponible <= stockmin || stockDisponible < cantidad)
            {
                MessageBox.Show("No hay suficiente stock para este producto.");
                return;
            }

            string articulo = dgvartcc.CurrentRow.Cells["articulos"].Value.ToString();
            decimal precioUnidad = Convert.ToDecimal(dgvartcc.CurrentRow.Cells["precio_venta"].Value);
            decimal importe = precioUnidad * cantidad;

            
            sumatotnuven += importe;
            saldotxt.Text = sumatotnuven.ToString("C");

            
            DataRow nuevaFila = nuevaventa.NewRow();
            nuevaFila["idproductofk"] = dgvartcc.CurrentRow.Cells["idproducto"].Value;
            nuevaFila["Artículos"] = articulo;
            nuevaFila["Cantidad"] = cantidad;
            nuevaFila["P.Unidad"] = precioUnidad;
            nuevaFila["Importe"] = importe;
            nuevaventa.Rows.Add(nuevaFila);

            dgvcc.DataSource = nuevaventa;
            enNuevaVenta = true; // Aseguramos que estamos en el modo de nueva venta
        }

        private void vendido_Click_1(object sender, EventArgs e)
        {
            if (nuevaventa.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en la cuenta para procesar la venta.");
                return;
            }

            foreach (DataRow row in nuevaventa.Rows)
            {
                int idCliente = Convert.ToInt32(idcctxt2.Text);
                int idproductofk = Convert.ToInt32(row["idproductofk"]);
                string descripcion = row["Artículos"].ToString();
                int cantidad = Convert.ToInt32(row["Cantidad"]);
                decimal saldo = Convert.ToDecimal(row["Importe"]);

                // Insertar en cuentcor para registrar la venta
                con.Open();
                MySqlCommand vender = new MySqlCommand(
                    "INSERT INTO cuentcor (idclientefk, idproductofk, cantidad, descripcion, debe, saldo, fecha) " +
                      "VALUES (@idclientefk, @idproductofk, @cantidad, @descripcion, @debe, @saldo, @fecha)", con);

                vender.Parameters.AddWithValue("@idclientefk", idCliente);
                vender.Parameters.AddWithValue("@idproductofk", idproductofk);
                vender.Parameters.AddWithValue("@cantidad", cantidad);
                vender.Parameters.AddWithValue("@descripcion", descripcion);
                vender.Parameters.AddWithValue("@debe", saldo);
                vender.Parameters.AddWithValue("@saldo", saldo);
                vender.Parameters.AddWithValue("@fecha", DateTime.Now);

                vender.ExecuteNonQuery();
                con.Close();

                // Actualizar el stock en la tabla productos
                con.Open();
                MySqlCommand actualizarStock = new MySqlCommand(
                    "UPDATE productos SET stock = stock - @cantidad WHERE idproducto = @idproductofk", con);
                actualizarStock.Parameters.AddWithValue("@cantidad", cantidad);
                actualizarStock.Parameters.AddWithValue("@idproductofk", idproductofk);
                actualizarStock.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Venta registrada exitosamente.");
            nuevaventa.Clear();
            preciounitxt.Clear();
            cantxt.Clear();
            imptxt.Clear();
            sumatotnuven = 0; // Reiniciar el total de nueva venta
            enNuevaVenta = false; // Cambiar a modo visualización de cuenta
            MostrarCuentcor();
        }

        // Método para cargar la tabla cuentcor
        private void MostrarCuentcor()
        {
            MySqlDataAdapter adapter = 
                new MySqlDataAdapter("SELECT idclientefk, idproductofk, cantidad, descripcion, debe, saldo, fecha from cuentcor", con);
            DataTable cuentcorTabla = new DataTable();
            adapter.Fill(cuentcorTabla);
            dgvcc.DataSource = cuentcorTabla;

            CalcularTotalMonto();
        }
    
        //---------------------------------------------------------------------------------------------------------------------------------
        private void moneyintxt_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de ingresar este monto?", "Confirmar", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    if (string.IsNullOrWhiteSpace(moneyintxt.Text))
                    {
                        MessageBox.Show("Por favor, ingrese un valor en el campo de monto.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                    decimal.TryParse(moneyintxt.Text, out decimal pago);
                    
                        decimal.TryParse(saldotxt.Text, out decimal debe);

                    decimal nuevosaldo = pago - debe;
                    entregatxt.Text = nuevosaldo.ToString("F2");

                    // Registro del pago en cuentcor
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "INSERT INTO cuentcor (idclientefk, descripcion, debe, haber, saldo, fecha) " +
                        "VALUES (@idclientefk, @descripcion, @debe, @haber, @saldo, @fecha)", con);
                    cmd.Parameters.AddWithValue("@idclientefk", Convert.ToInt32(idcctxt2.Text));
                    cmd.Parameters.AddWithValue("@descripcion", "Entrega de efectivo " +  DateTime.Now);
                    cmd.Parameters.AddWithValue("@debe", debe);
                    cmd.Parameters.AddWithValue("@haber", pago - debe);
                    cmd.Parameters.AddWithValue("@saldo", debe - nuevosaldo );
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    /*cmd.Parameters.AddWithValue("@debe", debe);
                    cmd.Parameters.AddWithValue("@haber", pago - debe);
                    cmd.Parameters.AddWithValue("@saldo", debe - nuevosaldo);*/
                    CalcularTotalMonto();
                    MessageBox.Show("Entrega registrada correctamente.");
                }
                moneyintxt.Clear();
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------
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

        private void dgvartcc_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            bustxt.Text = dgvartcc.CurrentRow.Cells["articulos"].Value.ToString();
            preciounitxt.Text = dgvartcc.CurrentRow.Cells["precio_venta"].Value.ToString();
            cantxt.Text = "1";
            cantxt.Focus();
        }

        private void idcctxt2_TextChanged_1(object sender, EventArgs e)
        {
            con.Open();
            string idclientex = idcctxt2.Text;
            MySqlDataAdapter adap = new MySqlDataAdapter("Select * from clientes where idcliente = @idcliente", con);
            adap.SelectCommand.Parameters.AddWithValue("@idcliente", idclientex);
            adap.Fill(datoscliente);
            if (datoscliente.Rows.Count > 0)
            {
                apenomtxt.Text = Convert.ToString(datoscliente.Rows[0][2]);
                dnitxt.Text = Convert.ToString(datoscliente.Rows[0]["DNI"]);
                teltxt.Text = Convert.ToString(datoscliente.Rows[0][3]);
                directxt.Text = Convert.ToString(datoscliente.Rows[0][4]);
            }
            else
            {
                MessageBox.Show("No se encontró el cliente con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        private void dgvartcc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvartcc.CurrentRow != null)
                {

                    bustxt.Text = dgvartcc.CurrentRow.Cells["articulos"].Value.ToString();
                    preciounitxt.Text = dgvartcc.CurrentRow.Cells["precio_venta"].Value.ToString();
                    cantxt.Text = "1";
                    cantxt.Focus();


                    e.SuppressKeyPress = true;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                dgvartcc.Focus();
                bustxt.Text = "";
                preciounitxt.Text = "";
            }

        }

        private void cantxt_TextChanged_1(object sender, EventArgs e)
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

        private void cantxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                imprimir_Click(sender, e);
                e.SuppressKeyPress = true;
                bustxt.Clear(); preciounitxt.Clear(); cantxt.Clear(); imptxt.Clear();
                bustxt.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // dgvarts.Focus();
                bustxt.Focus();
                bustxt.Clear(); preciounitxt.Clear(); cantxt.Clear(); imptxt.Clear();
            }
        }

        private void bustxt_TextChanged_1(object sender, EventArgs e)
        {
            artab.DefaultView.RowFilter = "articulos LIKE '%" + bustxt.Text + "%' ";//&& codigo LIKE '" + busartxt.Text + "'
            coincidtxt.Text = "Encontrados: " + artab.DefaultView.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm8_CuentaCorrienteDetalles detalles = new frm8_CuentaCorrienteDetalles();
            detalles.idccdetallestxt.Text = idcctxt2.Text;
            detalles.Show();
        }

        private void Estilo1(DataGridView dgv, DataTable dataSource)
        {
            dgvartcc.DataSource = dataSource;
            dgvartcc.EnableHeadersVisualStyles = false;
            dgvartcc.RowHeadersVisible = false;

            // Configuración de estilo para encabezados
            DataGridViewCellStyle encabezado = new DataGridViewCellStyle
            {
                BackColor = Color.LightGoldenrodYellow,
                ForeColor = Color.DarkOliveGreen,
                Font = new Font("Bradley Hand ITC", 15, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            dgvartcc.ColumnHeadersDefaultCellStyle = encabezado;

            // Ocultar columnas y establecer encabezados personalizados
            
            dgvartcc.Columns["idproducto"].Visible = false;
            dgvartcc.Columns["codigo"].Visible = false;
            dgvartcc.Columns["stockmin"].Visible = false;
            dgvartcc.Columns["stock"].HeaderText = "Stock";
            dgvartcc.Columns["articulos"].HeaderText = "Artículos";
            dgvartcc.Columns["precio_venta"].HeaderText = "P.Venta";

            // Configuración de ancho de columnas
            dgvartcc.Columns["articulos"].Width = 250;
            dgvartcc.Columns["stock"].Width = 80;
            dgvartcc.Columns["precio_venta"].Width = 100;

            // Centrar contenido de las columnas
            foreach (DataGridViewColumn column in dgvartcc.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void CalcularTotalMonto()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT SUM(saldo) FROM cuentcor WHERE idclientefk = @idcliente", con);
            cmd.Parameters.AddWithValue("@idcliente", idcctxt2.Text);
            object result = cmd.ExecuteScalar();
            totalMonto = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            saldotxt.Text = totalMonto.ToString("C");
            con.Close();
        }

     

        private void dgvcc_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica que el índice de la fila y la columna "saldo" sean válidos
            if (e.RowIndex >= 0 && dgvcc.Columns["saldo"] != null)
            {
                // Obtiene el valor de la celda correspondiente a la columna "saldo"
                var valorSaldo = dgvcc.Rows[e.RowIndex].Cells["saldo"].Value;

                // Verifica si el valor es negativo
                if (valorSaldo != null && decimal.TryParse(valorSaldo.ToString(), out decimal saldo) && saldo < 0)
                {
                    // Aplica el color de fondo verde claro a la fila
                    dgvcc.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
    }


}
                   
    






  