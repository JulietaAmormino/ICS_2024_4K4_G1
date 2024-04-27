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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNroPedido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nroCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRetiro = new System.Windows.Forms.DataGridViewLinkColumn();
            this.fEntrega = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Pedido:";
            // 
            // lblNroPedido
            // 
            this.lblNroPedido.AutoSize = true;
            this.lblNroPedido.Location = new System.Drawing.Point(142, 43);
            this.lblNroPedido.Name = "lblNroPedido";
            this.lblNroPedido.Size = new System.Drawing.Size(22, 13);
            this.lblNroPedido.TabIndex = 1;
            this.lblNroPedido.Text = "nro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado: ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(304, 43);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(21, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "est";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Pedido:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(489, 43);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(24, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha entrega:";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(126, 74);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(28, 13);
            this.lblFechaEntrega.TabIndex = 7;
            this.lblFechaEntrega.Text = "fech";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroCotizacion,
            this.transportista,
            this.importe,
            this.fRetiro,
            this.fEntrega});
            this.dataGridView1.Location = new System.Drawing.Point(55, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 189);
            this.dataGridView1.TabIndex = 8;
            // 
            // nroCotizacion
            // 
            this.nroCotizacion.HeaderText = "Nro Cotizacion";
            this.nroCotizacion.Name = "nroCotizacion";
            // 
            // transportista
            // 
            this.transportista.HeaderText = "Nombre Transportista";
            this.transportista.Name = "transportista";
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            // 
            // fRetiro
            // 
            this.fRetiro.HeaderText = "Fecha Retiro";
            this.fRetiro.Name = "fRetiro";
            // 
            // fEntrega
            // 
            this.fEntrega.HeaderText = "Fecha Entrega";
            this.fEntrega.Name = "fEntrega";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(657, 419);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // PedidoCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFechaEntrega);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNroPedido);
            this.Controls.Add(this.label1);
            this.Name = "PedidoCotizaciones";
            this.Text = "Pedido Cotizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNroPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewLinkColumn fRetiro;
        private System.Windows.Forms.DataGridViewLinkColumn fEntrega;
        private System.Windows.Forms.Button btnConfirmar;
    }
}