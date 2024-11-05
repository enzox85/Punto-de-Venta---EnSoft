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
    public partial class frm9_PROOV_modificar : Form
    {
        public frm9_PROOV_modificar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm9_PROOVScs volver = new frm9_PROOVScs();
            //   volver.Show();
            this.Close();
        }

        private void idCtxt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm9_PROOV_modificar_Load(object sender, EventArgs e)
        {

        }
    }
}
