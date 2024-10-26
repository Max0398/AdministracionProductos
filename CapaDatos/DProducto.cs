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


    }
}
