using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
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
        private Message mess = new Message();

        private string myEmail = "santiago0photography@gmail.com";
        private string MyPassword = "miyx wklc pcgu ltqd";
        private string MyAlias = "Tango";
        private MailMessage mCorreo;

        public pantallaCotizacion(Cotizacion cot)
        {
            InitializeComponent();
            CargarPantalla(cot);
        }

        public void CargarPantalla(Cotizacion cot)
        {
            cotizacion = cot;

            lblTransNombre.Text = cot.transportista.nombre + " " + cot.transportista.apellido;
            lblTransClasificacion.Text = cot.transportista.clasificacion.ToString();
            lblFechaRetiro.Text = cot.fechaRetiro.ToString("dd/MM/yyyy");
            lblFechaEntrega.Text = cot.fechaEntrega.ToString("dd/MM/yyyy");
            lblImporte.Text = cot.importe.ToString();


            cbTipo.Items.Add("DNI");
            cbTipo.Items.Add("CUIL");
            cbTipo.Items.Add("CUIT");
            cbTipo.Items.Add("Pasaporte");
        }

        private void CambioFormaPago()
        {

        }

        private void cbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbTarjeta.Checked)
            {
                tbNumeroTarjeta.Enabled = true;
                tbPin.Enabled = true;
                tbNombre.Enabled = true;
                tbFechaVencimiento.Enabled = true;
                tbDocumento.Enabled = true;
                cbTipo.Enabled = true;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbMensaje.Text = "";

            if (rbTarjeta.Checked)
            {
                if (String.IsNullOrEmpty(tbNumeroTarjeta.Text)
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
                    if (cbTipo.Text == "DNI" && tbDocumento.Text.Length != 8)
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
                    var txtSubject = "Cotizacion " + cotizacion.idCotizacion.ToString() + " Confrimada.";

                    var txtMessage = "Tu corizacion " + cotizacion.idCotizacion.ToString() + " del pedido " + cotizacion.pedido.idPedido.ToString()
                                    + " a ser retirado el dia " + cotizacion.fechaRetiro + " y entregado el " + cotizacion.fechaEntrega + ". \n"
                                    + "El pago ya fue efectuado mediante Tarjeta.";

                    cotizacion.pedido.estado = 1;
                    btConfirmar.Enabled = false;
                    lbMensaje.Text = "Pago procesado, Pedido confirmado.";
                }
            }
            else
            {
                var txtSubject = "Cotizacion " + cotizacion.idCotizacion.ToString() + " Confrimada.";

                var txtMessage = "Tu corizacion " + cotizacion.idCotizacion.ToString() + " del pedido " + cotizacion.pedido.idPedido.ToString()
                + " a ser retirado el dia " + cotizacion.fechaRetiro.ToString("dd/MM/yyyy") + " y entregado el " + cotizacion.fechaEntrega.ToString("dd/MM/yyyy") + ". \n";

                if (rbContadoRetirar.Checked)
                    txtMessage = txtMessage + "El pago sera efectuado al retirar el pedido.";
                else
                    txtMessage = txtMessage + "El pago sera efectuado contra entrega.";

                EnviarMail(txtSubject, txtMessage);

                cotizacion.pedido.estado = 1;
                btConfirmar.Enabled = false;
                MessageBox.Show("Pedido confirmado");
                this.Close();
            }
        }

        private void EnviarMail(string txtSubject, string txtMessage)
        {
            mCorreo = new MailMessage();
            mCorreo.From = new MailAddress(myEmail, MyAlias, System.Text.Encoding.UTF8);
            mCorreo.To.Add(cotizacion.transportista.mail.Trim());
            mCorreo.Subject = txtSubject.Trim();
            mCorreo.Body = txtMessage.Trim();
            mCorreo.IsBodyHtml = true;
            mCorreo.Priority = MailPriority.High;

            Enviar();
        }

        private void Enviar()
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Port = 25;
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential(myEmail, MyPassword);
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) { return true; };
                smtp.EnableSsl = true;
                smtp.Send(mCorreo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}