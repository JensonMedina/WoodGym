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
                listaClientes = datos.listarConSP();
                dgvClientes.DataSource = listaClientes;
                //OcultarColumnas();
                //CargarImagen(ListaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
