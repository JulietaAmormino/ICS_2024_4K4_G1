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
            this.transNombre = new System.Windows.Forms.Label();
            this.transClasificacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaRetiro = new System.Windows.Forms.Label();
            this.FechaEntrega = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.importe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.formaPago = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // transNombre
            // 
            this.transNombre.AutoSize = true;
            this.transNombre.Location = new System.Drawing.Point(172, 68);
            this.transNombre.Name = "transNombre";
            this.transNombre.Size = new System.Drawing.Size(17, 16);
            this.transNombre.TabIndex = 1;
            this.transNombre.Text = "N";
            // 
            // transClasificacion
            // 
            this.transClasificacion.AutoSize = true;
            this.transClasificacion.Location = new System.Drawing.Point(172, 30);
            this.transClasificacion.Name = "transClasificacion";
            this.transClasificacion.Size = new System.Drawing.Size(16, 16);
            this.transClasificacion.TabIndex = 2;
            this.transClasificacion.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Retiro y Entrega";
            // 
            // fechaRetiro
            // 
            this.fechaRetiro.AutoSize = true;
            this.fechaRetiro.Location = new System.Drawing.Point(122, 42);
            this.fechaRetiro.Name = "fechaRetiro";
            this.fechaRetiro.Size = new System.Drawing.Size(25, 16);
            this.fechaRetiro.TabIndex = 4;
            this.fechaRetiro.Text = "FR";
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.AutoSize = true;
            this.FechaEntrega.Location = new System.Drawing.Point(170, 42);
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.Size = new System.Drawing.Size(24, 16);
            this.FechaEntrega.TabIndex = 5;
            this.FechaEntrega.Text = "FE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "importe";
            // 
            // importe
            // 
            this.importe.AutoSize = true;
            this.importe.Location = new System.Drawing.Point(83, 10);
            this.importe.Name = "importe";
            this.importe.Size = new System.Drawing.Size(10, 16);
            this.importe.TabIndex = 7;
            this.importe.Text = "I";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Metodo de Pago";
            // 
            // formaPago
            // 
            this.formaPago.FormattingEnabled = true;
            this.formaPago.Location = new System.Drawing.Point(283, 39);
            this.formaPago.Name = "formaPago";
            this.formaPago.Size = new System.Drawing.Size(121, 24);
            this.formaPago.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.transNombre);
            this.panel1.Controls.Add(this.transClasificacion);
            this.panel1.Location = new System.Drawing.Point(55, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 99);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "TRANSPORTISTA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fechaRetiro);
            this.panel2.Controls.Add(this.FechaEntrega);
            this.panel2.Location = new System.Drawing.Point(450, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 99);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.importe);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.formaPago);
            this.panel3.Location = new System.Drawing.Point(55, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 70);
            this.panel3.TabIndex = 13;
            // 
            // pantallaCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "pantallaCotizacion";
            this.Text = "Aceptacion de Cotizacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label transNombre;
        private System.Windows.Forms.Label transClasificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fechaRetiro;
        private System.Windows.Forms.Label FechaEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label importe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox formaPago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}

