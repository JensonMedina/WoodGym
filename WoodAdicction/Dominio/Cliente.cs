using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int NroSocio { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? fechaNacimiento { get; set; }
        public int? Edad { get; set; }
        public string Telefono { get; set; }
        public DateTime fechaInicio { get; set; }
        public bool Activo { get; set; }
        public string urlImagen { get; set; }
        public Membresias TipoMembresia { get; set; }
        public decimal Saldo { get; set; }
    }
}
