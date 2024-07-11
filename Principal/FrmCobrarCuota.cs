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
        private bool nuevaCuota = false;
        public FrmCobrarCuota()
        {
            InitializeComponent();
        }
        public FrmCobrarCuota(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }
        public enum ModoOperacionEnum
        {
            Agregar,
            Modificar
        }
        public ModoOperacionEnum ModoOperacion { get; set; }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(ModoOperacion == ModoOperacionEnum.Agregar)
            {
                DialogResult resultado = MessageBox.Show("Si cancela la operacion, no se va a agregar correctamente el cliente, esta de acuerdo ?", "Pregunta", MessageBoxButtons.YesNo);
                if(resultado == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
            
        }

        private void FrmCobrarCuota_Load(object sender, EventArgs e)
        {
            try
            {

                CargarComboBox();
                CargarDatosCliente();
                if (ModoOperacion == ModoOperacionEnum.Modificar)
                {
                    cbxTipoMembresia.Text = cliente.TipoMembresia.Nombre;
                    //DialogResult resultado = MessageBox.Show("¿Va a cobrar una cuota nueva o el saldo pendiente?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    DialogResult resultado = CustomMessageBox.Show("¿Va a cobrar una cuota nueva o el saldo pendiente?", "Pregunta", "Cobrar Cuota Nueva", "Cobrar Saldo");

                    if (resultado == DialogResult.Yes)
                    {
                        nuevaCuota = true;
                        dtpFechaInicio.Value = cliente.fechaInicio.AddMonths(1);
                    }
                    else
                    {
                        if (cliente.Saldo < 0)
                        {
                            cbxTipoMembresia.Enabled = false;
                            txtMonto.Text = (cliente.Saldo * -1).ToString();
                            dtpFechaInicio.Value = cliente.fechaInicio;
                            dtpFechaInicio.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No hay un saldo pendiente");
                            this.Close();
                        }

                    }
                }
                else
                {
                    dtpFechaInicio.Value = cliente.fechaInicio;
                    btnCerrar.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error. Intente de nuevo mas tarde.", ex.ToString());
            }   
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
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error. Intente de nuevo mas tarde.", ex.ToString());
            }
        }

        private void CargarDatosCliente()
        {
            txtDni.Text = cliente.Dni.ToString();
            txtNombre.Text = cliente.Nombre;
            
            
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            ClienteDatos datos = new ClienteDatos();
            try
            {
                // Validar la fecha seleccionada u otros datos si es necesario
                if (ValidarDatos())
                {
                    MovimientosCaja movimiento = new MovimientosCaja();
                    if (ModoOperacion == ModoOperacionEnum.Agregar)
                    {
                        //le estoy cobrando por primera vez la cuota al cliente
                        //no lo puedo dejar salir sin asignarle un tipo de membresia al cliente
 
                        if(cbxTipoMembresia.SelectedIndex >= 0)
                        {
                            cliente.fechaInicio = dtpFechaInicio.Value;
                            int tipoMembresiaId = (int)cbxTipoMembresia.SelectedValue;
                            cliente.TipoMembresia = new Membresias();
                            cliente.TipoMembresia.Id = tipoMembresiaId;
                            decimal monto3 = decimal.Parse(txtMonto.Text);
                            MembresiasDatos Datos = new MembresiasDatos();
                            decimal precio = Datos.ObtenerPrecioMembresia(tipoMembresiaId);
                            decimal resto = monto3 - precio;
                            if (resto < 0)
                            {
                                //si resto es menor que cero signfica que el cliente queda debiendo
                                //como estamos agregando un cliente por primera vez no vamos a preguntar sobre el saldo, ya que el saldo va a ser cero
                                cliente.Saldo += resto; 
                            }
                            else if(resto > 0)
                            {
                                //si el resto es mayor que cero significa que el cliente queda a favor
                                cliente.Saldo += resto;
                            }
                            movimiento.Descripcion = "Registro de membresía de " + txtNombre.Text;
                            MessageBox.Show("Registro de membresia cobrada con éxito");
                        }
                        else
                        {
                            //no ha seleccionado un tipo de membresia
                            MessageBox.Show("Debe seleccionar un tipo de membresia");
                        }
                    }
                    else if(ModoOperacion == ModoOperacionEnum.Modificar)
                    {
                        //si es modificar significa que el cliente ya existe
                        //el cliente puede venir con un saldo
                        //hay que verificar si se va a cobrar una cuota nueva o se va a cobrar un saldo
                        if (nuevaCuota)
                        {
                            cliente.fechaInicio = dtpFechaInicio.Value;
                            int tipoMembresiaId = (int)cbxTipoMembresia.SelectedValue;
                            cliente.TipoMembresia = new Membresias();
                            cliente.TipoMembresia.Id = tipoMembresiaId;
                            decimal monto1 = decimal.Parse(txtMonto.Text);
                            MembresiasDatos Datos = new MembresiasDatos();
                            decimal precio = Datos.ObtenerPrecioMembresia(tipoMembresiaId);
                            decimal resto = monto1 - precio;
                            if (resto < 0)
                            {
                                //si resto es menor que cero signfica que el cliente queda debiendo
                                //como estamos cobrando una nueva cuota no nos molestamos en preguntar por el saldo del cliente
                                cliente.Saldo += resto;
                            }
                            else if (resto > 0)
                            {
                                //si el resto es mayor que cero significa que el cliente queda a favor
                                cliente.Saldo += resto;
                            }
                            movimiento.Descripcion = "Cuota de membresía de " + txtNombre.Text;
                            MessageBox.Show("Cuota cobrada con éxito");
                        }
                        else
                        {
                            //si me pone que no entonces vamos a cobrar un saldo pendiente
                            //primero que todo vamos a verificar que haya un saldo pendiente
                            if (cliente.Saldo < 0)
                            {
                                //hay saldo pendiente

                                decimal monto2 = decimal.Parse(txtMonto.Text);
                                decimal resto = cliente.Saldo + monto2;
                                if (resto < 0)
                                {
                                    //el cliente queda debiendo
                                    cliente.Saldo = resto;
                                }
                                else if (resto > 0)
                                {
                                    //el cliente queda a favor
                                    cliente.Saldo = resto;
                                }
                                else
                                {
                                    cliente.Saldo = resto;
                                }
                                movimiento.Descripcion = "Cobro de saldo de " + txtNombre.Text;
                                
                                MessageBox.Show("Saldo cobrado con éxito");
                            }
                        }
                    }
                    
                    
                    datos.ModificarClienteConSP(cliente, cliente.Dni);

                    //despues de cobrar la cuota

                    movimiento.Fecha = dtpFechaMovimientoCaja.Value;

                    decimal monto = decimal.Parse(txtMonto.Text);
                    movimiento.Monto = monto;

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
        public class CustomMessageBox
        {
            public static DialogResult Show(string text, string caption, string button1Text, string button2Text)
            {
                Form form = new Form();
                Label label = new Label();
                Button button1 = new Button();
                Button button2 = new Button();

                form.Text = caption;
                label.Text = text;
                button1.Text = button1Text;
                button2.Text = button2Text;

                button1.DialogResult = DialogResult.Yes;
                button2.DialogResult = DialogResult.No;

                label.SetBounds(9, 20, 372, 13);
                button1.SetBounds(12, 50, 180, 23); // Ajusta el ancho del botón 1
                button2.SetBounds(198, 50, 180, 23); // Ajusta el ancho del botón 2

                label.AutoSize = true;
                button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

                form.ClientSize = new System.Drawing.Size(396, 107);
                form.Controls.AddRange(new Control[] { label, button1, button2 });
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false; // Impide la maximización
                form.MinimizeBox = false; // Impide la minimización
                form.StartPosition = FormStartPosition.CenterScreen;
                form.AcceptButton = button1;
                form.CancelButton = button2;

                DialogResult dialogResult = form.ShowDialog();
                form.Dispose();
                return dialogResult;
            }
        }
    }
}
