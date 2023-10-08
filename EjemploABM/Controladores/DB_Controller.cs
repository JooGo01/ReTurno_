using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Controladores
{
    public static class DB_Controller
    {

        private static string connectionString = "";
        public static SqlConnection connection;

        public static void initialize()
        {
            var builder = new SqlConnectionStringBuilder();

            builder.DataSource = @"(localdb)\Local"; //NOMBRE DEL SERVIDOR
            builder.InitialCatalog = "abm_completo"; //NOMBRE DE LA BASE DE DATOS
            builder.IntegratedSecurity = true; //TIENE O NO SEGURIDAD INTEGRADA CON WINDOWS

            connectionString = builder.ToString();
            connection = new SqlConnection(connectionString);

            Trace.WriteLine("Conexion a la DB: " + connection);

        }

    }
}
