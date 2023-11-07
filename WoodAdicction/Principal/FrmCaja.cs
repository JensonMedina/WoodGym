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
using Dominio;

namespace Principal
{
    public partial class FrmCaja : Form
    {
        private List<MovimientosCaja> listaMovimientosCaja;
        public MovimientosCaja movimientosCaja = null;
        public FrmCaja()
        {
            InitializeComponent();
        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            try
            {
                cbxMetodoPagoFiltrar.SelectedIndex = -1;
                CargarGrilla();
                CargarComboBox();
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void LimpiarComboBox()
        {
            cbxMetodoPago.Items.Clear();
            cbxMetodoPagoFiltrar.Items.Clear();
            cbxTipoMovimiento.Items.Clear();
            cbxTipoMovimientoFiltrar.Items.Clear();
        }
        private void CargarComboBox()
        {
            MetodosPagoDatos datosMetodosPago = new MetodosPagoDatos();
            try
            {
                LimpiarComboBox();
                cbxMetodoPago.DataSource = datosMetodosPago.listarMetodosPagoConSp();
                cbxMetodoPago.ValueMember = "IdMetodoPago";
                cbxMetodoPago.DisplayMember = "NombreMetodoPago";

                cbxMetodoPagoFiltrar.DataSource = datosMetodosPago.listarMetodosPagoConSp();
                cbxMetodoPagoFiltrar.ValueMember = "IdMetodoPago";
                cbxMetodoPagoFiltrar.DisplayMember = "NombreMetodoPago";

                cbxTipoMovimiento.Items.Add("Ingreso");
                cbxTipoMovimiento.Items.Add("Gasto");

                cbxTipoMovimientoFiltrar.Items.Add("Ingreso");
                cbxTipoMovimientoFiltrar.Items.Add("Gasto");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        private void CargarGrilla()
        {
            MovimientosCajaDatos datosMovimientosCaja = new MovimientosCajaDatos();
            try
            {
                listaMovimientosCaja = datosMovimientosCaja.listarMovimientosConSp();
                dgvMovimientos.DataSource = listaMovimientosCaja;
                dgvMovimientos.Columns["TransaccionId"].Visible = false;
                dgvMovimientos.Columns["MetodoPago"].HeaderText = "Metodo de pago";
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidacionAgregarNuevoMovimiento())
            {
                MovimientosCajaDatos Datos = new MovimientosCajaDatos();
                if (movimientosCaja == null)
                    movimientosCaja = new MovimientosCaja();
                try
                {
                    CargarNuevoMovimiento(movimientosCaja);
                    Datos.AgregarMovimientoCaja(movimientosCaja);
                    MessageBox.Show("Agregado exitosamente");
                    CargarGrilla();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Todos los campos con * son obligatorios");
            }
            
        }

        private void CargarNuevoMovimiento(MovimientosCaja movimientosCaja)
        {
            DateTime fecha = dtpFecha.Value;
            int tipoMovimiento = cbxTipoMovimiento.SelectedIndex;
            string descripcion = txtDescripcion.Text;
            decimal monto = decimal.Parse(txtMonto.Text);
            int metodoPago = cbxMetodoPago.SelectedIndex + 1;
            //0 ingreso
            //1 gasto
            if (tipoMovimiento == 1)
            {
                monto *= (-1);
            }
            movimientosCaja.Fecha = fecha;
            movimientosCaja.Descripcion = descripcion;
            movimientosCaja.Monto = monto;
            movimientosCaja.MetodoPago = new MetodosPago();
            movimientosCaja.MetodoPago.IdMetodoPago = metodoPago;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            txtDescripcion.Text = "";
            txtMonto.Text = "";
            cbxMetodoPago.SelectedIndex = -1;
            cbxTipoMovimiento.SelectedIndex = -1;
        }

        private void dgvMovimientos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvMovimientos.Columns["Monto"].Index && e.RowIndex >= 0)
            {
                // Obtén el valor de la celda en la columna "Monto"
                if (dgvMovimientos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    decimal monto = Convert.ToDecimal(dgvMovimientos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                    // Cambia el color de fondo en función del valor
                    if (monto > 0)
                    {
                        e.CellStyle.BackColor = Color.FromArgb(84, 180, 53);
                    }
                    else if (monto < 0)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        //cuando cambie el valor del dtp entonces voy a invocar al metodo para filtrar
        private void dtpBuscar_ValueChanged(object sender, EventArgs e)
        {
            invocarElMetodoFiltrar();
        }
        private void dgvMovimientos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Manejar el error de formato aquí o simplemente suprimirlo si no es crítico.
            e.Cancel = true;
        }
        private bool ValidacionAgregarNuevoMovimiento()
        {
            return cbxTipoMovimiento.SelectedIndex >= 0 &&
                   cbxMetodoPago.SelectedIndex >= 0 &&
                   !string.IsNullOrWhiteSpace(txtDescripcion.Text) &&
                   !string.IsNullOrWhiteSpace(txtMonto.Text);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 12;
            // Verificar si la tecla presionada es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (txtMonto.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // Si no es un número o retroceso, se ignora la tecla
            }
        }
        private void invocarElMetodoFiltrar()
        {
            MovimientosCajaDatos datosMovimientosCaja = new MovimientosCajaDatos();
            try
            {
                DateTime fecha = dtpBuscar.Value;
                int idMetodoPago = 1;
                //tipoMovimiento 0 ingreso
                //1 gasto
                int tipoMovimiento = cbxTipoMovimientoFiltrar.SelectedIndex;
                listaMovimientosCaja = datosMovimientosCaja.Filtrar(fecha, idMetodoPago);
                if (tipoMovimiento == 0)
                {
                    // Filtra y muestra los valores positivos en la columna "Monto".
                    dgvMovimientos.DataSource = listaMovimientosCaja.Where(mc => mc.Monto >= 0).ToList();
                }
                else if (tipoMovimiento == 1)
                {
                    // Filtra y muestra los valores negativos en la columna "Monto".
                    dgvMovimientos.DataSource = listaMovimientosCaja.Where(mc => mc.Monto < 0).ToList();
                }
                else
                {
                    listaMovimientosCaja = datosMovimientosCaja.Filtrar(fecha, idMetodoPago);
                    dgvMovimientos.DataSource = listaMovimientosCaja;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cbxTipoMovimientoFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            invocarElMetodoFiltrar();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Antes de reiniciar, desasocia el controlador de eventos del DatePicker.
            dtpBuscar.ValueChanged -= dtpBuscar_ValueChanged;
            cbxTipoMovimientoFiltrar.SelectedIndexChanged -= cbxTipoMovimientoFiltrar_SelectedIndexChanged;

            // Realiza el proceso de reinicio
            CargarGrilla();
            dtpBuscar.Value = DateTime.Now;
            cbxTipoMovimientoFiltrar.SelectedIndex = -1;
            cbxMetodoPagoFiltrar.SelectedIndex = -1;

            // Vuelve a asociar el controlador de eventos después de reiniciar.
            dtpBuscar.ValueChanged += dtpBuscar_ValueChanged;
            cbxTipoMovimientoFiltrar.SelectedIndexChanged += cbxTipoMovimientoFiltrar_SelectedIndexChanged;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
