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
    class SucServ_Controller
    {
        public static bool crearServicio(SucursalServicio sucServ)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.sucursal_servicio values" +
               "(" +
               "@sucursal, " +
               "@servicio, " +
               "@tiempo_serv, " +
               "@estado " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            //cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@sucursal", sucServ.id_sucursal.id);
            cmd.Parameters.AddWithValue("@servicio", sucServ.id_subservicio.id);
            cmd.Parameters.AddWithValue("@tiempo_serv", sucServ.tiempo_servicio);
            cmd.Parameters.AddWithValue("@estado", 0);

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
            string query = "select max(id) from dbo.sucursal_servicio;";

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

        public static List<SucursalServicio> obtenerTodos(Cliente cli)
        {
            List<SucursalServicio> list = new List<SucursalServicio>();
            List<Sucursal> listSucursal = new List<Sucursal>();
            List<SubServicio> listSubServicio = new List<SubServicio>();
            List<int> listId = new List<int>();
            List<int> listTiempoServicio = new List<int>();
            List<int> listEstadoBaja = new List<int>();
            List<int> listIdSuc = new List<int>();
            List<int> listIdServ = new List<int>();

            string query = "SELECT ss.* FROM sucursal_servicio ss JOIN sucursal s ON ss.sucursal_id=s.id JOIN cliente c ON s.cliente_id=c.id where c.id=@cliente;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@cliente", cli.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listIdSuc.Add(reader.GetInt32(1));
                    listIdServ.Add(reader.GetInt32(2));
                    listTiempoServicio.Add(reader.GetInt32(3));
                    listEstadoBaja.Add(reader.GetInt32(4));
                }

                for (int i = 0; i < listIdSuc.Count; i++)
                {
                    listSucursal.Add(Sucursal_Controller.obtenerPorId(listIdSuc[i]));
                }

                for (int i = 0; i < listIdServ.Count; i++)
                {
                    listSubServicio.Add(SubServicio_Controller.obtenerPorId(listIdServ[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    SucursalServicio sucServ = new SucursalServicio(listId[i], listSucursal[i], listSubServicio[i], listTiempoServicio[i], listEstadoBaja[i]);
                    list.Add(sucServ);
                }

                Trace.WriteLine("Rubro encontrado, nombre: " + reader.GetString(1));

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }

        public static List<SucursalServicio> obtenerTodosActivos(Cliente cli)
        {
            List<SucursalServicio> list = new List<SucursalServicio>();
            List<Sucursal> listSucursal = new List<Sucursal>();
            List<SubServicio> listServicio = new List<SubServicio>();
            List<int> listId = new List<int>();
            List<int> listTiempoServicio = new List<int>();
            List<int> listEstadoBaja = new List<int>();
            List<int> listIdSuc = new List<int>();
            List<int> listIdServ = new List<int>();

            string query = "SELECT ss.* FROM sucursal_servicio ss JOIN sucursal s ON ss.sucursal_id=s.id JOIN cliente c ON s.cliente_id=c.id where c.id=@cliente and ss.estado_baja=0;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@cliente", cli.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listIdSuc.Add(reader.GetInt32(1));
                    listIdServ.Add(reader.GetInt32(2));
                    listTiempoServicio.Add(reader.GetInt32(3));
                    listEstadoBaja.Add(reader.GetInt32(4));
                }

                for (int i = 0; i < listIdSuc.Count; i++)
                {
                    listSucursal.Add(Sucursal_Controller.obtenerPorId(listIdSuc[i]));
                }

                for (int i = 0; i < listIdServ.Count; i++)
                {
                    listServicio.Add(SubServicio_Controller.obtenerPorId(listIdServ[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    SucursalServicio sucServ = new SucursalServicio(listId[i], listSucursal[i], listServicio[i], listTiempoServicio[i], listEstadoBaja[i]);
                    list.Add(sucServ);
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                return null;
            }

            return list;
        }

        public static List<SucursalServicio> obtenerTodosActivosSucursal(Sucursal suc)
        {
            List<SucursalServicio> list = new List<SucursalServicio>();
            List<Sucursal> listSucursal = new List<Sucursal>();
            List<SubServicio> listServicio = new List<SubServicio>();
            List<int> listId = new List<int>();
            List<int> listTiempoServicio = new List<int>();
            List<int> listEstadoBaja = new List<int>();
            List<int> listIdSuc = new List<int>();
            List<int> listIdServ = new List<int>();

            string query = "SELECT ss.* FROM sucursal_servicio ss JOIN sucursal s ON ss.sucursal_id=s.id JOIN cliente c ON s.cliente_id=c.id where s.id=@id and ss.estado_baja=0;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", suc.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listIdSuc.Add(reader.GetInt32(1));
                    listIdServ.Add(reader.GetInt32(2));
                    listTiempoServicio.Add(reader.GetInt32(3));
                    listEstadoBaja.Add(reader.GetInt32(4));
                }

                for (int i = 0; i < listIdSuc.Count; i++)
                {
                    listSucursal.Add(Sucursal_Controller.obtenerPorId(listIdSuc[i]));
                }

                for (int i = 0; i < listIdServ.Count; i++)
                {
                    listServicio.Add(SubServicio_Controller.obtenerPorId(listIdServ[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    SucursalServicio sucServ = new SucursalServicio(listId[i], listSucursal[i], listServicio[i], listTiempoServicio[i], listEstadoBaja[i]);
                    list.Add(sucServ);
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

        public static SucursalServicio obtenerPorId(int id)
        {
            SucursalServicio srv = new SucursalServicio();
            string query = "select * from dbo.sucursal_servicio where id = @id;";
            int idSuc = 0;
            int idServ = 0;
            int tiempoServ = 0;
            int estadoBaja = 0;
            Sucursal suc = new Sucursal();
            SubServicio serv = new SubServicio();
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id.ToString());

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    idSuc = reader.GetInt32(1);
                    idServ = reader.GetInt32(2);
                    tiempoServ = reader.GetInt32(3);
                    estadoBaja = reader.GetInt32(4);
                    Trace.WriteLine("SucServ encontrado, nombre: " + reader.GetInt32(0));
                }
                suc = Sucursal_Controller.obtenerPorId(idSuc);
                serv = SubServicio_Controller.obtenerPorId(idServ);
                srv = new SucursalServicio(id,suc,serv,tiempoServ,estadoBaja);

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return srv;
        }

        public static SucursalServicio obtenerPorSucServ(Sucursal suc, SubServicio ser)
        {
            SucursalServicio srv = new SucursalServicio();
            string query = "select * from dbo.sucursal_servicio where sucursal_id = @suc_id and subservicio_id=@ser_id;";
            int id = 0;
            int idSuc = 0;
            int idServ = 0;
            int tiempoServ = 0;
            int estadoBaja = 0;
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@suc_id", suc.id.ToString());
            cmd.Parameters.AddWithValue("@ser_id", ser.id.ToString());

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    tiempoServ = reader.GetInt32(3);
                    estadoBaja = reader.GetInt32(4);
                    Trace.WriteLine("SucServ encontrado, nombre: " + reader.GetInt32(0));
                }
                srv = new SucursalServicio(id, suc, ser, tiempoServ, estadoBaja);

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return srv;
        }



        // EDIT / PUT

        public static bool editarSucServicio(SucursalServicio srv, int minServ, int estado)
        {
            //Update en la BBDD

            string query = "update dbo.sucursal_servicio set tiempo_servicio  = @tiempo_servicio , estado_baja=@estado_baja " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", srv.id);
            cmd.Parameters.AddWithValue("@tiempo_servicio", minServ);
            cmd.Parameters.AddWithValue("@estado_baja", estado);

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

        public static bool bajaSucServicio(SucursalServicio srv, int estado)
        {
            //Update en la BBDD

            string query = "update dbo.sucursal_servicio set estado_baja=@estado_baja" +
                " where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", srv.id);
            cmd.Parameters.AddWithValue("@estado_baja", estado);

            try
            {
                DB_Controller.open();
                cmd.ExecuteNonQuery();
                DB_Controller.close();
                Atencion_Controller.bajaAtencionSucServ(srv);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }

        public static bool bajaSucServicioSuc(Sucursal suc)
        {
            //Update en la BBDD
            List<SucursalServicio> list = new List<SucursalServicio>();
            int id = 0;
            list = obtenerTodosActivosSucursal(suc);
            for (int i = 0; i < list.Count; i++)
            {
                id = list[i].id;
                Atencion_Controller.bajaAtencionSucServ(list[i]);
                string query = "update dbo.sucursal_servicio set estado_baja=@estado_baja" +
                "where id = @id ;";

                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                cmd.Parameters.AddWithValue("@id", id);
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
                    return false;
                }
            }
            return true;
        }
    }
}
