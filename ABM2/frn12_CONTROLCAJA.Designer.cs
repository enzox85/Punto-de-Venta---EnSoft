
namespace ABM2
{
    partial class frn12_CONTROLCAJA
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
            this.dtfechactual = new System.Windows.Forms.DateTimePicker();
            this.dtfecha1desde = new System.Windows.Forms.DateTimePicker();
            this.dtfecha2hasta = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgventas = new System.Windows.Forms.DataGridView();
            this.dgvgastos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.enviarboton = new System.Windows.Forms.Button();
            this.totventxt = new System.Windows.Forms.TextBox();
            this.totgastxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.importxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipo_movtxt = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.descriptxt = new System.Windows.Forms.TextBox();
            this.gananciatxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgastos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtfechactual
            // 
            this.dtfechactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfechactual.Location = new System.Drawing.Point(14, 12);
            this.dtfechactual.Name = "dtfechactual";
            this.dtfechactual.Size = new System.Drawing.Size(54, 30);
            this.dtfechactual.TabIndex = 0;
            this.dtfechactual.Visible = false;
            // 
            // dtfecha1desde
            // 
            this.dtfecha1desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfecha1desde.Location = new System.Drawing.Point(826, 88);
            this.dtfecha1desde.Name = "dtfecha1desde";
            this.dtfecha1desde.Size = new System.Drawing.Size(272, 28);
            this.dtfecha1desde.TabIndex = 1;
            // 
            // dtfecha2hasta
            // 
            this.dtfecha2hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfecha2hasta.Location = new System.Drawing.Point(826, 130);
            this.dtfecha2hasta.Name = "dtfecha2hasta";
            this.dtfecha2hasta.Size = new System.Drawing.Size(272, 28);
            this.dtfecha2hasta.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1120, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "CARGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(736, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Movimientos del día :";
            // 
            // dgventas
            // 
            this.dgventas.AllowUserToAddRows = false;
            this.dgventas.AllowUserToDeleteRows = false;
            this.dgventas.AllowUserToResizeColumns = false;
            this.dgventas.AllowUserToResizeRows = false;
            this.dgventas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgventas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgventas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgventas.Location = new System.Drawing.Point(708, 171);
            this.dgventas.Name = "dgventas";
            this.dgventas.ReadOnly = true;
            this.dgventas.RowHeadersWidth = 51;
            this.dgventas.RowTemplate.Height = 24;
            this.dgventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgventas.Size = new System.Drawing.Size(754, 350);
            this.dgventas.TabIndex = 5;
            // 
            // dgvgastos
            // 
            this.dgvgastos.AllowUserToAddRows = false;
            this.dgvgastos.AllowUserToDeleteRows = false;
            this.dgvgastos.AllowUserToResizeColumns = false;
            this.dgvgastos.AllowUserToResizeRows = false;
            this.dgvgastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvgastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvgastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvgastos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvgastos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvgastos.Location = new System.Drawing.Point(12, 171);
            this.dgvgastos.Name = "dgvgastos";
            this.dgvgastos.ReadOnly = true;
            this.dgvgastos.RowHeadersWidth = 51;
            this.dgvgastos.RowTemplate.Height = 24;
            this.dgvgastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvgastos.Size = new System.Drawing.Size(690, 350);
            this.dgvgastos.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1070, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "VENTAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkRed;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(293, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "GASTOS";
            // 
            // enviarboton
            // 
            this.enviarboton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enviarboton.Location = new System.Drawing.Point(546, 113);
            this.enviarboton.Name = "enviarboton";
            this.enviarboton.Size = new System.Drawing.Size(130, 44);
            this.enviarboton.TabIndex = 41;
            this.enviarboton.Text = "INGRESAR";
            this.enviarboton.UseVisualStyleBackColor = true;
            this.enviarboton.Click += new System.EventHandler(this.enviarboton_Click);
            // 
            // totventxt
            // 
            this.totventxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totventxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.totventxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totventxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.totventxt.Location = new System.Drawing.Point(1248, 599);
            this.totventxt.Name = "totventxt";
            this.totventxt.Size = new System.Drawing.Size(153, 41);
            this.totventxt.TabIndex = 43;
            // 
            // totgastxt
            // 
            this.totgastxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totgastxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.totgastxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totgastxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.totgastxt.Location = new System.Drawing.Point(1249, 680);
            this.totgastxt.Name = "totgastxt";
            this.totgastxt.Size = new System.Drawing.Size(153, 41);
            this.totgastxt.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1215, 648);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 29);
            this.label6.TabIndex = 44;
            this.label6.Text = "TOTAL de GASTOS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1227, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 29);
            this.label7.TabIndex = 45;
            this.label7.Text = "TOTAL de VENTAS:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1120, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 46;
            this.button2.Text = "CARGAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MintCream;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 29);
            this.label8.TabIndex = 48;
            this.label8.Text = "Descripción";
            // 
            // importxt
            // 
            this.importxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.importxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importxt.Location = new System.Drawing.Point(489, 59);
            this.importxt.Name = "importxt";
            this.importxt.Size = new System.Drawing.Size(187, 30);
            this.importxt.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MintCream;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(388, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 29);
            this.label9.TabIndex = 50;
            this.label9.Text = "Importe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(736, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(736, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 52;
            this.label4.Text = "Hasta";
            // 
            // tipo_movtxt
            // 
            this.tipo_movtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_movtxt.FormattingEnabled = true;
            this.tipo_movtxt.Location = new System.Drawing.Point(172, 121);
            this.tipo_movtxt.Name = "tipo_movtxt";
            this.tipo_movtxt.Size = new System.Drawing.Size(187, 28);
            this.tipo_movtxt.TabIndex = 53;
            this.tipo_movtxt.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MintCream;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(82, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 29);
            this.label10.TabIndex = 54;
            this.label10.Text = "Tipo";
            this.label10.Visible = false;
            // 
            // descriptxt
            // 
            this.descriptxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptxt.Location = new System.Drawing.Point(172, 61);
            this.descriptxt.Name = "descriptxt";
            this.descriptxt.Size = new System.Drawing.Size(187, 30);
            this.descriptxt.TabIndex = 55;
            // 
            // gananciatxt
            // 
            this.gananciatxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gananciatxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.gananciatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gananciatxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gananciatxt.Location = new System.Drawing.Point(1248, 756);
            this.gananciatxt.Name = "gananciatxt";
            this.gananciatxt.Size = new System.Drawing.Size(153, 41);
            this.gananciatxt.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1243, 724);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 29);
            this.label11.TabIndex = 57;
            this.label11.Text = "GANANCIAS :";
            // 
            // frn12_CONTROLCAJA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 872);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gananciatxt);
            this.Controls.Add(this.descriptxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tipo_movtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.importxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totventxt);
            this.Controls.Add(this.totgastxt);
            this.Controls.Add(this.enviarboton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvgastos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtfecha2hasta);
            this.Controls.Add(this.dtfecha1desde);
            this.Controls.Add(this.dtfechactual);
            this.Controls.Add(this.dgventas);
            this.Name = "frn12_CONTROLCAJA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frn12_CONTROLCAJA";
            this.Activated += new System.EventHandler(this.frn12_CONTROLCAJA_Activated);
            this.Load += new System.EventHandler(this.frn12_CONTROLCAJA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtfechactual;
        private System.Windows.Forms.DateTimePicker dtfecha1desde;
        private System.Windows.Forms.DateTimePicker dtfecha2hasta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgventas;
        private System.Windows.Forms.DataGridView dgvgastos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button enviarboton;
        private System.Windows.Forms.TextBox totventxt;
        private System.Windows.Forms.TextBox totgastxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox importxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipo_movtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox descriptxt;
        private System.Windows.Forms.TextBox gananciatxt;
        private System.Windows.Forms.Label label11;
    }
}