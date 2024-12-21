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
    public partial class frm11_CONFIGURAR : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password= "); //("Data Source = C:\\Users\\Usuario\\Documents\\SQLite\\comercio2.db; Version=3"); //("server = 209.94.59.168;   database= comercio2; user=enzo; password=Enzo315820"); 
        DataTable datab = new DataTable();
        public frm11_CONFIGURAR()
        {
            InitializeComponent();
        }

        private void frm11_CONFIGURAR_Load(object sender, EventArgs e)
        {
            con.Open();
            int idconfig = 1;
            MySqlDataAdapter adap = new MySqlDataAdapter("Select * from config where idconfig = @idconfig", con);
            adap.SelectCommand.Parameters.AddWithValue("@idconfig", idconfig);
            adap.Fill(datab);
            if (datab.Rows.Count > 0)
            {
                nomcomerciotxt.Text =  Convert.ToString(datab.Rows[0][1]);
                domtxt.Text = Convert.ToString(datab.Rows[0][2]);
                teltxt.Text = Convert.ToString(datab.Rows[0][3]);
                cuitxt.Text = Convert.ToString(datab.Rows[0][4]);
                limitecuentatxt.Text = Convert.ToString(datab.Rows[0][6]);
                porcencostxt.Text =    Convert.ToString(datab.Rows[0][7]);
                pagocredtxt.Text =     Convert.ToString(datab.Rows[0][8]);
                pagodebtxt.Text  =     Convert.ToString(datab.Rows[0][9]);
            }
            else
            {
                MessageBox.Show("No se encontró el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            // Verificar si el registro ya existe
            MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM config WHERE idconfig = @idconfig", con);
            checkCmd.Parameters.AddWithValue("@idconfig", 1); // Supongo que `idconfig = 1` es el registro que deseas actualizar
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count > 0)
            {
                // Si el registro existe, actualiza los datos
                MySqlCommand updateCmd = new MySqlCommand(
                    "UPDATE config SET nomcomercio = @nomcomercio, direccion = @direccion, telefono = @telefono, " +
                    "fecharegistro = @fecharegistro, cuit = @cuit, limitecuenta = @limitecuenta, " +
                    "porcentajecosto = @porcentajecosto, pagoscredito = @pagoscredito, pagosdebito = @pagosdebito " +
                    "WHERE idconfig = @idconfig", con);

                updateCmd.Parameters.AddWithValue("@idconfig", 1);
                updateCmd.Parameters.AddWithValue("@nomcomercio", nomcomerciotxt.Text);
                updateCmd.Parameters.AddWithValue("@direccion", domtxt.Text);
                updateCmd.Parameters.AddWithValue("@telefono", teltxt.Text);
                updateCmd.Parameters.AddWithValue("@fecharegistro", DateTime.Now);
                updateCmd.Parameters.AddWithValue("@cuit", cuitxt.Text);
                updateCmd.Parameters.AddWithValue("@limitecuenta", limitecuentatxt.Text);
                updateCmd.Parameters.AddWithValue("@porcentajecosto", porcencostxt.Text);
                updateCmd.Parameters.AddWithValue("@pagoscredito", pagocredtxt.Text);
                updateCmd.Parameters.AddWithValue("@pagosdebito", pagodebtxt.Text);

                updateCmd.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Si no existe, inserta un nuevo registro
                MySqlCommand insertCmd = new MySqlCommand(
                    "INSERT INTO config (nomcomercio, direccion, telefono, fecharegistro, cuit, limitecuenta, porcentajecosto, pagoscredito, pagosdebito) " +
                    "VALUES (@nomcomercio, @direccion, @telefono, @fecharegistro, @cuit, @limitecuenta, @porcentajecosto, @pagoscredito, @pagosdebito)", con);

                insertCmd.Parameters.AddWithValue("@nomcomercio", nomcomerciotxt.Text);
                insertCmd.Parameters.AddWithValue("@direccion", domtxt.Text);
                insertCmd.Parameters.AddWithValue("@telefono", teltxt.Text);
                insertCmd.Parameters.AddWithValue("@fecharegistro", DateTime.Now);
                insertCmd.Parameters.AddWithValue("@cuit", cuitxt.Text);
                insertCmd.Parameters.AddWithValue("@limitecuenta", limitecuentatxt.Text);
                insertCmd.Parameters.AddWithValue("@porcentajecosto", porcencostxt.Text);
                insertCmd.Parameters.AddWithValue("@pagoscredito", pagocredtxt.Text);
                insertCmd.Parameters.AddWithValue("@pagosdebito", pagodebtxt.Text);

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm01_menu volver = new frm01_menu();
            this.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    
}
