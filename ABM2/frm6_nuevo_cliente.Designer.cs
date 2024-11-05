
namespace ABM2
{
    partial class frm6_nuevo_cliente
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datostxt = new System.Windows.Forms.TextBox();
            this.direcctxt = new System.Windows.Forms.TextBox();
            this.teltxt = new System.Windows.Forms.TextBox();
            this.dnitxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Nombre y Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "DNI";
            // 
            // datostxt
            // 
            this.datostxt.BackColor = System.Drawing.SystemColors.Info;
            this.datostxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datostxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datostxt.Location = new System.Drawing.Point(25, 138);
            this.datostxt.Name = "datostxt";
            this.datostxt.Size = new System.Drawing.Size(374, 34);
            this.datostxt.TabIndex = 2;
            // 
            // direcctxt
            // 
            this.direcctxt.BackColor = System.Drawing.SystemColors.Info;
            this.direcctxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.direcctxt.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direcctxt.Location = new System.Drawing.Point(25, 303);
            this.direcctxt.Name = "direcctxt";
            this.direcctxt.Size = new System.Drawing.Size(380, 31);
            this.direcctxt.TabIndex = 4;
            // 
            // teltxt
            // 
            this.teltxt.BackColor = System.Drawing.SystemColors.Info;
            this.teltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teltxt.Location = new System.Drawing.Point(29, 210);
            this.teltxt.Name = "teltxt";
            this.teltxt.Size = new System.Drawing.Size(374, 34);
            this.teltxt.TabIndex = 3;
            // 
            // dnitxt
            // 
            this.dnitxt.BackColor = System.Drawing.SystemColors.Info;
            this.dnitxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dnitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnitxt.Location = new System.Drawing.Point(29, 59);
            this.dnitxt.Name = "dnitxt";
            this.dnitxt.Size = new System.Drawing.Size(374, 34);
            this.dnitxt.TabIndex = 1;
            this.dnitxt.TextChanged += new System.EventHandler(this.dnitxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 54;
            this.label9.Text = "Domicilio";
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImage = global::ABM2.Properties.Resources.Go_back_36760;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(582, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 101);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guardar.BackgroundImage = global::ABM2.Properties.Resources._43055891;
            this.guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guardar.Location = new System.Drawing.Point(84, 411);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(153, 113);
            this.guardar.TabIndex = 6;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABM2.Properties.Resources.Captura_de_pantalla_2024_08_29_201503;
            this.pictureBox1.Location = new System.Drawing.Point(392, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 307);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // frm6_nuevo_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 536);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datostxt);
            this.Controls.Add(this.direcctxt);
            this.Controls.Add(this.teltxt);
            this.Controls.Add(this.dnitxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm6_nuevo_cliente";
            this.Text = "NUEVO CLIENTE";
            this.Load += new System.EventHandler(this.frm6_nuevo_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox datostxt;
        private System.Windows.Forms.TextBox direcctxt;
        private System.Windows.Forms.TextBox teltxt;
        private System.Windows.Forms.TextBox dnitxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}