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
        private MovimientosCaja movimientosCaja = null;
        public FrmCaja()
        {
            InitializeComponent();
        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            MetodosPagoDatos datos = new MetodosPagoDatos();
            try
            {
                cbxMetodoPago.DataSource = datos.listarMetodosPagoConSp();
                cbxMetodoPago.ValueMember = "IdMetodoPago";
                cbxMetodoPago.DisplayMember = "NombreMetodoPago";
                cbxTipoMovimiento.Items.Add("Ingreso");
                cbxTipoMovimiento.Items.Add("Gasto");
                cbxTipoMovimientoFiltrar.Items.Add("Ingreso");
                cbxTipoMovimientoFiltrar.Items.Add("Gasto");
                Cargar();
                dgvMovimientos.Columns["MetodoPago"].HeaderText = "Metodo de pago";
            }
            catch (Exception)
            {
                throw;
            }
           
        }
        private void Cargar()
        {
            try
            {

                MovimientosCajaDatos datos = new MovimientosCajaDatos();
                listaMovimientosCaja = datos.listarMovimientosConSp();
                dgvMovimientos.DataSource = listaMovimientosCaja;
                dgvMovimientos.Columns["TransaccionId"].Visible = false;
                //OcultarYModificarColumnas();
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MovimientosCajaDatos Datos = new MovimientosCajaDatos();
            if (movimientosCaja == null)
                movimientosCaja = new MovimientosCaja();
            try
            {
                CargarNuevoMovimiento(movimientosCaja);
                Datos.AgregarMovimientoCaja(movimientosCaja);
                MessageBox.Show("Agregado exitosamente");
                Cargar();
            }
            catch (Exception)
            {

                throw;
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
            if(tipoMovimiento == 1)
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
                        e.CellStyle.BackColor = Color.Green;
                    }
                    else if (monto < 0)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            FrmCierreCaja cerrarCaja = new FrmCierreCaja();
            cerrarCaja.ShowDialog();
        }
    }
}
