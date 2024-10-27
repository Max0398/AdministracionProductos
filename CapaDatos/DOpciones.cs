using CapaEntidades;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public  class DOpciones
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        public DataTable productoOpciones(int ProductoId)
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leerfilas;
                SqlCommand cmd = new SqlCommand("SP_ListarOpcionesProducto", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("@ProductoId", ProductoId);
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

        public void editarOpcion(Opcion opcion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_EditarOpcion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("@NombreOpcion", opcion.NombreOpcion);
                cmd.Parameters.AddWithValue("@Estado", opcion.Estado);
                cmd.Parameters.AddWithValue("@OpcionID", opcion.OpcionId);
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception err)
            {

                Console.WriteLine($"Error al Guardar: {err}");
            }
        }

        public void registrarOpcion(Opcion opcion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_RegistrarOpcion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("@NombreOpcion",opcion.NombreOpcion);
                cmd.Parameters.AddWithValue("@ProductoID", opcion.ProductoId);
                cmd.Parameters.AddWithValue("@Estado", opcion.Estado);
                cmd.ExecuteNonQuery();
                conexion.Close();

            }
            catch (Exception err)
            {

                Console.WriteLine($"Error al Guardar: {err}");
            }

        }

       public DataTable listadoOpciones()
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leerfilas;
                SqlCommand cmd = new SqlCommand("SP_ListarOpciones", conexion);
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
    }
}
