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
            MetodosPagoDatos metodosPagoDatos = new MetodosPagoDatos();
            try
            {
                cbxTipoMembresia.DataSource = datos.listarMembresiasConSp();
                cbxTipoMembresia.ValueMember = "Id";
                cbxTipoMembresia.DisplayMember = "Nombre";
                cbxMetodoPago.DataSource = metodosPagoDatos.listarMetodosPagoConSp();
                cbxMetodoPago.ValueMember = "IdMetodoPago";
                cbxMetodoPago.DisplayMember = "NombreMetodoPago";
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
                    decimal monto = decimal.Parse(txtMonto.Text);
                    MembresiasDatos Datos = new MembresiasDatos();
                    decimal precio = Datos.ObtenerPrecioMembresia(cliente.TipoMembresia.Id);
                    cliente.Saldo = monto - precio;
                    int tipoMembresiaId = (int)cbxTipoMembresia.SelectedValue;
                    cliente.TipoMembresia = new Membresias();
                    cliente.TipoMembresia.Id = tipoMembresiaId;
                    datos.ModificarClienteConSP(cliente, cliente.Dni);
                    MessageBox.Show("Cuota cobrada con éxito");
                    //despues de cobrar la cuota
                    MovimientosCaja movimiento = new MovimientosCaja();
                    movimiento.Fecha = cliente.fechaInicio;
                    movimiento.Descripcion = "Cuota de membresía de " + txtNombre.Text;
                    movimiento.Monto = monto;
                    
                    
                    //if (precio > 0)
                    //{

                    movimiento.MetodoPago = new MetodosPago();
                    int metodoPagoId = (int)cbxMetodoPago.SelectedValue;
                    movimiento.MetodoPago.IdMetodoPago = metodoPagoId;
                    MovimientosCajaDatos movimientosCajaDatos = new MovimientosCajaDatos();
                    movimientosCajaDatos.AgregarMovimientoCaja(movimiento);
                    MessageBox.Show("Movimiento de caja registrado exitosamente");
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
            if (cbxTipoMembresia.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una membresia");
                return false;
            }
            if (cbxMetodoPago.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un medio de pago");
                return false;
            }
            if (string.IsNullOrEmpty(txtMonto.Text))
            {
                MessageBox.Show("Debe ingresar un monto");
                return false;
            }

            return true;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 9;
            // Verificar si la tecla presionada es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (txtDni.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // Si no es un número o retroceso, se ignora la tecla
            }
        }
    }
}
