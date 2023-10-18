using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Membresias
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public decimal precio { get; set; }
        public int duracion { get; set; }

        public override string ToString()
        {
            return tipo;
        }
    }
}
