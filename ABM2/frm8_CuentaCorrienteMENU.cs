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
    public partial class frm8_CuentaCorrienteMENU : Form
    {
        public MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password= ");
        public DataTable cuentab = new DataTable();

        public frm8_CuentaCorrienteMENU()
        {
            InitializeComponent();
        }

        private void frm8_CuentaCorrienteMENU_Load(object sender, EventArgs e)
        {
            
        }

        private void frm8_CuentaCorrienteMENU_Activated(object sender, EventArgs e)
        {
           
            cuentab.Clear();
            con.Open();
            MySqlDataAdapter adapt = new MySqlDataAdapter(
                "SELECT c.idcliente, c.ape_nom AS Nombre, SUM(cc.saldo) AS DeudaTotal " +
                "FROM clientes c " +
                "JOIN cuentcor cc ON c.idcliente = cc.idclientefk " +
                "GROUP BY c.idcliente, c.ape_nom", con);
            adapt.Fill(cuentab);
            dgvcc.DataSource = cuentab.DefaultView;
            dgvcc.RowHeadersVisible = false;
            dgvcc.Columns["idcliente"].Visible = false;
            dgvcc.ClearSelection();

            con.Close();
            ActualizarTotales();

        }

        private void nuevacctxt_Click(object sender, EventArgs e)
        {
            frm5_clientes nuevacuenta = new frm5_clientes();
            nuevacuenta.Show();
         
        }

        private void dgvcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idccmenutxt.Text = dgvcc.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void dgvcc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm8_CuentaCorriente cuentaCorrienteForm = new frm8_CuentaCorriente();
            cuentaCorrienteForm.idcctxt2.Text = dgvcc.CurrentRow.Cells[0].Value.ToString();
            cuentaCorrienteForm.Show();
          
        }

        private void dgvcc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvcc.CurrentRow != null)
                {
                    frm8_CuentaCorriente cuentaCorrienteForm = new frm8_CuentaCorriente();
                    cuentaCorrienteForm.idcctxt2.Text = dgvcc.CurrentRow.Cells[0].Value.ToString();
                    cuentaCorrienteForm.Show();
                    e.SuppressKeyPress = true;
             
                }
            }
        }
        private void ActualizarTotales()
        {
            // Cantidad total de clientes
            int totalClientes = cuentab.Rows.Count;
            label1.Text = totalClientes.ToString();

            // Monto total de deudas
            decimal totalDeudas = cuentab.AsEnumerable()
                                         .Sum(row => Convert.ToDecimal(row["DeudaTotal"]));
            label2.Text = totalDeudas.ToString("C"); // Formato moneda
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
