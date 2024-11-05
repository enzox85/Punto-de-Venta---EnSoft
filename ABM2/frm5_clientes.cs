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
    public partial class frm5_clientes : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database= comercio2; user=root; password= "); //("Data Source = C:\\Users\\Usuario\\Documents\\SQLite\\comercio2.db; Version=3"); //("server = 209.94.59.168;   database= comercio2; user=enzo; password=Enzo315820"); 
        DataTable tab = new DataTable();
        public frm5_clientes()
        {
            InitializeComponent();
        }

        private void busctxt_TextChanged(object sender, EventArgs e)
        {
            tab.DefaultView.RowFilter = "ape_nom LIKE '%" + busctxt.Text + "%' OR CONVERT(DNI, 'System.String') LIKE '%" + busctxt.Text + "%'";
        }

        private void frm5_clientes_Activated(object sender, EventArgs e)
        {
            //conexión-----------------------------------------
            tab.Clear();
            con.Open();
            MySqlDataAdapter clientes = new MySqlDataAdapter("select idcliente, DNI, ape_nom, telefono, domicilio from clientes", con);
            clientes.Fill(tab);
            dataGridView2.DataSource = tab.DefaultView;
            totxt.Text = "Total: " + tab.DefaultView.Count.ToString();
            con.Close();

            //Ajusta el datagrid a la ventana--------------------
            dataGridView2.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        
            // Desactivar los estilos visuales de encabezado predeterminados
            dataGridView2.EnableHeadersVisualStyles = false;

            // Creación de estilo para las cabeceras del DataGridView
            DataGridViewCellStyle encabezado = new DataGridViewCellStyle();
            encabezado.BackColor = Color.LightGoldenrodYellow; 
            encabezado.ForeColor = Color.DarkOliveGreen; 
            encabezado.Font = new Font("Bradley Hand ITC", 15, FontStyle.Bold); 
            encabezado.Alignment = DataGridViewContentAlignment.MiddleCenter; 

            // Asignar estilo a las cabeceras del control
           dataGridView2.ColumnHeadersDefaultCellStyle = encabezado;
           dataGridView2.RowHeadersVisible = false;

            // Personalizar los encabezados de las columnas
            dataGridView2.Columns["idcliente"].Visible = false;
            dataGridView2.Columns["ape_nom"].HeaderText = "Datos personales";
            dataGridView2.Columns["telefono"].HeaderText = "Teléfono";
            dataGridView2.Columns["domicilio"].HeaderText = "Domicilio";

            // Ajustar el ancho de las columnas al contenido de las celdas
            //dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            dataGridView2.Columns["DNI"].Width = 110;
            dataGridView2.Columns["telefono"].Width = 100;
            dataGridView2.Columns["domicilio"].Width = 150;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            //FUNCION: ELIMINAR ARTICULO-----

            string fila = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("¿Borrar a: " + dataGridView2.CurrentRow.Cells[2].Value + " de los clientes?", caption: "Enzo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                con.Open();
                MySqlCommand eliminar = new MySqlCommand("DELETE FROM clientes WHERE idcliente LIKE '" + fila + "'", con);
                eliminar.ExecuteNonQuery();
                tab.Clear();
                MySqlDataAdapter articulos = new MySqlDataAdapter("SELECT idcliente, DNI, ape_nom, telefono, domicilio FROM clientes", con);
                articulos.Fill(tab);
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm01_menu menu = new frm01_menu();
           // menu.Show();
            this.Close();
        }
        private void modificarbut_Click(object sender, EventArgs e)
        {

            if (idCtxt.Text != "")
            {
                frm7_modificar_cliente modificar = new frm7_modificar_cliente();
                modificar.idCtxt2.Text = idCtxt.Text;
                modificar.Show();
              //  this.Hide();
            }
            else
            {
                MessageBox.Show("Elija una fila para modificar sus datos");
            }
        }

        private void agregart_Click(object sender, EventArgs e)
        {
            frm6_nuevo_cliente ir_a = new frm6_nuevo_cliente();
            ir_a.Show();
           // this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCtxt.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            frm7_modificar_cliente modificar = new frm7_modificar_cliente();
            modificar.idCtxt2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            modificar.Show();
            //this.Hide();

        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                frm8_CuentaCorriente ccc = new frm8_CuentaCorriente();
                ccc.idcctxt2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                ccc.Show();;
               this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm8_CuentaCorriente ccc = new frm8_CuentaCorriente();
            ccc.idcctxt2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ccc.Show();
        }

        private void frm5_clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
