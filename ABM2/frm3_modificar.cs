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
    public partial class frm3_modificar : Form
    {

        public MySqlConnection con = new MySqlConnection("server = localhost; database = comercio2; user = root; password = ");
        DataTable tabupdate = new DataTable();
        public frm3_modificar()
        {
            InitializeComponent();
        }

        private void frm3_modificar_Load(object sender, EventArgs e)
        {

            con.Open();
            string id = idtxt2.Text;
            MySqlCommand consulta = new MySqlCommand("SELECT idproducto, codigo, articulos, stock,  stockmin, precio_costo, iva, precio_venta FROM productos WHERE idproducto LIKE '" + id + "' ", con);
            MySqlDataReader resultado = consulta.ExecuteReader();
            if (resultado.Read())
            {
                codigotxt.Text = resultado["codigo"].ToString();
                artxt.Text = resultado["articulos"].ToString();
                stocktxt.Text = resultado["stock"].ToString();
                stocmintxt.Text = resultado["stockmin"].ToString();
                preciocostotxt.Text = resultado["precio_costo"].ToString();
                ivatxt.Text = resultado["iva"].ToString();
                precioventatxt.Text = resultado["precio_venta"].ToString();
              
            }
            con.Close();
        }
        
       private void Guardar_Click_1(object sender, EventArgs e)
       {

            if (idtxt2.Text == "" || codigotxt.Text == " " || artxt.Text == " " || stocktxt.Text == "" || preciocostotxt.Text == " " || ivatxt.Text == " " || precioventatxt.Text == " ")
            {
                MessageBox.Show("Hay campos vacíos, tienen una longitud no valida", caption: "Atención", MessageBoxButtons.OK);
            }
            else
            {
                

                decimal iva = Convert.ToDecimal(ivatxt.Text);
                decimal preciocos = Convert.ToDecimal(preciocostotxt.Text);
                decimal precioven = (iva / 100) * Convert.ToDecimal(preciocostotxt.Text) + preciocos;
                int stockmin = Convert.ToInt32(stocmintxt.Text);
                int stock = Convert.ToInt32(stocktxt.Text);
                stocmintxt.Text = stockmin.ToString();
                precioventatxt.Text = precioven.ToString();
                con.Open();
                MySqlCommand modificar = new MySqlCommand(@"UPDATE productos SET codigo = @codigo,articulos = @articulos,stock = @stock,stockmin =@stockmin, precio_costo = @precio_costo,iva = @iva,precio_venta = @precio_venta WHERE idproducto = @idproducto",con);          
                modificar.Parameters.AddWithValue("@codigo", codigotxt.Text.Trim());
                modificar.Parameters.AddWithValue("@articulos", artxt.Text.Trim());
                modificar.Parameters.AddWithValue("@stock", stock);
                modificar.Parameters.AddWithValue("@precio_costo", preciocos);
                modificar.Parameters.AddWithValue("@iva", iva);
                modificar.Parameters.AddWithValue("@precio_venta", precioven);
                modificar.Parameters.AddWithValue("@stockmin", stockmin);
                modificar.Parameters.AddWithValue("@idproducto", idtxt2.Text.Trim());

                modificar.ExecuteNonQuery();//
                MessageBox.Show("Los datos se guardaron correctamente", caption: "Enzo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

                if (MessageBox.Show("¿Cargar otro articulo?", "ISFD", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    idtxt2.Text = "";
                    codigotxt.Text = "";
                    artxt.Text = "";
                    stocktxt.Text = "";
                    preciocostotxt.Text = "";
                    ivatxt.Text = "";
                    precioventatxt.Text = "";
                    frm1_articulos volver = new frm1_articulos();
                    this.Close();
                }
                else
                {
                    frm1_articulos volver = new frm1_articulos();
                    this.Close();
                }
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {

            frm1_articulos volver = new frm1_articulos();
           // volver.Show();
            this.Close();
        }
        decimal iva;
        private void ivatxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (decimal.TryParse(ivatxt.Text, out iva))
                {
                    // Si la conversión es exitosa, mueve el foco al siguiente control
                    this.SelectNextControl(ivatxt, true, true, true, true);
                }
                else
                {
                     MessageBox.Show("Por favor, ingrese un valor válido para el IVA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.SuppressKeyPress = true;
            }
        }
        private void cantxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int stock;
                if (int.TryParse(stocktxt.Text, out stock))
                {
                    this.SelectNextControl(stocktxt, true, true, true, true);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para el Stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.SuppressKeyPress = true;
            }
        }


        private void preciocostotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                int pcosto;
                if (int.TryParse(preciocostotxt.Text, out pcosto))  
                {
                   
                    decimal iva;
                    if (decimal.TryParse(ivatxt.Text, out iva))
                    {
                        decimal precioven = (iva / 100) * pcosto + pcosto;
                        precioventatxt.Text = precioven.ToString("F2");
                        this.SelectNextControl(preciocostotxt, true, true, true, true);
                        Guardar_Click_1(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un valor válido para el IVA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Mostrar mensaje si el precio de costo no es válido
                    MessageBox.Show("Por favor, ingrese un valor válido para el precio de costo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    e.Handled = true;
            }
        }

      
    }
}

/*BUSCAR POR articulos y por idproducto
 * if (tabupdate != null)
           {
               string filter = "";

               // Verifica si el texto ingresado es un número
               if (int.TryParse(bustxt.Text, out int idValue))
               {
                   filter = string.Format("idproducto = {1} OR articulos LIKE '%{1}%'", idValue, bustxt.Text);
               }
               else
               {
                   filter = string.Format("articulos LIKE '%{1}%'", bustxt.Text);
               }

               tabupdate.DefaultView.RowFilter = filter;
           }*/

/* private void dataGridView1_SelectionChanged(object sender, EventArgs e)
          {

               if (dataGridView1.CurrentRow != null)
               {
                   idproductotxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                   codigotxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                   artxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                   cantxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                   preciocostotxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                   ivatxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                   precioventatxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
               }
          }*/
