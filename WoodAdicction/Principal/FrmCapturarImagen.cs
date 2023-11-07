using AForge.Video;
using AForge.Video.DirectShow;
using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class FrmCapturarImagen : Form
    {
        private string path = @"C:\Users\chuni\OneDrive\Escritorio\WoodAdicctionGym\ImagenesPerfiles\";
        private bool hayDispositivos;
        public string RutaImagenGuardada { get; private set; }
        private FilterInfoCollection misDispositivos; //Esto me sirve para obtener una lista de los dispositivos que hay en mi equipo instalados
        private VideoCaptureDevice miWebCam; //Una vez que tengo un dispositivo elegido voy guardando los frames aca.
        public FrmCapturarImagen()
        {
            InitializeComponent();
        }
        public void CargarDispositivos()
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (misDispositivos.Count > 0)
            {
                hayDispositivos = true;
                for (int i = 0; i < misDispositivos.Count; i++)
                {
                    cbxGrabar.Items.Add(misDispositivos[i].Name.ToString());
                }
                cbxGrabar.Text = misDispositivos[0].Name.ToString();
            }
            else
            {
                hayDispositivos = false;
            }
        }

        private void FrmCapturarImagen_Load(object sender, EventArgs e)
        {
            CargarDispositivos();

        }
        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            pbxGrabar.Image = imagen;
            pbxGrabar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            CerrarWebCam();
            int i = cbxGrabar.SelectedIndex;
            string nombreVideo = misDispositivos[i].MonikerString;
            miWebCam = new VideoCaptureDevice(nombreVideo);
            miWebCam.NewFrame += new NewFrameEventHandler(Capturando);
            miWebCam.Start();
        }
        private void CerrarWebCam()
        {
            if (miWebCam != null && miWebCam.IsRunning)
            {
                miWebCam.SignalToStop();
                miWebCam = null;
            }
        }

        private void FrmCapturarImagen_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebCam();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (miWebCam != null && miWebCam.IsRunning)
            {
                pbxCapturar.Image = pbxGrabar.Image;
                pbxCapturar.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreArchivo = "Cliente" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                string rutaCompleta = Path.Combine(path, nombreArchivo);

                pbxCapturar.Image.Save(rutaCompleta, ImageFormat.Jpeg);

                RutaImagenGuardada = rutaCompleta; // Almacena la ruta de la imagen guardada

                MessageBox.Show("Imagen cargada con éxito");
                this.Close();
            }
            catch (ExternalException ex)
            {
                MessageBox.Show("Error al guardar la imagen: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
