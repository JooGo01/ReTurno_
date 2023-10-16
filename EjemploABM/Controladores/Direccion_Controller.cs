using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Controladores
{
    class Direccion_Controller
    {
        //id, calle, altura, codigo_postal, piso, provincia, ciudad, departamento
        public static bool crearDireccion(String calle, int altura, String cod_pos, int piso, String provincia, String ciudad, String departamento)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.direccion values" +
               "(@id, " +
               "@calle, " +
               "@altura, " +
               "@codigo_postal, " +
               "@piso, " +
               "@provincia, " +
               "@ciudad, " +
               "@departamento, " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@calle", calle);
            cmd.Parameters.AddWithValue("@altura", altura);
            cmd.Parameters.AddWithValue("@codigo_postal", cod_pos);
            cmd.Parameters.AddWithValue("@piso", piso);
            cmd.Parameters.AddWithValue("@provincia", provincia);
            cmd.Parameters.AddWithValue("@ciudad", ciudad);
            cmd.Parameters.AddWithValue("@departamento", departamento);

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }


        // OBTENER EL MAX ID

        public static int obtenerMaxId()
        {
            int MaxId = 0;
            string query = "select max(id) from dbo.direccion;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MaxId = reader.GetInt32(0);
                }

                reader.Close();
                DB_Controller.connection.Close();
                return MaxId;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }


        // GET ALL

        public static List<Direccion> obtenerTodos()
        {
            List<Direccion> list = new List<Direccion>();
            string query = "select * from dbo.direccion;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Direccion(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }



        // GET ONE BY ID

        public static Direccion obtenerPorId(int id)
        {
            Direccion dir = new Direccion();
            string query = "select * from dbo.direccion where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dir = new Direccion(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                    Trace.WriteLine("Direccion encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return dir;
        }



        // EDIT / PUT

        public static bool editarDireccion(Direccion dir, String calle, int altura, String cod_pos, int piso, String provincia, String ciudad, String departamento)
        {
            //Update en la BBDD
            string query = "update dbo.direccion set altura  = @altura , " +
                "calle   = @calle , " +
                "codigo_postal   = @codigo_postal , " +
                "piso   = @piso , " +
                "provincia   = @provincia , " +
                "ciudad   = @ciudad , " +
                "departamento   = @departamento , " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", dir.id);
            cmd.Parameters.AddWithValue("@calle", calle);
            cmd.Parameters.AddWithValue("@altura", altura);
            cmd.Parameters.AddWithValue("@codigo_postal", cod_pos);
            cmd.Parameters.AddWithValue("@piso", piso);
            cmd.Parameters.AddWithValue("@provincia", provincia);
            cmd.Parameters.AddWithValue("@ciudad", ciudad);
            cmd.Parameters.AddWithValue("@departamento", departamento);

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }
    }
}
