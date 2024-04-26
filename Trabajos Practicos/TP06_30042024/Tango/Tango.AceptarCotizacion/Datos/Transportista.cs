using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tango.AceptarCotizacion.Datos
{
    public class Transportista
    {
        public string nombre {  get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public decimal clasificacion { get; set; }
        public List<MetodoDePago> metodosPago { get; set; }

    }
}
