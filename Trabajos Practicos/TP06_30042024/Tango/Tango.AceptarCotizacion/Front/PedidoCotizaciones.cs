using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tango.AceptarCotizacion.Datos;

namespace Tango.AceptarCotizacion.Front
{
    public partial class PedidoCotizaciones : Form
    {
        public PedidoCotizaciones(Pedido ped )
        {
            InitializeComponent();
        }

        private void CargarPantalla (Pedido ped)
        {
            //lblNroPedido.Text = ped.idPedido.ToString();
            //lblFechaEntrega.Text = ped.fechaEntrega.ToString();
            //lblTipo = ped.tipoDeCarga.ToString();
            //lbl
            //lblEstado.Text = ped.estado == 1 ? ""
        }
    }
}
