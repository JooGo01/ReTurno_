using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploABM.Controladores
{
    class Calendario_Controller
    {
        public static bool crearTurno(Usuario usr, Sucursal suc, DateTime fecha_ini, DateTime fecha_fin, Servicio servicio)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.turno values" +
//               "(@id, " +
               "(@id_suc, " +
               "@id_usr, " +
               "@fecha_ini, " +
               "@fecha_fin, " +
               "0, " +
               "@id_srv);";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            //cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@id_suc", suc.id);
            cmd.Parameters.AddWithValue("@id_usr", usr.id);
            cmd.Parameters.AddWithValue("@id_srv", servicio.id);
            cmd.Parameters.AddWithValue("@fecha_ini", fecha_ini.ToString("yyyyMMdd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@fecha_fin", fecha_fin.ToString("yyyyMMdd HH:mm:ss"));

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
            string query = "select max(id) from dbo.turno;";

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

        public static List<Turno> obtenerTodos()
        {
            List<Turno> list = new List<Turno>();
            List<int> listId = new List<int>();
            List<int> listIdSuc = new List<int>();
            List<int> listIdUsr = new List<int>();
            List<DateTime> listDtIni = new List<DateTime>();
            List<DateTime> listDtFin = new List<DateTime>();
            List<int> listEstado = new List<int>();
            List<int> listEstadoBaja = new List<int>();
            List<Sucursal> listSuc = new List<Sucursal>();
            List<Usuario> listUsr = new List<Usuario>();
            List<int> listIdServ = new List<int>();
            List<Servicio> listServ = new List<Servicio>();
            string query = "select * from dbo.turno;";
            //id, sucursal_id, usuario_id, fecha_ini, fecha_fin, estado, estado_baja
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listIdSuc.Add(reader.GetInt32(1));
                    listIdUsr.Add(reader.GetInt32(2));
                    listDtIni.Add(reader.GetDateTime(3));
                    listDtFin.Add(reader.GetDateTime(4));
                    listEstadoBaja.Add(reader.GetInt32(5));
                    listIdServ.Add(reader.GetInt32(6));
                    Trace.WriteLine("Turno encontrado, id: " + reader.GetInt32(0));
                }

                reader.Close();

                for (int i = 0; i < listIdSuc.Count; i++)
                {
                    listSuc.Add(Sucursal_Controller.obtenerPorId(listIdSuc[i]));
                }

                for (int i = 0; i < listIdUsr.Count; i++)
                {
                    listUsr.Add(Usuario_Controller.obtenerPorId(listIdUsr[i]));
                }

                for (int i = 0; i < listIdServ.Count; i++)
                {
                    listServ.Add(Servicio_Controller.obtenerPorId(listIdServ[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    list.Add(new Turno(listId[i], listSuc[i], listUsr[i], listDtIni[i], listDtFin[i], listEstadoBaja[i], listServ[i]));
                }

                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }

        /*public static List<Turno> obtenerPorFecha(DateTime fecha, Sucursal suc) {
            List<Turno> list = new List<Turno>();
            List<int> listId = new List<int>();
            List<int> listIdSuc = new List<int>();
            List<int> listIdUsr = new List<int>();
            List<DateTime> listDtIni = new List<DateTime>();
            List<DateTime> listDtFin = new List<DateTime>();
            List<int> listEstado = new List<int>();
            List<int> listEstadoBaja = new List<int>();
            List<Sucursal> listSuc = new List<Sucursal>();
            List<Usuario> listUsr = new List<Usuario>();
            string query = "select * from dbo.turno where sucursal_id=@suc_id and (fecha_ini >= @fecha and fecha_fin<@fecha_fin);";
            
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@fecha", fecha.ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@fecha_fin", fecha.AddDays(1).ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@suc_id", suc.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listIdSuc.Add(reader.GetInt32(1));
                    listIdUsr.Add(reader.GetInt32(2));
                    listDtIni.Add(reader.GetDateTime(3));
                    listDtFin.Add(reader.GetDateTime(4));
                    listEstadoBaja.Add(reader.GetInt32(5));
                    Trace.WriteLine("Turno encontrado, id: " + reader.GetInt32(0));
                }

                reader.Close();

                for (int i = 0; i < listIdSuc.Count; i++)
                {
                    listSuc.Add(Sucursal_Controller.obtenerPorId(listIdSuc[i]));
                }

                for (int i = 0; i < listIdUsr.Count; i++)
                {
                    listUsr.Add(Usuario_Controller.obtenerPorId(listIdUsr[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    list.Add(new Turno(listId[i], listSuc[i], listUsr[i], listDtIni[i], listDtFin[i], listEstadoBaja[i]));
                }

                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }*/

        public static List<Turno> obtenerPorFecha(DateTime fecha, Sucursal suc, Servicio ser)
        {
            List<Turno> list = new List<Turno>();
            List<int> listId = new List<int>();
            List<int> listIdSuc = new List<int>();
            List<int> listIdUsr = new List<int>();
            List<DateTime> listDtIni = new List<DateTime>();
            List<DateTime> listDtFin = new List<DateTime>();
            List<int> listEstado = new List<int>();
            List<int> listEstadoBaja = new List<int>();
            List<int> listIdServ = new List<int>();
            List<Sucursal> listSuc = new List<Sucursal>();
            List<Usuario> listUsr = new List<Usuario>();
            List<Servicio> listServ = new List<Servicio>();
            string query = "select * from dbo.turno where estado_baja=0 and sucursal_id=@suc_id and servicio_id=@ser_id and (fecha_ini >= @fecha and fecha_fin<@fecha_fin);";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@fecha", fecha.ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@fecha_fin", fecha.AddDays(1).ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@suc_id", suc.id);
            cmd.Parameters.AddWithValue("@ser_id", ser.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listIdSuc.Add(reader.GetInt32(1));
                    listIdUsr.Add(reader.GetInt32(2));
                    listDtIni.Add(reader.GetDateTime(3));
                    listDtFin.Add(reader.GetDateTime(4));
                    listEstadoBaja.Add(reader.GetInt32(5));
                    listIdServ.Add(reader.GetInt32(6));
                    Trace.WriteLine("Turno encontrado, id: " + reader.GetInt32(0));
                }

                reader.Close();

                for (int i = 0; i < listIdSuc.Count; i++)
                {
                    listSuc.Add(Sucursal_Controller.obtenerPorId(listIdSuc[i]));
                }

                for (int i = 0; i < listIdUsr.Count; i++)
                {
                    listUsr.Add(Usuario_Controller.obtenerPorId(listIdUsr[i]));
                }

                for(int i=0; i<listIdServ.Count; i++)
                {
                    listServ.Add(Servicio_Controller.obtenerPorId(listIdServ[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    list.Add(new Turno(listId[i], listSuc[i], listUsr[i], listDtIni[i], listDtFin[i], listEstadoBaja[i], listServ[i]));
                }

                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }



        // GET ONE BY ID

        public static Turno obtenerPorId(int id)
        {
            Turno trn = new Turno();
            int suc_id=0;
            int usr_id=0;
            int srv_id = 0;
            Sucursal suc = new Sucursal();
            Usuario usr = new Usuario();
            Servicio servicio = new Servicio();
            string query = "select * from dbo.turno where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    suc_id = reader.GetInt32(1);
                    usr_id = reader.GetInt32(2);
                    srv_id=reader.GetInt32(6);
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetInt32(1));
                }

                reader.Close();
                DB_Controller.close();

                suc = Sucursal_Controller.obtenerPorId(suc_id);
                usr = Usuario_Controller.obtenerPorId(usr_id);
                servicio=Servicio_Controller.obtenerPorId(srv_id);

                DB_Controller.open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    trn = new Turno(reader.GetInt32(0), suc, usr, reader.GetDateTime(3), reader.GetDateTime(4), reader.GetInt32(5), servicio);
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetInt32(0));
                }

                reader.Close();

                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return trn;
        }

        public static Boolean obtenerPorFecha(DateTime dt_ini, DateTime dt_fin, Sucursal suc)
        {
            int cantidadTurnos = 0;
            Boolean boolTurno = false;
            string query = "select * from dbo.turno where estado_baja=0 and sucursal_id=@suc and ((fecha_ini >= @fecha and fecha_ini<@fecha_fin) or ( fecha_ini >= @fecha and fecha_fin<@fecha_fin) or (fecha_fin >= @fecha and fecha_fin<@fecha_fin));";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@fecha", dt_ini.ToString("yyyyMMdd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@fecha_fin", dt_fin.ToString("yyyyMMdd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@suc", suc.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cantidadTurnos = cantidadTurnos + 1;
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            if (cantidadTurnos > 0)
            {
                boolTurno = true;
            }else {
                boolTurno = false;
            }

            return boolTurno;
        }

        public static Boolean obtenerPorFechaCambio(DateTime dt_ini, DateTime dt_fin, Sucursal suc)
        {
            int cantidadTurnos = 0;
            Boolean boolTurno = false;
            string query = "select * from dbo.turno where estado_baja=0 and sucursal_id<>@suc and ((fecha_ini >= @fecha and fecha_ini<@fecha_fin) or ( fecha_ini >= @fecha and fecha_fin<@fecha_fin) or (fecha_fin >= @fecha and fecha_fin<@fecha_fin));";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@fecha", dt_ini.ToString("yyyyMMdd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@fecha_fin", dt_fin.ToString("yyyyMMdd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@suc", suc.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cantidadTurnos = cantidadTurnos + 1;
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            if (cantidadTurnos > 0)
            {
                boolTurno = true;
            }
            else
            {
                boolTurno = false;
            }

            return boolTurno;
        }



        // EDIT / PUT

        public static bool editarTurno(Turno trn, Usuario usr, Sucursal suc, DateTime dt_ini, DateTime dt_fin, int estado_baja)
        {
            //Darlo de alta en la BBDD

            string query = "update dbo.turno set sucursal_id  = @sucursal , " +
                "usuario_id  = @usuario , " +
                "fecha_ini  = @fecha_ini  , " +
                "fecha_fin  = @fecha_fin , " +
                "estado_baja  = @estado_baja " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", trn.id);
            cmd.Parameters.AddWithValue("@sucursal", suc.id);
            cmd.Parameters.AddWithValue("@usuario", usr.id);
            cmd.Parameters.AddWithValue("@fecha_ini", dt_ini);
            cmd.Parameters.AddWithValue("@fecha_fin", dt_fin);
            cmd.Parameters.AddWithValue("@estado_baja", estado_baja);

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

        public static bool bajarTurno(int id)
        {
            //Darlo de alta en la BBDD

            string query = "update dbo.turno set estado_baja  = @estado_baja " +
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
            }

        }

        public static List<DateTime> obtenerListadoActividad(DateTime dt_ini, DateTime dt_fin, Sucursal suc)
        {
            int cantidadTurnos = 0;
            Boolean boolTurno = false;
            DateTime dt_ini_data = DateTime.Now;
            List<DateTime> fecha = new List<DateTime>();
            string query = "select cast(fecha_ini as date) as fecha, count(*) as cantidad from turno where sucursal_id=@suc and ( fecha_ini >= @fecha and fecha_fin<=@fecha_fin) GROUP BY CAST(fecha_ini AS DATE) order by fecha;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@fecha", dt_ini.ToString("yyyyMMdd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@fecha_fin", dt_fin.ToString("yyyyMMdd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@suc", suc.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dt_ini_data = reader.GetDateTime(0);
                    fecha.Add(dt_ini_data);
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return fecha;
        }

        public static List<int> obtenerListadoCantActividad(DateTime dt_ini, DateTime dt_fin, Sucursal suc)
        {
            int cantidadTurnos = 0;
            Boolean boolTurno = false;
            DateTime dt_ini_data = DateTime.Now;
            List<int> cantidad = new List<int>();
            string query = "select cast(fecha_ini as date) as fecha, count(*) as cantidad from turno where sucursal_id=@suc and ( fecha_ini >= @fecha and fecha_fin<=@fecha_fin) GROUP BY CAST(fecha_ini AS DATE) order by fecha;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@fecha", dt_ini.ToString("yyyyMMdd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@fecha_fin", dt_fin.ToString("yyyyMMdd HH:mm:ss"));
            cmd.Parameters.AddWithValue("@suc", suc.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cantidadTurnos = reader.GetInt32(1);
                    cantidad.Add(cantidadTurnos);
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return cantidad;
        }
    }
}
