
namespace ABM2
{
    partial class frm5_clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.busctxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idCtxt = new System.Windows.Forms.TextBox();
            this.modificarbut = new System.Windows.Forms.Button();
            this.agregart = new System.Windows.Forms.Button();
            this.totxt = new System.Windows.Forms.Label();
            this.coinctxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar :";
            // 
            // busctxt
            // 
            this.busctxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.busctxt.BackColor = System.Drawing.SystemColors.Info;
            this.busctxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.busctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busctxt.Location = new System.Drawing.Point(129, 16);
            this.busctxt.Name = "busctxt";
            this.busctxt.Size = new System.Drawing.Size(763, 41);
            this.busctxt.TabIndex = 1;
            this.busctxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.busctxt.TextChanged += new System.EventHandler(this.busctxt_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImage = global::ABM2.Properties.Resources._1214926;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(1375, 756);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 72);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(1, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1469, 755);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            // 
            // idCtxt
            // 
            this.idCtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idCtxt.BackColor = System.Drawing.Color.DimGray;
            this.idCtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idCtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.idCtxt.Location = new System.Drawing.Point(781, 16);
            this.idCtxt.Name = "idCtxt";
            this.idCtxt.Size = new System.Drawing.Size(111, 41);
            this.idCtxt.TabIndex = 21;
            this.idCtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idCtxt.Visible = false;
            // 
            // modificarbut
            // 
            this.modificarbut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modificarbut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modificarbut.BackgroundImage = global::ABM2.Properties.Resources.Captura_de_pantalla_2024_08_29_210431;
            this.modificarbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modificarbut.Location = new System.Drawing.Point(1287, 756);
            this.modificarbut.Name = "modificarbut";
            this.modificarbut.Size = new System.Drawing.Size(83, 72);
            this.modificarbut.TabIndex = 3;
            this.modificarbut.UseVisualStyleBackColor = false;
            this.modificarbut.Click += new System.EventHandler(this.modificarbut_Click);
            // 
            // agregart
            // 
            this.agregart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.agregart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.agregart.BackgroundImage = global::ABM2.Properties.Resources.Iconos_gratuitos_de_Botón_Agregar_diseñados_por_Uniconlabs1;
            this.agregart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregart.Location = new System.Drawing.Point(1199, 756);
            this.agregart.Name = "agregart";
            this.agregart.Size = new System.Drawing.Size(83, 72);
            this.agregart.TabIndex = 2;
            this.agregart.UseVisualStyleBackColor = false;
            this.agregart.Click += new System.EventHandler(this.agregart_Click);
            // 
            // totxt
            // 
            this.totxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totxt.AutoSize = true;
            this.totxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totxt.Location = new System.Drawing.Point(898, 6);
            this.totxt.Name = "totxt";
            this.totxt.Size = new System.Drawing.Size(80, 29);
            this.totxt.TabIndex = 22;
            this.totxt.Text = "Total :";
            this.totxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // coinctxt
            // 
            this.coinctxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coinctxt.AutoSize = true;
            this.coinctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinctxt.Location = new System.Drawing.Point(898, 49);
            this.coinctxt.Name = "coinctxt";
            this.coinctxt.Size = new System.Drawing.Size(183, 29);
            this.coinctxt.TabIndex = 23;
            this.coinctxt.Text = "Coinicidencias :";
            this.coinctxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1337, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 66);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cuenta \r\nCorriente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1199, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 66);
            this.button3.TabIndex = 25;
            this.button3.Text = "Consumidor\r\nFinal\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm5_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 854);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.coinctxt);
            this.Controls.Add(this.totxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.modificarbut);
            this.Controls.Add(this.agregart);
            this.Controls.Add(this.idCtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busctxt);
            this.Controls.Add(this.dataGridView2);
            this.Name = "frm5_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.Activated += new System.EventHandler(this.frm5_clientes_Activated);
            this.Load += new System.EventHandler(this.frm5_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox busctxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button agregart;
        public System.Windows.Forms.Button modificarbut;
        public System.Windows.Forms.TextBox idCtxt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label totxt;
        private System.Windows.Forms.Label coinctxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}