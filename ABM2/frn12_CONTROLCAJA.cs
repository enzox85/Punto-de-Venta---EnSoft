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
    public partial class frn12_CONTROLCAJA : Form
    {
        public MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password=");
        public DataTable ventab = new DataTable();
        public DataTable ventab_rango = new DataTable();
        public DataTable gastab = new DataTable();
        public frn12_CONTROLCAJA()
        {InitializeComponent();}

        private void frn12_CONTROLCAJA_Load(object sender, EventArgs e)
        {
            ventab.Clear();
            con.Open();
            MySqlDataAdapter adapt = new MySqlDataAdapter("SELECT num_fact, articulos, cantidad, total, fecha FROM ventas WHERE DATE(fecha) = @fecha", con);
            adapt.SelectCommand.Parameters.AddWithValue("@fecha", dtfechactual.Value.ToString("yyyy-MM-dd"));
            adapt.Fill(ventab);
            dgventas.DataSource = ventab;
            dgventas.RowHeadersVisible = false;
            dgventas.ClearSelection();

            gastab.Clear();
            MySqlDataAdapter adapt2 = new MySqlDataAdapter("SELECT fecha, concepto, monto FROM caja WHERE DATE(fecha) = @fecha", con);
            adapt2.SelectCommand.Parameters.AddWithValue("@fecha", dtfechactual.Value.ToString("yyyy-MM-dd"));
            adapt2.Fill(gastab);
            dgvgastos.DataSource = gastab;
            dgvgastos.RowHeadersVisible = false;
            dgvgastos.ClearSelection();
            con.Close();
            CalcularTotales();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventab_rango.Clear();
            con.Open();
            MySqlDataAdapter adapt3 = new MySqlDataAdapter("SELECT num_fact, articulos, cantidad, total, fecha FROM ventas WHERE DATE(fecha) BETWEEN @fechaDesde AND @fechaHasta", con);
            adapt3.SelectCommand.Parameters.AddWithValue("@fechaDesde", dtfecha1desde.Value.ToString("yyyy-MM-dd"));
            adapt3.SelectCommand.Parameters.AddWithValue("@fechaHasta", dtfecha2hasta.Value.ToString("yyyy-MM-dd"));
            adapt3.Fill(ventab_rango);
            dgventas.DataSource = ventab_rango; // Muestra los datos filtrados
            dgventas.RowHeadersVisible = false;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {//boton para volver a cargar movimientos del día
            frn12_CONTROLCAJA_Load(sender, e);
        }

        private void frn12_CONTROLCAJA_Activated(object sender, EventArgs e)
        {}
                    //GASTOS
        private void enviarboton_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO caja (fecha, concepto, monto) VALUES (@fecha, @concepto, @monto)", con);
            cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@concepto", descriptxt.Text);
            cmd.Parameters.AddWithValue("@monto", Convert.ToDecimal(importxt.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            gastab.Clear();
            con.Open();
            MySqlDataAdapter adapt2 = new MySqlDataAdapter("SELECT fecha, concepto, monto FROM caja WHERE DATE(fecha) = @fecha", con);
            adapt2.SelectCommand.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"));
            adapt2.Fill(gastab);
            dgvgastos.DataSource = gastab;
            dgvgastos.ClearSelection();
            con.Close();

            CalcularTotales();
        }
        private void CalcularTotales()
        {
            
            decimal totalVentas = ventab.AsEnumerable().Sum(row => row.Field<decimal>("total"));
            totventxt.Text = totalVentas.ToString("C"); 

            
            decimal totalGastos = gastab.AsEnumerable().Sum(row => row.Field<decimal>("monto"));
            totgastxt.Text = totalGastos.ToString("C");

            
            decimal ganancia = totalVentas - totalGastos;
            gananciatxt.Text = ganancia.ToString("C");
        }

    }
}
