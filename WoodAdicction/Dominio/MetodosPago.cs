using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MetodosPago
    {
        public int IdMetodoPago { get; set; }
        public string NombreMetodoPago { get; set; }

        public override string ToString()
        {
            return NombreMetodoPago;
        }
    }
}
