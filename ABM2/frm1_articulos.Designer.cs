
namespace ABM2
{
    partial class frm1_articulos
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
            this.totxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bustxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.agregart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.modificarbut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // totxt
            // 
            this.totxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totxt.AutoSize = true;
            this.totxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totxt.Location = new System.Drawing.Point(998, 30);
            this.totxt.Name = "totxt";
            this.totxt.Size = new System.Drawing.Size(160, 29);
            this.totxt.TabIndex = 26;
            this.totxt.Text = "Encontrados: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Buscar :";
            // 
            // bustxt
            // 
            this.bustxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bustxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bustxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bustxt.Location = new System.Drawing.Point(230, 25);
            this.bustxt.Name = "bustxt";
            this.bustxt.Size = new System.Drawing.Size(762, 38);
            this.bustxt.TabIndex = 1;
            this.bustxt.TextChanged += new System.EventHandler(this.bustxt_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1458, 752);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // idtxt
            // 
            this.idtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idtxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.idtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.idtxt.Location = new System.Drawing.Point(892, 28);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 34);
            this.idtxt.TabIndex = 27;
            this.idtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idtxt.Visible = false;
            // 
            // agregart
            // 
            this.agregart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.agregart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.agregart.BackgroundImage = global::ABM2.Properties.Resources.Iconos_gratuitos_de_Botón_Agregar_diseñados_por_Uniconlabs1;
            this.agregart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.agregart.Location = new System.Drawing.Point(1212, 12);
            this.agregart.Name = "agregart";
            this.agregart.Size = new System.Drawing.Size(82, 72);
            this.agregart.TabIndex = 3;
            this.agregart.UseVisualStyleBackColor = false;
            this.agregart.Click += new System.EventHandler(this.agregart_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImage = global::ABM2.Properties.Resources._12149261;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(1388, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 72);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // modificarbut
            // 
            this.modificarbut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modificarbut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modificarbut.BackgroundImage = global::ABM2.Properties.Resources.Captura_de_pantalla_2024_08_29_2104311;
            this.modificarbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modificarbut.Location = new System.Drawing.Point(1300, 12);
            this.modificarbut.Name = "modificarbut";
            this.modificarbut.Size = new System.Drawing.Size(82, 72);
            this.modificarbut.TabIndex = 4;
            this.modificarbut.UseVisualStyleBackColor = false;
            this.modificarbut.Click += new System.EventHandler(this.modificarbut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImage = global::ABM2.Properties.Resources.Go_back_36760;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 72);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm1_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1482, 854);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.totxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bustxt);
            this.Controls.Add(this.modificarbut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.agregart);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm1_articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARTÍCULOS";
            this.Activated += new System.EventHandler(this.frm1_articulos_Activated);
            this.Load += new System.EventHandler(this.frm1_articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bustxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Button agregart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button modificarbut;
        private System.Windows.Forms.Button button1;
    }
}