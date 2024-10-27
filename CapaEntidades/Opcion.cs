using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Opcion
    {
        public int OpcionId { get; set; }
        public string NombreOpcion { get; set; }
        public int ProductoId { get; set; }
        public bool Estado { get; set; }
    }
}
