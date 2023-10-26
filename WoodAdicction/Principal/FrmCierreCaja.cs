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
            DateTime fecha = dtpCierreCaja.Value;
            bool cierreSemanal = cbxTipoCierre.SelectedIndex == 1; // Si es 1, es cierre semanal

            try
            {
                MovimientosCajaDatos datos = new MovimientosCajaDatos();
                decimal montoFinal = datos.RealizarCierreCaja(fecha, cierreSemanal);
                txtCierreCaja.Text = montoFinal.ToString();
            }
            catch (Exception ex)
            {
                // Manejar la excepción de manera adecuada, por ejemplo, mostrar un mensaje de error
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FrmCierreCaja_Load(object sender, EventArgs e)
        {
            cbxTipoCierre.Items.Add("Diario");
            cbxTipoCierre.Items.Add("Semanal");
        }
    }
}
