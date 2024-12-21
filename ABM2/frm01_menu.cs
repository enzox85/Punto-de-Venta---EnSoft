using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;


namespace ABM2
{
    public partial class frm01_menu : Form
    {
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private bool isMaximized = false;

        public frm01_menu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;  // Deshabilitar la barra de título predeterminada
            this.BackColor = Color.DarkGreen;  // Fondo del formulario (puedes cambiarlo)
            this.Width = 800;  // Ancho inicial
            this.Height = 600;  // Alto inicial



            // Configurar los botones
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();

            // Configuración de los botones
            ConfigureButton(btnMinimize, "–", 1440, 5, BtnMinimize_Click);
            ConfigureButton(btnMaximize, "□", 1470, 5, BtnMaximize_Click);
            ConfigureButton(btnClose, "X", 1500, 5, BtnClose_Click);

            // Añadir los botones al formulario
            this.Controls.Add(btnMinimize);
            this.Controls.Add(btnMaximize);
            this.Controls.Add(btnClose);

            // Para mover la ventana sin la barra de título estándar
            this.MouseDown += new MouseEventHandler(MyForm_MouseDown);
        }

        private void ConfigureButton(Button button, string text, int x, int y, EventHandler clickEvent)
        {
            button.Text = text;
            button.Size = new Size(25, 25);
            button.Location = new Point(x, y);
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.Transparent;
            button.ForeColor = Color.White;
            button.Click += clickEvent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Cambiar el color de la barra de título
            e.Graphics.FillRectangle(Brushes.Teal, 0, 0, this.Width, 30);  // Color de la barra de título

            // Dibujar el texto o elementos adicionales en la barra si es necesario
            e.Graphics.DrawString("SISTEMA DE VENTAS - ENSOFT", new Font("DigifaceWide", 12), Brushes.White, 10, 5);
        }

        // Controlar el movimiento de la ventana
        private void MyForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Permite mover el formulario
                ReleaseCapture();
                SendMessage(Handle, 0x112, 0xf012, 0);
            }
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            isMaximized = !isMaximized;
        }
        private void frm01_menu_Paint_1(object sender, PaintEventArgs e)
        {
            // Configurar fuente y estilo
            Font font = new Font("DigifaceWide", 80, FontStyle.Bold, GraphicsUnit.Point);
            Brush brush = new SolidBrush(Color.FromArgb(100, Color.LightGoldenrodYellow)); // Color con transparencia

            // Texto que aparecerá de fondo
            string texto = "EnSoft Systems";

            // Tamaño del área del texto
            SizeF textSize = e.Graphics.MeasureString(texto, font);

            // Centrar el texto en el formulario
            float x = (this.ClientSize.Width - textSize.Width) / 2;
            float y = (this.ClientSize.Height - textSize.Height) / 2;

            // Dibujar el texto
            e.Graphics.DrawString(texto, font, brush, new PointF(x, y));
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            // Crear el rectángulo del área del panel
            Rectangle rect = panel1.ClientRectangle;

            // Crear el pincel gradiente
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.LightBlue,  // Color inicial
                Color.Teal,   // Color final
                LinearGradientMode.Horizontal)) // Dirección del gradiente
            {
                // Dibujar el gradiente en el área del panel
                e.Graphics.FillRectangle(brush, rect);
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1_articulos arts = new frm1_articulos();
            arts.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm5_clientes clies = new frm5_clientes();
            clies.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm9_PROOVScs PROOVEDOR = new frm9_PROOVScs();
            PROOVEDOR.Show();
        }

        private void frm01_menu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm8_vender vender = new frm8_vender();
            vender.Show();
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
            frn12_CONTROLCAJA caja = new frn12_CONTROLCAJA();
            caja.Show();
        }

       

        private void button9config_Click(object sender, EventArgs e)
        {
            frm11_CONFIGURAR config = new frm11_CONFIGURAR();
            config.Show();
        }
        private void frm01_menu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
