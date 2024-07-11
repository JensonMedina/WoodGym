using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MovimientosCaja
    {
        public int TransaccionId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public MetodosPago MetodoPago { get; set; }
    }
}
