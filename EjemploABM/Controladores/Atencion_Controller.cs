﻿using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Controladores
{
    class Atencion_Controller
    {
        public static bool crearAtencion(Atencion atencion)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.atencion values" +
               "(" +
               "@dia_id, " +
               "@suc_serv, " +
               "@hora_apertura, " +
               "@hora_cierre, " +
               "@personal, " +
               "@estado " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            //cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@dia_id", atencion.dia_id.id);
            cmd.Parameters.AddWithValue("@suc_serv", atencion.sucursal_servicio_id.id);
            cmd.Parameters.AddWithValue("@hora_apertura", atencion.hora_apertura);
            cmd.Parameters.AddWithValue("@hora_cierre", atencion.hora_cierre);
            cmd.Parameters.AddWithValue("@personal", atencion.personal_servicio);
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
            string query = "select max(id) from dbo.atencion;";

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

        public static List<Atencion> obtenerTodos(Cliente cli)
        {
            List<Atencion> list = new List<Atencion>();
            List<SucursalServicio> listSucServ = new List<SucursalServicio>();
            List<Dia> listDia = new List<Dia>();
            List<int> listId = new List<int>();
            List<int> listSucServId = new List<int>();
            List<int> listDiaId= new List<int>();
            List<int> listHoraIni = new List<int>();
            List<int> listHoraFin = new List<int>();
            List<int> listPersonal = new List<int>();
            List<int> listEstado = new List<int>();

            string query = "SELECT a.* FROM atencion a JOIN sucursal_servicio ss ON a.sucursal_servicio_id=ss.id JOIN sucursal s ON ss.sucursal_id=s.id JOIN cliente c ON s.cliente_id=c.id where c.id=@cliente;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@cliente", cli.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listDiaId.Add(reader.GetInt32(1));
                    listSucServId.Add(reader.GetInt32(2));
                    listHoraIni.Add(reader.GetInt32(3));
                    listHoraFin.Add(reader.GetInt32(4));
                    listPersonal.Add(reader.GetInt32(5));
                    listEstado.Add(reader.GetInt32(5));
                }

                for (int i = 0; i < listSucServId.Count; i++)
                {
                    listSucServ.Add(SucServ_Controller.obtenerPorId(listSucServId[i]));
                }

                for (int i = 0; i < listDiaId.Count; i++)
                {
                    listDia.Add(Dia_Contoller.obtenerPorId(listDiaId[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    Atencion atencion = new Atencion(listId[i], listDia[i], listSucServ[i], listHoraIni[i], listHoraFin[i], listPersonal[i], listEstado[i]);
                    list.Add(atencion);
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

        public static List<Atencion> obtenerTodosSuc(Sucursal suc)
        {
            List<Atencion> list = new List<Atencion>();
            List<SucursalServicio> listSucServ = new List<SucursalServicio>();
            List<Dia> listDia = new List<Dia>();
            List<int> listId = new List<int>();
            List<int> listSucServId = new List<int>();
            List<int> listDiaId = new List<int>();
            List<int> listHoraIni = new List<int>();
            List<int> listHoraFin = new List<int>();
            List<int> listPersonal = new List<int>();
            List<int> listEstado = new List<int>();

            string query = "SELECT a.* FROM atencion a JOIN sucursal_servicio ss ON a.sucursal_servicio_id=ss.id JOIN sucursal s ON ss.sucursal_id=s.id JOIN cliente c ON s.cliente_id=c.id where ss.sucursal_id=@sucursal_id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@sucursal_id", suc.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listDiaId.Add(reader.GetInt32(1));
                    listSucServId.Add(reader.GetInt32(2));
                    listHoraIni.Add(reader.GetInt32(3));
                    listHoraFin.Add(reader.GetInt32(4));
                    listPersonal.Add(reader.GetInt32(5));
                    listEstado.Add(reader.GetInt32(5));
                }

                for (int i = 0; i < listSucServId.Count; i++)
                {
                    listSucServ.Add(SucServ_Controller.obtenerPorId(listSucServId[i]));
                }

                for (int i = 0; i < listDiaId.Count; i++)
                {
                    listDia.Add(Dia_Contoller.obtenerPorId(listDiaId[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    Atencion atencion = new Atencion(listId[i], listDia[i], listSucServ[i], listHoraIni[i], listHoraFin[i], listPersonal[i], listEstado[i]);
                    list.Add(atencion);
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

        public static List<Atencion> obtenerTodosSucSer(Sucursal suc, SubServicio ser, Dia dia)
        {
            List<Atencion> list = new List<Atencion>();
            List<SucursalServicio> listSucServ = new List<SucursalServicio>();
            List<Dia> listDia = new List<Dia>();
            List<int> listId = new List<int>();
            List<int> listSucServId = new List<int>();
            List<int> listDiaId = new List<int>();
            List<int> listHoraIni = new List<int>();
            List<int> listHoraFin = new List<int>();
            List<int> listPersonal = new List<int>();
            List<int> listEstado = new List<int>();

            string query = "SELECT a.* FROM atencion a JOIN sucursal_servicio ss ON a.sucursal_servicio_id=ss.id JOIN sucursal s ON ss.sucursal_id=s.id JOIN cliente c ON s.cliente_id=c.id where ss.sucursal_id=@sucursal_id and ss.subservicio_id=@subservicio_id and a.dia_id=@dia_id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@sucursal_id", suc.id);
            cmd.Parameters.AddWithValue("@subservicio_id", ser.id);
            cmd.Parameters.AddWithValue("@dia_id", dia.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listDiaId.Add(reader.GetInt32(1));
                    listSucServId.Add(reader.GetInt32(2));
                    listHoraIni.Add(reader.GetInt32(3));
                    listHoraFin.Add(reader.GetInt32(4));
                    listPersonal.Add(reader.GetInt32(5));
                    listEstado.Add(reader.GetInt32(5));
                }

                for (int i = 0; i < listSucServId.Count; i++)
                {
                    listSucServ.Add(SucServ_Controller.obtenerPorId(listSucServId[i]));
                }

                for (int i = 0; i < listDiaId.Count; i++)
                {
                    listDia.Add(Dia_Contoller.obtenerPorId(listDiaId[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    Atencion atencion = new Atencion(listId[i], listDia[i], listSucServ[i], listHoraIni[i], listHoraFin[i], listPersonal[i], listEstado[i]);
                    list.Add(atencion);
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

        public static List<Atencion> obtenerTodosActivos(Cliente cli)
        {
            List<Atencion> list = new List<Atencion>();
            List<SucursalServicio> listSucServ = new List<SucursalServicio>();
            List<Dia> listDia = new List<Dia>();
            List<int> listId = new List<int>();
            List<int> listSucServId = new List<int>();
            List<int> listDiaId = new List<int>();
            List<int> listHoraIni = new List<int>();
            List<int> listHoraFin = new List<int>();
            List<int> listPersonal = new List<int>();
            List<int> listEstado = new List<int>();

            string query = "SELECT a.* FROM atencion a JOIN sucursal_servicio ss ON a.sucursal_servicio_id=ss.id JOIN sucursal s ON ss.sucursal_id=s.id JOIN cliente c ON s.cliente_id=c.id where c.id=@cliente AND ss.estado_baja=0 and a.estado_baja=0;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@cliente", cli.id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listDiaId.Add(reader.GetInt32(1));
                    listSucServId.Add(reader.GetInt32(2));
                    listHoraIni.Add(reader.GetInt32(3));
                    listHoraFin.Add(reader.GetInt32(4));
                    listPersonal.Add(reader.GetInt32(5));
                    listEstado.Add(reader.GetInt32(6));
                }

                for (int i = 0; i < listSucServId.Count; i++)
                {
                    listSucServ.Add(SucServ_Controller.obtenerPorId(listSucServId[i]));
                }

                for (int i = 0; i < listDiaId.Count; i++)
                {
                    listDia.Add(Dia_Contoller.obtenerPorId(listDiaId[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    Atencion atencion = new Atencion(listId[i], listDia[i], listSucServ[i], listHoraIni[i], listHoraFin[i], listPersonal[i], listEstado[i]);
                    list.Add(atencion);
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

        public static Atencion obtenerPorId(int id)
        {
            Atencion atencion = new Atencion();
            string query = "select * from dbo.atencion where id = @id;";
            SucursalServicio sucServ = new SucursalServicio();
            Dia dia = new Dia();
            int sucServId = 0;
            int diaId = 0;
            int horaIni = 0;
            int horaFin = 0;
            int personal = 0;
            int estadoBaja = 0;

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    diaId=reader.GetInt32(1);
                    sucServId=reader.GetInt32(2);
                    horaIni=reader.GetInt32(3);
                    horaFin=reader.GetInt32(4);
                    personal= reader.GetInt32(5);
                    estadoBaja= reader.GetInt32(6);
                    Trace.WriteLine("Atencion encontrado, id: " + reader.GetInt32(0));
                }
                sucServ = SucServ_Controller.obtenerPorId(sucServId);
                dia = Dia_Contoller.obtenerPorId(diaId);
                atencion = new Atencion(id, dia, sucServ, horaIni, horaFin, personal, estadoBaja);

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return atencion;
        }

        public static List<Atencion> obtenerPorDatos(Sucursal suc, Dia dia, SubServicio ser, int hora_ini, int hora_fin)
        {
            List<Atencion> listAtencion = new List<Atencion>();
            List<int> idAtencion= new List<int>();
            Atencion atencion = new Atencion();
            string query = "select * from dbo.atencion a join sucursal_servicio s on s.id=a.sucursal_servicio_id where a.dia_id=@dia_id and s.sucursal_id=@suc_id and s.servicio_id=@sev_id and (a.hora_apertura>=@hora_apertura and a.hora_cierre<=@hora_cierre);";
            int id = 0;

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@dia_id ", dia.id);
            cmd.Parameters.AddWithValue("@suc_id ", suc.id);
            cmd.Parameters.AddWithValue("@sev_id ", ser.id);
            cmd.Parameters.AddWithValue("@hora_apertura ", hora_ini);
            cmd.Parameters.AddWithValue("@hora_cierre", hora_fin);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    idAtencion.Add(id);
                }
                for (int i = 0; i < idAtencion.Count; i++)
                {
                    atencion = obtenerPorId(idAtencion[i]);
                    listAtencion.Add(atencion);
                }
                

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                //throw new Exception("Hay un error en la query: " + ex.Message);
                listAtencion = null;
            }

            return listAtencion;
        }


        // EDIT / PUT

        public static bool editarAtencion(Atencion atencion, int hora_ini, int hora_fin, int personal, int estado)
        {
            //Update en la BBDD

            string query = "update dbo.atencion set hora_apertura  = @hora_apertura, hora_cierre=@hora_cierre, personal_servicio=@personal, estado_baja=@estado_baja " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", atencion.id);
            cmd.Parameters.AddWithValue("@hora_apertura", hora_ini);
            cmd.Parameters.AddWithValue("@hora_cierre", hora_fin);
            cmd.Parameters.AddWithValue("@personal", personal);
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

        public static bool bajaAtencionSucServ(SucursalServicio sucServ)
        {
            //Update en la BBDD

            string query = "update dbo.atencion set estado_baja=1" +
                " where sucursal_servicio_id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", sucServ.id.ToString());

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

        public static bool bajaAtencion(Atencion atencion)
        {
            //Update en la BBDD

            string query = "update dbo.atencion set estado_baja=1" +
                " where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", atencion.id.ToString());

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
