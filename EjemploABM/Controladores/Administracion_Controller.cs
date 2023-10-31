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

        public static bool crearAdministracion(Sucursal suc, Usuario usr)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.administracion values" +
               "(@sucursal, " +
               "@usuario, " +
               "@estado_baja);";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@sucursal", suc.id);
            cmd.Parameters.AddWithValue("@usuario", usr.id);
            cmd.Parameters.AddWithValue("@estado_baja", 0);
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
                //return 0;
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
                    list.Add(new Administracion(reader.GetInt32(0), Sucursal_Controller.obtenerPorId(reader.GetInt32(1)), Usuario_Controller.obtenerPorId(reader.GetInt32(2)), reader.GetInt32(3)));
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

        public static List<Administracion> obtenerTodosCliente(Cliente cli)
        {
            List<Administracion> list = new List<Administracion>();
            List<Sucursal> sucursal = new List<Sucursal>();
            List<Usuario> usuario = new List<Usuario>();
            List<int> listId = new List<int>();
            List<int> listIdSuc = new List<int>();
            List<int> listIdUsuario = new List<int>();
            List<int> listEstadoBaja = new List<int>();
            string query = "select a.* from administracion a join sucursal s on a.sucursal_id=s.id join cliente c on s.cliente_id=c.id where s.estado_baja=0 and a.estado_baja=0 and c.id= @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", cli.id);
            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listIdSuc.Add(reader.GetInt32(1));
                    listIdUsuario.Add(reader.GetInt32(2));
                    listEstadoBaja.Add(reader.GetInt32(3));
                    Trace.WriteLine("Adminsitracion encontrado, id: " + reader.GetInt32(0));
                }

                for (int i = 0; i < listIdSuc.Count; i++)
                {
                    sucursal.Add(Sucursal_Controller.obtenerPorId(listIdSuc[i]));
                }

                for (int i = 0; i < listIdUsuario.Count; i++)
                {
                    usuario.Add(Usuario_Controller.obtenerPorId(listIdUsuario[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    list.Add(new Administracion(listId[i], sucursal[i], usuario[i], listEstadoBaja[i]));
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
                    adm = new Administracion(reader.GetInt32(0), Sucursal_Controller.obtenerPorId(reader.GetInt32(1)), Usuario_Controller.obtenerPorId(reader.GetInt32(2)), reader.GetInt32(3));
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

        public static bool editarAdministracion(Administracion adm, Sucursal suc, Usuario usr, int estado_baja)
        {
            //Update en la BBDD
            string query = "update dbo.administracion set estado_baja  = @estado_baja , " +
                "sucursal_id = @sucursal_id  , " +
                "usuario_id = @usuario_id  " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", adm.id);
            cmd.Parameters.AddWithValue("@estado_baja", estado_baja);
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

        public static bool bajaAdministracion(Administracion adm)
        {
            //Update en la BBDD
            string query = "update dbo.administracion set estado_baja  = @estado_baja " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", adm.id);
            cmd.Parameters.AddWithValue("@estado_baja", 1);

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
