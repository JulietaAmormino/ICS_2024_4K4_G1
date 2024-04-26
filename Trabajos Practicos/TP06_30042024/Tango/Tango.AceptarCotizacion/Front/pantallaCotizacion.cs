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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tango.AceptarCotizacion
{
    public partial class pantallaCotizacion : Form
    {
        public pantallaCotizacion(Cotizacion cot)
        {
            InitializeComponent();
            CargarPantalla(cot);
        }

        public void CargarPantalla(Cotizacion cot)
        {
            transNombre.Text = cot.transportista.nombre +  " " + cot.transportista.apellido;
            transClasificacion.Text = cot.transportista.clasificacion.ToString();
            fechaRetiro.Text = cot.fechaRetiro.ToString("dd/MM/yyyy");
            FechaEntrega.Text = cot.fechaEntrega.ToString("dd/MM/yyyy");
            importe.Text = cot.importe.ToString();

            foreach (var c in cot.transportista.metodosPago)
            {
                formaPago.Items.Add(c.descripcionPago);
            }

        }
    }
}
