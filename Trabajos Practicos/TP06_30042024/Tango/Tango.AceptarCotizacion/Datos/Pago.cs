using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tango.AceptarCotizacion.Datos
{
    public class Pago
    {
        public int idPago {  get; set; }
        public MetodoDePago metodoDePago { get; set;}
        public int estado {  get; set; }

    }
}
