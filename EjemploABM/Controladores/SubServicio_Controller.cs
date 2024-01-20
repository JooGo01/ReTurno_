using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Controladores
{
    class SubServicio_Controller
    {
        public static bool crearServicio(SubServicio sbServ)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.subservicio values" +
               "(" +
               "@nombre_servicio," +
               "@servicio_id" + 
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            //cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@nombre_servicio", sbServ.nombre_servicio.ToString());
            cmd.Parameters.AddWithValue("@servicio_id", sbServ.id_servicio.id.ToString());

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
            string query = "select max(id) from dbo.subservicio;";

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

        public static List<SubServicio> obtenerTodos()
        {
            List<SubServicio> list = new List<SubServicio>();
            List<int> listSubServId = new List<int>();
            List<int> listServId = new List<int>();
            List<String> listSubServNombre = new List<String>();
            List<Servicio> listServ = new List<Servicio>();
            Servicio serv = new Servicio();
            string query = "select * from dbo.subservicio;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listSubServId.Add(reader.GetInt32(0));
                    listSubServNombre.Add(reader.GetString(1));
                    listServId.Add(reader.GetInt32(2));
                    Trace.WriteLine("SubServicio encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();

                for (int i = 0; i < listServId.Count; i++)
                {
                    serv = Servicio_Controller.obtenerPorId(listServId[i]);
                    listServ.Add(serv);
                }

                for (int i = 0; i < listServId.Count; i++)
                {
                    list.Add(new SubServicio(listSubServId[i], listSubServNombre[i], listServ[i]));
                }

                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }

        public static List<SubServicio> obtenerTodosSubServiciosServicio(Servicio serv)
        {
            List<SubServicio> list = new List<SubServicio>();
            SubServicio sbServ = new SubServicio();
            List<int> listIdSbServ = new List<int>();
            string query = "select ss.id from subservicio ss join servicio se on ss.servicio_id=se.id where se.id=@id_srv;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_srv", serv.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listIdSbServ.Add(reader.GetInt32(0));
                    Trace.WriteLine("Rubro encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();

                for (int i = 0; i < listIdSbServ.Count; i++)
                {
                    sbServ = SubServicio_Controller.obtenerPorId(listIdSbServ[i]);
                    list.Add(sbServ);
                }

                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }

        public static List<SubServicio> obtenerTodosSubServiciosCliente(Cliente cli)
        {
            List<SubServicio> list = new List<SubServicio>();
            SubServicio sbServ = new SubServicio();
            List<int> listIdSubServ = new List<int>();
            string query = "select sbs.id from sucursal s join sucursal_servicio ss on ss.sucursal_id=s.id join subservicio sbs on sbs.id=ss.subservicio_id join servicio se on sbs.servicio_id=se.id join cliente c on s.cliente_id=c.id where c.id=@id_cli;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_cli", cli.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listIdSubServ.Add(reader.GetInt32(0));
                    Trace.WriteLine("Id subservicio encontrado, id: " + reader.GetInt32(0));
                }

                for (int i = 0; i < listIdSubServ.Count; i++)
                {
                    sbServ = obtenerPorId(listIdSubServ[i]);
                    list.Add(sbServ);
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

        public static List<SubServicio> obtenerTodosSubServiciosSucursalServicio(Servicio serv, Sucursal suc)
        {
            List<SubServicio> list = new List<SubServicio>();
            SubServicio sbServ = new SubServicio();
            List<int> listIdSubServ = new List<int>();
            string query = "select sb.id from sucursal_servicio ss join subservicio sb on sb.id=ss.subservicio_id join servicio s on sb.servicio_id=s.id where ss.sucursal_id=@id_suc and s.id=@id_serv;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_serv", serv.id);
            cmd.Parameters.AddWithValue("@id_suc", suc.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listIdSubServ.Add(reader.GetInt32(0));
                    Trace.WriteLine("Id subservicio encontrado, id: " + reader.GetInt32(0));
                }

                for (int i = 0; i < listIdSubServ.Count; i++)
                {
                    sbServ = obtenerPorId(listIdSubServ[i]);
                    list.Add(sbServ);
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

        public static SubServicio obtenerPorId(int id)
        {
            SubServicio sbsrv = new SubServicio();
            Servicio serv = new Servicio();
            int id_sbsrv=0;
            int id_srv=0;
            String nombre_sbsrv="";
            string query = "select * from dbo.subservicio where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id_sbsrv = reader.GetInt32(0);
                    nombre_sbsrv = reader.GetString(1);
                    id_srv = reader.GetInt32(2);
                    Trace.WriteLine("SubServicio encontrado, nombre: " + nombre_sbsrv);
                }
                reader.Close();
                if (id_srv > 0)
                {
                    serv = Servicio_Controller.obtenerPorId(id_srv);
                    sbsrv = new SubServicio(id_sbsrv, nombre_sbsrv, serv);
                }
                DB_Controller.close();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return sbsrv;
        }

        public static SubServicio obtenerPorNombre(String nom_ser)
        {
            SubServicio sbsrv = new SubServicio();
            Servicio serv = new Servicio();
            int id_sbsrv = 0;
            int id_srv = 0;
            String nombre_sbsrv = "";

            string query = "select * from dbo.subservicio where lower(nombre_servicio) = @nombre;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", nom_ser);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id_sbsrv = reader.GetInt32(0);
                    nombre_sbsrv = reader.GetString(1);
                    id_srv = reader.GetInt32(2);
                    Trace.WriteLine("SubServicio encontrado, nombre: " + nombre_sbsrv);
                }
                reader.Close();
                if (id_srv > 0)
                {
                    serv = Servicio_Controller.obtenerPorId(id_srv);
                    sbsrv = new SubServicio(id_sbsrv, nombre_sbsrv, serv);
                }
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                return null;
            }

            return sbsrv;
        }



        // EDIT / PUT

        public static bool editarSubServicio(Servicio sbsrv, String nombre)
        {
            //Update en la BBDD

            string query = "update dbo.subservicio set nombre_servicio  = @nombre_servicio , " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", sbsrv.id);
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
