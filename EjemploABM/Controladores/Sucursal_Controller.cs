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
    class Sucursal_Controller
    {
        public static bool crearCliente(String rzn_social, Rubro rubro)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.sucursal values" +
               "(@id, " +
               "@razon_social, " +
               "@rubro_id, " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@razon_social", rzn_social);
            cmd.Parameters.AddWithValue("@rubro_id", rubro.id);

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
            string query = "select max(id) from dbo.sucursal;";

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

        public static List<Sucursal> obtenerTodos()
        {
            List<Sucursal> list = new List<Sucursal>();
            string query = "select * from dbo.sucursal;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            // id, cliente_id, direccion_id, telefono, estado_baja
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Sucursal(reader.GetInt32(0), Cliente_Controller.obtenerPorId(reader.GetInt32(1)), Direccion_Controller.obtenerPorId(reader.GetInt32(2)), reader.GetInt32(3), reader.GetInt32(4)));
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

        public static Sucursal obtenerPorId(int id)
        {
            Sucursal suc = new Sucursal();
            string query = "select * from dbo.sucursal where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    suc = new Sucursal(reader.GetInt32(0), Cliente_Controller.obtenerPorId(reader.GetInt32(1)), Direccion_Controller.obtenerPorId(reader.GetInt32(2)), reader.GetInt32(3), reader.GetInt32(4));
                    Trace.WriteLine("Sucursal encontrado, id: " + reader.GetInt32(0));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return suc;
        }



        // EDIT / PUT

        public static bool editarSucursal(Sucursal suc, Cliente cliente, Direccion dir, long telefono, int estado_baja)
        {
            //Update en la BBDD

            string query = "update dbo.sucursal set cliente_id  = @cliente_id , " +
                "direccion_id   = @direccion_id , " +
                "telefono   = @telefono , " +
                "estado_baja  = @estado_baja " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", suc.id);
            cmd.Parameters.AddWithValue("@direccion_id", dir.id);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@cliente_id", cliente.id);
            cmd.Parameters.AddWithValue("@estado_baja", estado_baja);

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
