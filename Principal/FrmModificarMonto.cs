using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Principal
{
    public partial class FrmModificarMonto : Form
    {
        private Cliente Cliente = null;
        public FrmModificarMonto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDni.Text))
            {
                if (ValidarDni())
                    return;
                ClienteDatos clienteDatos = new ClienteDatos();
                try
                {
                    int dni = int.Parse(txtDni.Text);
                    Cliente = new Cliente();
                    Cliente = clienteDatos.BuscarCliente(dni);
                    string nombreCliente = Cliente.Nombre + " " + Cliente.Apellido;
                    DialogResult result = MessageBox.Show("El cliente encontrado es: " + nombreCliente + " , es correcto ?", "Pregunta", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        label2.Visible = true;
                        label3.Visible = true;
                        cbxTipoMembresia.Visible = true;
                        txtMonto.Visible = true;
                        btnAceptar.Visible = true;
                        cbxTipoMembresia.SelectedItem = Cliente.TipoMembresia.Nombre;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar el cliente, intente de nuevo mas tarde");
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 9;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (txtDni.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private bool ValidarDni()
        {
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                return true;
            }

            if (!int.TryParse(txtDni.Text, out int dni))
            {
                return true; // No es un número válido
            }

            if (dni < 1000000 || dni > 999999999)
            {
                return true; // DNI fuera de rango
            }

            return false;
        }

        private void FrmModificarMonto_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }
        private void CargarComboBox()
        {
            MembresiasDatos datos = new MembresiasDatos();
            try
            {
                cbxTipoMembresia.DataSource = datos.listarMembresiasConSp();
                cbxTipoMembresia.ValueMember = "Id";
                cbxTipoMembresia.DisplayMember = "Nombre";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ClienteDatos datos = new ClienteDatos();
            MembresiasDatos Datos = new MembresiasDatos();
            try
            {
                if (cbxTipoMembresia.SelectedIndex >= 0 && !string.IsNullOrEmpty(txtMonto.Text))
                {
                    int tipoMembresiaId = (int)cbxTipoMembresia.SelectedValue;
                    decimal monto = decimal.Parse(txtMonto.Text);

                    decimal precio = Datos.ObtenerPrecioMembresia(tipoMembresiaId);
                    decimal resto = monto - precio;
                    Cliente.Saldo = 0;
                    if (resto < 0)
                    {
                        //si resto es menor que cero signfica que el cliente queda debiendo
                        //como estamos agregando un cliente por primera vez no vamos a preguntar sobre el saldo, ya que el saldo va a ser cero
                        Cliente.Saldo += resto;
                    }
                    else if (resto > 0)
                    {
                        //si el resto es mayor que cero significa que el cliente queda a favor
                        Cliente.Saldo += resto;
                    }
                    datos.ModificarClienteConSP(Cliente, Cliente.Dni);
                    MessageBox.Show("Modificado exitosamente");
                    this.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
