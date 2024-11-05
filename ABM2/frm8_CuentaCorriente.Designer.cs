
namespace ABM2
{
    partial class frm8_CuentaCorriente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bustxt = new System.Windows.Forms.TextBox();
            this.dgvcc = new System.Windows.Forms.DataGridView();
            this.cancelar = new System.Windows.Forms.Button();
            this.vendido = new System.Windows.Forms.Button();
            this.imprimir = new System.Windows.Forms.Button();
            this.moneyintxt = new System.Windows.Forms.TextBox();
            this.entregatxt = new System.Windows.Forms.TextBox();
            this.preciounitxt = new System.Windows.Forms.TextBox();
            this.cantxt = new System.Windows.Forms.TextBox();
            this.imptxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.coincidtxt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idcctxt2 = new System.Windows.Forms.Label();
            this.dgvartcc = new System.Windows.Forms.DataGridView();
            this.directxt = new System.Windows.Forms.Label();
            this.teltxt = new System.Windows.Forms.Label();
            this.apenomtxt = new System.Windows.Forms.Label();
            this.dnitxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechapedido = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.idartxt = new System.Windows.Forms.TextBox();
            this.idcuentatxt = new System.Windows.Forms.TextBox();
            this.saldotxt = new System.Windows.Forms.TextBox();
            this.totalnuventxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.entretatip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvartcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Buscar :";
            // 
            // bustxt
            // 
            this.bustxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bustxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bustxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bustxt.Location = new System.Drawing.Point(128, 11);
            this.bustxt.Name = "bustxt";
            this.bustxt.Size = new System.Drawing.Size(592, 38);
            this.bustxt.TabIndex = 28;
            this.bustxt.TextChanged += new System.EventHandler(this.bustxt_TextChanged_1);
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
            this.dgvcc.Location = new System.Drawing.Point(726, 213);
            this.dgvcc.Name = "dgvcc";
            this.dgvcc.ReadOnly = true;
            this.dgvcc.RowHeadersWidth = 51;
            this.dgvcc.RowTemplate.Height = 24;
            this.dgvcc.Size = new System.Drawing.Size(698, 567);
            this.dgvcc.TabIndex = 37;
            // 
            // cancelar
            // 
            this.cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelar.Location = new System.Drawing.Point(630, 150);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(94, 46);
            this.cancelar.TabIndex = 40;
            this.cancelar.Text = "CANCELAR VENTA";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // vendido
            // 
            this.vendido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vendido.Location = new System.Drawing.Point(631, 99);
            this.vendido.Name = "vendido";
            this.vendido.Size = new System.Drawing.Size(93, 43);
            this.vendido.TabIndex = 39;
            this.vendido.Text = "VENDER";
            this.vendido.UseVisualStyleBackColor = true;
            this.vendido.Click += new System.EventHandler(this.vendido_Click_1);
            // 
            // imprimir
            // 
            this.imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imprimir.Location = new System.Drawing.Point(538, 97);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(87, 45);
            this.imprimir.TabIndex = 38;
            this.imprimir.Text = "CARGAR";
            this.imprimir.UseVisualStyleBackColor = true;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // moneyintxt
            // 
            this.moneyintxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.moneyintxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.moneyintxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyintxt.Location = new System.Drawing.Point(377, 798);
            this.moneyintxt.Name = "moneyintxt";
            this.moneyintxt.Size = new System.Drawing.Size(219, 38);
            this.moneyintxt.TabIndex = 41;
            this.moneyintxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moneyintxt_KeyDown_1);
            // 
            // entregatxt
            // 
            this.entregatxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.entregatxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.entregatxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entregatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entregatxt.Location = new System.Drawing.Point(947, 797);
            this.entregatxt.Name = "entregatxt";
            this.entregatxt.Size = new System.Drawing.Size(219, 38);
            this.entregatxt.TabIndex = 42;
            this.entregatxt.Visible = false;
            // 
            // preciounitxt
            // 
            this.preciounitxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preciounitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciounitxt.Location = new System.Drawing.Point(18, 151);
            this.preciounitxt.Name = "preciounitxt";
            this.preciounitxt.Size = new System.Drawing.Size(145, 45);
            this.preciounitxt.TabIndex = 45;
            // 
            // cantxt
            // 
            this.cantxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cantxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantxt.Location = new System.Drawing.Point(185, 151);
            this.cantxt.Name = "cantxt";
            this.cantxt.Size = new System.Drawing.Size(74, 45);
            this.cantxt.TabIndex = 43;
            this.cantxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantxt.TextChanged += new System.EventHandler(this.cantxt_TextChanged_1);
            this.cantxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cantxt_KeyDown);
            // 
            // imptxt
            // 
            this.imptxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imptxt.Location = new System.Drawing.Point(276, 151);
            this.imptxt.Name = "imptxt";
            this.imptxt.Size = new System.Drawing.Size(180, 45);
            this.imptxt.TabIndex = 44;
            this.imptxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "P. Unitario";
            // 
            // coincidtxt
            // 
            this.coincidtxt.AutoSize = true;
            this.coincidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coincidtxt.Location = new System.Drawing.Point(12, 77);
            this.coincidtxt.Name = "coincidtxt";
            this.coincidtxt.Size = new System.Drawing.Size(155, 25);
            this.coincidtxt.TabIndex = 46;
            this.coincidtxt.Text = "Coincidencias:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 48;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 49;
            this.label7.Text = "Importe";
            // 
            // idcctxt2
            // 
            this.idcctxt2.AutoSize = true;
            this.idcctxt2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.idcctxt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idcctxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idcctxt2.ForeColor = System.Drawing.Color.Lime;
            this.idcctxt2.Location = new System.Drawing.Point(756, 10);
            this.idcctxt2.Name = "idcctxt2";
            this.idcctxt2.Size = new System.Drawing.Size(89, 38);
            this.idcctxt2.TabIndex = 50;
            this.idcctxt2.Text = "         ";
            this.idcctxt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.idcctxt2.TextChanged += new System.EventHandler(this.idcctxt2_TextChanged_1);
            // 
            // dgvartcc
            // 
            this.dgvartcc.AllowUserToAddRows = false;
            this.dgvartcc.AllowUserToDeleteRows = false;
            this.dgvartcc.AllowUserToResizeColumns = false;
            this.dgvartcc.AllowUserToResizeRows = false;
            this.dgvartcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvartcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvartcc.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvartcc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvartcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvartcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvartcc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvartcc.Location = new System.Drawing.Point(12, 213);
            this.dgvartcc.Name = "dgvartcc";
            this.dgvartcc.ReadOnly = true;
            this.dgvartcc.RowHeadersVisible = false;
            this.dgvartcc.RowHeadersWidth = 51;
            this.dgvartcc.RowTemplate.Height = 24;
            this.dgvartcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvartcc.Size = new System.Drawing.Size(712, 567);
            this.dgvartcc.TabIndex = 29;
            this.dgvartcc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvartcc_CellContentDoubleClick_1);
            this.dgvartcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvartcc_KeyDown);
            // 
            // directxt
            // 
            this.directxt.AutoSize = true;
            this.directxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directxt.Location = new System.Drawing.Point(1123, 118);
            this.directxt.Name = "directxt";
            this.directxt.Size = new System.Drawing.Size(95, 29);
            this.directxt.TabIndex = 54;
            this.directxt.Text = "Importe";
            // 
            // teltxt
            // 
            this.teltxt.AutoSize = true;
            this.teltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teltxt.Location = new System.Drawing.Point(1123, 73);
            this.teltxt.Name = "teltxt";
            this.teltxt.Size = new System.Drawing.Size(122, 29);
            this.teltxt.TabIndex = 55;
            this.teltxt.Text = "Teléfono :";
            // 
            // apenomtxt
            // 
            this.apenomtxt.AutoSize = true;
            this.apenomtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apenomtxt.Location = new System.Drawing.Point(751, 73);
            this.apenomtxt.Name = "apenomtxt";
            this.apenomtxt.Size = new System.Drawing.Size(123, 29);
            this.apenomtxt.TabIndex = 57;
            this.apenomtxt.Text = "Ap. y Nom";
            // 
            // dnitxt
            // 
            this.dnitxt.AutoSize = true;
            this.dnitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnitxt.Location = new System.Drawing.Point(769, 120);
            this.dnitxt.Name = "dnitxt";
            this.dnitxt.Size = new System.Drawing.Size(54, 29);
            this.dnitxt.TabIndex = 56;
            this.dnitxt.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1055, 802);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 59;
            this.label2.Text = "SALDO : ";
            // 
            // fechapedido
            // 
            this.fechapedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechapedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechapedido.Location = new System.Drawing.Point(1079, 18);
            this.fechapedido.Name = "fechapedido";
            this.fechapedido.Size = new System.Drawing.Size(345, 27);
            this.fechapedido.TabIndex = 61;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1241, 709);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 59);
            this.button2.TabIndex = 63;
            this.button2.Text = "HISTORIAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idartxt
            // 
            this.idartxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idartxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.idartxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idartxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.idartxt.Location = new System.Drawing.Point(654, 55);
            this.idartxt.Name = "idartxt";
            this.idartxt.Size = new System.Drawing.Size(66, 38);
            this.idartxt.TabIndex = 36;
            this.idartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idcuentatxt
            // 
            this.idcuentatxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idcuentatxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.idcuentatxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idcuentatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idcuentatxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.idcuentatxt.Location = new System.Drawing.Point(868, 11);
            this.idcuentatxt.Name = "idcuentatxt";
            this.idcuentatxt.Size = new System.Drawing.Size(66, 38);
            this.idcuentatxt.TabIndex = 64;
            this.idcuentatxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saldotxt
            // 
            this.saldotxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saldotxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.saldotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saldotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldotxt.Location = new System.Drawing.Point(1178, 797);
            this.saldotxt.Name = "saldotxt";
            this.saldotxt.Size = new System.Drawing.Size(219, 38);
            this.saldotxt.TabIndex = 65;
            // 
            // totalnuventxt
            // 
            this.totalnuventxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalnuventxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.totalnuventxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalnuventxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalnuventxt.Location = new System.Drawing.Point(805, 797);
            this.totalnuventxt.Name = "totalnuventxt";
            this.totalnuventxt.Size = new System.Drawing.Size(119, 38);
            this.totalnuventxt.TabIndex = 66;
            this.totalnuventxt.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 802);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 67;
            this.label4.Text = "PAGO :";
            // 
            // entretatip
            // 
            this.entretatip.ToolTipTitle = "Registre el valor hy presione Enter";
            // 
            // frm8_CuentaCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 848);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalnuventxt);
            this.Controls.Add(this.saldotxt);
            this.Controls.Add(this.idcuentatxt);
            this.Controls.Add(this.idcctxt2);
            this.Controls.Add(this.idartxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fechapedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apenomtxt);
            this.Controls.Add(this.dnitxt);
            this.Controls.Add(this.teltxt);
            this.Controls.Add(this.directxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coincidtxt);
            this.Controls.Add(this.preciounitxt);
            this.Controls.Add(this.cantxt);
            this.Controls.Add(this.imptxt);
            this.Controls.Add(this.entregatxt);
            this.Controls.Add(this.moneyintxt);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.vendido);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.dgvcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bustxt);
            this.Controls.Add(this.dgvartcc);
            this.Name = "frm8_CuentaCorriente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUENTAS";
            this.Activated += new System.EventHandler(this.frm8_CuentaCorriente_Activated);
            this.Load += new System.EventHandler(this.frm8_CuentaCorriente_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvartcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bustxt;
        private System.Windows.Forms.DataGridView dgvcc;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button vendido;
        private System.Windows.Forms.Button imprimir;
        private System.Windows.Forms.TextBox moneyintxt;
        private System.Windows.Forms.TextBox entregatxt;
        private System.Windows.Forms.TextBox preciounitxt;
        private System.Windows.Forms.TextBox cantxt;
        private System.Windows.Forms.TextBox imptxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label coincidtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label idcctxt2;
        private System.Windows.Forms.DataGridView dgvartcc;
        private System.Windows.Forms.Label directxt;
        private System.Windows.Forms.Label teltxt;
        private System.Windows.Forms.Label apenomtxt;
        private System.Windows.Forms.Label dnitxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechapedido;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox idartxt;
        public System.Windows.Forms.TextBox idcuentatxt;
        private System.Windows.Forms.TextBox saldotxt;
        private System.Windows.Forms.TextBox totalnuventxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip entretatip;
    }
}