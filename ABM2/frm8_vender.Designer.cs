
namespace ABM2
{
    partial class frm8_vender
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.busartxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvarts = new System.Windows.Forms.DataGridView();
            this.imptxt = new System.Windows.Forms.TextBox();
            this.cantxt = new System.Windows.Forms.TextBox();
            this.preciounitxt = new System.Windows.Forms.TextBox();
            this.fechapedido = new System.Windows.Forms.DateTimePicker();
            this.dgvpedido = new System.Windows.Forms.DataGridView();
            this.creditotxt = new System.Windows.Forms.TextBox();
            this.debitotxt = new System.Windows.Forms.TextBox();
            this.efectivotxt = new System.Windows.Forms.TextBox();
            this.rb_efectivo = new System.Windows.Forms.RadioButton();
            this.rb_deb = new System.Windows.Forms.RadioButton();
            this.rb_cred = new System.Windows.Forms.RadioButton();
            this.deb_porcent = new System.Windows.Forms.TextBox();
            this.cred_porcent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imprimir = new System.Windows.Forms.Button();
            this.vendido = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.idartxt = new System.Windows.Forms.Label();
            this.coincidtxt = new System.Windows.Forms.Label();
            this.nuevclientbut = new System.Windows.Forms.Button();
            this.nfactxt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.idc3txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subtotaltxt = new System.Windows.Forms.TextBox();
            this.cuencorradb = new System.Windows.Forms.RadioButton();
            this.apenomtxt = new System.Windows.Forms.Label();
            this.dnitxt = new System.Windows.Forms.Label();
            this.teltxt = new System.Windows.Forms.Label();
            this.directxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).BeginInit();
            this.SuspendLayout();
            // 
            // busartxt
            // 
            this.busartxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.busartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busartxt.Location = new System.Drawing.Point(24, 62);
            this.busartxt.Name = "busartxt";
            this.busartxt.Size = new System.Drawing.Size(677, 34);
            this.busartxt.TabIndex = 0;
            this.busartxt.TextChanged += new System.EventHandler(this.busartxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar artículo por nombre o código";
            // 
            // dgvarts
            // 
            this.dgvarts.AllowUserToAddRows = false;
            this.dgvarts.AllowUserToDeleteRows = false;
            this.dgvarts.AllowUserToResizeColumns = false;
            this.dgvarts.AllowUserToResizeRows = false;
            this.dgvarts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvarts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvarts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvarts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvarts.Location = new System.Drawing.Point(9, 213);
            this.dgvarts.Name = "dgvarts";
            this.dgvarts.ReadOnly = true;
            this.dgvarts.RowHeadersWidth = 51;
            this.dgvarts.RowTemplate.Height = 24;
            this.dgvarts.Size = new System.Drawing.Size(692, 623);
            this.dgvarts.TabIndex = 1;
            this.dgvarts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvarts_CellContentClick);
            this.dgvarts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvarts_CellContentDoubleClick);
            this.dgvarts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvarts_KeyDown);
            // 
            // imptxt
            // 
            this.imptxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imptxt.Location = new System.Drawing.Point(501, 149);
            this.imptxt.Name = "imptxt";
            this.imptxt.Size = new System.Drawing.Size(180, 45);
            this.imptxt.TabIndex = 3;
            this.imptxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cantxt
            // 
            this.cantxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cantxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantxt.Location = new System.Drawing.Point(417, 149);
            this.cantxt.Name = "cantxt";
            this.cantxt.Size = new System.Drawing.Size(74, 45);
            this.cantxt.TabIndex = 2;
            this.cantxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantxt.TextChanged += new System.EventHandler(this.cantxt_TextChanged);
            this.cantxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cantxt_KeyDown_1);
            // 
            // preciounitxt
            // 
            this.preciounitxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preciounitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciounitxt.Location = new System.Drawing.Point(261, 149);
            this.preciounitxt.Name = "preciounitxt";
            this.preciounitxt.Size = new System.Drawing.Size(145, 45);
            this.preciounitxt.TabIndex = 5;
            // 
            // fechapedido
            // 
            this.fechapedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechapedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechapedido.Location = new System.Drawing.Point(1080, 19);
            this.fechapedido.Name = "fechapedido";
            this.fechapedido.Size = new System.Drawing.Size(345, 27);
            this.fechapedido.TabIndex = 8;
            // 
            // dgvpedido
            // 
            this.dgvpedido.AllowUserToAddRows = false;
            this.dgvpedido.AllowUserToDeleteRows = false;
            this.dgvpedido.AllowUserToResizeColumns = false;
            this.dgvpedido.AllowUserToResizeRows = false;
            this.dgvpedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvpedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpedido.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvpedido.Location = new System.Drawing.Point(721, 213);
            this.dgvpedido.Name = "dgvpedido";
            this.dgvpedido.RowHeadersWidth = 51;
            this.dgvpedido.RowTemplate.Height = 24;
            this.dgvpedido.Size = new System.Drawing.Size(704, 325);
            this.dgvpedido.TabIndex = 10;
            this.dgvpedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvpedido_KeyDown);
            // 
            // creditotxt
            // 
            this.creditotxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.creditotxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.creditotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditotxt.ForeColor = System.Drawing.Color.Lime;
            this.creditotxt.Location = new System.Drawing.Point(1258, 734);
            this.creditotxt.Name = "creditotxt";
            this.creditotxt.Size = new System.Drawing.Size(153, 34);
            this.creditotxt.TabIndex = 14;
            // 
            // debitotxt
            // 
            this.debitotxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.debitotxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.debitotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.debitotxt.Location = new System.Drawing.Point(1258, 675);
            this.debitotxt.Name = "debitotxt";
            this.debitotxt.Size = new System.Drawing.Size(153, 34);
            this.debitotxt.TabIndex = 13;
            // 
            // efectivotxt
            // 
            this.efectivotxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.efectivotxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.efectivotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efectivotxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.efectivotxt.Location = new System.Drawing.Point(1258, 612);
            this.efectivotxt.Name = "efectivotxt";
            this.efectivotxt.Size = new System.Drawing.Size(153, 34);
            this.efectivotxt.TabIndex = 12;
            // 
            // rb_efectivo
            // 
            this.rb_efectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_efectivo.AutoSize = true;
            this.rb_efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_efectivo.Location = new System.Drawing.Point(979, 617);
            this.rb_efectivo.Name = "rb_efectivo";
            this.rb_efectivo.Size = new System.Drawing.Size(102, 29);
            this.rb_efectivo.TabIndex = 15;
            this.rb_efectivo.TabStop = true;
            this.rb_efectivo.Text = "Efectivo";
            this.rb_efectivo.UseVisualStyleBackColor = true;
            // 
            // rb_deb
            // 
            this.rb_deb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_deb.AutoSize = true;
            this.rb_deb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_deb.Location = new System.Drawing.Point(980, 678);
            this.rb_deb.Name = "rb_deb";
            this.rb_deb.Size = new System.Drawing.Size(89, 29);
            this.rb_deb.TabIndex = 16;
            this.rb_deb.TabStop = true;
            this.rb_deb.Text = "Débito";
            this.rb_deb.UseVisualStyleBackColor = true;
            // 
            // rb_cred
            // 
            this.rb_cred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_cred.AutoSize = true;
            this.rb_cred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cred.Location = new System.Drawing.Point(980, 736);
            this.rb_cred.Name = "rb_cred";
            this.rb_cred.Size = new System.Drawing.Size(96, 29);
            this.rb_cred.TabIndex = 17;
            this.rb_cred.TabStop = true;
            this.rb_cred.Text = "Crédito";
            this.rb_cred.UseVisualStyleBackColor = true;
            // 
            // deb_porcent
            // 
            this.deb_porcent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deb_porcent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deb_porcent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deb_porcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deb_porcent.Location = new System.Drawing.Point(1131, 679);
            this.deb_porcent.Name = "deb_porcent";
            this.deb_porcent.Size = new System.Drawing.Size(81, 30);
            this.deb_porcent.TabIndex = 18;
            this.deb_porcent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cred_porcent
            // 
            this.cred_porcent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cred_porcent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cred_porcent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cred_porcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cred_porcent.Location = new System.Drawing.Point(1131, 738);
            this.cred_porcent.Name = "cred_porcent";
            this.cred_porcent.Size = new System.Drawing.Size(81, 30);
            this.cred_porcent.TabIndex = 19;
            this.cred_porcent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1218, 740);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1218, 678);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "P. Unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(531, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Importe";
            // 
            // imprimir
            // 
            this.imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imprimir.Location = new System.Drawing.Point(778, 676);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(156, 45);
            this.imprimir.TabIndex = 3;
            this.imprimir.Text = "CARGAR";
            this.imprimir.UseVisualStyleBackColor = true;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // vendido
            // 
            this.vendido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vendido.Location = new System.Drawing.Point(778, 727);
            this.vendido.Name = "vendido";
            this.vendido.Size = new System.Drawing.Size(156, 43);
            this.vendido.TabIndex = 28;
            this.vendido.Text = "VENDER";
            this.vendido.UseVisualStyleBackColor = true;
            this.vendido.Click += new System.EventHandler(this.vendido_Click);
            // 
            // cancelar
            // 
            this.cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelar.Location = new System.Drawing.Point(778, 776);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(156, 47);
            this.cancelar.TabIndex = 29;
            this.cancelar.Text = "CANCELAR VENTA";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // idartxt
            // 
            this.idartxt.AutoSize = true;
            this.idartxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idartxt.Location = new System.Drawing.Point(651, 65);
            this.idartxt.Name = "idartxt";
            this.idartxt.Size = new System.Drawing.Size(50, 25);
            this.idartxt.TabIndex = 31;
            this.idartxt.Text = "Idart";
            // 
            // coincidtxt
            // 
            this.coincidtxt.AutoSize = true;
            this.coincidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coincidtxt.Location = new System.Drawing.Point(24, 124);
            this.coincidtxt.Name = "coincidtxt";
            this.coincidtxt.Size = new System.Drawing.Size(160, 25);
            this.coincidtxt.TabIndex = 36;
            this.coincidtxt.Text = "Coinicidencias:";
            // 
            // nuevclientbut
            // 
            this.nuevclientbut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nuevclientbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevclientbut.Location = new System.Drawing.Point(1341, 62);
            this.nuevclientbut.Name = "nuevclientbut";
            this.nuevclientbut.Size = new System.Drawing.Size(59, 31);
            this.nuevclientbut.TabIndex = 39;
            this.nuevclientbut.Text = "( + )";
            this.nuevclientbut.UseVisualStyleBackColor = true;
       
            // 
            // nfactxt
            // 
            this.nfactxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nfactxt.AutoSize = true;
            this.nfactxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfactxt.Location = new System.Drawing.Point(727, 22);
            this.nfactxt.Name = "nfactxt";
            this.nfactxt.Size = new System.Drawing.Size(164, 25);
            this.nfactxt.TabIndex = 41;
            this.nfactxt.Text = "N ° Factura : ....";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(1288, 584);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "TOTAL :";
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImage = global::ABM2.Properties.Resources.Go_back_36760;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(721, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 42);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(565, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 32);
            this.label10.TabIndex = 125;
            this.label10.Text = "CAJA 1";
            // 
            // idc3txt
            // 
            this.idc3txt.AutoSize = true;
            this.idc3txt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idc3txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idc3txt.Location = new System.Drawing.Point(962, 19);
            this.idc3txt.Name = "idc3txt";
            this.idc3txt.Size = new System.Drawing.Size(80, 24);
            this.idc3txt.TabIndex = 126;
            this.idc3txt.Text = "idcliente";
       
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(795, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "SUBTOTAL";
            // 
            // subtotaltxt
            // 
            this.subtotaltxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.subtotaltxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.subtotaltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotaltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotaltxt.ForeColor = System.Drawing.Color.Lime;
            this.subtotaltxt.Location = new System.Drawing.Point(780, 612);
            this.subtotaltxt.Name = "subtotaltxt";
            this.subtotaltxt.Size = new System.Drawing.Size(156, 30);
            this.subtotaltxt.TabIndex = 40;
            // 
            // cuencorradb
            // 
            this.cuencorradb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuencorradb.AutoSize = true;
            this.cuencorradb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuencorradb.Location = new System.Drawing.Point(980, 790);
            this.cuencorradb.Name = "cuencorradb";
            this.cuencorradb.Size = new System.Drawing.Size(182, 29);
            this.cuencorradb.TabIndex = 130;
            this.cuencorradb.TabStop = true;
            this.cuencorradb.Text = "Cuenta Corriente";
            this.cuencorradb.UseVisualStyleBackColor = true;
            // 
            // apenomtxt
            // 
            this.apenomtxt.AutoSize = true;
            this.apenomtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apenomtxt.Location = new System.Drawing.Point(766, 79);
            this.apenomtxt.Name = "apenomtxt";
            this.apenomtxt.Size = new System.Drawing.Size(123, 29);
            this.apenomtxt.TabIndex = 134;
            this.apenomtxt.Text = "Ap. y Nom";
            // 
            // dnitxt
            // 
            this.dnitxt.AutoSize = true;
            this.dnitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnitxt.Location = new System.Drawing.Point(784, 126);
            this.dnitxt.Name = "dnitxt";
            this.dnitxt.Size = new System.Drawing.Size(54, 29);
            this.dnitxt.TabIndex = 133;
            this.dnitxt.Text = "DNI";
            // 
            // teltxt
            // 
            this.teltxt.AutoSize = true;
            this.teltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teltxt.Location = new System.Drawing.Point(1138, 79);
            this.teltxt.Name = "teltxt";
            this.teltxt.Size = new System.Drawing.Size(122, 29);
            this.teltxt.TabIndex = 132;
            this.teltxt.Text = "Teléfono :";
            // 
            // directxt
            // 
            this.directxt.AutoSize = true;
            this.directxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directxt.Location = new System.Drawing.Point(1138, 124);
            this.directxt.Name = "directxt";
            this.directxt.Size = new System.Drawing.Size(95, 29);
            this.directxt.TabIndex = 131;
            this.directxt.Text = "Importe";
            // 
            // frm8_vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1436, 848);
            this.Controls.Add(this.apenomtxt);
            this.Controls.Add(this.dnitxt);
            this.Controls.Add(this.teltxt);
            this.Controls.Add(this.directxt);
            this.Controls.Add(this.cuencorradb);
            this.Controls.Add(this.idc3txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nfactxt);
            this.Controls.Add(this.subtotaltxt);
            this.Controls.Add(this.nuevclientbut);
            this.Controls.Add(this.coincidtxt);
            this.Controls.Add(this.idartxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.vendido);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cred_porcent);
            this.Controls.Add(this.deb_porcent);
            this.Controls.Add(this.rb_cred);
            this.Controls.Add(this.rb_deb);
            this.Controls.Add(this.rb_efectivo);
            this.Controls.Add(this.creditotxt);
            this.Controls.Add(this.debitotxt);
            this.Controls.Add(this.efectivotxt);
            this.Controls.Add(this.dgvpedido);
            this.Controls.Add(this.fechapedido);
            this.Controls.Add(this.preciounitxt);
            this.Controls.Add(this.cantxt);
            this.Controls.Add(this.imptxt);
            this.Controls.Add(this.dgvarts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busartxt);
            this.KeyPreview = true;
            this.Name = "frm8_vender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENDER";
            this.Activated += new System.EventHandler(this.frm8_vender_Activated);
            this.Load += new System.EventHandler(this.frm8_vender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvarts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox busartxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvarts;
        private System.Windows.Forms.TextBox imptxt;
        private System.Windows.Forms.TextBox cantxt;
        private System.Windows.Forms.TextBox preciounitxt;
        private System.Windows.Forms.DateTimePicker fechapedido;
        private System.Windows.Forms.DataGridView dgvpedido;
        private System.Windows.Forms.TextBox creditotxt;
        private System.Windows.Forms.TextBox debitotxt;
        private System.Windows.Forms.TextBox efectivotxt;
        private System.Windows.Forms.RadioButton rb_efectivo;
        private System.Windows.Forms.RadioButton rb_deb;
        private System.Windows.Forms.RadioButton rb_cred;
        private System.Windows.Forms.TextBox deb_porcent;
        private System.Windows.Forms.TextBox cred_porcent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button imprimir;
        private System.Windows.Forms.Button vendido;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label idartxt;
        private System.Windows.Forms.Label coincidtxt;
        private System.Windows.Forms.Button nuevclientbut;
        private System.Windows.Forms.Label nfactxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label idc3txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subtotaltxt;
        private System.Windows.Forms.RadioButton cuencorradb;
        private System.Windows.Forms.Label apenomtxt;
        private System.Windows.Forms.Label dnitxt;
        private System.Windows.Forms.Label teltxt;
        private System.Windows.Forms.Label directxt;
    }
}