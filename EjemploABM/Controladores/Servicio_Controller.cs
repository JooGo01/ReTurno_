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
    class Servicio_Controller
    {
        public static bool crearServicio(Servicio serv)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.servicio values" +
               "(" +
               "@nombre_servicio" +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            //cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@nombre_servicio", serv.nombre_servicio.ToString());

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
            string query = "select max(id) from dbo.servicio;";

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
                return MaxId;
            }
        }


        // GET ALL

        public static List<Servicio> obtenerTodos()
        {
            List<Servicio> list = new List<Servicio>();
            string query = "select * from dbo.servicio;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Servicio(reader.GetInt32(0), reader.GetString(1)));
                    Trace.WriteLine("Rubro encontrado, nombre: " + reader.GetString(1));
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

        public static List<Servicio> obtenerTodosServiciosSucursal(Sucursal suc)
        {
            List<Servicio> list = new List<Servicio>();
            Servicio serv = new Servicio();
            List<int> listIdServ = new List<int>();
            string query = "select se.id from sucursal s join sucursal_servicio ss on ss.sucursal_id=s.id join servicio se on ss.servicio_id=se.id where s.id=@id_suc;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_suc", suc.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listIdServ.Add(reader.GetInt32(0));
                    Trace.WriteLine("Rubro encontrado, nombre: " + reader.GetString(1));
                }

                for (int i = 0; i < listIdServ.Count; i++) {
                    serv = Servicio_Controller.obtenerPorId(listIdServ[i]);
                    list.Add(serv);
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

        public static List<Servicio> obtenerTodosServiciosCliente(Cliente cli)
        {
            List<Servicio> list = new List<Servicio>();
            Servicio serv = new Servicio();
            List<int> listIdServ = new List<int>();
            string query = "select se.id from sucursal s join sucursal_servicio ss on ss.sucursal_id=s.id join servicio se on ss.servicio_id=se.id join cliente c on s.cliente_id=c.id where c.id=@id_cli;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_cli", cli.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listIdServ.Add(reader.GetInt32(0));
                    Trace.WriteLine("Rubro encontrado, nombre: " + reader.GetString(1));
                }

                for (int i = 0; i < listIdServ.Count; i++)
                {
                    serv = obtenerPorId(listIdServ[i]);
                    list.Add(serv);
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                list = null;
            }

            return list;
        }



        // GET ONE BY ID

        public static Servicio obtenerPorId(int id)
        {
            Servicio srv = new Servicio();
            string query = "select * from dbo.servicio where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    srv = new Servicio(reader.GetInt32(0), reader.GetString(1));
                    Trace.WriteLine("Rubro encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return srv;
        }

        public static Servicio obtenerPorNombre(String nom_ser)
        {
            Servicio srv = new Servicio();
            string query = "select * from dbo.servicio where lcase(nombre_servicio) = @nombre;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", nom_ser);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    srv = new Servicio(reader.GetInt32(0), reader.GetString(1));
                    Trace.WriteLine("Rubro encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                return null;
            }

            return srv;
        }



        // EDIT / PUT

        public static bool editarServicio(Servicio srv, String nombre)
        {
            //Update en la BBDD

            string query = "update dbo.servicio set nombre_servicio  = @nombre_servicio , " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", srv.id);
            cmd.Parameters.AddWithValue("@nombre_servicio", nombre);

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
