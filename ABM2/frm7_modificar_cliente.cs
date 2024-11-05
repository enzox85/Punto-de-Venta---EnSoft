using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABM2
{
    public partial class frm7_modificar_cliente : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost; database=comercio2; user=root; password= ");
        DataTable tab = new DataTable();

        public frm7_modificar_cliente()
        {
            InitializeComponent();
        }

        private void frm7_modificar_cliente_Load(object sender, EventArgs e)
        {
            con.Open();
            string idcliente = idCtxt2.Text;
             MySqlDataAdapter adap = new MySqlDataAdapter("Select * from clientes where idcliente = @idcliente", con);
            adap.SelectCommand.Parameters.AddWithValue("@idcliente", idcliente);
            adap.Fill(tab);
            if (tab.Rows.Count > 0)
            {
                datostxt.Text = Convert.ToString(tab.Rows[0][2]);
                dnitxt.Text = Convert.ToString(tab.Rows[0]["DNI"]);
                teltxt.Text = Convert.ToString(tab.Rows[0][3]);
                direcctxt.Text = Convert.ToString(tab.Rows[0][4]);
            }
            else
            {
                MessageBox.Show("No se encontró el cliente con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (idCtxt2.Text == "" || dnitxt.Text == "" || datostxt.Text == "" || teltxt.Text == "" || direcctxt.Text == "")
            {
                MessageBox.Show("Necesita rellenar todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              
                    con.Open();
                    MySqlCommand modClientes = new MySqlCommand("UPDATE clientes SET DNI = @DNI, ape_nom = @ape_nom, telefono = @telefono, domicilio = @domicilio WHERE idcliente = @idcliente", con);
                    modClientes.Parameters.AddWithValue("@DNI", dnitxt.Text);
                    modClientes.Parameters.AddWithValue("@ape_nom", datostxt.Text);
                    modClientes.Parameters.AddWithValue("@telefono", teltxt.Text); 
                    modClientes.Parameters.AddWithValue("@domicilio", direcctxt.Text);
                    modClientes.Parameters.AddWithValue("@idcliente", idCtxt2.Text); 
                    modClientes.ExecuteNonQuery();
                    MessageBox.Show("Los datos se guardaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
        
                // Refresca el DataGridView con los datos actualizados
                tab.Clear();
                MySqlDataAdapter articulos = new MySqlDataAdapter("select * from clientes", con);
                articulos.Fill(tab);

                if (MessageBox.Show("¿Modificar otro cliente?", "Continuar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    idCtxt2.Text = "";
                    dnitxt.Text = "";
                    datostxt.Text = "";
                    teltxt.Text = "";
                    direcctxt.Text = "";
                    frm5_clientes volver = new frm5_clientes();
                    this.Close();
                }
                else
                {
                    frm5_clientes volver = new frm5_clientes();
                    
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm5_clientes volver = new frm5_clientes();
            //volver.Show();
            this.Close();
        }

  
    }
}
