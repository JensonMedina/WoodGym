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

namespace Principal
{
    public partial class FrmFichaCliente : Form
    {
        private Cliente Cliente = null;
        public FrmFichaCliente()
        {
            InitializeComponent();
        }
        public FrmFichaCliente(Cliente cliente)
        {
            InitializeComponent();
            this.Cliente = cliente; 
        }

        private void FrmFichaCliente_Load(object sender, EventArgs e)
        {
            try
            {
                if(Cliente != null)
                {
                    txtNombre.Text = Cliente.Nombre;
                    txtDni.Text = Cliente.dni.ToString();
                    txtFechaNacimiento.Text = Cliente.fechaNacimiento.ToString("d");
                    txtTelefono.Text = Cliente.telefono.ToString();
                    txtFechaInicio.Text = Cliente.fechaInicio.ToString("d");
                    txtTipoMembresia.Text = Cliente.tipo.tipo;
                    string rutaImagen = Cliente.urlImagen;

                    if (File.Exists(rutaImagen))
                    {
                        pcbCliente.Load(rutaImagen);
                    }
                    else
                    {
                        pcbCliente.Load("C:/Users/chuni/OneDrive/Escritorio/WoodAdicctionGym/Imagenes/placeholderPortrait.jpg");
                    }

                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
