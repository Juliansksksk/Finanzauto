using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Finanzauto.Datos
{
    public class ConexionSql
    {
        private string connectionString;

        public ConexionSql()
        {
            // Obtiene la cadena de conexión del Web.config
            connectionString = ConfigurationManager.ConnectionStrings["pruebaJulian"].ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

}