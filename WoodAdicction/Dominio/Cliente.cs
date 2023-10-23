using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? fechaNacimiento { get; set; }
        public int? Edad { get; set; }
        public string Telefono { get; set; }
        public DateTime fechaInicio { get; set; }
        public bool Estado { get; set; }
        public string urlImagen { get; set; }
        public Membresias Tipo { get; set; }
        public decimal Precio { get; set; }
        public int Duracion { get; set; }
        
    }
}
