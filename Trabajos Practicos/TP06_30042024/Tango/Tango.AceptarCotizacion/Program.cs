using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tango.AceptarCotizacion.Datos;
using Tango.AceptarCotizacion.Front;

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

            MetodoDePago alRetirar = new MetodoDePago() { idPago = 1, descripcionPago = "Al Retirar" };
            MetodoDePago contraEntrega = new MetodoDePago() { idPago = 1, descripcionPago = "Contra Entrega" };
            MetodoDePago tarjeta = new MetodoDePago() { idPago = 1, descripcionPago = "Tarjeta" };
            MetodoDePago debito = new MetodoDePago() { idPago = 1, descripcionPago = "Debito" };

            Transportista trans = new Transportista()
            {
                nombre = "Fran",
                apellido = "Gomez",
                mail = "santi00lp@gmail.com",
                clasificacion = (decimal) 3.1,
                metodosPago = new List<MetodoDePago> { alRetirar, contraEntrega, tarjeta, debito}
            };
            Transportista trans1 = new Transportista()
            {
                nombre = "Lionel",
                apellido = "Messi",
                mail = "abrilmarcomini@gmail.com",
                clasificacion = (decimal)5,
                metodosPago = new List<MetodoDePago> { alRetirar, contraEntrega, tarjeta, debito }
            };
            Transportista trans2 = new Transportista()
            {
                nombre = "Carlos",
                apellido = "Bala",
                mail = "mailejemplo@gmail.com",
                clasificacion = (decimal)4.3,
                metodosPago = new List<MetodoDePago> { alRetirar, contraEntrega, tarjeta, debito }
            };
            Transportista trans3 = new Transportista()
            {
                nombre = "Guillermo",
                apellido = "Franchela",
                mail = "mailejemplo@gmail.com",
                clasificacion = (decimal)4.5,
                metodosPago = new List<MetodoDePago> { alRetirar, contraEntrega, tarjeta, debito }
            };
            Transportista trans4 = new Transportista()
            {
                nombre = "Marcos",
                apellido = "Acuña",
                mail = "mailejemplo@gmail.com",
                clasificacion = (decimal)2.9,
                metodosPago = new List<MetodoDePago> { alRetirar, contraEntrega, tarjeta, debito }
            };

            Pedido ped = new Pedido()
            {
                idPedido = 1352,
                tipoDeCarga = "Paquete",
                fechaEntrega = new DateTime(2024, 5, 15),
                estado = 0
            };


            Cotizacion cot = new Cotizacion()
            {
                idCotizacion = 783,
                importe = 1530,
                fechaRetiro = new DateTime(2024, 5, 10),
                fechaEntrega = new DateTime(2024, 5, 15),
                transportista = trans,
                pedido = ped
            };
            Cotizacion cot1 = new Cotizacion()
            {
                idCotizacion = 790,
                importe = 1490,
                fechaRetiro = new DateTime(2024, 5, 14),
                fechaEntrega = new DateTime(2024, 5, 15),
                transportista = trans1,
                pedido = ped
            };
            Cotizacion cot2 = new Cotizacion()
            {
                idCotizacion = 792,
                importe = 1500,
                fechaRetiro = new DateTime(2024, 4, 12),
                fechaEntrega = new DateTime(2024, 5, 15),
                transportista = trans2,
                pedido = ped
            };
            Cotizacion cot3 = new Cotizacion()
            {
                idCotizacion = 793,
                importe = 1320,
                fechaRetiro = new DateTime(2024, 4, 15),
                fechaEntrega = new DateTime(2024, 5, 15),
                transportista = trans3,
                pedido = ped
            };
            Cotizacion cot4 = new Cotizacion()
            {
                idCotizacion = 801,
                importe = 1050,
                fechaRetiro = new DateTime(2024, 4, 15),
                fechaEntrega = new DateTime(2024, 5, 16),
                transportista = trans4,
                pedido = ped
            };

            List<Cotizacion> cotizacions = new List<Cotizacion>() { cot, cot1, cot2, cot3, cot4 };

            Application.Run(new PedidoCotizaciones(ped, cotizacions));

        }
    }
}
