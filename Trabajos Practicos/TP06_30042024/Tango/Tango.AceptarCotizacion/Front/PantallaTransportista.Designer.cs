namespace Tango.AceptarCotizacion.Front
{
    partial class PantallaTransportista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaTransportista));
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridCotizaciones = new System.Windows.Forms.DataGridView();
            this.nroCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRetiro = new System.Windows.Forms.DataGridViewLinkColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.psh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(208, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 33);
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
            this.groupBox1.Location = new System.Drawing.Point(-142, -4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1085, 70);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(24, 87);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 48);
            this.panel3.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tus Cotizaciones";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.gridCotizaciones);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 13F);
            this.groupBox3.Location = new System.Drawing.Point(27, 158);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(746, 258);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // gridCotizaciones
            // 
            this.gridCotizaciones.AllowUserToAddRows = false;
            this.gridCotizaciones.AllowUserToDeleteRows = false;
            this.gridCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCotizaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroCotizacion,
            this.nroPedido,
            this.importe,
            this.fRetiro});
            this.gridCotizaciones.Location = new System.Drawing.Point(24, 18);
            this.gridCotizaciones.Margin = new System.Windows.Forms.Padding(4);
            this.gridCotizaciones.Name = "gridCotizaciones";
            this.gridCotizaciones.ReadOnly = true;
            this.gridCotizaciones.RowHeadersWidth = 51;
            this.gridCotizaciones.Size = new System.Drawing.Size(701, 219);
            this.gridCotizaciones.TabIndex = 8;
            // 
            // nroCotizacion
            // 
            this.nroCotizacion.HeaderText = "Nro Cotizacion";
            this.nroCotizacion.MinimumWidth = 6;
            this.nroCotizacion.Name = "nroCotizacion";
            this.nroCotizacion.ReadOnly = true;
            this.nroCotizacion.Width = 200;
            // 
            // nroPedido
            // 
            this.nroPedido.HeaderText = "Nro Pedido";
            this.nroPedido.MinimumWidth = 6;
            this.nroPedido.Name = "nroPedido";
            this.nroPedido.ReadOnly = true;
            this.nroPedido.Width = 175;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.MinimumWidth = 6;
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // fRetiro
            // 
            this.fRetiro.HeaderText = "Fecha Retiro";
            this.fRetiro.MinimumWidth = 6;
            this.fRetiro.Name = "fRetiro";
            this.fRetiro.ReadOnly = true;
            this.fRetiro.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // psh
            // 
            this.psh.AutoSize = true;
            this.psh.Location = new System.Drawing.Point(44, 447);
            this.psh.Name = "psh";
            this.psh.Size = new System.Drawing.Size(0, 16);
            this.psh.TabIndex = 27;
            // 
            // PantallaTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.psh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaTransportista";
            this.Text = "PantallaTransportista";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCotizaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridCotizaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewLinkColumn fRetiro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label psh;
    }
}