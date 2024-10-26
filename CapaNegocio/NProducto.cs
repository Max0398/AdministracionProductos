using CapaDatos;
using CapaEntidades;
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

        public void registrarProductos(Producto producto)
        {
            dProducto.registrarProductos(producto);
        }
    }
}
