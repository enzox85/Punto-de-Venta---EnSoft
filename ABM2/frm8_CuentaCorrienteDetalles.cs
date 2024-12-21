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
        decimal montotal = 0;
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

            string idcliente = idccdetallestxt.Text;
            int mes  = dateTimePicker1.Value.Month; // Obtener el mes seleccionado
            int anio = dateTimePicker1.Value.Year;  // Obtener el año seleccionado

            MySqlDataAdapter detadapt = new MySqlDataAdapter(
                "SELECT *FROM cuentcor WHERE idclientefk = @idCliente", con);
            /* "SELECT cuentcor.idcuenta, cuentcor.idclientefk, cuentcor.idproductofk, cuentcor.descripcion, " +
              "cuentcor.cantidad, cuentcor.haber, cuentcor.saldo, cuentcor.fecha " +
              "FROM cuentcor " +
              "INNER JOIN clientes ON cuentcor.idclientefk = clientes.idcliente " +
              "INNER JOIN productos ON cuentcor.idproductofk = productos.idproducto " +
              "WHERE cuentcor.idclientefk = @idCliente " +
              "AND MONTH(cuentcor.fecha) = @Mes AND YEAR(cuentcor.fecha) = @Anio", con);*/

            detadapt.SelectCommand.Parameters.AddWithValue("@idCliente", idcliente);
            detadapt.SelectCommand.Parameters.AddWithValue("@Mes", mes);
            detadapt.SelectCommand.Parameters.AddWithValue("@Anio", anio);

            detadapt.Fill(detallestab);
            dgvdetalles.DataSource = detallestab.DefaultView;
            dgvdetalles.RowHeadersVisible = false;
            dgvdetalles.Columns["idcuenta"].Visible = false;
            dgvdetalles.Columns["idproductofk"].Visible = false;
            dgvdetalles.Columns["idclientefk"].Visible = false;
            dgvdetalles.Columns["haber"].Visible = false;

            con.Close();

            // Calcular el total después de filtrar
            CalcularTotalMonto();

        }
        private void CalcularTotalMonto()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT SUM(debe) FROM cuentcor WHERE idclientefk = @idcliente", con);
            cmd.Parameters.AddWithValue("@idcliente", idccdetallestxt.Text);
            object result = cmd.ExecuteScalar();
            montotal = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            totaltxt.Text = "TOTAL: "  + montotal.ToString("C");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm8_CuentaCorrienteEntregas detalles = new frm8_CuentaCorrienteEntregas();
            detalles.idccentregatxt.Text = idccdetallestxt.Text;
            detalles.Show();
        }
    }


    }
