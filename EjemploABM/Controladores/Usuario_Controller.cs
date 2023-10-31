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
            Direccion dire = new Direccion();
            Boolean log = false;
            int id_dire = 0;
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
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id_dire = reader.GetInt32(8);
                    log= true;
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            dire = Direccion_Controller.obtenerPorId(id_dire);

            query = "select * from dbo.usuario where email = @email and contrasenia = @contrasenia;";

            cmd = new SqlCommand(query, DB_Controller.connection);
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
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), dire, reader.GetInt32(9));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.close();
                Program.logueado = user;
                Cliente cliente = new Cliente();
                if (user.tipo_usuario == "S")
                {
                    Program.cli = Cliente_Controller.obtenerPorIdUsuario(user.id);
                }
                else
                {
                    Program.cli = cliente;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            return log;
        }


        // POST

        public static bool crearUsuario(Usuario usr)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.usuario values" +
               "(@nombre, " +
               "@apellido, " +
               "@dni, " +
               "@telefono, " +
               "@email, " +
               "@contrasenia, " +
               "@tipo_usuario, " +
               "@direccion_id," +
               "@estado_baja);";
            //id, nombre, apellido, dni, telefono, email, contrasenia, tipo_usuario, direccion_id, estado_baja
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", usr.nombre.ToString());
            cmd.Parameters.AddWithValue("@apellido", usr.apellido.ToString());
            cmd.Parameters.AddWithValue("@dni", usr.dni.ToString());
            cmd.Parameters.AddWithValue("@telefono", usr.telefono.ToString());
            cmd.Parameters.AddWithValue("@email", usr.email.ToString());
            cmd.Parameters.AddWithValue("@contrasenia", usr.contrasenia.ToString());
            cmd.Parameters.AddWithValue("@tipo_usuario", usr.tipo_usuario.ToString());
            cmd.Parameters.AddWithValue("@direccion_id", Int32.Parse(usr.direccion.id.ToString()));
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
            string query = "select max(id) from dbo.usuario;";

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

        public static List<Usuario> obtenerTodos()
        {
            List<Usuario> list = new List<Usuario>();
            List<int> listId = new List<int>();
            List<String> listNombre = new List<String>();
            List<String> listApellido = new List<String>();
            List<String> listDni = new List<String>();
            List<String> listTelefono = new List<String>();
            List<String> listMail = new List<String>();
            List<String> listContrasenia = new List<String>();
            List<String> listTipoUsuario = new List<String>();
            List<int> listIdDireccion = new List<int>();
            List<Direccion> listDireccion = new List<Direccion>();
            List<int> listEstadoBaja = new List<int>();
            string query = "select * from dbo.usuario;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            //id, nombre, apellido, dni, telefono, email, contrasenia, tipo_usuario, direccion_id, estado_baja
            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listNombre.Add(reader.GetString(1));
                    listApellido.Add(reader.GetString(2));
                    listDni.Add(reader.GetString(3));
                    listTelefono.Add(reader.GetString(4));
                    listMail.Add(reader.GetString(5));
                    listContrasenia.Add(reader.GetString(6));
                    listTipoUsuario.Add(reader.GetString(7));
                    listIdDireccion.Add(reader.GetInt32(8));
                    listEstadoBaja.Add(reader.GetInt32(9));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();

                for (int i = 0; i < listIdDireccion.Count; i++)
                {
                    listDireccion.Add(Direccion_Controller.obtenerPorId(listIdDireccion[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    list.Add(new Usuario(listId[i], listNombre[i], listApellido[i], listDni[i], listTelefono[i], listMail[i], listContrasenia[i], listTipoUsuario[i], listDireccion[i], listEstadoBaja[i]));
                }

                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }

        public static List<Usuario> obtenerTodosAdmCliente(Cliente cl)
        {
            List<Usuario> list = new List<Usuario>();
            List<int> listId = new List<int>();
            List<String> listNombre = new List<String>();
            List<String> listApellido = new List<String>();
            List<String> listDni = new List<String>();
            List<String> listTelefono = new List<String>();
            List<String> listMail = new List<String>();
            List<String> listContrasenia = new List<String>();
            List<String> listTipoUsuario = new List<String>();
            List<int> listIdDireccion = new List<int>();
            List<Direccion> listDireccion = new List<Direccion>();
            List<int> listEstadoBaja = new List<int>();
            string query = "select u.* from usuario u join administracion a on a.usuario_id=u.id join sucursal s on a.sucursal_id=s.id join cliente c on c.id=s.cliente_id where a.estado_baja=0 and u.tipo_usuario<>'S' and c.id=@id_cliente;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_cliente", cl.id);
            //id, nombre, apellido, dni, telefono, email, contrasenia, tipo_usuario, direccion_id, estado_baja
            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listNombre.Add(reader.GetString(1));
                    listApellido.Add(reader.GetString(2));
                    listDni.Add(reader.GetString(3));
                    listTelefono.Add(reader.GetString(4));
                    listMail.Add(reader.GetString(5));
                    listContrasenia.Add(reader.GetString(6));
                    listTipoUsuario.Add(reader.GetString(7));
                    listIdDireccion.Add(reader.GetInt32(8));
                    listEstadoBaja.Add(reader.GetInt32(9));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();

                for (int i = 0; i < listIdDireccion.Count; i++)
                {
                    listDireccion.Add(Direccion_Controller.obtenerPorId(listIdDireccion[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    list.Add(new Usuario(listId[i], listNombre[i], listApellido[i], listDni[i], listTelefono[i], listMail[i], listContrasenia[i], listTipoUsuario[i], listDireccion[i], listEstadoBaja[i]));
                }

                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }

        public static List<Usuario> obtenerTodosAdmSuc(Usuario us)
        {
            List<Usuario> list = new List<Usuario>();
            List<int> listId = new List<int>();
            List<String> listNombre = new List<String>();
            List<String> listApellido = new List<String>();
            List<String> listDni = new List<String>();
            List<String> listTelefono = new List<String>();
            List<String> listMail = new List<String>();
            List<String> listContrasenia = new List<String>();
            List<String> listTipoUsuario = new List<String>();
            List<int> listIdDireccion = new List<int>();
            List<Direccion> listDireccion = new List<Direccion>();
            List<int> listEstadoBaja = new List<int>();
            string query = "select u.* from usuario u join administracion a on a.usuario_id=u.id join sucursal s on a.sucursal_id=s.id join cliente c on c.id=s.cliente_id where a.estado_baja=0 and u.tipo_usuario<>'S' and u.tipo_usuario<>'A' and s.id in (select a.sucursal_id from usuario u join administracion a on u.id=a.usuario_id join sucursal s on s.id=a.sucursal_id where u.id=@id_usuario);";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_usuario", us.id);
            //id, nombre, apellido, dni, telefono, email, contrasenia, tipo_usuario, direccion_id, estado_baja
            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listNombre.Add(reader.GetString(1));
                    listApellido.Add(reader.GetString(2));
                    listDni.Add(reader.GetString(3));
                    listTelefono.Add(reader.GetString(4));
                    listMail.Add(reader.GetString(5));
                    listContrasenia.Add(reader.GetString(6));
                    listTipoUsuario.Add(reader.GetString(7));
                    listIdDireccion.Add(reader.GetInt32(8));
                    listEstadoBaja.Add(reader.GetInt32(9));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();

                for (int i = 0; i < listIdDireccion.Count; i++)
                {
                    listDireccion.Add(Direccion_Controller.obtenerPorId(listIdDireccion[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    list.Add(new Usuario(listId[i], listNombre[i], listApellido[i], listDni[i], listTelefono[i], listMail[i], listContrasenia[i], listTipoUsuario[i], listDireccion[i], listEstadoBaja[i]));
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

        public static Usuario obtenerPorId(int id)
        {
            Usuario usr = new Usuario();
            Direccion dire = new Direccion();
            int id_dire = 0;
            string query = "select * from dbo.usuario where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id_dire = reader.GetInt32(8);
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            dire = Direccion_Controller.obtenerPorId(id_dire);

            query = "select * from dbo.usuario where id = @id;";

            cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usr = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), dire, reader.GetInt32(9));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return usr;
        }

        public static Usuario obtenerPorMail(String mail)
        {
            Usuario usr = new Usuario();
            Direccion dire = new Direccion();
            int id_dire = 0;
            string query = "select * from dbo.usuario where email = @email;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@email", mail);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id_dire = reader.GetInt32(8);
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            dire = Direccion_Controller.obtenerPorId(id_dire);

            query = "select * from dbo.usuario where email = @email;";

            cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@email", mail);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usr = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), dire, reader.GetInt32(9));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return usr;
        }

        public static Usuario obtenerPorDni(String dni)
        {
            Usuario usr = new Usuario();
            Direccion dire = new Direccion();
            int id_dire = 0;
            string query = "select * from dbo.usuario where dni = @dni;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@dni", dni);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id_dire = reader.GetInt32(8);
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            dire = Direccion_Controller.obtenerPorId(id_dire);

            query = "select * from dbo.usuario where dni = @dni;";

            cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@dni", dni);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usr = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), dire, reader.GetInt32(9));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.close();

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

        public static bool bajaUsuario(Usuario usr)
        {
            //Darlo de alta en la BBDD

            string query = "update dbo.usuario set estado_baja = @baja " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", usr.id);
            cmd.Parameters.AddWithValue("@baja", 1);

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
