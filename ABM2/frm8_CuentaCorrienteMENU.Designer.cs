
namespace ABM2
{
    partial class frm8_CuentaCorrienteMENU
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
            this.dgvcc = new System.Windows.Forms.DataGridView();
            this.busclientxt = new System.Windows.Forms.TextBox();
            this.nuevacctxt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idccmenutxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcc
            // 
            this.dgvcc.AllowUserToAddRows = false;
            this.dgvcc.AllowUserToDeleteRows = false;
            this.dgvcc.AllowUserToResizeColumns = false;
            this.dgvcc.AllowUserToResizeRows = false;
            this.dgvcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcc.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvcc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcc.Location = new System.Drawing.Point(227, 100);
            this.dgvcc.Name = "dgvcc";
            this.dgvcc.ReadOnly = true;
            this.dgvcc.RowHeadersWidth = 51;
            this.dgvcc.RowTemplate.Height = 24;
            this.dgvcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcc.Size = new System.Drawing.Size(800, 546);
            this.dgvcc.TabIndex = 38;
            this.dgvcc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcc_CellContentClick);
            this.dgvcc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcc_CellContentDoubleClick);
            this.dgvcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvcc_KeyDown);
            // 
            // busclientxt
            // 
            this.busclientxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.busclientxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.busclientxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.busclientxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busclientxt.Location = new System.Drawing.Point(237, 26);
            this.busclientxt.Name = "busclientxt";
            this.busclientxt.Size = new System.Drawing.Size(755, 38);
            this.busclientxt.TabIndex = 59;
            // 
            // nuevacctxt
            // 
            this.nuevacctxt.Location = new System.Drawing.Point(12, 100);
            this.nuevacctxt.Name = "nuevacctxt";
            this.nuevacctxt.Size = new System.Drawing.Size(111, 75);
            this.nuevacctxt.TabIndex = 60;
            this.nuevacctxt.Text = "Nueva\r\nCuenta";
            this.nuevacctxt.UseVisualStyleBackColor = true;
            this.nuevacctxt.Click += new System.EventHandler(this.nuevacctxt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 75);
            this.button1.TabIndex = 61;
            this.button1.Text = "Modificar\r\nCuenta\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 75);
            this.button2.TabIndex = 62;
            this.button2.Text = "Eliminar\r\nCuenta\r\n\r\n";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(36, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 32);
            this.label1.TabIndex = 63;
            this.label1.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(28, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 32);
            this.label2.TabIndex = 64;
            this.label2.Text = "....";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // idccmenutxt
            // 
            this.idccmenutxt.AutoSize = true;
            this.idccmenutxt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.idccmenutxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idccmenutxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idccmenutxt.ForeColor = System.Drawing.Color.Lime;
            this.idccmenutxt.Location = new System.Drawing.Point(916, 26);
            this.idccmenutxt.Name = "idccmenutxt";
            this.idccmenutxt.Size = new System.Drawing.Size(89, 38);
            this.idccmenutxt.TabIndex = 65;
            this.idccmenutxt.Text = "         ";
            this.idccmenutxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 96);
            this.label3.TabIndex = 66;
            this.label3.Text = " \r\nTotal \r\nde \r\nClientes :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 96);
            this.label4.TabIndex = 67;
            this.label4.Text = "\r\nTotal \r\nde \r\nDeudas :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm8_CuentaCorrienteMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 736);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idccmenutxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nuevacctxt);
            this.Controls.Add(this.busclientxt);
            this.Controls.Add(this.dgvcc);
            this.Name = "frm8_CuentaCorrienteMENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm8_CuentaCorrienteMENU";
            this.Activated += new System.EventHandler(this.frm8_CuentaCorrienteMENU_Activated);
            this.Load += new System.EventHandler(this.frm8_CuentaCorrienteMENU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcc;
        private System.Windows.Forms.TextBox busclientxt;
        private System.Windows.Forms.Button nuevacctxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label idccmenutxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}