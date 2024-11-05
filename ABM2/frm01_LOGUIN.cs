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
    public partial class frm01_LOGUIN : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password= ");
        public frm01_LOGUIN()
        {
            InitializeComponent();
        }

        private void frm01_LOGUIN_Load(object sender, EventArgs e)
        {
            passtxt.UseSystemPasswordChar = true;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            /*  string usuario, pass;
              usuario = usuariotxt.Text.Trim();
              pass = passtxt.Text.Trim();
              if (usuario == "admin" && pass == "123")
              {
                  MessageBox.Show("Bienvenido al Sistema");
                  frm01_menu menu = new frm01_menu();
                  menu.Show();
                  this.Hide();


              }
              else
              {
                  MessageBox.Show("Usuario o Contraseña incorrecto");


              }*/
            string usuario = usuariotxt.Text.Trim();
            string pass = passtxt.Text.Trim();

            try
            {
                // Abrir la conexión a la base de datos
                con.Open();

                // Consulta para obtener el ID de credenciales y verificar la contraseña
                //https://learn.microsoft.com/es-es/dotnet/api/system.data.sqlclient.sqlcommand.executescalar?view=netframework-4.8.1
                string SQL = "SELECT e.idempleado FROM empleados e " +
                               "INNER JOIN credenciales c ON e.idcredencial = c.idcredencial " +
                               "WHERE e.nombre = @nombre AND c.password = @password";

                MySqlCommand inner_emps_pass = new MySqlCommand(SQL, con);
                inner_emps_pass.Parameters.AddWithValue("@nombre", usuario);
                inner_emps_pass.Parameters.AddWithValue("@password", pass);

                // Ejecutar la consulta
                object emp_pass = inner_emps_pass.ExecuteScalar();

                // Si se encuentra un resultado, el usuario está autenticado
                if (emp_pass != null)
                {
                    MessageBox.Show("Bienvenido al Sistema", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm01_menu menu = new frm01_menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                con.Close();
            }
        }
    }
    
}
