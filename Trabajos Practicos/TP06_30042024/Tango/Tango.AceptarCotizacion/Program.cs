using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tango.AceptarCotizacion.Datos;

namespace Tango.AceptarCotizacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MetodoDePago efectivo = new MetodoDePago() { idPago = 1, descripcionPago = "Efectivo"};
            MetodoDePago contraEntrega = new MetodoDePago() { idPago = 1, descripcionPago = "Contra Entrega" };
            MetodoDePago tarjeta = new MetodoDePago() { idPago = 1, descripcionPago = "Tarjeta" };
            MetodoDePago debito = new MetodoDePago() { idPago = 1, descripcionPago = "Debito" };

            Transportista trans = new Transportista()
            {
                nombre = "Fran",
                apellido = "Gomez",
                mail = "mailejemplo@gmail.com",
                clasificacion = (decimal) 4.5,
                metodosPago = new List<MetodoDePago> { efectivo, contraEntrega, tarjeta, debito}
            };

            Pedido ped = new Pedido()
            {
                idPedido = 1,
                estado = 1
            };

            Cotizacion cot = new Cotizacion()
            {
                idCotizacion = 14550,
                importe = 1560,
                fechaRetiro = new DateTime(2024, 4, 30),
                fechaEntrega = new DateTime(2024, 5, 2),
                transportista = trans,
                pedido = ped

            };

            Application.Run(new pantallaCotizacion(cot));



        }
    }
}
