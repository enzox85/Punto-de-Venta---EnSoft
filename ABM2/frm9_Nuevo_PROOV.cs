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
    public partial class frm9_Nuevo_PROOV : Form
    {
        public MySqlConnection con = new MySqlConnection("server = localhost;   database= comercio2; port=3306; user=root; password= ");
        public frm9_Nuevo_PROOV()
        {
            InitializeComponent();
        }

        private void frm9_Nuevo_PROOV_Load(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {

            if (nomprovtxt.Text == " " | contactotxt.Text == " " | teltxt.Text == "" | direcctxt.Text == " " | localidadtxt.Text == " " | provtxt.Text == " " | detstxt.Text == " ")
            {
                MessageBox.Show("Hay campos vacíos, tienen una longitud no valida", caption: "Atención", MessageBoxButtons.OK);
            }
            else
            {

                con.Open();
                string nombreproveedor = nomprovtxt.Text;
                string contacto =       contactotxt.Text;
                string telefono =       teltxt.Text;
                string direc =          direcctxt.Text;
                string localidad =      localidadtxt.Text;
                string provincia =      provtxt.Text;
                string detalles =       detstxt.Text;


                MySqlCommand hacer = new MySqlCommand("INSERT INTO proveedores(nombre, contacto, telefono, direccion, localidad, provincia, detalles) VALUES (@nombre, @contacto, @telefono, @direccion, @localidad, @provincia, @detalles)", con);

                hacer.Parameters.AddWithValue("@nombre", nombreproveedor);
                hacer.Parameters.AddWithValue("@contacto", contacto);
                hacer.Parameters.AddWithValue("@telefono", telefono);
                hacer.Parameters.AddWithValue("@direccion", direc);
                hacer.Parameters.AddWithValue("@localidad", localidad);
                hacer.Parameters.AddWithValue("@provincia", provincia);
                hacer.Parameters.AddWithValue("@detalles", detalles);

                hacer.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente", caption: "Enzo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                if (MessageBox.Show("¿Cargar otro articulo?", "Qué decí vo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    nomprovtxt.Text = "";
                    contactotxt.Text = "";
                    teltxt.Text = "";
                    direcctxt.Text = "";
                    localidadtxt.Text = "";
                    provtxt.Text = "";
                    detstxt.Text = "";
                }
                else
                {

                    frm9_PROOVScs volver = new frm9_PROOVScs();
                    volver.Show();
                    this.Close();
                }
            }
        }
      
    }
}
