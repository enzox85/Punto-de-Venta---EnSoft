
namespace ABM2
{
    partial class frm8_CuentaCorrienteDetalles
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
            this.bustxt = new System.Windows.Forms.TextBox();
            this.dgvdetalles = new System.Windows.Forms.DataGridView();
            this.idccdetallestxt = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // bustxt
            // 
            this.bustxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bustxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bustxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bustxt.Location = new System.Drawing.Point(28, 22);
            this.bustxt.Name = "bustxt";
            this.bustxt.Size = new System.Drawing.Size(720, 38);
            this.bustxt.TabIndex = 3;
            // 
            // dgvdetalles
            // 
            this.dgvdetalles.AllowUserToAddRows = false;
            this.dgvdetalles.AllowUserToDeleteRows = false;
            this.dgvdetalles.AllowUserToResizeColumns = false;
            this.dgvdetalles.AllowUserToResizeRows = false;
            this.dgvdetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdetalles.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvdetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdetalles.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdetalles.Location = new System.Drawing.Point(12, 79);
            this.dgvdetalles.Name = "dgvdetalles";
            this.dgvdetalles.ReadOnly = true;
            this.dgvdetalles.RowHeadersWidth = 51;
            this.dgvdetalles.RowTemplate.Height = 24;
            this.dgvdetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetalles.Size = new System.Drawing.Size(1011, 611);
            this.dgvdetalles.TabIndex = 4;
            // 
            // idccdetallestxt
            // 
            this.idccdetallestxt.AutoSize = true;
            this.idccdetallestxt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.idccdetallestxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idccdetallestxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idccdetallestxt.ForeColor = System.Drawing.Color.Lime;
            this.idccdetallestxt.Location = new System.Drawing.Point(679, 27);
            this.idccdetallestxt.Name = "idccdetallestxt";
            this.idccdetallestxt.Size = new System.Drawing.Size(69, 31);
            this.idccdetallestxt.TabIndex = 61;
            this.idccdetallestxt.Text = "         ";
            this.idccdetallestxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totaltxt
            // 
            this.totaltxt.AutoSize = true;
            this.totaltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltxt.Location = new System.Drawing.Point(12, 722);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(111, 32);
            this.totaltxt.TabIndex = 62;
            this.totaltxt.Text = "TOTAL";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(812, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(619, 714);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 40);
            this.button1.TabIndex = 69;
            this.button1.Text = "Entregas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm8_CuentaCorrienteDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 772);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.idccdetallestxt);
            this.Controls.Add(this.bustxt);
            this.Controls.Add(this.dgvdetalles);
            this.Name = "frm8_CuentaCorrienteDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm8_CuentaCorrienteDetalles";
            this.Activated += new System.EventHandler(this.frm8_CuentaCorrienteDetalles_Activated);
            this.Load += new System.EventHandler(this.frm8_CuentaCorrienteDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bustxt;
        private System.Windows.Forms.DataGridView dgvdetalles;
        public System.Windows.Forms.Label idccdetallestxt;
        private System.Windows.Forms.Label totaltxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}