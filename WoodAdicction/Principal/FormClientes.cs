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
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            Cargar();
            RedondearBordes(panelAviso, 20);
            panel1.BackgroundImageLayout = ImageLayout.Center;

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
                listaClientes = listaClientes.OrderByDescending(c => c.fechaInicio).ToList();
                dgvClientes.DataSource = listaClientes;
                OcultarYModificarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error. Intente de nuevo mas tarde.", ex.ToString());
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
            dgvClientes.Columns["apellido"].HeaderText = "Apellido";
            dgvClientes.Columns["Saldo"].Visible = false;
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
            panelFiltroAvanzado.Height += 354;
            label8.Visible = false;
            btnVerMas.Visible = false;
            label7.Visible = true;
            btnOcultar.Visible = true;
            panelContainerFiltro.Height += 354;
            CargarCombosBox();

        }

        private void CargarCombosBox()
        {
            MembresiasDatos datos = new MembresiasDatos();
            List<Membresias> listaMembresias = new List<Membresias>();
            cbxAñoInicio.Items.Clear();
            cbxMesInicio.Items.Clear();
            cbxEstado.Items.Clear();
            try
            {
                for (int i = 3; i < 23; i++)
                {
                    if (i <= 9)
                    {
                        cbxAñoInicio.Items.Add("202" + i);
                    }
                    else
                    {
                        if (i <= 19)
                        {
                            cbxAñoInicio.Items.Add("203" + (i - 10));
                        }
                        else
                        {
                            cbxAñoInicio.Items.Add("204" + (i - 20));
                        }
                    }

                }
                cbxMesInicio.Items.Add("Enero");
                cbxMesInicio.Items.Add("Febrero");
                cbxMesInicio.Items.Add("Marzo");
                cbxMesInicio.Items.Add("Abril");
                cbxMesInicio.Items.Add("Mayo");
                cbxMesInicio.Items.Add("Junio");
                cbxMesInicio.Items.Add("Julio");
                cbxMesInicio.Items.Add("Agosto");
                cbxMesInicio.Items.Add("Septiembre");
                cbxMesInicio.Items.Add("Octubre");
                cbxMesInicio.Items.Add("Noviembre");
                cbxMesInicio.Items.Add("Diciembre");

                cbxEstado.Items.Add("Activo");
                cbxEstado.Items.Add("Inactivo");

                listaMembresias = datos.listarMembresiasConSp();
                cbxTipoMembresia.DataSource = listaMembresias;
                cbxTipoMembresia.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al tratar de cargar los campos del filtro avanzado." + ex.ToString());
            }

        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            panelFiltroAvanzado.Height -= 354;
            label8.Visible = true;
            btnVerMas.Visible = true;
            label7.Visible = false;
            btnOcultar.Visible = false;
            panelContainerFiltro.Height -= 354;
            Cargar();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FiltroRapido()
        {
            List<Cliente> ListaFiltrada;
            string filtro = txtNombre.Text;
            if (filtro.Length >= 3)
            {
                ListaFiltrada = listaClientes.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = ListaFiltrada;
                OcultarYModificarColumnas();
            }
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Si no es una letra o retroceso, se ignora la tecla
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClienteDatos Datos = new ClienteDatos();
            try
            {
                if (ValidarFiltro())
                    return;
                int dni = string.IsNullOrEmpty(txtDni.Text) ? -1 : int.Parse(txtDni.Text);
                string añoInicio;
                if (cbxAñoInicio.SelectedIndex >= 0)
                {
                    añoInicio = cbxAñoInicio.SelectedItem.ToString();
                }
                else
                {
                    añoInicio = null;
                }
                string mesInicio;
                if (cbxMesInicio.SelectedIndex >= 0)
                {
                    int mes = cbxMesInicio.SelectedIndex + 1;
                    if (mes < 10)
                    {
                        mesInicio = "0" + mes.ToString();
                    }
                    else
                    {
                        mesInicio = mes.ToString();
                    }

                }
                else
                {
                    mesInicio = null;
                }
                string tipoMembresia;
                if (cbxTipoMembresia.SelectedIndex >= 0)
                {
                    tipoMembresia = cbxTipoMembresia.SelectedItem.ToString();
                }
                else
                {
                    tipoMembresia = null;
                }
                int edad;
                if (!string.IsNullOrEmpty(txtEdad.Text))
                {
                    edad = int.Parse(txtEdad.Text);
                }
                else
                {
                    edad = -1;
                }
                string estado;
                if (cbxEstado.SelectedIndex >= 0)
                {
                    estado = cbxEstado.SelectedItem.ToString();
                }
                else
                {
                    estado = null;
                }

                dgvClientes.DataSource = Datos.Filtrar(dni, añoInicio, mesInicio, tipoMembresia, edad, estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error. Intente de nuevo mas tarde.", ex.ToString());
            }
        }

        private bool ValidarFiltro()
        {
            if (string.IsNullOrEmpty(txtDni.Text) &&
                cbxAñoInicio.SelectedIndex < 0 &&
                cbxMesInicio.SelectedIndex < 0 &&
                cbxTipoMembresia.SelectedIndex < 0 &&
                string.IsNullOrEmpty(txtEdad.Text) &&
                cbxEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Debes completar al menos uno de los campos");
                return true;
            }
            return false;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtDni.Text = "";
            cbxAñoInicio.SelectedIndex = -1;
            cbxMesInicio.SelectedIndex = -1;
            cbxTipoMembresia.SelectedIndex = -1;
            txtEdad.Text = "";
            cbxEstado.SelectedIndex = -1;
            Cargar();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 9;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (txtDni.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 3;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (txtEdad.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnCobrarCuota_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null && dgvClientes.CurrentRow.DataBoundItem != null)
            {
                Cliente Seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                FrmCobrarCuota cobrarCuota = new FrmCobrarCuota(Seleccionado);
                cobrarCuota.ModoOperacion = FrmCobrarCuota.ModoOperacionEnum.Modificar;
                cobrarCuota.ShowDialog();
                Cargar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un socio", "Error de seleccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarFiltroRapido_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                FiltroRapido();
            }
            else
            {
                Cargar();
            }
            
        }
    }
}
