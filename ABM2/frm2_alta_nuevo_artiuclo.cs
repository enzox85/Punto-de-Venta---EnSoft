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
    public partial class frm2_alta_nuevo_artiuclo : Form
    {
        public MySqlConnection con = new MySqlConnection("server = localhost;   database= comercio2; port=3306; user=root; password= "); //("Data Source = C:\\Users\\Usuario\\Documents\\SQLite\\comercio2.db; Version=3"); 
        public frm2_alta_nuevo_artiuclo()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (codigotxt.Text == " " | artxt.Text == " " | stocktxt.Text == "" | preciocostotxt.Text == " " | ivatxt.Text == " " | precioventatxt.Text == " ")
            {
                MessageBox.Show("Hay campos vacíos, tienen una longitud no valida", caption: "Atención", MessageBoxButtons.OK);
            }
            else
            {

                con.Open();
                string codigo = codigotxt.Text;
                string articulos = artxt.Text;
                string stock = stocktxt.Text;
                string stockmin = stockmintxt.Text;
                
               
                decimal iva = Convert.ToDecimal(ivatxt.Text);
                decimal preciocos = Convert.ToDecimal(preciocostotxt.Text);
                if (codigo == "" | articulos == "" | stock == "" | stockmin == "" | ivatxt.Text == "" | preciocostotxt.Text == "" )
                {
                    MessageBox.Show("Hay campos vacíos, tienen una longitud no valida", caption: "Atención", MessageBoxButtons.OK);
                }
                decimal precioven = (iva / 100) * Convert.ToDecimal(preciocostotxt.Text) + preciocos;
                precioventatxt.Text = precioven.ToString("C");
               
                /*MySqlCommand hacer = new MySqlCommand("insert into productos(codigo, articulos, stock, precio_costo, iva, precio_venta) values ('" + codigo + "' , '" + articulos + "', '" + stock + "' , '" + preciocos + "','" + iva + "', '" + precioven + "')", con);*/
                //Ver sql concatenado, no recomendado por inyeccion sql
                MySqlCommand nuevoart = new MySqlCommand("insert into productos(codigo, articulos, stock, stockmin, precio_costo, iva, precio_venta) values (@codigo, @articulos, @stock, @stockmin, @precio_costo, @iva, @precio_venta )", con);
                nuevoart.Parameters.AddWithValue ("@codigo", codigo);
                nuevoart.Parameters.AddWithValue("@articulos", articulos);
                nuevoart.Parameters.AddWithValue("@stock",stock);
                nuevoart.Parameters.AddWithValue("@stockmin", stockmin);
                nuevoart.Parameters.AddWithValue("@precio_costo", preciocos);
                nuevoart.Parameters.AddWithValue("@iva", iva);
                nuevoart.Parameters.AddWithValue("@precio_venta", precioven);
                

                nuevoart.ExecuteNonQuery();//
                MessageBox.Show("Los datos se guardaron correctamente", caption: "Enzo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                if (MessageBox.Show("¿Cargar otro articulo?", "Enzo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    codigotxt.Text = "";
                    artxt.Text = "";
                    stocktxt.Text = "";
                    preciocostotxt.Text = "";
                    ivatxt.Text = "";
                    precioventatxt.Text = "";
                    stockmintxt.Text = "";
                    
                }
                else
                {

                    frm1_articulos volver = new frm1_articulos();
                    volver.Show();
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm1_articulos volver = new frm1_articulos();
           // volver.Show();
            this.Close();

        }

        private void frm2_alta_nuevo_artiuclo_Load(object sender, EventArgs e)
        {

        }
    }
}
