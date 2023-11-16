using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Datos;

namespace Principal
{
    public partial class FrmCierreCaja : Form
    {
        public FrmCierreCaja()
        {
            InitializeComponent();
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            if (ValidarBusqueda())
            {
                DateTime fecha = dtpCierreCaja.Value;
                bool cierreSemanal = cbxTipoCierre.SelectedIndex == 1; // Si es 1, es cierre semanal

                try
                {
                    MovimientosCajaDatos datos = new MovimientosCajaDatos();

                    // Realizar una verificación de movimientos para la fecha seleccionada
                    bool existenMovimientos = datos.ExistenMovimientosParaFecha(fecha, cierreSemanal);

                    if (existenMovimientos)
                    {
                        // Si existen movimientos, realizar el cierre de caja normalmente
                        decimal[] resultados = datos.RealizarCierreCaja(fecha, cierreSemanal);

                        // Mostrar totales en los TextBox correspondientes
                        txtIngresosEfectivo.Text = resultados[0].ToString();
                        txtGastosEfectivo.Text = resultados[1].ToString();
                        txtIngresosTransferencia.Text = resultados[2].ToString();
                        txtGastosTransferencias.Text = resultados[3].ToString();
                        txtTotalIngresos.Text = resultados[4].ToString();
                        txtTotalGastos.Text = resultados[5].ToString();
                        txtCajaFinalEfectivo.Text = resultados[6].ToString();
                        txtCajaFinalTransferencias.Text = resultados[7].ToString();
                    }
                    else
                    {
                        // Si no hay movimientos, limpiar los TextBox y mostrar un mensaje
                        txtCajaFinalEfectivo.Text = "";
                        txtCajaFinalTransferencias.Text = "";
                        MessageBox.Show("No se registraron movimientos en la fecha seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción de manera adecuada, por ejemplo, mostrar un mensaje de error
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool ValidarBusqueda()
        {
            if (cbxTipoCierre.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de cierre");
                return false;
            }
            return true;
        }


        private void FrmCierreCaja_Load(object sender, EventArgs e)
        {
            cbxTipoCierre.Items.Add("Diario");
            cbxTipoCierre.Items.Add("Semanal");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
