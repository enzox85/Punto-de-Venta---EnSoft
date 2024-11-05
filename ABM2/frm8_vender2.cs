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

    public partial class frm8_vender2 : Form
    {
        public MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password= ");
        public DataTable artab = new DataTable();
        public DataTable pedtab = new DataTable();

        public frm8_vender2()
        {
            InitializeComponent();
        }

        private void frm8_vender2_Activated(object sender, EventArgs e)
        {
            artab.Clear();
            con.Open();
            MySqlDataAdapter artadapt =
            new MySqlDataAdapter("SELECT idproducto, codigo, stock, articulos, precio_venta FROM productos", con);
            artadapt.Fill(artab);
            dgvarts.DataSource = artab;
            dgvarts.EnableHeadersVisualStyles = false;
            dgvarts.RowHeadersVisible = false;
        }

        private void busartxt_TextChanged(object sender, EventArgs e)
        {
            artab.DefaultView.RowFilter = "articulos LIKE '%" + busartxt.Text + "%' ";
            //&& codigo LIKE '" + busartxt.Text + "'            
        }

        private void frm8_vender2_Load(object sender, EventArgs e)
        {

        }
    }
}
