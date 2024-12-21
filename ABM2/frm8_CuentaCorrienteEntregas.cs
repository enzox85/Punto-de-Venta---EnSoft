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
    public partial class frm8_CuentaCorrienteEntregas : Form
    {
        public MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password= ");
        public DataTable entregatab = new DataTable();
        decimal montotal;
        public frm8_CuentaCorrienteEntregas()
        {
            InitializeComponent();
        }

        private void frm8_CuentaCorrienteEntregas_Load(object sender, EventArgs e)
        {
            entregatab.Clear();
            con.Open();
            string idcliente = idccentregatxt.Text;
            // Modificar la consulta para filtrar por idclientefk
            MySqlDataAdapter entregas = new MySqlDataAdapter(
            "SELECT idclientefk, haber, fecha FROM cuentcor WHERE idclientefk = @idclientefk AND haber > 0", con);
            entregas.SelectCommand.Parameters.AddWithValue("@idclientefk", idcliente);
            entregas.Fill(entregatab);
            dgventrecc.DataSource = entregatab;
            con.Close();
            dgventrecc.Columns["idclientefk"].Visible = false;
            CalcularTotalMonto();
        }
        private void CalcularTotalMonto()
        {
            con.Open();
            string idcliente = idccentregatxt.Text;
            MySqlCommand cmd = new MySqlCommand("SELECT SUM(haber) FROM cuentcor WHERE idclientefk = @idcliente", con);
            cmd.Parameters.AddWithValue("@idcliente", idccentregatxt.Text);
            object result = cmd.ExecuteScalar();
            montotal = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            totaltxt.Text = montotal.ToString("C");
            con.Close();
        }
    }
}
