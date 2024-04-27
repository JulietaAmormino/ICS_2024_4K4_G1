 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tango.AceptarCotizacion.Datos
{
    public class Pedido
    {
        public int idPedido {  get; set; }
        public string tipoDeCarga { get; set; }
        public string domRetiro { get; set; }
        public string domEntrega { get; set; }
        public DateTime fechaRetiro { get; set; }
        public DateTime fechaEntrega { get; set; }
        public int estado {  get; set; }
    }
}
