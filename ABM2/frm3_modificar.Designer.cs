
namespace ABM2
{
    partial class frm3_modificar
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
            this.label11 = new System.Windows.Forms.Label();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.stocktxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ivatxt = new System.Windows.Forms.TextBox();
            this.preciocostotxt = new System.Windows.Forms.TextBox();
            this.stocmintxt = new System.Windows.Forms.TextBox();
            this.idtxt2 = new System.Windows.Forms.TextBox();
            this.volver = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.precioventatxt = new System.Windows.Forms.Label();
            this.artxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 29);
            this.label11.TabIndex = 70;
            this.label11.Text = "Código";
            // 
            // codigotxt
            // 
            this.codigotxt.BackColor = System.Drawing.SystemColors.Info;
            this.codigotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigotxt.Location = new System.Drawing.Point(135, 32);
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(465, 30);
            this.codigotxt.TabIndex = 1;
            // 
            // stocktxt
            // 
            this.stocktxt.BackColor = System.Drawing.SystemColors.Info;
            this.stocktxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stocktxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocktxt.ForeColor = System.Drawing.Color.Black;
            this.stocktxt.Location = new System.Drawing.Point(135, 171);
            this.stocktxt.Name = "stocktxt";
            this.stocktxt.Size = new System.Drawing.Size(100, 30);
            this.stocktxt.TabIndex = 3;
            this.stocktxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stocktxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cantxt_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 65;
            this.label9.Text = "Stock ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "Stock minimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "P. Costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "P. Venta";
            // 
            // ivatxt
            // 
            this.ivatxt.BackColor = System.Drawing.SystemColors.Info;
            this.ivatxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ivatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ivatxt.Location = new System.Drawing.Point(357, 234);
            this.ivatxt.Name = "ivatxt";
            this.ivatxt.Size = new System.Drawing.Size(79, 30);
            this.ivatxt.TabIndex = 6;
            this.ivatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ivatxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ivatxt_KeyDown);
            // 
            // preciocostotxt
            // 
            this.preciocostotxt.BackColor = System.Drawing.SystemColors.Info;
            this.preciocostotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preciocostotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciocostotxt.Location = new System.Drawing.Point(135, 234);
            this.preciocostotxt.Name = "preciocostotxt";
            this.preciocostotxt.Size = new System.Drawing.Size(146, 30);
            this.preciocostotxt.TabIndex = 5;
            this.preciocostotxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.preciocostotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preciocostotxt_KeyPress);
            // 
            // stocmintxt
            // 
            this.stocmintxt.BackColor = System.Drawing.SystemColors.Info;
            this.stocmintxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stocmintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocmintxt.Location = new System.Drawing.Point(429, 166);
            this.stocmintxt.Name = "stocmintxt";
            this.stocmintxt.Size = new System.Drawing.Size(103, 30);
            this.stocmintxt.TabIndex = 4;
            this.stocmintxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idtxt2
            // 
            this.idtxt2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.idtxt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idtxt2.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt2.Location = new System.Drawing.Point(632, 56);
            this.idtxt2.Name = "idtxt2";
            this.idtxt2.Size = new System.Drawing.Size(41, 30);
            this.idtxt2.TabIndex = 0;
            this.idtxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.volver.BackgroundImage = global::ABM2.Properties.Resources.Go_back_36760;
            this.volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volver.Location = new System.Drawing.Point(22, 319);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(73, 58);
            this.volver.TabIndex = 8;
            this.volver.UseVisualStyleBackColor = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Guardar.BackgroundImage = global::ABM2.Properties.Resources._4305589;
            this.Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Guardar.Location = new System.Drawing.Point(650, 309);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(86, 68);
            this.Guardar.TabIndex = 7;
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ABM2.Properties.Resources._1738697;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(619, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 144);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // precioventatxt
            // 
            this.precioventatxt.AutoSize = true;
            this.precioventatxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.precioventatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioventatxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.precioventatxt.Location = new System.Drawing.Point(560, 239);
            this.precioventatxt.Name = "precioventatxt";
            this.precioventatxt.Size = new System.Drawing.Size(0, 29);
            this.precioventatxt.TabIndex = 72;
            this.precioventatxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artxt
            // 
            this.artxt.BackColor = System.Drawing.SystemColors.Info;
            this.artxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.artxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artxt.Location = new System.Drawing.Point(135, 93);
            this.artxt.Name = "artxt";
            this.artxt.Size = new System.Drawing.Size(465, 30);
            this.artxt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 62;
            this.label6.Text = "Artículo";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(804, 769);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 30);
            this.textBox1.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "%";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm3_modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.precioventatxt);
            this.Controls.Add(this.idtxt2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.codigotxt);
            this.Controls.Add(this.stocktxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.artxt);
            this.Controls.Add(this.ivatxt);
            this.Controls.Add(this.preciocostotxt);
            this.Controls.Add(this.stocmintxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm3_modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFICAR ARTÍCULOS :";
            this.Load += new System.EventHandler(this.frm3_modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox codigotxt;
        private System.Windows.Forms.TextBox stocktxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ivatxt;
        private System.Windows.Forms.TextBox preciocostotxt;
        private System.Windows.Forms.TextBox stocmintxt;
        public System.Windows.Forms.TextBox idtxt2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label precioventatxt;
        private System.Windows.Forms.TextBox artxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}