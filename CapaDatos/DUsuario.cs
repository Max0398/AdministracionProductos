using CapaEntidades;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DUsuario
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);


        public bool validarUsuario(string usuario, string contrasenia)
        {
            bool esValido = false;

            try
            {
                using (conexion) 
                {
                    using (SqlCommand command = new SqlCommand("sp_ValidarUsuario", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombreUsuario", usuario);
                        command.Parameters.AddWithValue("@Contrasenia", contrasenia);

                        conexion.Open();
                        int resultado = Convert.ToInt32(command.ExecuteScalar());
                        esValido = resultado == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la conexión: {ex.Message}");
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return esValido;
        }

        public void registroUsuario(Usuario usuario)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia); // Se agregara el hash en la base de datos de forma Automatica
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine($"Error de Registro: {err.Message}");
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

     


    }
}
