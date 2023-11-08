using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Principal
{
    public partial class FrmCobrarCuota : Form
    {
        private Cliente cliente = null;
        public FrmCobrarCuota()
        {
            InitializeComponent();
        }
        public FrmCobrarCuota(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCobrarCuota_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            CargarDatosCliente();
        }

        private void CargarComboBox()
        {
            MembresiasDatos datos = new MembresiasDatos();
            try
            {
                cbxTipoMembresia.DataSource = datos.listarMembresiasConSp();
                cbxTipoMembresia.ValueMember = "Id";
                cbxTipoMembresia.DisplayMember = "Nombre";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarDatosCliente()
        {
            txtDni.Text = cliente.Dni.ToString();
            txtNombre.Text = cliente.Nombre;
            cbxTipoMembresia.Text = cliente.TipoMembresia.Nombre;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            ClienteDatos datos = new ClienteDatos();
            try
            {
                // Validar la fecha seleccionada u otros datos si es necesario
                if (ValidarDatos())
                {
                    cliente.fechaInicio = dtpFechaInicio.Value;
                    int tipoMembresiaId = (int)cbxTipoMembresia.SelectedValue;
                    cliente.TipoMembresia = new Membresias();
                    cliente.TipoMembresia.Id = tipoMembresiaId;
                    //cliente.TipoMembresia = cbxTipoMembresia.SelectedItem;
                    datos.ModificarClienteConSP(cliente, cliente.Dni);
                    MessageBox.Show("Cuota cobrada con éxito");
                    //despues de cobrar la cuota
                    MovimientosCaja movimiento = new MovimientosCaja();
                    movimiento.Fecha = cliente.fechaInicio;
                    movimiento.Descripcion = "Cuota de membresía de " + txtNombre.Text;
                    MembresiasDatos Datos = new MembresiasDatos();
                    decimal precio = Datos.ObtenerPrecioMembresia(cliente.TipoMembresia.Id);
                    if (precio > 0)
                    {
                        movimiento.Monto = precio;
                        movimiento.MetodoPago = new MetodosPago();
                        movimiento.MetodoPago.IdMetodoPago = 1;
                        MovimientosCajaDatos movimientosCajaDatos = new MovimientosCajaDatos();
                        movimientosCajaDatos.AgregarMovimientoCaja(movimiento);
                        MessageBox.Show("Movimiento de caja registrado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener automáticamente el precio de la membresía. Registra el movimiento de caja manualmente.");
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: registrar el error, mostrar un mensaje al usuario o realizar otras acciones necesarias
                MessageBox.Show("Error al cobrar la cuota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarDatos()
        {
            // Realiza la validación de datos aquí
            // Puedes verificar que la fecha sea válida y cumpla con las reglas de negocio
            // Si los datos son válidos, devuelve true; de lo contrario, devuelve false

            // Ejemplo de validación simple de la fecha
            if (dtpFechaInicio.Value < DateTime.Now.AddDays(-1))
            {
                MessageBox.Show("La fecha de inicio no puede ser anterior a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
