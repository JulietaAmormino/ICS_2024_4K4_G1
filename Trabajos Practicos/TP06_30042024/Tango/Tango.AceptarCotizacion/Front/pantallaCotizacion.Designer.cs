namespace Tango.AceptarCotizacion
{
    partial class pantallaCotizacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallaCotizacion));
            this.lblTransNombre = new System.Windows.Forms.Label();
            this.lblTransClasificacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaRetiro = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMarcaTraj = new System.Windows.Forms.Label();
            this.tbDocumento = new System.Windows.Forms.MaskedTextBox();
            this.tbNumeroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.tbPin = new System.Windows.Forms.MaskedTextBox();
            this.tbFechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbContraEntrega = new System.Windows.Forms.RadioButton();
            this.rbContadoRetirar = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbVuelto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbImportePago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTransNombre
            // 
            this.lblTransNombre.AutoSize = true;
            this.lblTransNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransNombre.ForeColor = System.Drawing.Color.White;
            this.lblTransNombre.Location = new System.Drawing.Point(17, 57);
            this.lblTransNombre.Name = "lblTransNombre";
            this.lblTransNombre.Size = new System.Drawing.Size(89, 26);
            this.lblTransNombre.TabIndex = 1;
            this.lblTransNombre.Text = "Nombre";
            // 
            // lblTransClasificacion
            // 
            this.lblTransClasificacion.AutoSize = true;
            this.lblTransClasificacion.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.lblTransClasificacion.ForeColor = System.Drawing.Color.White;
            this.lblTransClasificacion.Location = new System.Drawing.Point(58, 88);
            this.lblTransClasificacion.Name = "lblTransClasificacion";
            this.lblTransClasificacion.Size = new System.Drawing.Size(50, 33);
            this.lblTransClasificacion.TabIndex = 2;
            this.lblTransClasificacion.Text = "0,0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de retiro";
            // 
            // lblFechaRetiro
            // 
            this.lblFechaRetiro.AutoSize = true;
            this.lblFechaRetiro.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRetiro.ForeColor = System.Drawing.Color.Black;
            this.lblFechaRetiro.Location = new System.Drawing.Point(21, 70);
            this.lblFechaRetiro.Name = "lblFechaRetiro";
            this.lblFechaRetiro.Size = new System.Drawing.Size(44, 33);
            this.lblFechaRetiro.TabIndex = 4;
            this.lblFechaRetiro.Text = "FR";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.ForeColor = System.Drawing.Color.Black;
            this.lblFechaEntrega.Location = new System.Drawing.Point(23, 70);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(41, 33);
            this.lblFechaEntrega.TabIndex = 5;
            this.lblFechaEntrega.Text = "FE";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.ForeColor = System.Drawing.Color.White;
            this.lblImporte.Location = new System.Drawing.Point(49, 68);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(93, 33);
            this.lblImporte.TabIndex = 7;
            this.lblImporte.Text = "monto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTransNombre);
            this.panel1.Controls.Add(this.lblTransClasificacion);
            this.panel1.Location = new System.Drawing.Point(24, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 135);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Información del transportista";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblFechaRetiro);
            this.panel2.Location = new System.Drawing.Point(406, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 135);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lblImporte);
            this.panel3.Location = new System.Drawing.Point(828, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 135);
            this.panel3.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 29);
            this.label13.TabIndex = 12;
            this.label13.Text = "Importe del viaje";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblMarcaTraj);
            this.panel4.Controls.Add(this.tbDocumento);
            this.panel4.Controls.Add(this.tb1);
            this.panel4.Controls.Add(this.tbNumeroTarjeta);
            this.panel4.Controls.Add(this.tbPin);
            this.panel4.Controls.Add(this.tbFechaVencimiento);
            this.panel4.Controls.Add(this.cbTipo);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.tbNombre);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(334, 239);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 379);
            this.panel4.TabIndex = 14;
            // 
            // lblMarcaTraj
            // 
            this.lblMarcaTraj.AutoSize = true;
            this.lblMarcaTraj.Location = new System.Drawing.Point(111, 116);
            this.lblMarcaTraj.Name = "lblMarcaTraj";
            this.lblMarcaTraj.Size = new System.Drawing.Size(171, 29);
            this.lblMarcaTraj.TabIndex = 26;
            this.lblMarcaTraj.Text = "Marca de tarjeta";
            // 
            // tbDocumento
            // 
            this.tbDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.tbDocumento.Location = new System.Drawing.Point(151, 324);
            this.tbDocumento.Mask = "99999999999";
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(131, 35);
            this.tbDocumento.TabIndex = 25;
            this.tbDocumento.ValidatingType = typeof(int);
            // 
            // tbNumeroTarjeta
            // 
            this.tbNumeroTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.tbNumeroTarjeta.Location = new System.Drawing.Point(116, 68);
            this.tbNumeroTarjeta.Mask = "999999999999999999";
            this.tbNumeroTarjeta.Name = "tbNumeroTarjeta";
            this.tbNumeroTarjeta.Size = new System.Drawing.Size(344, 35);
            this.tbNumeroTarjeta.TabIndex = 24;
            this.tbNumeroTarjeta.ValidatingType = typeof(int);
            // 
            // tbPin
            // 
            this.tbPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.tbPin.Location = new System.Drawing.Point(67, 161);
            this.tbPin.Mask = "000";
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(55, 35);
            this.tbPin.TabIndex = 23;
            // 
            // tbFechaVencimiento
            // 
            this.tbFechaVencimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.tbFechaVencimiento.Location = new System.Drawing.Point(397, 164);
            this.tbFechaVencimiento.Mask = "00/00";
            this.tbFechaVencimiento.Name = "tbFechaVencimiento";
            this.tbFechaVencimiento.Size = new System.Drawing.Size(63, 35);
            this.tbFechaVencimiento.TabIndex = 22;
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(229, 268);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(231, 37);
            this.cbTipo.Sorted = true;
            this.cbTipo.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 29);
            this.label11.TabIndex = 19;
            this.label11.Text = "Documento";
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(116, 214);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(344, 35);
            this.tbNombre.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo de documento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fecha Vencimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tarjeta";
            // 
            // btConfirmar
            // 
            this.btConfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.btConfirmar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.btConfirmar.Location = new System.Drawing.Point(828, 530);
            this.btConfirmar.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(202, 37);
            this.btConfirmar.TabIndex = 15;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Location = new System.Drawing.Point(245, 681);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(0, 22);
            this.lbMensaje.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.lblFechaEntrega);
            this.panel5.Location = new System.Drawing.Point(616, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 135);
            this.panel5.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(12, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 29);
            this.label12.TabIndex = 3;
            this.label12.Text = "Fecha de entrega";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.rbTarjeta);
            this.panel6.Controls.Add(this.rbContraEntrega);
            this.panel6.Controls.Add(this.rbContadoRetirar);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(24, 239);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(297, 172);
            this.panel6.TabIndex = 14;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTarjeta.Location = new System.Drawing.Point(22, 131);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(92, 29);
            this.rbTarjeta.TabIndex = 11;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            this.rbTarjeta.CheckedChanged += new System.EventHandler(this.cbFormaPago_SelectedIndexChanged);
            // 
            // rbContraEntrega
            // 
            this.rbContraEntrega.AutoSize = true;
            this.rbContraEntrega.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContraEntrega.Location = new System.Drawing.Point(22, 96);
            this.rbContraEntrega.Name = "rbContraEntrega";
            this.rbContraEntrega.Size = new System.Drawing.Size(242, 29);
            this.rbContraEntrega.TabIndex = 10;
            this.rbContraEntrega.TabStop = true;
            this.rbContraEntrega.Text = "Contado contra entrega";
            this.rbContraEntrega.UseVisualStyleBackColor = true;
            this.rbContraEntrega.CheckedChanged += new System.EventHandler(this.cbFormaPago_SelectedIndexChanged);
            // 
            // rbContadoRetirar
            // 
            this.rbContadoRetirar.AutoSize = true;
            this.rbContadoRetirar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContadoRetirar.Location = new System.Drawing.Point(22, 61);
            this.rbContadoRetirar.Name = "rbContadoRetirar";
            this.rbContadoRetirar.Size = new System.Drawing.Size(187, 29);
            this.rbContadoRetirar.TabIndex = 9;
            this.rbContadoRetirar.TabStop = true;
            this.rbContadoRetirar.Text = "Contado al retirar";
            this.rbContadoRetirar.UseVisualStyleBackColor = true;
            this.rbContadoRetirar.CheckedChanged += new System.EventHandler(this.cbFormaPago_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(62, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 29);
            this.label14.TabIndex = 8;
            this.label14.Text = "Forma de pago";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-12, -13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1202, 84);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(97, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 33);
            this.label19.TabIndex = 14;
            this.label19.Text = "Tango";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.tbVuelto);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.tbImportePago);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(24, 428);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(297, 190);
            this.panel7.TabIndex = 15;
            // 
            // tbVuelto
            // 
            this.tbVuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.tbVuelto.Enabled = false;
            this.tbVuelto.Location = new System.Drawing.Point(20, 141);
            this.tbVuelto.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.tbVuelto.Name = "tbVuelto";
            this.tbVuelto.Size = new System.Drawing.Size(252, 30);
            this.tbVuelto.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.label15.Location = new System.Drawing.Point(27, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(243, 29);
            this.label15.TabIndex = 21;
            this.label15.Text = "Vuelto que debo recibir";
            // 
            // tbImportePago
            // 
            this.tbImportePago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.tbImportePago.Enabled = false;
            this.tbImportePago.Location = new System.Drawing.Point(22, 75);
            this.tbImportePago.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.tbImportePago.Name = "tbImportePago";
            this.tbImportePago.Size = new System.Drawing.Size(250, 30);
            this.tbImportePago.TabIndex = 20;
            this.tbImportePago.TextChanged += new System.EventHandler(this.tbImportePago_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.label4.Location = new System.Drawing.Point(18, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Importe con el que pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pago contado";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.panel8.Controls.Add(this.label18);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Location = new System.Drawing.Point(828, 239);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(202, 281);
            this.panel8.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(9, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(180, 29);
            this.label18.TabIndex = 13;
            this.label18.Text = "Número de pago";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(12, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 87);
            this.label16.TabIndex = 12;
            this.label16.Text = "Pago procesado\r\ncorrectamente/\r\nrechazado";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(62, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 33);
            this.label17.TabIndex = 7;
            this.label17.Text = "0000";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.button1.Location = new System.Drawing.Point(828, 581);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb1
            // 
            this.tb1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.tb1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.tb1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.tb1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.tb1.Location = new System.Drawing.Point(352, 378);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(90, 35);
            this.tb1.TabIndex = 21;
            this.tb1.Value = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // pantallaCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pantallaCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aceptacion de Cotizacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTransNombre;
        private System.Windows.Forms.Label lblTransClasificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaRetiro;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox tbFechaVencimiento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.RadioButton rbContraEntrega;
        private System.Windows.Forms.RadioButton rbContadoRetirar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox tbPin;
        private System.Windows.Forms.MaskedTextBox tbNumeroTarjeta;
        private System.Windows.Forms.MaskedTextBox tbDocumento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMarcaTraj;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbVuelto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbImportePago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker tb1;
    }
}

