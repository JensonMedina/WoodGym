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
                Cargar();
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
    }
}
