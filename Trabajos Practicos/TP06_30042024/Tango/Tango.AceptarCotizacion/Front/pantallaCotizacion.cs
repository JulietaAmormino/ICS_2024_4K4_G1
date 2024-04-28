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
        private Cotizacion cotizacion;
        public pantallaCotizacion(Cotizacion cot)
        {
            InitializeComponent();
            CargarPantalla(cot);
            tbFechaVencimiento.Format = DateTimePickerFormat.Custom;
            tbFechaVencimiento.CustomFormat = "MM/yyyy";
            tbFechaVencimiento.ShowUpDown = false;
        }

        public void CargarPantalla(Cotizacion cot)
        {
            cotizacion = cot;

            lblTransNombre.Text = cot.transportista.nombre +  " " + cot.transportista.apellido;
            lblTransClasificacion.Text = cot.transportista.clasificacion.ToString();
            lblFechaRetiro.Text = cot.fechaRetiro.ToString("dd/MM/yyyy");
            lblFechaEntrega.Text = cot.fechaEntrega.ToString("dd/MM/yyyy");
            lblImporte.Text = cot.importe.ToString();

            /*foreach (var c in cot.transportista.metodosPago)
            {
                cbFormaPago.Items.Add(c.descripcionPago);
            }*/

            cbTipo.Items.Add("DNI");
            cbTipo.Items.Add("CUIL");
            cbTipo.Items.Add("CUIT");
            cbTipo.Items.Add("Pasaporte");
        }

        private void CambioFormaPago()
        {

        }

        /*private void cbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormaPago.Text == "Tarjeta" || cbFormaPago.Text == "Debito")
            {
                tbNumeroTarjeta.Enabled = true;
                tbPin.Enabled = true;
                tbNombre.Enabled = true;
                tbFechaVencimiento.Enabled = true;
                tbDocumento.Enabled = true;
                cbTipo.Enabled = true;
            }
            else if (cbFormaPago.Text == "")
            {
                tbNumeroTarjeta.Enabled = false;
                tbPin.Enabled = false;
                tbNombre.Enabled = false;
                tbFechaVencimiento.Enabled = false;
                tbDocumento.Enabled = false;
                cbTipo.Enabled = false;
            }
            else
            {
                tbNumeroTarjeta.Enabled = false;
                tbPin.Enabled = false;
                tbNombre.Enabled = false;
                tbFechaVencimiento.Enabled = false;
                tbDocumento.Enabled = false;
                cbTipo.Enabled = false;
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            lbMensaje.Text = "";

            /*if (String.IsNullOrEmpty(cbFormaPago.Text))
            {
                lbMensaje.Text = "Ingrese una forma de Pago";
            }
            else if (cbFormaPago.Text == "Tarjeta" || cbFormaPago.Text == "Debito")
            {
                if(String.IsNullOrEmpty(tbNumeroTarjeta.Text)
                    || String.IsNullOrEmpty(tbPin.Text)
                    || String.IsNullOrEmpty(tbFechaVencimiento.Text)
                    || String.IsNullOrEmpty(tbNombre.Text)
                    || String.IsNullOrEmpty(tbDocumento.Text)
                    || String.IsNullOrEmpty(cbTipo.Text))
                {
                    lbMensaje.Text = "Complete los datos de la tarjeta";
                }
                else if (tbNumeroTarjeta.Text.Length < 16 || tbNumeroTarjeta.Text.Length > 18)
                {
                    lbMensaje.Text = "Longitud del numero de tarjeta incorrecto.";
                }
                else if (tbPin.Text.Length != 3)
                {
                    lbMensaje.Text = "Numero de Pin Erroneo";
                }
                else if (tbPin.Text.Length != 3)
                {
                    lbMensaje.Text = "Numero de Pin Erroneo";
                }
                else if (String.IsNullOrEmpty(tbNombre.Text))
                {
                    lbMensaje.Text = "Ingrese el nombre del titular de la tarjeta";
                }
                else if (String.IsNullOrEmpty(tbDocumento.Text))
                {
                    lbMensaje.Text = "Ingrese un tipo de documento";
                }
                else if (String.IsNullOrEmpty(cbTipo.Text))
                {
                    lbMensaje.Text = "Ingrese un tipo de documento";
                }
                else if (!String.IsNullOrEmpty(cbTipo.Text))
                {
                    if(cbTipo.Text == "DNI" && tbDocumento.Text.Length != 8)
                        lbMensaje.Text = "Longitud del numero de documento incorrecto, los tipo DNI tienen 8 digitos";
                    else if ((cbTipo.Text == "CUIL" || cbTipo.Text == "CUIT") && tbDocumento.Text.Length != 10)
                        lbMensaje.Text = "Longitud del numero de documento incorrecto, los tipo CUIL/CUIT tienen 8 digitos";
                    else if (cbTipo.Text == "Pasaporte" && tbDocumento.Text.Length != 9)
                        lbMensaje.Text = "Longitud del numero de documento incorrecto, los tipo Pasaporte tienen 8 digitos";
                }
                else if ((int.Parse(tbNumeroTarjeta.Text) % 2) == 0)
                {
                    lbMensaje.Text = "Fondos insuficientes";
                }
                else if ((int.Parse(tbNumeroTarjeta.Text) % 3) == 0)
                {
                    lbMensaje.Text = "La tarjeta ingresada no fue encontrada";
                }
                else
                {
                    cotizacion.pedido.estado = 1;
                    btConfirmar.Enabled = false;
                    lbMensaje.Text = "Pago procesado, Pedido confirmado.";
                }
            }
            else
            {
                cotizacion.pedido.estado = 1;
                btConfirmar.Enabled = false;
                lbMensaje.Text = "Pedido confirmado";
            }*/
        }
    }
}
