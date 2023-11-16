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
using Dominio;
using Datos;

namespace Principal
{
    public partial class FrmDatosSocio : Form
    {
        private Cliente Cliente = null;
        private string rutaFoto = null;
        private string dniAmodificar = null;

        public FrmDatosSocio()
        {
            InitializeComponent();
        }
        public enum ModoOperacionEnum
        {
            VerCliente,
            Agregar,
            Modificar
        }
        public ModoOperacionEnum ModoOperacion { get; set; }
        public FrmDatosSocio(Cliente cliente)
        {
            InitializeComponent();
            this.Cliente = cliente;
        }

        private void btnCamara_Click(object sender, EventArgs e)
        {
            FrmCapturarImagen capturarImagen = new FrmCapturarImagen();

            capturarImagen.ShowDialog();

            // Verifica si se guardó una imagen y la carga en el PictureBox
            if (!string.IsNullOrEmpty(capturarImagen.RutaImagenGuardada))
            {
                rutaFoto = capturarImagen.RutaImagenGuardada;
                CargarImagen();
            }
        }


        private void CargarImagen()
        {
            if (!string.IsNullOrEmpty(rutaFoto))
            {
                pbxCliente.Image = Image.FromFile(rutaFoto);
                //pbxCliente.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbxCliente.Image = Image.FromFile(@"C:/Users/chuni/OneDrive/Escritorio/WoodAdicctionGym/Imagenes/placeholderPortrait.jpg");
            }
            //pbxCliente.Tag = pbxCliente.ImageLocation;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDatosSocio_Load(object sender, EventArgs e)
        {
            MembresiasDatos membresiasDatos = new MembresiasDatos();
            try
            {
                if (ModoOperacion == ModoOperacionEnum.VerCliente)
                {
                    lblTitulo.Text = "Datos del Socio";
                    txtNombre.ReadOnly = true;
                    txtApellido.ReadOnly = true;
                    txtDni.ReadOnly = true;
                    txtTelefono.ReadOnly = true;
                    dtpFechaNacimiento.Enabled = false;
                    dtpFechaInicio.Enabled = false;

                    btnGuardar.Visible = false;
                    btnCancelar.Visible = false;
                    //label9.Visible = false;
                    //txtMonto.Visible = false;
                    btnCamara.Visible = false;
                }
                else
                {
                    if (ModoOperacion == ModoOperacionEnum.Agregar)
                    {
                        lblTitulo.Text = "Agregar Socio";
                        lblEdad.Visible = false;
                        label1.Visible = false;
                        lblVencimiento.Visible = false;
                        lblEstado.Visible = false;

                        lblDebe.Visible = false;
                        label10.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                    }
                    if (ModoOperacion == ModoOperacionEnum.Modificar)
                    {
                        lblTitulo.Text = "Modificar Datos";

                        //label9.Visible = false;
                        //txtMonto.Visible = false;
                    }
                    txtNombre.ReadOnly = false;
                    txtApellido.ReadOnly = false;
                    txtDni.ReadOnly = false;
                    txtTelefono.ReadOnly = false;
                    dtpFechaNacimiento.Enabled = true;
                    dtpFechaInicio.Enabled = true;
                    btnCamara.Visible = true;

                }


                if (Cliente != null)
                {
                    txtNombre.Text = Cliente.Nombre;
                    txtApellido.Text = Cliente.Apellido;
                    txtDni.Text = Cliente.Dni.ToString();
                    if (Cliente.fechaNacimiento != null)
                    {
                        dtpFechaNacimiento.Text = Cliente.fechaNacimiento.Value.ToString("d");
                    }

                    txtTelefono.Text = Cliente.Telefono.ToString();
                    dtpFechaInicio.Text = Cliente.fechaInicio.ToString("d");


                    if (Cliente.Activo)
                    {
                        lblEstado.Text = "Activo";
                    }
                    else
                    {
                        lblEstado.Text = "Inactivo";
                    }
                    lblEdad.Text = Cliente.Edad.ToString();
                    DateTime fechaInicioMembresia = Cliente.fechaInicio;
                    int duracionMembresiaEnDias = Cliente.TipoMembresia.Duracion;

                    // Calcula la fecha de vencimiento en función de la duración de la membresía
                    DateTime fechaVencimientoMembresia = fechaInicioMembresia.AddDays(duracionMembresiaEnDias);
                    int diasRestantes;
                    // Verifica si la fecha de vencimiento ha pasado
                    if (fechaVencimientoMembresia < DateTime.Now)
                    {
                        // La membresía ya ha vencido, muestra un mensaje o establece los días restantes en 0
                        lblVencimiento.Text = "Vencido";
                        diasRestantes = 0;
                    }
                    else
                    {
                        TimeSpan tiempoRestante = fechaVencimientoMembresia - DateTime.Now;
                        diasRestantes = (int)tiempoRestante.TotalDays;
                        lblVencimiento.Text = diasRestantes.ToString() + " dias";
                    }

                    rutaFoto = Cliente.urlImagen;

                    if (File.Exists(rutaFoto))
                    {
                        pbxCliente.Load(rutaFoto);

                    }
                    else
                    {
                        pbxCliente.Load(@"C:/Users/chuni/OneDrive/Escritorio/WoodAdicctionGym/Imagenes/placeholderPortrait.jpg");
                    }
                    //pbxCliente.Tag = rutaFoto;
                    //pbxCliente.SizeMode = PictureBoxSizeMode.Zoom;
                    dniAmodificar = Cliente.Dni.ToString();
                    if (Cliente.Saldo > 0)
                    {
                        label10.Text = "A favor";
                        lblDebe.Text = "$" + Cliente.Saldo.ToString();
                    }
                    else
                    {
                        if (Cliente.Saldo < 0)
                        {
                            label10.Text = "Debe";
                            lblDebe.Text = "$" + (Cliente.Saldo * (-1)).ToString();
                        }
                        else
                        {
                            label10.Text = "No debe";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 9;
            // Verificar si la tecla presionada es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (txtDni.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // Si no es un número o retroceso, se ignora la tecla
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClienteDatos Datos = new ClienteDatos();
            MembresiasDatos membresiasDatos = new MembresiasDatos();
            if (Cliente == null)
                Cliente = new Cliente();
            try
            {
                if (ModoOperacion == ModoOperacionEnum.Agregar)
                {
                    if (ValidarCliente())
                        return;
                    CargarCliente(Cliente);

                    //decimal precio = membresiasDatos.ObtenerPrecioMembresia(Cliente.TipoMembresia.Id);
                    //Cliente.Saldo = precio * (-1);
                    Cliente.Saldo = 0;
                    FrmCobrarCuota cobrarCuota = new FrmCobrarCuota(Cliente);
                    cobrarCuota.ModoOperacion = FrmCobrarCuota.ModoOperacionEnum.Agregar;
                    cobrarCuota.ShowDialog();
                    if(Cliente.TipoMembresia != null)
                    {
                        Datos.AgregarClienteConSP(Cliente);
                        MessageBox.Show("Agregado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se agrego el cliente");
                    }

                }
                else if (ModoOperacion == ModoOperacionEnum.Modificar)
                {
                    if (ValidarCliente())
                        return;
                    CargarCliente(Cliente);
                    Datos.ModificarClienteConSP(Cliente, int.Parse(dniAmodificar));
                    MessageBox.Show("Modificado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCliente()
        {
            try
            {
                if (string.IsNullOrEmpty(txtDni.Text)
                    || string.IsNullOrEmpty(txtNombre.Text)
                    || string.IsNullOrEmpty(txtApellido.Text))
                {
                    MessageBox.Show("Debes completar todos los campos con * ");
                    return true; // Indica que la validación ha fallado
                }
                if (int.Parse(txtDni.Text) < 1000000 || int.Parse(txtDni.Text) > 999999999)
                {
                    MessageBox.Show("DNI no válido");
                    return true;
                }
                if (txtDni.Text != dniAmodificar || ModoOperacion == ModoOperacionEnum.Agregar)
                {
                    ClienteDatos datos = new ClienteDatos();
                    List<Cliente> listaClientes = datos.listarClientesConSP();
                    Cliente cliente = listaClientes.Find(x => x.Dni.ToString() == txtDni.Text);

                    if (cliente != null)
                    {
                        MessageBox.Show("El DNI ya está en uso por otro cliente.");
                        return true; // Indica que la validación ha fallado
                    }
                }
                if (dtpFechaInicio.Value < DateTime.Now.AddDays(-1))
                {
                    DialogResult result = MessageBox.Show("Estás intentando registrar un cliente en una fecha anterior a la de hoy. ¿Estás de acuerdo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                        return false;
                }



                return false; // Indica que la validación ha tenido éxito
            }
            catch (Exception ex)
            {
                // Manejar la excepción de manera adecuada, como mostrar un mensaje de error.
                MessageBox.Show("Error en la validación: " + ex.Message);
                return true; // Indica que la validación ha fallado debido a una excepción
            }
        }


        private void CargarCliente(Cliente cliente)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int dni = int.Parse(txtDni.Text);
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string telefono = txtTelefono.Text;
            DateTime fechaInicio = dtpFechaInicio.Value;
            cliente.Dni = dni;
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.fechaNacimiento = fechaNacimiento;
            cliente.Telefono = telefono;
            //string rutaDeFoto = pbxCliente.Tag as string;

            if (!string.IsNullOrEmpty(rutaFoto))
            {
                cliente.urlImagen = rutaFoto;
            }
            else
            {
                cliente.urlImagen = "C: /Users/chuni/OneDrive/Escritorio/WoodAdicctionGym/Imagenes/placeholderPortrait.jpg";
            }

            cliente.fechaInicio = fechaInicio;

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra, la tecla de retroceso o el espacio
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Si no es una letra, retroceso o espacio, se ignora la tecla
            }
        }

    }
}
