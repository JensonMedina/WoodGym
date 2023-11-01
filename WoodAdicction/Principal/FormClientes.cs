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
using System.Drawing.Drawing2D;

namespace Principal
{
    public partial class FormClientes : Form
    {
        private List<Cliente> listaClientes;
        int yOriginal;
        private Point coordenadasEnPantalla;

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            Cargar();
            RedondearBordes(panelAviso, 20);
            yOriginal = panelContainerSocios.Location.Y;
        }
        // Método para redondear los bordes de un Panel.
        private void RedondearBordes(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = panel.ClientRectangle;

            // Crea un rectángulo redondeado que define los bordes redondeados.
            path.AddArc(bounds.Left, bounds.Top, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Top, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            // Define la región del Panel usando el camino redondeado.
            panel.Region = new Region(path);
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
            dgvClientes.Columns["urlImagen"].Visible = false;
            dgvClientes.Columns["fechaNacimiento"].Visible = false;
            dgvClientes.Columns["fechaInicio"].HeaderText = "Inicio";
            dgvClientes.Columns["TipoMembresia"].HeaderText = "Membresia";
            dgvClientes.Columns["telefono"].Visible = false;
            dgvClientes.Columns["edad"].Visible = false;
            dgvClientes.Columns["apellido"].Visible = false;
        }
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                Cliente Seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
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

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            int nuevaX = 270;
            int nuevaY = 470;
            panelFiltroAvanzado.Height += 160;
            label8.Visible = false;
            btnVerMas.Visible = false;
            label7.Visible = true;
            btnOcultar.Visible = true;
            panelContainerFiltro.Height += 160;
            panelContainerSocios.Location = new Point(nuevaX, nuevaY);
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            int nuevaX = 270;
            int nuevaY = coordenadasEnPantalla.Y + panelContainerFiltro.Size.Height + 20;
            panelFiltroAvanzado.Height -= 160;
            label8.Visible = true;
            btnVerMas.Visible = true;
            label7.Visible = false;
            btnOcultar.Visible = false;
            panelContainerFiltro.Height -= 160;
            panelContainerSocios.Location = new Point(nuevaX, nuevaY);
        }

        private void btnRestablecer_MouseEnter(object sender, EventArgs e)
        {
            btnRestablecer.BackColor = Color.FromArgb(110, 110, 110);
        }

        private void btnRestablecer_MouseLeave(object sender, EventArgs e)
        {
            btnRestablecer.BackColor = Color.FromArgb(164, 164, 164);
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.FromArgb(255, 96, 0);
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.FromArgb(230, 105, 45);
        }
    }
}
