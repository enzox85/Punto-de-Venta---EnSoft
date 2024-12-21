
namespace ABM2
{
    partial class frm8_CuentaCorrienteEntregas
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
            this.dgventrecc = new System.Windows.Forms.DataGridView();
            this.idccentregatxt = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgventrecc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgventrecc
            // 
            this.dgventrecc.AllowUserToAddRows = false;
            this.dgventrecc.AllowUserToDeleteRows = false;
            this.dgventrecc.AllowUserToResizeColumns = false;
            this.dgventrecc.AllowUserToResizeRows = false;
            this.dgventrecc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgventrecc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgventrecc.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgventrecc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgventrecc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgventrecc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgventrecc.Location = new System.Drawing.Point(12, 79);
            this.dgventrecc.Name = "dgventrecc";
            this.dgventrecc.ReadOnly = true;
            this.dgventrecc.RowHeadersWidth = 51;
            this.dgventrecc.RowTemplate.Height = 24;
            this.dgventrecc.Size = new System.Drawing.Size(372, 429);
            this.dgventrecc.TabIndex = 5;
            // 
            // idccentregatxt
            // 
            this.idccentregatxt.AutoSize = true;
            this.idccentregatxt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.idccentregatxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idccentregatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idccentregatxt.ForeColor = System.Drawing.Color.Lime;
            this.idccentregatxt.Location = new System.Drawing.Point(26, 25);
            this.idccentregatxt.Name = "idccentregatxt";
            this.idccentregatxt.Size = new System.Drawing.Size(69, 31);
            this.idccentregatxt.TabIndex = 62;
            this.idccentregatxt.Text = "         ";
            this.idccentregatxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totaltxt
            // 
            this.totaltxt.AutoSize = true;
            this.totaltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltxt.Location = new System.Drawing.Point(216, 529);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(111, 32);
            this.totaltxt.TabIndex = 63;
            this.totaltxt.Text = "TOTAL";
            // 
            // frm8_CuentaCorrienteEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 590);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.idccentregatxt);
            this.Controls.Add(this.dgventrecc);
            this.Name = "frm8_CuentaCorrienteEntregas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm8_CuentaCorrienteEntregas";
            this.Load += new System.EventHandler(this.frm8_CuentaCorrienteEntregas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgventrecc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgventrecc;
        public System.Windows.Forms.Label idccentregatxt;
        private System.Windows.Forms.Label totaltxt;
    }
}