using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tango.AceptarCotizacion.Datos;

namespace Tango.AceptarCotizacion.Front
{
    public partial class PantallaTransportista : Form
    {
        public PantallaTransportista(List<Cotizacion> cots, PedidoCotizaciones pantalla)
        {
            InitializeComponent();

            label1.Text = "Tus Cotizaciones " + cots[0].transportista.nombre.ToString() + " " + cots[0].transportista.apellido.ToString();

            pantalla.SendMessageEvent += (sender, message) =>
            {
               psh.Text = message; // Mostrar el mensaje en PantallaTransportista
               psh.BackColor = Color.Red;
                psh.ForeColor = Color.White;
            };


            for (int i = 0; i < cots.Count; i++)
            {
                gridCotizaciones.Rows.Add();
                gridCotizaciones.Rows[i].Cells[0].Value = cots[i].idCotizacion.ToString();
                gridCotizaciones.Rows[i].Cells[1].Value = cots[i].pedido.idPedido.ToString();
                gridCotizaciones.Rows[i].Cells[2].Value = cots[i].importe;
                gridCotizaciones.Rows[i].Cells[3].Value = cots[i].fechaRetiro.ToString("dd/MM/yyyy");
            }
        }
    }
}
