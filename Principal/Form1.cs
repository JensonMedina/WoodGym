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
        
        public FrmFichaCliente()
        {
            InitializeComponent();
        }
        

        private void FrmFichaCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
