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
    public partial class frm9_empleados : Form
    {
        MySqlConnection conemp =
            new MySqlConnection("server = localhost; database= comercio2; user=root; password= ");
        DataTable tabemp = new DataTable();
        public frm9_empleados()
        {
            InitializeComponent();
        }

        private void agregart_Click(object sender, EventArgs e)
        {
            frm9_nuevo_empleado nuevoemp = new frm9_nuevo_empleado();
            nuevoemp.Show();
        }

        private void modificarbut_Click(object sender, EventArgs e)
        {
            frm9_modificar_empleado modemp = new frm9_modificar_empleado();
            modemp.Show();
        }

        private void frm9_empleados_Load(object sender, EventArgs e)
        {
            

        }

        private void frm9_empleados_Activated(object sender, EventArgs e)
        {
            //Conexion----------------------------------------
            tabemp.Clear();
            conemp.Open();
            MySqlDataAdapter empleados = new MySqlDataAdapter("Select * from empleados", conemp);
            dgvemps.DataSource = tabemp.DefaultView;
            empleados.Fill(tabemp);
            conemp.Close();
            //Tunear--------------------------------------------
            // Desactivar los estilos visuales de encabezado predeterminados
            dgvemps.EnableHeadersVisualStyles = false;

            // Creación de estilo para las cabeceras del DataGridView
            DataGridViewCellStyle encabezado = new DataGridViewCellStyle();
            encabezado.BackColor = Color.LightGoldenrodYellow; // Color de fondo del encabezado
            encabezado.ForeColor = Color.DarkOliveGreen; // Color del texto del encabezado
            encabezado.Font = new Font("Bradley Hand ITC", 15, FontStyle.Bold); // Fuente del texto del encabezado
            encabezado.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alineación del texto

            // Asignar estilo a las cabeceras del control
            dgvemps.ColumnHeadersDefaultCellStyle = encabezado;
            dgvemps.RowHeadersVisible = false;

            // Personalizar los encabezados de las columnas
            dgvemps.Columns["idempleado"].Visible = false;
            dgvemps.Columns["nombre"].HeaderText = "Nombre";
            dgvemps.Columns["apellido"].HeaderText = "Apellido";
            dgvemps.Columns["email"].HeaderText = "E-m@il";
            dgvemps.Columns["telefono"].HeaderText = "P.Teléfono";
            dgvemps.Columns["domicilio"].HeaderText = "Domicilio";
            dgvemps.Columns["estado"].HeaderText = "Estado";
            dgvemps.Columns["idcredencial"].Visible = false;


            // Ajustar el ancho de las columnas al contenido de las celdas
            //dgvemps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvemps.Columns["nombre"].Width = 100;
            dgvemps.Columns["apellido"].Width = 100;
            dgvemps.Columns["email"].Width = 150;
            dgvemps.Columns["telefono"].Width = 100;
            dgvemps.Columns["domicilio"].Width = 100;
            dgvemps.Columns["estado"].Width = 50;
            conemp.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FUNCION: ELIMINAR ARTICULO-----

            string fila = Convert.ToString(dgvemps.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("¿Borrar a: " + dgvemps.CurrentRow.Cells[2].Value + " de los empleados?", 
                caption: "Enzo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                conemp.Open();
                MySqlCommand eliminar = new MySqlCommand("DELETE FROM empleados WHERE idempleado LIKE '" + fila + "'", conemp);
                eliminar.ExecuteNonQuery();
                tabemp.Clear();
                MySqlDataAdapter articulos = 
                    new MySqlDataAdapter("SELECT idempleado, nombre, apellido, email, telefono, domicilio, estado FROM empleados", conemp);
                articulos.Fill(tabemp);
                conemp.Close();
            }
        }
    }
}
