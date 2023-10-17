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
    class Administracion_Controller
    {
        //id, cliente_id, sucursal_id, usuario_id,estado_baja

        public static bool crearAdministracion(Cliente cli, Sucursal suc, Usuario usr)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.administracion values" +
               "(@id, " +
               "@cliente, " +
               "@sucursal, " +
               "@usuario, " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@cliente", cli.id);
            cmd.Parameters.AddWithValue("@sucursal", suc.id);
            cmd.Parameters.AddWithValue("@usuario", usr.id);

            try
            {
                DB_Controller.open();
                cmd.ExecuteNonQuery();
                DB_Controller.close();
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
            string query = "select max(id) from dbo.administracion;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MaxId = reader.GetInt32(0);
                }

                reader.Close();
                DB_Controller.close();
                return MaxId;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }


        // GET ALL

        public static List<Administracion> obtenerTodos()
        {
            List<Administracion> list = new List<Administracion>();
            string query = "select * from dbo.administracion;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Administracion(reader.GetInt32(0), Cliente_Controller.obtenerPorId(reader.GetInt32(1)), Sucursal_Controller.obtenerPorId(reader.GetInt32(2)), Usuario_Controller.obtenerPorId(reader.GetInt32(3)), reader.GetInt32(4)));
                    Trace.WriteLine("Adminsitracion encontrado, id: " + reader.GetInt32(0));
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }



        // GET ONE BY ID

        public static Administracion obtenerPorId(int id)
        {
            Administracion adm = new Administracion();
            string query = "select * from dbo.administracion where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    adm = new Administracion(reader.GetInt32(0), Cliente_Controller.obtenerPorId(reader.GetInt32(1)), Sucursal_Controller.obtenerPorId(reader.GetInt32(2)), Usuario_Controller.obtenerPorId(reader.GetInt32(3)), reader.GetInt32(4));
                    Trace.WriteLine("Administracion encontrado, id: " + reader.GetInt32(0));
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return adm;
        }



        // EDIT / PUT

        public static bool editarAdministracion(Administracion adm, Cliente cli, Sucursal suc, Usuario usr, int estado_baja)
        {
            //Update en la BBDD
            string query = "update dbo.administracion set estado_baja  = @estado_baja , " +
                "cliente_id  = @cliente_id  , " +
                "sucursal_id = @sucursal_id  , " +
                "usuario_id = @usuario_id  , " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", adm.id);
            cmd.Parameters.AddWithValue("@estado_baja", estado_baja);
            cmd.Parameters.AddWithValue("@cliente_id", cli.id);
            cmd.Parameters.AddWithValue("@sucursal_id", suc.id);
            cmd.Parameters.AddWithValue("@usuario_id", usr.id);

            try
            {
                DB_Controller.open();
                cmd.ExecuteNonQuery();
                DB_Controller.close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }
    }
}
