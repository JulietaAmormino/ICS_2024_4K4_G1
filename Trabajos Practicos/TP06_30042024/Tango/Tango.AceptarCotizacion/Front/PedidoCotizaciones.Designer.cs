namespace Tango.AceptarCotizacion.Front
{
    partial class PedidoCotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoCotizaciones));
            this.gridCotizaciones = new System.Windows.Forms.DataGridView();
            this.nroCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRetiro = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNroPedido = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCotizaciones
            // 
            this.gridCotizaciones.AllowUserToAddRows = false;
            this.gridCotizaciones.AllowUserToDeleteRows = false;
            this.gridCotizaciones.BackgroundColor = System.Drawing.Color.White;
            this.gridCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCotizaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroCotizacion,
            this.transportista,
            this.importe,
            this.fRetiro});
            this.gridCotizaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.gridCotizaciones.Location = new System.Drawing.Point(24, 50);
            this.gridCotizaciones.Margin = new System.Windows.Forms.Padding(4);
            this.gridCotizaciones.Name = "gridCotizaciones";
            this.gridCotizaciones.ReadOnly = true;
            this.gridCotizaciones.RowHeadersWidth = 51;
            this.gridCotizaciones.Size = new System.Drawing.Size(974, 241);
            this.gridCotizaciones.TabIndex = 8;
            this.gridCotizaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCotizaciones_CellClick);
            // 
            // nroCotizacion
            // 
            this.nroCotizacion.HeaderText = "Nro Cotizacion";
            this.nroCotizacion.MinimumWidth = 6;
            this.nroCotizacion.Name = "nroCotizacion";
            this.nroCotizacion.ReadOnly = true;
            this.nroCotizacion.Width = 200;
            // 
            // transportista
            // 
            this.transportista.HeaderText = "Transportista";
            this.transportista.MinimumWidth = 6;
            this.transportista.Name = "transportista";
            this.transportista.ReadOnly = true;
            this.transportista.Width = 300;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.MinimumWidth = 6;
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            this.importe.Width = 200;
            // 
            // fRetiro
            // 
            this.fRetiro.HeaderText = "Fecha Retiro";
            this.fRetiro.MinimumWidth = 6;
            this.fRetiro.Name = "fRetiro";
            this.fRetiro.ReadOnly = true;
            this.fRetiro.Width = 200;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Gadugi", 13F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(97, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 26);
            this.label19.TabIndex = 14;
            this.label19.Text = "Tango";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-13, -15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1085, 84);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.lblFechaEntrega);
            this.panel5.Location = new System.Drawing.Point(527, 49);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 89);
            this.panel5.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 13F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(10, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 26);
            this.label12.TabIndex = 3;
            this.label12.Text = "Fecha de entrega";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Gadugi", 13F, System.Drawing.FontStyle.Bold);
            this.lblFechaEntrega.ForeColor = System.Drawing.Color.Black;
            this.lblFechaEntrega.Location = new System.Drawing.Point(10, 47);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(148, 26);
            this.lblFechaEntrega.TabIndex = 5;
            this.lblFechaEntrega.Text = "dd/mm/yyyy";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lblEstado);
            this.panel3.Font = new System.Drawing.Font("Gadugi", 13F);
            this.panel3.Location = new System.Drawing.Point(774, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 89);
            this.panel3.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 13F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(10, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 26);
            this.label13.TabIndex = 12;
            this.label13.Text = "Estado del pedido";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Gadugi", 13F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(10, 47);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(82, 26);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "estado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblTipo);
            this.panel2.Font = new System.Drawing.Font("Gadugi", 13F);
            this.panel2.Location = new System.Drawing.Point(275, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 89);
            this.panel2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 13F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tipo de pedido";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Gadugi", 13F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.Color.Black;
            this.lblTipo.Location = new System.Drawing.Point(12, 47);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(54, 26);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "tipo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.lblNroPedido);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(24, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 89);
            this.panel1.TabIndex = 19;
            // 
            // lblNroPedido
            // 
            this.lblNroPedido.AutoSize = true;
            this.lblNroPedido.Font = new System.Drawing.Font("Gadugi", 13F, System.Drawing.FontStyle.Bold);
            this.lblNroPedido.ForeColor = System.Drawing.Color.White;
            this.lblNroPedido.Location = new System.Drawing.Point(12, 47);
            this.lblNroPedido.Name = "lblNroPedido";
            this.lblNroPedido.Size = new System.Drawing.Size(64, 26);
            this.lblNroPedido.TabIndex = 5;
            this.lblNroPedido.Text = "0000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 13F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nro. de pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 13F);
            this.groupBox2.Location = new System.Drawing.Point(11, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1015, 159);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 13F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(357, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Información del pedido";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.gridCotizaciones);
            this.groupBox3.Font = new System.Drawing.Font("Gadugi", 13F);
            this.groupBox3.Location = new System.Drawing.Point(11, 258);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1015, 314);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 13F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(397, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cotizaciones";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Font = new System.Drawing.Font("Gadugi", 13F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(823, 581);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(203, 37);
            this.btnConfirmar.TabIndex = 25;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // PedidoCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PedidoCotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido Cotizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridCotizaciones;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNroPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewLinkColumn fRetiro;
    }
}