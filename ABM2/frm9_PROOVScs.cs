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
    public partial class frm9_PROOVScs : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password= "); //("Data Source = C:\\Users\\Usuario\\Documents\\SQLite\\comercio2.db; Version=3"); //("server = 209.94.59.168;   database= comercio2; user=enzo; password=Enzo315820"); 
        DataTable tab = new DataTable();
        public frm9_PROOVScs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm01_menu volver = new frm01_menu();
            //   volver.Show();
            this.Close();
        }

        private void agregart_Click(object sender, EventArgs e)
        {
            frm9_Nuevo_PROOV nuevoprove = new frm9_Nuevo_PROOV();
            nuevoprove.Show();
            
        }

        private void modificarbut_Click(object sender, EventArgs e)
        {
            if (idPtxt.Text != "")
            { 
                frm9_PROOV_modificar modificarproov = new frm9_PROOV_modificar();
            modificarproov.Show();
            }
            else
            {
                MessageBox.Show("Elija una fila para modificar sus datos");
            }
        }


        private void frm9_PROOVScs_Load(object sender, EventArgs e)
        {
            dgvprov.RowHeadersVisible = false;// oculta el encabezado de fila, que no sirve p nada solo de relleno. Recomendado, ocultar para amplliar otras columnas con datos
        }

        private void frm9_PROOVScs_Activated(object sender, EventArgs e)
        {
            tab.Clear();
            con.Open();
            MySqlDataAdapter proveed = 
                new MySqlDataAdapter("SELECT idproveedor, nombre, contacto, telefono, direccion FROM proveedores", con);
            proveed.Fill(tab);
            dgvprov.DataSource = tab.DefaultView;
            dgvprov.Columns["idproveedor"].Visible = false;
           //totxt.Text = "Encontrados: " + tab.DefaultView.Count.ToString();
            con.Close();
        }

        private void busctxt_TextChanged(object sender, EventArgs e)
        {
            tab.DefaultView.RowFilter = "nombre LIKE '%" + busctxt.Text + "%' OR contacto LIKE '%" + busctxt + "%'";
        }

        private void dgvprov_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          frm9_PROOV_modificar modifproveed = new frm9_PROOV_modificar();
          modifproveed.idPtxt2.Text = dgvprov.CurrentRow.Cells[0].Value.ToString();
          modifproveed.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FUNCION: ELIMINAR ARTICULO-----

            string fila = Convert.ToString(dgvprov.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("¿Borrar a: " + dgvprov.CurrentRow.Cells[2].Value + " de los Proovedor?",
                caption: "Enzo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                con.Open();
                MySqlCommand eliminar = 
                    new MySqlCommand("DELETE FROM proveedores WHERE idproveedor LIKE '" + fila + "'", con);
                eliminar.ExecuteNonQuery();
                tab.Clear();
                MySqlDataAdapter articulos =
                    new MySqlDataAdapter("SELECT idproveedor, nombre, contacto, telefono, direccion, localidad, provincia, detalles FROM proveedores", con);
                articulos.Fill(tab);
                con.Close();
            }
        }
    }
}
