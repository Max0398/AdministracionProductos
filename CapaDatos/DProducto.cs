using CapaEntidades;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DProducto
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public DataTable listadoProductos()
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

    }
}
