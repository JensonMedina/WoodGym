using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Membresias
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public int Duracion { get; set; }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
