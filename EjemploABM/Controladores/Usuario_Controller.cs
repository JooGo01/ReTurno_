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
        //id, nombre, apellido, dni, telefono, email, contrasenia, tipo_usuario, direccion_id, estado_baja
        public static bool autenticar(string mail, string pass, bool hasheado)
        {
            Usuario user = new Usuario();
            string query = "select * from dbo.usuario where email = @email and contrasenia = @contrasenia;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@email", mail);
            if (hasheado)
            {
                cmd.Parameters.AddWithValue("@contrasenia", pass);
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
                    //id, nombre, apellido, dni, telefono, email, contrasenia, tipo_usuario, direccion_id, estado_baja
                    user = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), Direccion_Controller.obtenerPorId(reader.GetInt32(8)), reader.GetInt32(9));
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
               "@nombre, " +
               "@apellido, " +
               "@dni, " +
               "@telefono, " +
               "@email, " +
               "@contrasenia, " +
               "@tipo_usuario, " +
               "@direccion_id);";
            //id, nombre, apellido, dni, telefono, email, contrasenia, tipo_usuario, direccion_id, estado_baja
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@nombre", usr.nombre);
            cmd.Parameters.AddWithValue("@apellido", usr.apellido);
            cmd.Parameters.AddWithValue("@dni", usr.dni);
            cmd.Parameters.AddWithValue("@telefono", usr.telefono);
            cmd.Parameters.AddWithValue("@email", usr.email);
            cmd.Parameters.AddWithValue("@contrasenia", usr.contrasenia);
            cmd.Parameters.AddWithValue("@tipo_usuario", usr.tipo_usuario);
            cmd.Parameters.AddWithValue("@direccion_id", usr.direccion.id);

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
                    list.Add(new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), Direccion_Controller.obtenerPorId(reader.GetInt32(8)), reader.GetInt32(9)));
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
                    usr = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), Direccion_Controller.obtenerPorId(reader.GetInt32(8)), reader.GetInt32(9));
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

            string query = "update dbo.usuario set apellido = @apellido , " +
                "nombre = @nombre , " +
                "dni = @dni , " +
                "email = @email " +
                "telefono = @telefono , " +
                "contrasenia = @contrasenia , " +
                "tipo_usuario = @tipo_usuario " +
                "direccion_id = @direccion_id , " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", usr.id);
            cmd.Parameters.AddWithValue("@nombre", usr.nombre);
            cmd.Parameters.AddWithValue("@apellido", usr.apellido);
            cmd.Parameters.AddWithValue("@dni", usr.dni);
            cmd.Parameters.AddWithValue("@telefono", usr.telefono);
            cmd.Parameters.AddWithValue("@email", usr.email);
            cmd.Parameters.AddWithValue("@contrasenia", usr.contrasenia);
            cmd.Parameters.AddWithValue("@tipo_usuario", usr.tipo_usuario);
            cmd.Parameters.AddWithValue("@direccion_id", usr.direccion.id);

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
