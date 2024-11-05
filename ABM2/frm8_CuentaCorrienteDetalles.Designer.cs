
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // bustxt
            // 
            this.bustxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bustxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bustxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bustxt.Location = new System.Drawing.Point(249, 24);
            this.bustxt.Name = "bustxt";
            this.bustxt.Size = new System.Drawing.Size(510, 38);
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
            this.dgvdetalles.Location = new System.Drawing.Point(12, 106);
            this.dgvdetalles.Name = "dgvdetalles";
            this.dgvdetalles.ReadOnly = true;
            this.dgvdetalles.RowHeadersWidth = 51;
            this.dgvdetalles.RowTemplate.Height = 24;
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
            this.idccdetallestxt.Location = new System.Drawing.Point(700, 31);
            this.idccdetallestxt.Name = "idccdetallestxt";
            this.idccdetallestxt.Size = new System.Drawing.Size(69, 31);
            this.idccdetallestxt.TabIndex = 61;
            this.idccdetallestxt.Text = "         ";
            this.idccdetallestxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm8_CuentaCorrienteDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 772);
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
    }
}