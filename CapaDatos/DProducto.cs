using CapaEntidades;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DProducto
    {
        //cadena de conexion 
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        //Procedimientos almacenado para tratar la informacion de la producto con los formularios
        public DataTable listadoProductos()
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leerfilas;
                SqlCommand cmd = new SqlCommand("SP_ListarProductos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                leerfilas = cmd.ExecuteReader();
                tabla.Load(leerfilas);
                leerfilas.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
         
            return tabla;

        }
        public DataTable listadoProductosActivos()
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leerfilas;
                SqlCommand cmd = new SqlCommand("SP_ListarProductosActivos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                leerfilas = cmd.ExecuteReader();
                tabla.Load(leerfilas);
                leerfilas.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            return tabla;

        }
        public DataTable listadoProductosInactivos()
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leerfilas;
                SqlCommand cmd = new SqlCommand("SP_ListarProductosInactivos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                leerfilas = cmd.ExecuteReader();
                tabla.Load(leerfilas);
                leerfilas.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            return tabla;

        }
        public DataTable filtroNombreCodigo(string buscar)
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leerfilas;
                SqlCommand cmd = new SqlCommand("SP_BuscarProducto", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Busqueda",buscar);
                conexion.Open();
                leerfilas = cmd.ExecuteReader();
                tabla.Load(leerfilas);
                leerfilas.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            return tabla;

        }
        public void registrarProductos(Producto producto)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_RegistrarProducto", conexion);
                cmd.CommandType= CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("@Codigo",producto.Codigo);
                cmd.Parameters.AddWithValue("@Nombre",producto.Nombre);
                cmd.Parameters.AddWithValue("@Existencia",producto.Existencia);
                cmd.Parameters.AddWithValue("@Estado",producto.Estado);
                cmd.Parameters.AddWithValue("@Proveedor",producto.NombreProveedor);
                cmd.ExecuteNonQuery();
                conexion.Close();

            }
            catch (Exception err)
            {

                Console.WriteLine($"Error al Guardar: {err}");
            }
            
        }
        public void editarProducto(Producto producto)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_EditarProducto", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("@Id",producto.IdProducto);
                cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                cmd.Parameters.AddWithValue("@Estado", producto.Estado);
                cmd.Parameters.AddWithValue("@Proveedor", producto.NombreProveedor);
                cmd.ExecuteNonQuery();
                conexion.Close();

            }
            catch (Exception err)
            {

                Console.WriteLine($"Error al Editar el Producto: {err}");
            }
        }
        public void eliminacionLogicaProducto(int idProducto)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_BorrarProductoLogico", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("@Id", idProducto);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception err)
            {

                Console.WriteLine($"Error al Realizar el Borrado:{err.Message} ");
            }
        }
    }
}
