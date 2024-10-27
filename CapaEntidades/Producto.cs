using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        public int  IdProducto{get;set;} 
        public String Codigo { get; set; }
        public string Nombre { get; set; }
        public int Existencia { get; set; }
        public bool Estado { get; set; } // true para activo, false para inactivo
        public string NombreProveedor { get; set; }
    }
}
