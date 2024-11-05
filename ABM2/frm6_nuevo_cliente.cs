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
    public partial class frm6_nuevo_cliente : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost;   database= comercio2; port=3306; user=root; password= ");
        DataTable tab = new DataTable();
        public frm6_nuevo_cliente()
        {
            InitializeComponent();
        }

        private void frm6_nuevo_cliente_Load(object sender, EventArgs e)
        {
            
        }
        private void dnitxt_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(dnitxt.Text.Trim(), out int DNI))
            {
                MessageBox.Show("Por favor, ingresa un DNI válido (números únicamente).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Open();
            MySqlCommand revisardatos = new MySqlCommand("SELECT COUNT(*) FROM clientes WHERE DNI = @DNI", con);
            revisardatos.Parameters.AddWithValue("@DNI", DNI);

            int count = Convert.ToInt32(revisardatos.ExecuteScalar());
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("El DNI ingresado ya existe en la base de datos.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return;
            }

        }
        private void guardar_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(dnitxt.Text) || string.IsNullOrWhiteSpace(datostxt.Text) ||string.IsNullOrWhiteSpace(teltxt.Text) ||string.IsNullOrWhiteSpace(direcctxt.Text))
            {
                MessageBox.Show("Hay campos vacíos o contienen solo espacios. Por favor, complete todos los campos.",
                                "Atención",
                                MessageBoxButtons.OK,MessageBoxIcon.Warning);return;
            }

         
            else
            {
                con.Open();
                MySqlCommand cmdagregar = new MySqlCommand("INSERT INTO clientes(DNI, ape_nom, telefono, domicilio) VALUES(@DNI, @ape_nom, @telefono, @domicilio)", con);
                cmdagregar.Parameters.AddWithValue("@DNI", dnitxt.Text);
                cmdagregar.Parameters.AddWithValue("@ape_nom", datostxt.Text);
                cmdagregar.Parameters.AddWithValue("@telefono", teltxt.Text);
                cmdagregar.Parameters.AddWithValue("@domicilio", direcctxt.Text);

                int fila = cmdagregar.ExecuteNonQuery();
                if (fila > 0)
                {
                    MessageBox.Show("Los datos se guardaron correctamente.","Éxito",MessageBoxButtons.OK,MessageBoxIcon.Information);

                   
                    DialogResult dialogResult = MessageBox.Show("¿Desea agregar otro cliente?","MASTER",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        dnitxt.Text = "";
                        datostxt.Text = "";
                        teltxt.Text = "";
                        direcctxt.Text = "";
                        dnitxt.Focus();
                    }
                    else
                    {
                        // Cerrar este formulario y volver al anterior
                        frm5_clientes volver = new frm5_clientes();
                        volver.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo guardar los datos. Inténtalo nuevamente.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
               
            }
            con.Close();
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            frm5_clientes volver = new frm5_clientes();
           // volver.Show();
            this.Close();
        }

        

       
    }
}
/*cmdagregar.Parameters.AddWithValue("@ape_nom", datostxt.Text.Trim());
cmdagregar.Parameters.AddWithValue("@telefono", teltxt.Text.Trim());
cmdagregar.Parameters.AddWithValue("@domicilio", direcctxt.Text.Trim());*/