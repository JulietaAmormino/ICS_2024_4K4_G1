using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tango.AceptarCotizacion.Datos;

namespace Tango.AceptarCotizacion.Front
{
    public partial class PedidoCotizaciones : Form
    {
        List<Cotizacion> cotizaciones;
        Cotizacion cot;
        Pedido pedido;

        public PedidoCotizaciones(Pedido ped, List<Cotizacion> cots )
        {
            InitializeComponent();
            CargarPantalla(ped, cots);
            cotizaciones = cots;
            pedido = ped;
        }

        private void CargarPantalla (Pedido ped, List<Cotizacion> cots)
        {
            lblNroPedido.Text = ped.idPedido.ToString();
            lblFechaEntrega.Text = ped.fechaEntrega.ToString();
            lblTipo.Text = ped.tipoDeCarga;
            lblEstado.Text = ped.estado == 0 ? "Publicado" : "Confirmado";

            for (int i = 0; i < cots.Count; i++)
            {
                gridCotizaciones.Rows.Add();
                gridCotizaciones.Rows[i].Cells[0].Value = cots[i].idCotizacion.ToString();
                gridCotizaciones.Rows[i].Cells[1].Value = cots[i].transportista.nombre + " " + cots[i].transportista.apellido;
                gridCotizaciones.Rows[i].Cells[2].Value = cots[i].importe;
                gridCotizaciones.Rows[i].Cells[3].Value = cots[i].fechaRetiro.ToString("dd/MM/yyyy");
                gridCotizaciones.Rows[i].Cells[4].Value = cots[i].fechaEntrega.ToString("dd/MM/yyyy");
            }
        }

        private void ActualizarPantalla(Cotizacion cot)
        {
            lblNroPedido.Text = cot.pedido.idPedido.ToString();
            lblFechaEntrega.Text = cot.pedido.fechaEntrega.ToString();
            lblTipo.Text = cot.pedido.tipoDeCarga;
            lblEstado.Text = cot.pedido.estado == 1 ? "Confirmado" : "Publicado";
            if (cot.pedido.estado == 1)
                btnConfirmar.Enabled = false;
        }

        private void gridCotizaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pedido.estado != 1)
                btnConfirmar.Enabled = true;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            var idCot = gridCotizaciones.CurrentRow.Cells["nroCotizacion"].Value.ToString();
            foreach (var item in cotizaciones)
            {
                if (item.idCotizacion.ToString() == idCot)
                    cot = item;
            }

            this.Hide();
            pantallaCotizacion prop = new pantallaCotizacion(cot);
            prop.ShowDialog();
            this.Show();

            ActualizarPantalla(cot);
        }
    }
}
