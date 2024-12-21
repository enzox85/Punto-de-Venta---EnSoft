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
    public partial class frm1_articulos : Form
    {
        public MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password= "); 
        public DataTable tab = new DataTable();
        public frm1_articulos()
        {
            InitializeComponent();
            
        }
      
        private void frm1_articulos_Activated(object sender, EventArgs e)
        {
            tab.Clear();
            con.Open();
            MySqlDataAdapter articulos =
            new MySqlDataAdapter("SELECT idproducto, codigo, articulos, stock, stockmin, precio_costo, iva, precio_venta FROM productos", con);
            articulos.Fill(tab);
            dataGridView1.DataSource = tab.DefaultView;
            //Estilo --------------------------------------------------------
            dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            dataGridView1.EnableHeadersVisualStyles = false;

            DataGridViewCellStyle encabezado = new DataGridViewCellStyle();
            encabezado.BackColor = Color.LightGoldenrodYellow;
            encabezado.ForeColor = Color.DarkOliveGreen; 
            encabezado.Font = new Font("Bradley Hand ITC", 15, FontStyle.Bold); 
            encabezado.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            dataGridView1.ColumnHeadersDefaultCellStyle = encabezado;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["idproducto"].Visible = false;
            dataGridView1.Columns["codigo"].HeaderText = "Código";
            dataGridView1.Columns["articulos"].HeaderText = "Artículos";
            dataGridView1.Columns["stock"].HeaderText = "Stock";
            dataGridView1.Columns["stockmin"].HeaderText = "Stock Min";
            dataGridView1.Columns["precio_costo"].HeaderText = "P.Costo";
            dataGridView1.Columns["iva"].HeaderText = "IVA";
            dataGridView1.Columns["precio_venta"].HeaderText = "P.Venta";
            dataGridView1.Columns["codigo"].Width = 150;
            dataGridView1.Columns["articulos"].Width = 250;
            dataGridView1.Columns["stock"].Width = 100;
            dataGridView1.Columns["stockmin"].Width = 100;
            dataGridView1.Columns["idproducto"].Width = 100;
            dataGridView1.Columns["precio_costo"].Width = 100;
            dataGridView1.Columns["iva"].Width = 50;
            dataGridView1.Columns["precio_venta"].Width = 100;

            con.Close();
        }
        private void bustxt_TextChanged(object sender, EventArgs e)
        {
            tab.DefaultView.RowFilter = "articulos LIKE '%" + bustxt.Text + "%' OR codigo LIKE '" + bustxt.Text + "%'";
            totxt.Text = "Encontrados: " + tab.DefaultView.Count.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idtxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm3_modificar artmod = new frm3_modificar();
            artmod.idtxt2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            artmod.Show();
        
        }


        private void agregart_Click(object sender, EventArgs e)
        {
            frm2_alta_nuevo_artiuclo alta = new frm2_alta_nuevo_artiuclo();
            alta.Show();

        }
        private void modificarbut_Click(object sender, EventArgs e)
        {

            if (idtxt.Text != "")
            {
                frm3_modificar modificar = new frm3_modificar();
                modificar.idtxt2.Text = idtxt.Text;
                modificar.Show();

            }
            else
            {
                MessageBox.Show("Elija una fila para modificar sus datos");
            }
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {//FUNCIÓN: al presionar enter en la fila actual del dgv abre modificar

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                frm3_modificar articulos = new frm3_modificar();
                articulos.idtxt2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                articulos.Show();
        
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//FUNCION: ELIMINAR ARTICULO-----

            /* string fila = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
             if (MessageBox.Show("¿Borrar a: " + dataGridView1.CurrentRow.Cells[2].Value + " de los articulos?", caption: "Enzo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
             {
                 con.Open();
                 MySqlCommand eliminar = new MySqlCommand("DELETE FROM productos WHERE idproducto LIKE '" + fila + "'", con);
                 eliminar.ExecuteNonQuery();
                 tab.Clear();
                 MySqlDataAdapter articulos = new MySqlDataAdapter("SELECT idproducto, codigo, articulos, stock, stockmin, precio_costo, iva, precio_venta FROM productos", con);
                 articulos.Fill(tab);
                 con.Close();
             }*/
            string fila = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("¿Borrar a: " + dataGridView1.CurrentRow.Cells[2].Value + " de los articulos?",
                                "Enzo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                con.Open();

                // Eliminar filas dependientes de la tabla `cuentcor`
                MySqlCommand eliminarDependencias = new MySqlCommand("DELETE FROM cuentcor WHERE idproductofk = @id", con);
                eliminarDependencias.Parameters.AddWithValue("@id", fila);
                eliminarDependencias.ExecuteNonQuery();

                // Eliminar el producto
                MySqlCommand eliminarProducto = new MySqlCommand("DELETE FROM productos WHERE idproducto = @id", con);
                eliminarProducto.Parameters.AddWithValue("@id", fila);
                eliminarProducto.ExecuteNonQuery();

                // Actualizar DataGridView
                tab.Clear();
                MySqlDataAdapter articulos = new MySqlDataAdapter("SELECT idproducto, codigo, articulos, stock, stockmin, precio_costo, iva, precio_venta FROM productos", con);
                articulos.Fill(tab);

                con.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm01_menu volver = new frm01_menu();
           this.Close();
        }

        private void frm1_articulos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm5_clientes clientes = new frm5_clientes();
            clientes.Show();

        }
    }
    
}
