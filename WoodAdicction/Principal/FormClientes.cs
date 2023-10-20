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
                CultureInfo Culture = new CultureInfo("es-AR");
                Culture.NumberFormat.CurrencySymbol = "ARS";
                ClienteDatos datos = new ClienteDatos();
                listaClientes = datos.listarClientesConSP();
                dgvClientes.DataSource = listaClientes;
                dgvClientes.Columns["precio"].DefaultCellStyle.Format = "C2";
                dgvClientes.Columns["precio"].DefaultCellStyle.FormatProvider = Culture;
                //OcultarColumnas();
                //CargarImagen(ListaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.ToString());
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                Cliente Seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                label3.Text = Seleccionado.tipo.id.ToString();
            }
        }

        private void btnVerCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null && dgvClientes.CurrentRow.DataBoundItem != null)
            {
                Cliente Seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                FrmDatosSocio verCliente = new FrmDatosSocio(Seleccionado);
                verCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de modificar un articulo", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmDatosSocio clienteNuevo = new FrmDatosSocio();
            clienteNuevo.ShowDialog();
            Cargar();
        }
    }
}
