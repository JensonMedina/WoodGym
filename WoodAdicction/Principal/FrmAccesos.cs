using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Dominio;
using System.Media;
using System.Windows.Media;

namespace Principal
{
    public partial class FrmAccesos : Form
    {
        public FrmAccesos()
        {
            InitializeComponent();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 10;

            // Verificar si la tecla presionada es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (txtDni.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // Si no es un número o retroceso, se ignora la tecla
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                // Aquí coloca el código que deseas ejecutar al presionar Enter en el TextBox.
                e.Handled = true;  // Esto evita que se emita el sonido de "beep" al presionar Enter.
                if (ValidarDni())
                    return;
                AccesosDiariosDatos Datos = new AccesosDiariosDatos();
                ClienteDatos clienteDatos = new ClienteDatos();

                try
                {
                    int dni = int.Parse(txtDni.Text);
                    Datos.AgregarIngreso(dni);
                    Cliente cliente = new Cliente();
                    cliente = clienteDatos.BuscarCliente(dni);
                    CargarCampos(cliente);
                }
                catch (Exception)
                {

                    return;
                }
            }
            
            
        }

        private void CargarCampos(Cliente cliente)
        {
            string rutaImagen = cliente.urlImagen;
            if (File.Exists(rutaImagen))
            {
                pbxImagenCliente.Load(rutaImagen);
            }
            else
            {
                pbxImagenCliente.Load(@"C:/Users/chuni/OneDrive/Escritorio/WoodAdicctionGym/Imagenes/placeholderPortrait.jpg");
            }
            lblNombre.Text = cliente.Nombre + " " + cliente.Apellido;
            lblNroSocio.Text = cliente.NroSocio.ToString();

            DateTime fechaInicioMembresia = cliente.fechaInicio;
            int duracionMembresiaEnDias = cliente.TipoMembresia.Duracion;

            // Calculo la fecha de vencimiento en función de la duración de la membresía
            DateTime fechaVencimientoMembresia = fechaInicioMembresia.AddDays(duracionMembresiaEnDias);
            // Verifica si la fecha de vencimiento ha pasado
            if (fechaVencimientoMembresia < DateTime.Now)
            {
                // La membresía ya ha vencido, muestra un mensaje o establece los días restantes en 0
                lblEstado.Text = "Acceso Denegado";
                EmitirSonidoDeBeep();
            }
            else
            {
                lblEstado.Text = "Acceso Permitido";
            }
            lblDebe.Visible = true;
            if (cliente.Saldo < 0)
            {
                label5.Text = "Debe";
                lblDebe.Text = "$" + cliente.Saldo.ToString();
                lblDebe.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (cliente.Saldo > 0)
                {
                    label5.Text = "A favor";
                    lblDebe.Text = "$" + cliente.Saldo.ToString();
                    lblDebe.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    label5.Text = "No debe";
                    lblDebe.Visible = false;
                }
            }

            lblVencimiento.Text = fechaVencimientoMembresia.ToString("dd/MM/yyyy");
            panel1.Visible = true;
            txtDni.Text = "";
        }

        private bool ValidarDni()
        {
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                return true;
            }

            if (!int.TryParse(txtDni.Text, out int dni))
            {
                return true; // No es un número válido
            }

            if (dni < 1000000 || dni > 999999999)
            {
                return true; // DNI fuera de rango
            }

            return false;
        }
        private void EmitirSonidoDeBeep()
        {
            SystemSounds.Beep.Play();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
