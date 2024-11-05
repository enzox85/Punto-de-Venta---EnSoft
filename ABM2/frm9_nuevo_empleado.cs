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
    public partial class frm9_nuevo_empleado : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost;   database= comercio2; port=3306; user=root; password= ");
        DataTable tab = new DataTable();
        public frm9_nuevo_empleado()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm9_nuevo_empleado_Load(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {/*
            if (nomemptxt.Text == " " || apemptxt.Text == " " || emailtxt.Text == "" || teltxt.Text == " "||domtxt.Text=="")
            {
                MessageBox.Show(" Hay campos vacíos, tienen una longitud invalida", caption: "Atebción", MessageBoxButtons.OK);
            }
            else
            {
                con.Open();
                
                string nombre =   nomemptxt.Text;
                string apellido = apemptxt.Text;
                string email =   emailtxt.Text;
                string telefono =  teltxt.Text;
                string domicilio = domtxt.Text;
                string pass = passtxt.Text;
                MySqlCommand nuevo = new MySqlCommand("INSERT INTO empleados(  nombre, apellido, email, telefono, domicilio) VALUES('" + nombre + "' , '" + apellido + "' , '" + email + "' , '" + telefono + "', '" + domicilio + "')", con);
                nuevo.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente", caption: "Enzo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Clone();
                if (MessageBox.Show("¿Cargar otro artículo", "MASTER", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    nomemptxt.Text = "";
                    apemptxt.Text = "";
                    teltxt.Text  = "";
                    teltxt.Text = "";
                    domtxt.Text = "";
                }


            
                else
                {
                    frm5_clientes volver = new frm5_clientes();
                    volver.Show();
                    this.Close();
                }

            }
            con.Clone();
*/
            if (string.IsNullOrWhiteSpace(nomemptxt.Text) ||
        string.IsNullOrWhiteSpace(apemptxt.Text) ||
        string.IsNullOrWhiteSpace(emailtxt.Text) ||
        string.IsNullOrWhiteSpace(teltxt.Text) ||
        string.IsNullOrWhiteSpace(domtxt.Text) ||
        string.IsNullOrWhiteSpace(passtxt.Text)) // Validamos el campo de contraseña
            {
                MessageBox.Show("Hay campos vacíos o con longitud inválida", "Atención", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    con.Open();

                    string nombre = nomemptxt.Text;
                    string apellido = apemptxt.Text;
                    string email = emailtxt.Text;
                    string telefono = teltxt.Text;
                    string domicilio = domtxt.Text;
                    string pass = passtxt.Text;

                    // Insertar en la tabla credenciales
                    MySqlCommand cmdCredenciales = new MySqlCommand("INSERT INTO credenciales (password) VALUES (@password)", con);
                    cmdCredenciales.Parameters.AddWithValue("@password", pass);
                    cmdCredenciales.ExecuteNonQuery();

                    // Obtener el último idcredencial insertado
                    long idcredencial = cmdCredenciales.LastInsertedId;

                    // Insertar en la tabla empleados
                    MySqlCommand cmdEmpleados = new MySqlCommand("INSERT INTO empleados (nombre, apellido, email, telefono, domicilio, idcredencial) VALUES (@nombre, @apellido, @email, @telefono, @domicilio, @idcredencial)", con);
                    cmdEmpleados.Parameters.AddWithValue("@nombre", nombre);
                    cmdEmpleados.Parameters.AddWithValue("@apellido", apellido);
                    cmdEmpleados.Parameters.AddWithValue("@email", email);
                    cmdEmpleados.Parameters.AddWithValue("@telefono", telefono);
                    cmdEmpleados.Parameters.AddWithValue("@domicilio", domicilio);
                    cmdEmpleados.Parameters.AddWithValue("@idcredencial", idcredencial);
                    cmdEmpleados.ExecuteNonQuery();

                    MessageBox.Show("Los datos se guardaron correctamente", "Enzo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("¿Cargar otro artículo?", "MASTER", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        nomemptxt.Text = "";
                        apemptxt.Text = "";
                        emailtxt.Text = "";
                        teltxt.Text = "";
                        domtxt.Text = "";
                        passtxt.Text = "";
                    }
                    else
                    {
                        frm5_clientes volver = new frm5_clientes();
                        volver.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
