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
        public FrmMembresias()
        {
            InitializeComponent();
        }

        private void FrmMembresias_Load(object sender, EventArgs e)
        {
            Cargar();
            OcultarColumnas();
        }

        private void OcultarColumnas()
        {
            dgvMembresias.Columns["id"].Visible = false;
        }

        private void Cargar()
        {
            try
            {
                MembresiasDatos datos = new MembresiasDatos();
                listaMembresias = datos.listarMembresiasConSp();
                dgvMembresias.DataSource = listaMembresias;
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
            if(dgvMembresias.CurrentRow != null)
            {
                Membresias seleccionada = (Membresias)dgvMembresias.CurrentRow.DataBoundItem;
                txtTipo.Text = seleccionada.Tipo;
                txtPrecio.Text = seleccionada.Precio.ToString();
                nudDuracion.Value = seleccionada.Duracion;
            }
        }
    }
}
