using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Datos;

namespace Principal
{
    public partial class FrmMembresias : Form
    {
        private List<Membresias> listaMembresias;
        private Membresias membresia = null;
        private bool modoModificar = false;
        public FrmMembresias()
        {
            InitializeComponent();
        }

        private void FrmMembresias_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            OcultarColumnas();
        }

        private void OcultarColumnas()
        {
            dgvMembresias.Columns["id"].Visible = false;
        }

        private void CargarGrilla()
        {
            try
            {
                MembresiasDatos datos = new MembresiasDatos();
                listaMembresias = datos.listarMembresiasConSp();
                dgvMembresias.DataSource = listaMembresias;
                dgvMembresias.Columns["Eliminar"].DisplayIndex = 5;
                dgvMembresias.Columns["Eliminar"].Width = 30;
                dgvMembresias.Columns["Eliminar"].HeaderText = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.ToString());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvMembresias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembresias.CurrentRow != null)
            {
                Membresias seleccionada = (Membresias)dgvMembresias.CurrentRow.DataBoundItem;
                txtTipo.Text = seleccionada.Nombre;
                txtPrecio.Text = seleccionada.Precio.ToString();
                txtDescripcion.Text = seleccionada.Descripcion.ToString();
                nudDuracion.Value = seleccionada.Duracion;
                modoModificar = true;
                membresia = seleccionada;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTipo.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            nudDuracion.Value = 1;
            membresia = null; // Restablecer la membresía seleccionada.
            modoModificar = false; // Restablecer el modo.
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MembresiasDatos Datos = new MembresiasDatos();

            if (membresia == null)
                membresia = new Membresias();

            if (ValidarMembresia())
            {
                try
                {
                    if (modoModificar)
                    {
                        ModificarMembresia(Datos);
                    }
                    else
                    {
                        AgregarMembresia(Datos);
                    }

                    MessageBox.Show(modoModificar ? "Modificado exitosamente" : "Agregado exitosamente");
                    CargarGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos con * son obligatorios");
            }
        }

        private void ModificarMembresia(MembresiasDatos Datos)
        {
            CargarMembresia(membresia);
            Datos.ModificarMembresia(membresia);
        }

        private void AgregarMembresia(MembresiasDatos Datos)
        {
            CargarMembresia(membresia);
            Datos.AgregarMembresia(membresia);
        }


        private void CargarMembresia(Membresias nuevaMembresia)
        {
            //Leo y guardo los valores de los campos en variables auxiliares
            string nombre = txtTipo.Text;
            decimal precio = decimal.Parse(txtPrecio.Text);
            string descripcion = txtDescripcion.Text;
            int duracion = (int)nudDuracion.Value;

            //cargo la nueva membresia
            nuevaMembresia.Nombre = nombre;
            nuevaMembresia.Precio = precio;
            nuevaMembresia.Descripcion = descripcion;
            nuevaMembresia.Duracion = duracion;

        }

        private bool ValidarMembresia()
        {
            //Valido que el campo de duracion sea mayor a cero
            //y que los campos de texto no sean nulos o vacios.
            return nudDuracion.Value > 0 &&
                   !string.IsNullOrWhiteSpace(txtPrecio.Text) &&
                   !string.IsNullOrWhiteSpace(txtTipo.Text) &&
                   !string.IsNullOrWhiteSpace(txtDescripcion.Text) &&
                   !string.IsNullOrWhiteSpace(nudDuracion.Value.ToString());
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 10;
            // Verificar si la tecla presionada es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (txtPrecio.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // Si no es un número o retroceso, se ignora la tecla
            }
        }

        private void dgvMembresias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMembresias.Columns[e.ColumnIndex].Name == "Eliminar" && dgvMembresias.CurrentRow != null)
            {
                int id = int.Parse(dgvMembresias.CurrentRow.Cells["id"].Value.ToString());

                // Mostrar un cuadro de diálogo de confirmación al usuario.
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar esta membresía?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    MembresiasDatos Datos = new MembresiasDatos();
                    try
                    {
                        Datos.EliminarMembresia(id);
                        MessageBox.Show("Membresía eliminada exitosamente");
                        CargarGrilla(); // Vuelve a cargar la grilla después de la eliminación.
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la membresía: " + ex.Message);
                    }
                }
            }
        }

    }
}
