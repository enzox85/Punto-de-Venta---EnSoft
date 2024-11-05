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
    public partial class frm8_CuentaCorrienteDetalles : Form
    {
        public MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password= ");
        public DataTable detallestab = new DataTable();
        public frm8_CuentaCorrienteDetalles()
        {
            InitializeComponent();
        }

        private void frm8_CuentaCorrienteDetalles_Load(object sender, EventArgs e)
        {

        }

        private void frm8_CuentaCorrienteDetalles_Activated(object sender, EventArgs e)
        {
            detallestab.Clear();
            con.Open();
            string idCliente = idccdetallestxt.Text;
            MySqlDataAdapter detadapt =
                new MySqlDataAdapter("SELECT cuentcor.idcuenta, cuentcor.idclientefk," +
                "cuentcor.idproductofk, cuentcor.descripcion, cuentcor.cantidad, cuentcor.debe, cuentcor.haber, cuentcor.saldo, cuentcor.fecha " +
                "FROM cuentcor " +
                "INNER JOIN clientes ON cuentcor.idclientefk = clientes.idcliente " +
                "INNER JOIN productos ON cuentcor.idproductofk = productos.idproducto " +
                "WHERE cuentcor.idclientefk = @idCliente", con);
                detadapt.SelectCommand.Parameters.AddWithValue("@idCliente", idCliente); 
            // 
            detadapt.Fill(detallestab);
            dgvdetalles.DataSource = detallestab.DefaultView;
            dgvdetalles.Columns["idproductofk"].Visible = false;
            dgvdetalles.Columns["idclientefk"].Visible = false;
            con.Close();

        }
    }
    
}
