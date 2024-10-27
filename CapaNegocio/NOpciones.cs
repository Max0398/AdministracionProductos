using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocio
{
    public  class NOpciones
    {
        DOpciones dOpciones = new DOpciones();

        public DataTable productoOpciones(int ProductoId)
        {
            return dOpciones.productoOpciones(ProductoId);
        }

        public void editarOpcion(Opcion opcion)
        {
            dOpciones.editarOpcion(opcion);
        }

        public void registrarOpcion(Opcion opcion)
        {
            dOpciones.registrarOpcion(opcion);
        }

        public DataTable listadoOpciones()
        {
            return dOpciones.listadoOpciones();
        }

    }
}
