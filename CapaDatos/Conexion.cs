using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public  static class ConexionBD
    {
        // Obtiene la cadena de conexión desde app.config
        private static readonly string connectionString = "Conexion";

        public static SqlConnection ObtenerConexion()
        {
            var conexion = new SqlConnection(connectionString);
            conexion.Open();
            return conexion;
        }
       
    }

}
