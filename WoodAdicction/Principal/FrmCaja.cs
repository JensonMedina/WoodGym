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
                // Desasociar los controladores de eventos
                dtpBuscar.ValueChanged -= dtpBuscar_ValueChanged;
                cbxTipoMovimientoFiltrar.SelectedIndexChanged -= cbxTipoMovimientoFiltrar_SelectedIndexChanged;
                cbxMetodoPagoFiltrar.SelectedIndexChanged -= cbxMetodoPagoFiltrar_SelectedIndexChanged;

                CargarGrilla();
                CargarComboBox();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                // Volver a asociar los controladores de eventos después de la carga inicial
                dtpBuscar.ValueChanged += dtpBuscar_ValueChanged;
                cbxTipoMovimientoFiltrar.SelectedIndexChanged += cbxTipoMovimientoFiltrar_SelectedIndexChanged;
                cbxMetodoPagoFiltrar.SelectedIndexChanged += cbxMetodoPagoFiltrar_SelectedIndexChanged;
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
                cbxMetodoPago.SelectedIndex = -1;


                cbxMetodoPagoFiltrar.DataSource = datosMetodosPago.listarMetodosPagoConSp();
                cbxMetodoPagoFiltrar.ValueMember = "IdMetodoPago";
                cbxMetodoPagoFiltrar.DisplayMember = "NombreMetodoPago";
                cbxMetodoPagoFiltrar.SelectedIndex = -1;

                cbxTipoMovimiento.Items.Add("Ingreso");
                cbxTipoMovimiento.Items.Add("Gasto");


                cbxTipoMovimientoFiltrar.Items.Add("Ingreso");
                cbxTipoMovimientoFiltrar.Items.Add("Gasto");
                cbxTipoMovimientoFiltrar.SelectedIndex = -1;
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
                catch (Exception ex)
                {

                    throw ex;
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
            int metodoPagoId = (int)cbxMetodoPago.SelectedValue;
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
            movimientosCaja.MetodoPago.IdMetodoPago = metodoPagoId;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            txtDescripcion.Text = "";
            txtMonto.Text = "";
            cbxMetodoPago.SelectedIndex = -1;
            cbxTipoMovimiento.SelectedIndex = -1;
            cbxMetodoPagoFiltrar.SelectedIndex = -1;
            cbxTipoMovimientoFiltrar.SelectedIndex = -1;
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
                int tipoMovimiento = cbxTipoMovimientoFiltrar.SelectedIndex;
                int idMetodoPago = cbxMetodoPagoFiltrar.SelectedIndex;
                if(tipoMovimiento < 0 && idMetodoPago == -1)
                {
                    listaMovimientosCaja = datosMovimientosCaja.Filtrar(fecha, -1);
                    dgvMovimientos.DataSource = listaMovimientosCaja;
                }
                //en tipo de movimiento: 0 es ingreso y 1 es gasto.
                //si tipo de movimiento es cero significa que estamos frente a un ingreso y
                //si ademas el metodo de pago es -1 significa que no se ha seleccionado un metodo de pago
                //por lo que invocamos al metodo filtrando por tipo de movimiento y trayendo los dos metodos de pago
                if (tipoMovimiento == 0 && idMetodoPago == -1)
                {
                    //como tipo de movimiento es ingreso entonces cargo la grilla con los montos mayores a cero que son los que representan ingresos
                    listaMovimientosCaja = datosMovimientosCaja.Filtrar(fecha, -1);
                    dgvMovimientos.DataSource = listaMovimientosCaja.Where(mc => mc.Monto >= 0).ToList();

                }
                else if (tipoMovimiento == 1 && idMetodoPago == -1)
                {
                    //como tipo de movimiento es gasto entonces cargo la grilla con los montos menores a cero que son los que representan los gastos
                    listaMovimientosCaja = datosMovimientosCaja.Filtrar(fecha, -1);
                    dgvMovimientos.DataSource = listaMovimientosCaja.Where(mc => mc.Monto < 0).ToList();
                }
                //si el tipo de movimiento es -1 significa que no se ha seleccionado un tipo de movimiento
                // y ademas si el metodo de pago es 0 significa que se ha seleccionado el metodo de pago "efectivo"
                if (tipoMovimiento == -1 && idMetodoPago == 0)
                {
                    listaMovimientosCaja = datosMovimientosCaja.Filtrar(fecha, 1);
                    dgvMovimientos.DataSource = listaMovimientosCaja;
                }
                else if (tipoMovimiento == -1 && idMetodoPago == 1)
                {
                    listaMovimientosCaja = datosMovimientosCaja.Filtrar(fecha, 2);
                    dgvMovimientos.DataSource = listaMovimientosCaja;
                }
                //si el tipo de movimiento es cero estoy frente a un ingreso
                //si ademas el metodo de pago es 0 estoy frente a un movimiento en efectivo
                //por lo que tengo filtrar movimientos de ingreso y en efectivo
                if (tipoMovimiento == 0 && idMetodoPago == 0)
                {
                    listaMovimientosCaja = datosMovimientosCaja.Filtrar(fecha, 1);
                    dgvMovimientos.DataSource = listaMovimientosCaja.Where(mc => mc.Monto >= 0).ToList();
                }
                //si el tipo de movimiento es 1 estoy frente a un gasto
                //y si ademas el metodo de pago es 0 esoty frente a un movimiento en efectivo
                //por lo que tengo que filtrar movimientos de gasto en efectivo
                else if (tipoMovimiento == 1 && idMetodoPago == 0)
                {
                    listaMovimientosCaja = datosMovimientosCaja.Filtrar(fecha, 1);
                    dgvMovimientos.DataSource = listaMovimientosCaja.Where(mc => mc.Monto < 0).ToList();
                }
                //si el tipo de movimiento es 0 estoy frente a un ingreso
                //y si ademas el metodo de pago es 1 estoy frente a un movimiento en transferencia
                //por lo que tengo que filtrar movimientos de ingreso en transferencia
                else if (tipoMovimiento == 0 && idMetodoPago == 1)
                {
                    listaMovimientosCaja = datosMovimientosCaja.Filtrar(fecha, 2);
                    dgvMovimientos.DataSource = listaMovimientosCaja.Where(mc => mc.Monto >= 0).ToList();
                }
                //si el tipo de movimiento es 1 estoy frente a un gasto
                //y si el metodo de pago es 1 estoy frente a un movimiento es transferencia
                //por lo que tengo que filtrar movimientos de gasto es transferencia
                else if (tipoMovimiento == 1 && idMetodoPago == 1)
                {
                    listaMovimientosCaja = datosMovimientosCaja.Filtrar(fecha, 2);
                    dgvMovimientos.DataSource = listaMovimientosCaja.Where(mc => mc.Monto < 0).ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al filtrar movimientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxTipoMovimientoFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoMovimientoFiltrar.SelectedIndex >= 0)
            {
                invocarElMetodoFiltrar();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Antes de reiniciar, desasocia el controlador de eventos del DatePicker.
            dtpBuscar.ValueChanged -= dtpBuscar_ValueChanged;
            cbxTipoMovimientoFiltrar.SelectedIndexChanged -= cbxTipoMovimientoFiltrar_SelectedIndexChanged;
            cbxMetodoPagoFiltrar.SelectedIndexChanged -= cbxMetodoPagoFiltrar_SelectedIndexChanged;

            // Realiza el proceso de reinicio
            CargarGrilla();
            dtpBuscar.Value = DateTime.Now;
            cbxTipoMovimientoFiltrar.SelectedIndex = -1;
            cbxMetodoPagoFiltrar.SelectedIndex = -1;

            // Vuelve a asociar el controlador de eventos después de reiniciar.
            dtpBuscar.ValueChanged += dtpBuscar_ValueChanged;
            cbxTipoMovimientoFiltrar.SelectedIndexChanged += cbxTipoMovimientoFiltrar_SelectedIndexChanged;
            cbxMetodoPagoFiltrar.SelectedIndexChanged += cbxMetodoPagoFiltrar_SelectedIndexChanged;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxMetodoPagoFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMetodoPagoFiltrar.SelectedIndex != -1)
            {
                invocarElMetodoFiltrar();
            }

        }
    }
}
