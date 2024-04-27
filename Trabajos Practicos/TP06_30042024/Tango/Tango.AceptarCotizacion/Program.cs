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
                mail = "mailejemplo@gmail.com",
                clasificacion = (decimal) 4.5,
                metodosPago = new List<MetodoDePago> { alRetirar, contraEntrega, tarjeta, debito}
            };

            Pedido ped = new Pedido()
            {
                idPedido = 1,
                tipoDeCarga = "Paquete",
                fechaEntrega = new DateTime(2024, 05, 15),
                estado = 1
            };


            Cotizacion cot = new Cotizacion()
            {
                idCotizacion = 14550,
                importe = 13460,
                fechaRetiro = new DateTime(2024, 4, 30),
                fechaEntrega = new DateTime(2024, 5, 2),
                transportista = trans,
                pedido = ped
            };
            Cotizacion cot1 = new Cotizacion()
            {
                idCotizacion = 1500,
                importe = 11260,
                fechaRetiro = new DateTime(2024, 4, 30),
                fechaEntrega = new DateTime(2024, 5, 2),
                transportista = trans,
                pedido = ped
            };
            Cotizacion cot2 = new Cotizacion()
            {
                idCotizacion = 13250,
                importe = 1560,
                fechaRetiro = new DateTime(2024, 4, 30),
                fechaEntrega = new DateTime(2024, 5, 2),
                transportista = trans,
                pedido = ped
            };
            Cotizacion cot3 = new Cotizacion()
            {
                idCotizacion = 16210,
                importe = 15460,
                fechaRetiro = new DateTime(2024, 4, 30),
                fechaEntrega = new DateTime(2024, 5, 2),
                transportista = trans,
                pedido = ped
            };
            Cotizacion cot4 = new Cotizacion()
            {
                idCotizacion = 14200,
                importe = 15230,
                fechaRetiro = new DateTime(2024, 4, 30),
                fechaEntrega = new DateTime(2024, 5, 2),
                transportista = trans,
                pedido = ped
            };

            List<Cotizacion> cotizacions = new List<Cotizacion>() { cot, cot1, cot2, cot3, cot4 };

            Application.Run(new PedidoCotizaciones(ped, cotizacions));

        }
    }
}
