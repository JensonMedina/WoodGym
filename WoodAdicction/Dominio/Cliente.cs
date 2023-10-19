using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int dni { get; set; }
        public string Nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string telefono { get; set; }
        public DateTime fechaInicio { get; set; }
        public bool estado { get; set; }
        public string urlImagen { get; set; }
        public Membresias tipo { get; set; }
        public decimal precio { get; set; }
        public int duracion { get; set; }
        
    }
}
