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
        public DataTable listadoProductosInactivos()
        {
            return dProducto.listadoProductosInactivos();
        }
        public DataTable listadoProductosActivos()
        {
            return dProducto.listadoProductosActivos();
        }

        public void registrarProductos(Producto producto)
        {
            dProducto.registrarProductos(producto);
        }

        public void editarProducto(Producto producto)
        {
            dProducto.editarProducto(producto);
        }

        public void elimacionLogicaProducto(int idProducto)
        {
            dProducto.eliminacionLogicaProducto(idProducto);
        }

        public DataTable filtroNombreCodigo(string buscar)
        {
           return dProducto.filtroNombreCodigo(buscar);
        }
    }
}
