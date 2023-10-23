using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
    public partial class FormClientes : Form
    {
        private List<Cliente> listaClientes;
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {
            try
            {
                
                ClienteDatos datos = new ClienteDatos();
                listaClientes = datos.listarClientesConSP();
                dgvClientes.DataSource = listaClientes;
                OcultarYModificarColumnas();
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.ToString());
            }
        }
        private void OcultarYModificarColumnas()
        {
            CultureInfo Culture = new CultureInfo("es-AR");
            Culture.NumberFormat.CurrencySymbol = "ARS";
            dgvClientes.Columns["dni"].Visible = false;
            dgvClientes.Columns["urlImagen"].Visible = false;
            dgvClientes.Columns["fechaNacimiento"].Visible = false;
            dgvClientes.Columns["precio"].Visible = false;
            dgvClientes.Columns["duracion"].Visible = false;
            dgvClientes.Columns["fechaInicio"].HeaderText = "Fecha de inicio";
            dgvClientes.Columns["estado"].HeaderText = "Activo";
            dgvClientes.Columns["tipo"].HeaderText = "Tipo de membresia";
            dgvClientes.Columns["precio"].DefaultCellStyle.Format = "C2";
            dgvClientes.Columns["precio"].DefaultCellStyle.FormatProvider = Culture;
        }
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                Cliente Seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                label3.Text = Seleccionado.Tipo.Id.ToString();
            }
        }

        private void btnVerCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null && dgvClientes.CurrentRow.DataBoundItem != null)
            {
                Cliente Seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                FrmDatosSocio verCliente = new FrmDatosSocio(Seleccionado);
                verCliente.ModoOperacion = FrmDatosSocio.ModoOperacionEnum.VerCliente;
                verCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un socio", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmDatosSocio clienteNuevo = new FrmDatosSocio();
            clienteNuevo.ModoOperacion = FrmDatosSocio.ModoOperacionEnum.Agregar;
            clienteNuevo.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dgvClientes.CurrentRow != null && dgvClientes.CurrentRow.DataBoundItem != null)
            {
                Cliente Seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                FrmDatosSocio modificarCliente = new FrmDatosSocio(Seleccionado);
                modificarCliente.ModoOperacion = FrmDatosSocio.ModoOperacionEnum.Modificar;
                modificarCliente.ShowDialog();
                Cargar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una socio", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
