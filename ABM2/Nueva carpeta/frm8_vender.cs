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

        private void frm8_vender_Load(object sender, EventArgs e)
        {
            // Verificar si las columnas ya existen antes de agregarlas
            if (pedtab.Columns.Count == 0)
            {
                pedtab.Columns.Add("idproducto", typeof(int)); 
                pedtab.Columns.Add("Cantidad", typeof(int));
                pedtab.Columns.Add("Articulo", typeof(string));
                pedtab.Columns.Add("Importe", typeof(decimal));
                pedtab.Columns.Add("Actual", typeof(int));
            }

            foreach (DataGridViewColumn column in dgvpedido.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Configurar tabla pedido
            dgvpedido.RowHeadersVisible = false;

        }

        private void frm8_vender_Activated(object sender, EventArgs e)
        {
            artab.Clear();
            con.Open();
            MySqlDataAdapter artadapt = 
            new MySqlDataAdapter("SELECT idproducto, codigo, stock, articulos, precio_venta FROM productos", con);
            
            artadapt.Fill(artab);
            dgvarts.DataSource = artab;
            dgvarts.EnableHeadersVisualStyles = false;

            DataGridViewCellStyle encabezado = new DataGridViewCellStyle();
            encabezado.BackColor = Color.LightGoldenrodYellow; // Color de fondo del encabezado
            encabezado.ForeColor = Color.DarkOliveGreen; // Color del texto del encabezado
            encabezado.Font = new Font("Bradley Hand ITC", 15, FontStyle.Bold); // Fuente del texto del encabezado
            encabezado.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alineación del texto

            //ESTILO BEBÉ
            dgvarts.ColumnHeadersDefaultCellStyle = encabezado;
            dgvarts.RowHeadersVisible = false;
            //Encabezados de las columnas
            dgvarts.Columns["idproducto"].Visible = false;
            dgvarts.Columns["codigo"].Visible = false;
            dgvarts.Columns["stock"].HeaderText = "Stock";
            dgvarts.Columns["articulos"].HeaderText = "Artículos";
            dgvarts.Columns["precio_venta"].HeaderText = "P.Venta";
            // Ajustar el ancho de las columnas al contenido de las celdas
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
            con.Close();
        }

        private void busartxt_TextChanged(object sender, EventArgs e)
        {
            artab.DefaultView.RowFilter = "articulos LIKE '%" + busartxt.Text + "%' OR codigo LIKE '" + busartxt.Text + "'";
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            if (dgvarts.CurrentRow != null && !string.IsNullOrEmpty(cantxt.Text))
            {
                int cantidad;
                if (int.TryParse(cantxt.Text, out cantidad) && cantidad > 0)
                {
                    // Obtener el idproducto del artículo seleccionado
                    int idproducto = Convert.ToInt32(dgvarts.CurrentRow.Cells["idproducto"].Value);
                    string articulo = dgvarts.CurrentRow.Cells["articulos"].Value.ToString();
                    decimal precioVenta = Convert.ToDecimal(dgvarts.CurrentRow.Cells["precio_venta"].Value);
                    decimal importe = cantidad * precioVenta;

                    // Actualizar el TextBox con los detalles seleccionados
                    preciounitxt.Text = precioVenta.ToString("C");
                    imptxt.Text = importe.ToString("C");
                   // codartxt.Text = dgvarts.CurrentRow.Cells["codigo"].Value.ToString();

                    if (dgvarts.CurrentRow.Cells["precio_venta"].Value != DBNull.Value)
                    {
                        // Agregar los datos al DataTable de pedidos
                        pedtab.Rows.Add(idproducto, cantidad, articulo, importe);

                        // Crear el comando para insertar en la tabla de ventas
                        MySqlCommand venta = new MySqlCommand("INSERT INTO ventas (idart, cantidad, articulos, importe_ventas, actual) VALUES (@idart, @cantidad, @articulos, @importe_ventas, @actual)", con);
                        venta.Parameters.AddWithValue("@idart", idproducto);
                        venta.Parameters.AddWithValue("@cantidad", cantidad);
                        venta.Parameters.AddWithValue("@articulos", articulo);
                        venta.Parameters.AddWithValue("@importe_ventas", importe);
                        venta.Parameters.AddWithValue("@actual", DateTime.Now);

                        // Abrir la conexión y ejecutar la consulta
                        con.Open();
                        venta.ExecuteNonQuery();

                        // Actualizar la cantidad en la tabla de productos
                        MySqlCommand actualizarStock = new MySqlCommand("UPDATE productos SET stock = stock - @cantidad WHERE idproducto = @idproducto", con);
                        actualizarStock.Parameters.AddWithValue("@cantidad", cantidad);
                        actualizarStock.Parameters.AddWithValue("@idproducto", idproducto);
                        actualizarStock.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Artículo agregado a la tabla de ventas y stock actualizado.");
                    }
                    else
                    {
                        MessageBox.Show("El precio de venta no está disponible para el artículo seleccionado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa una cantidad válida.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un artículo y especifica la cantidad.");
            }
        }

        private void vendido_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea confirmar la venta?", "Confirmar Venta", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("La venta ha sido confirmada.");
                // Lógica adicional para finalizar la venta si es necesario
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (dgvpedido.CurrentRow != null)
            {
                // Eliminar el artículo del DataTable de pedidos
                dgvpedido.Rows.RemoveAt(dgvpedido.CurrentRow.Index);

                MessageBox.Show("Artículo eliminado de la venta.");
            }
            else
            {
                MessageBox.Show("Seleccione un artículo para eliminar.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm01_menu volver = new frm01_menu();
            this.Close();
        }

        private void dgvarts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            busartxt.Text = dgvarts.CurrentRow.Cells["articulos"].Value.ToString();
            preciounitxt.Text = dgvarts.CurrentRow.Cells["precio_venta"].Value.ToString();
            //codartxt.Text = dgvarts.CurrentRow.Cells["codigo"].Value.ToString();
        }

        private void cantxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                imprimir_Click(sender, e);
                e.SuppressKeyPress = true; // Evita el sonido de beep al presionar Enter
            }
        }

        private void dgvarts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvarts.CurrentRow != null)
                {
                    string articulo = dgvarts.CurrentRow.Cells["articulos"].Value.ToString();
                    busartxt.Text = articulo;
                    busartxt.Focus();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void codartxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
