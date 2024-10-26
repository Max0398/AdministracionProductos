using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NProducto
    {
        DProducto dProducto = new DProducto();

        public DataTable listadoProductos()
        {
            return dProducto.listadoProductos();
        }
    }
}
