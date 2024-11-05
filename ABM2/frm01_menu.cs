using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABM2
{
    public partial class frm01_menu : Form
    {
        public frm01_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1_articulos arts = new frm1_articulos();
            arts.Show();
          //  this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm5_clientes clies = new frm5_clientes();
            clies.Show();
         //   this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm9_PROOVScs PROOVEDOR = new frm9_PROOVScs();
            PROOVEDOR.Show();
        }

        private void frm01_menu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm8_vender vender = new frm8_vender();
            vender.Show();
           // this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm9_empleados ira_empleados = new frm9_empleados();
            ira_empleados.Show();
         }

        private void caja2but_Click(object sender, EventArgs e)
        {
            frm8_vender2 caja2 = new frm8_vender2();
            caja2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm8_vender3 caja3 = new frm8_vender3();
            caja3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm8_CuentaCorriente cuenta = new frm8_CuentaCorriente();
            cuenta.Show();
        }

        private void CuentaMenu_Click(object sender, EventArgs e)
        {
            frm8_CuentaCorrienteMENU cuentamenu = new frm8_CuentaCorrienteMENU();
            cuentamenu.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm10_Ventas ventas = new frm10_Ventas();
            ventas.Show();
        }
    }
}
