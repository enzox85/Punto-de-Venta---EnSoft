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
    public partial class frm10_Ventas : Form
    {
        public MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password= ");
        public DataTable ventab = new DataTable();

        public frm10_Ventas()
        {
            InitializeComponent();
        }

        private void frm10_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void frm10_Ventas_Activated(object sender, EventArgs e)
        {
            ventab.Clear();
            con.Open();
            MySqlDataAdapter articulos =
            new MySqlDataAdapter("SELECT * FROM ventas", con);
            articulos.Fill(ventab);
            dataGridView1.DataSource = ventab.DefaultView;
            con.Close();
        }

        private void bustxt_TextChanged(object sender, EventArgs e)
        {
            ventab.DefaultView.RowFilter = "articulos LIKE '%" + bustxt.Text + "%' OR codigo LIKE '" + bustxt.Text + "%'";
            totxt.Text = "Encontrados: " + ventab.DefaultView.Count.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idventxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
        }
    }
}
