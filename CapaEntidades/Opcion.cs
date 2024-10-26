using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Opcion
    {
        public int Id { get; set; }
        public string NombreOpcion { get; set; }
        public int ProductoId { get; set; } // Relación con Producto
        public bool Estado { get; set; } //
    }
}
