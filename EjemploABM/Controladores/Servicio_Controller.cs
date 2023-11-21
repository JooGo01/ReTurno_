﻿using EjemploABM.Modelo;
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
                throw new Exception("Hay un error en la query: " + ex.Message);
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