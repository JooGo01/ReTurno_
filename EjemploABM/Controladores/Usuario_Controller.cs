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
    class Usuario_Controller
    {

        // GET ONE

        public static bool autenticar(string usr, string pass, bool hasheado)
        {
            Usuario user = new Usuario();
            string query = "select * from dbo.usuario where username = @usr and password = @pass;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@usr", usr);
            if (hasheado)
            {
                cmd.Parameters.AddWithValue("@pass", pass);
            }
            else
            {
                //cmd.Parameters.AddWithValue("@pass", hc.PassHash(pass));
            }

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                    user = new Usuario(reader.GetInt32(0), reader.GetString(1), "", reader.GetString(3), reader.GetString(4), reader.GetInt32(5));
                }

                reader.Close();
                DB_Controller.connection.Close();
                Program.logueado = user;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }


        // POST

        public static bool crearUsuario(Usuario usr)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.usuario values" +
               "(@id, " +
               "@username, " +
               "@password, " +
               "@name, " +
               "@lastname, " +
               "@rol);";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@username", usr.usuario);
            cmd.Parameters.AddWithValue("@password", usr.Contraseña);
            cmd.Parameters.AddWithValue("@name", usr.Nombre);
            cmd.Parameters.AddWithValue("@lastname", usr.Apellido);
            cmd.Parameters.AddWithValue("@rol", usr.Id_tipo);

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
            string query = "select max(id) from dbo.usuario;";

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

        public static List<Usuario> obtenerTodos()
        {
            List<Usuario> list = new List<Usuario>();
            string query = "select * from dbo.usuario;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Usuario(reader.GetInt32(0), reader.GetString(1), "", reader.GetString(3), reader.GetString(4), reader.GetInt32(5)));
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

        public static Usuario obtenerPorId(int id)
        {
            Usuario usr = new Usuario();
            string query = "select * from dbo.usuario where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usr = new Usuario(reader.GetInt32(0), reader.GetString(1), "", reader.GetString(3), reader.GetString(4), reader.GetInt32(5));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return usr;
        }



        // EDIT / PUT

        public static bool editarUsuario(Usuario usr)
        {
            //Darlo de alta en la BBDD

            string query = "update dbo.usuario set username = @username , " +
                "name = @name , " +
                "lastname = @lastname , " +
                "rol = @rol " + 
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", usr.Id);
            cmd.Parameters.AddWithValue("@username", usr.usuario);
            cmd.Parameters.AddWithValue("@name", usr.Nombre);
            cmd.Parameters.AddWithValue("@lastname", usr.Apellido);
            cmd.Parameters.AddWithValue("@rol", usr.Id_tipo);

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
