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
                mail = "santiago_00lp@hotmail.com",
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
                nombre = "Mickaela",
                apellido = "Crespo",
                mail = "mickaelacrespo@gmail.com",
                clasificacion = (decimal)4.3,
                metodosPago = new List<MetodoDePago> { alRetirar, contraEntrega, tarjeta, debito }
            };
            Transportista trans3 = new Transportista()
            {
                nombre = "Georgina",
                apellido = "González",
                mail = "gg.georginagonzalez@gmail.com",
                clasificacion = (decimal)4.5,
                metodosPago = new List<MetodoDePago> { alRetirar, contraEntrega, tarjeta, debito }
            };
            Transportista trans4 = new Transportista()
            {
                nombre = "Constanza",
                apellido = "Garnero",
                mail = "constanzagarnero@gmail.com",
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

            Pedido ped1 = new Pedido()
            {
                idPedido = 1355,
                tipoDeCarga = "Paquete",
                fechaEntrega = new DateTime(2024, 5, 15),
                estado = 0
            };

            Pedido ped2 = new Pedido()
            {
                idPedido = 1262,
                tipoDeCarga = "Paquete",
                fechaEntrega = new DateTime(2024, 5, 15),
                estado = 0
            };

            Pedido ped3 = new Pedido()
            {
                idPedido = 1652,
                tipoDeCarga = "Paquete",
                fechaEntrega = new DateTime(2024, 5, 15),
                estado = 0
            };

            Cotizacion cotizacion1 = new Cotizacion()
            {
                idCotizacion = 710,
                importe = 2578,
                fechaRetiro = new DateTime(2024, 5, 30),
                fechaEntrega = new DateTime(2024, 5, 31),
                transportista = trans,
                pedido = ped1
            };
            Cotizacion cotizacion2 = new Cotizacion()
            {
                idCotizacion = 875,
                importe = 10256,
                fechaRetiro = new DateTime(2024, 5, 1),
                fechaEntrega = new DateTime(2024, 5, 20),
                transportista = trans,
                pedido = ped2
            };
            Cotizacion cotizacion3 = new Cotizacion()
            {
                idCotizacion = 766,
                importe = 1420,
                fechaRetiro = new DateTime(2024, 5, 7),
                fechaEntrega = new DateTime(2024, 5, 18),
                transportista = trans,
                pedido = ped3
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
                fechaRetiro = new DateTime(2024, 5, 12),
                fechaEntrega = new DateTime(2024, 5, 15),
                transportista = trans2,
                pedido = ped
            };
            Cotizacion cot3 = new Cotizacion()
            {
                idCotizacion = 793,
                importe = 1320,
                fechaRetiro = new DateTime(2024, 5, 15),
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

            List<Cotizacion> cotizacions1 = new List<Cotizacion>() { cot, cotizacion1, cotizacion2, cotizacion3};

            var pantalla = new PedidoCotizaciones(ped, cotizacions);

            new PantallaTransportista(cotizacions1, pantalla).Show();
            Application.Run(pantalla);
            //new PedidoCotizaciones(ped, cotizacions).Show();


        }
    }
}
