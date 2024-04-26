using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tango.AceptarCotizacion.Datos
{
    public class Cotizacion
    {
        public int idCotizacion {  get; set; }
        public Pedido pedido { get; set; }
        public decimal importe {  get; set; }
        public DateTime fechaRetiro { get; set; }
        public DateTime fechaEntrega { get; set; }
        public Transportista transportista { get; set; }

    }
}
