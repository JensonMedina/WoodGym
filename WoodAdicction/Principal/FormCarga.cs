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
    public partial class FormCarga : Form
    {
        int startPoint = 0;
        public FormCarga()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            myProgressBar.Value = startPoint;
            if (myProgressBar.Value == 100)
            {
                myProgressBar.Value = 0;
                timer1.Stop();
                FrmFichaCliente log = new FrmFichaCliente();
                this.Hide();
                log.Show();
            }
        }

        private void FormCarga_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
