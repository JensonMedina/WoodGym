using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            FrmCaja caja = new FrmCaja();
            caja.ShowDialog();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.FromArgb(255, 176, 0);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.Transparent;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes verClientes = new FormClientes();
            verClientes.ShowDialog();
        }

        private void btnMembresias_Click(object sender, EventArgs e)
        {
            FrmMembresias verMembresias = new FrmMembresias();
            verMembresias.ShowDialog();
        }
    }
}
