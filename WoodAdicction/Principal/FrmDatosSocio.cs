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
                cbxTipoMembresia.DataSource = membresiasDatos.listarMembresiasConSp();
                cbxTipoMembresia.ValueMember = "id";
                cbxTipoMembresia.DisplayMember = "tipo";
                if (ModoOperacion == ModoOperacionEnum.VerCliente)
                {
                    lblTitulo.Text = "Datos del Socio";
                    txtNombre.ReadOnly = true;
                    txtApellido.ReadOnly = true;
                    txtDni.ReadOnly = true;
                    txtTelefono.ReadOnly = true;
                    dtpFechaNacimiento.Enabled = false;
                    dtpFechaInicio.Enabled = false;
                    cbxTipoMembresia.Enabled = false;
                }
                else
                {
                    txtNombre.ReadOnly = false;
                    txtApellido.ReadOnly = false;
                    txtDni.ReadOnly = false;
                    txtTelefono.ReadOnly = false;
                    dtpFechaNacimiento.Enabled = true;
                    dtpFechaInicio.Enabled = true;
                    cbxTipoMembresia.Enabled = true;
                    if (ModoOperacion == ModoOperacionEnum.Agregar)
                    {
                        lblTitulo.Text = "Agregar Socio";
                    }
                    if (ModoOperacion == ModoOperacionEnum.Modificar)
                    {
                        lblTitulo.Text = "Modificar Datos";
                    }
                }


                if (Cliente != null)
                {
                    txtNombre.Text = Cliente.nombre;
                    txtApellido.Text = Cliente.apellido;
                    txtDni.Text = Cliente.dni.ToString();
                    dtpFechaNacimiento.Text = Cliente.fechaNacimiento.ToString("d");
                    txtTelefono.Text = Cliente.telefono.ToString();
                    dtpFechaInicio.Text = Cliente.fechaInicio.ToString("d");
                    cbxTipoMembresia.Text = Cliente.tipo.tipo;
                    string rutaImagen = Cliente.urlImagen;

                    if (File.Exists(rutaImagen))
                    {
                        pbxCliente.Load(rutaImagen);
                    }
                    else
                    {
                        pbxCliente.Load("C:/Users/chuni/OneDrive/Escritorio/WoodAdicctionGym/Imagenes/placeholderPortrait.jpg");
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
            int maxLength = 10;
            // Verificar si la tecla presionada es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (txtDni.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // Si no es un número o retroceso, se ignora la tecla
            }
            //if (txtDni.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            //{
            //    e.Handled = true; // Bloquear la entrada adicional si se alcanza el límite
            //}
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClienteDatos Datos = new ClienteDatos();
            if (Cliente == null)
                Cliente = new Cliente();
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int dni = int.Parse(txtDni.Text);
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string telefono = txtTelefono.Text;
            DateTime fechaInicio = dtpFechaInicio.Value;
            int idTipoMembresia = cbxTipoMembresia.SelectedIndex + 1;
            Cliente.dni = dni;
            Cliente.nombre = nombre;
            Cliente.apellido = apellido;
            Cliente.fechaNacimiento = fechaNacimiento;
            Cliente.telefono = telefono;
            Cliente.fechaInicio = fechaInicio;
            Cliente.tipo = new Membresias();
            Cliente.tipo.id = idTipoMembresia;
            Cliente.urlImagen = "C:/Users/chuni/OneDrive/Escritorio/WoodAdicctionGym/Imagenes/placeholderPortrait.jpg";
            try
            {
                Datos.AgregarClienteConSP(Cliente);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
