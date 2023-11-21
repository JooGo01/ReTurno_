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
    class Sucursal_Controller
    {
        public static bool crearSucursal(Sucursal suc)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.sucursal values" +
               "(@cliente_id , " +
               "@direccion_id, " +
               "@telefono, " +
               "@estado_baja);";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@cliente_id", Int32.Parse(suc.cliente.id.ToString()));
            cmd.Parameters.AddWithValue("@direccion_id", Int32.Parse(suc.direccion.id.ToString()));
            cmd.Parameters.AddWithValue("@telefono", suc.telefono.ToString());
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
            string query = "select max(id) from dbo.sucursal;";

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

        public static List<Sucursal> obtenerTodos()
        {
            List<Sucursal> list = new List<Sucursal>();
            List<int> listId = new List<int>();
            List<int> listIdCliente = new List<int>();
            List<int> listIdDireccion = new List<int>();
            List<String> listTelefono = new List<String>();
            List<int> listEstadoBaja = new List<int>();
            List<Cliente> listCliente = new List<Cliente>();
            List<Direccion> listDireccion = new List<Direccion>();
            string query = "select * from dbo.sucursal;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            
            // id, cliente_id, direccion_id, telefono, estado_baja
            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listIdCliente.Add(reader.GetInt32(1));
                    listIdDireccion.Add(reader.GetInt32(2));
                    listTelefono.Add(reader.GetString(3));
                    listEstadoBaja.Add(reader.GetInt32(4));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                //list.Add(new Sucursal(reader.GetInt32(0), Cliente_Controller.obtenerPorId(reader.GetInt32(1)), Direccion_Controller.obtenerPorId(reader.GetInt32(2)), reader.GetInt32(3), reader.GetInt32(4)));

                reader.Close();

                for (int i = 0; i < listIdCliente.Count; i++)
                {
                    listCliente.Add(Cliente_Controller.obtenerPorId(listIdCliente[i]));
                }

                for (int i = 0; i < listIdDireccion.Count; i++)
                {
                    listDireccion.Add(Direccion_Controller.obtenerPorId(listIdDireccion[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    list.Add(new Sucursal(listId[i], listCliente[i], listDireccion[i], listTelefono[i], listEstadoBaja[i]));
                }

                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }

        public static List<Sucursal> obtenerTodosSucCliente(Cliente cli)
        {
            List<Sucursal> list = new List<Sucursal>();
            List<int> listId = new List<int>();
            List<int> listIdCliente = new List<int>();
            List<int> listIdDireccion = new List<int>();
            List<String> listTelefono = new List<String>();
            List<int> listEstadoBaja = new List<int>();
            List<Cliente> listCliente = new List<Cliente>();
            List<Direccion> listDireccion = new List<Direccion>();
            string query = "select * from dbo.sucursal where cliente_id=@id_cliente and estado_baja=0;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_cliente", cli.id);
            // id, cliente_id, direccion_id, telefono, estado_baja
            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listIdCliente.Add(reader.GetInt32(1));
                    listIdDireccion.Add(reader.GetInt32(2));
                    listTelefono.Add(reader.GetString(3));
                    listEstadoBaja.Add(reader.GetInt32(4));
                    Trace.WriteLine("Sucursal encontrada, id: " + reader.GetInt32(0));
                }

                //list.Add(new Sucursal(reader.GetInt32(0), Cliente_Controller.obtenerPorId(reader.GetInt32(1)), Direccion_Controller.obtenerPorId(reader.GetInt32(2)), reader.GetInt32(3), reader.GetInt32(4)));

                reader.Close();

                for (int i = 0; i < listIdCliente.Count; i++)
                {
                    listCliente.Add(Cliente_Controller.obtenerPorId(listIdCliente[i]));
                }

                for (int i = 0; i < listIdDireccion.Count; i++)
                {
                    listDireccion.Add(Direccion_Controller.obtenerPorId(listIdDireccion[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    list.Add(new Sucursal(listId[i], listCliente[i], listDireccion[i], listTelefono[i], listEstadoBaja[i]));
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

        public static Sucursal obtenerPorId(int id)
        {
            Sucursal suc = new Sucursal();
            Cliente cli = new Cliente();
            Direccion dire = new Direccion();
            int id_cli = 0;
            int id_dire = 0;
            string query = "select * from dbo.sucursal where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id_cli = reader.GetInt32(1);
                    id_dire = reader.GetInt32(2);
                    Trace.WriteLine("Sucursal encontrado, id: " + reader.GetInt32(0));
                }

                reader.Close();
                cli = Cliente_Controller.obtenerPorId(id_cli);
                dire = Direccion_Controller.obtenerPorId(id_dire);
                
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }


            query = "select * from dbo.sucursal where id = @id;";
            cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    suc = new Sucursal(reader.GetInt32(0), cli, dire, reader.GetString(3), reader.GetInt32(4));
                    Trace.WriteLine("Sucursal encontrado, id: " + reader.GetInt32(0));
                }

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return suc;
        }


        public static bool editarSucursal(Sucursal suc, Cliente cliente, Direccion dir, long telefono, int estado_baja)
        {
            //Update en la BBDD

            string query = "update dbo.sucursal set cliente_id  = @cliente_id , " +
                "direccion_id   = @direccion_id , " +
                "telefono   = @telefono , " +
                "estado_baja  = @estado_baja " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", suc.id);
            cmd.Parameters.AddWithValue("@direccion_id", dir.id);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@cliente_id", cliente.id);
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

        public static bool bajaSucursal(Sucursal suc, int estado_baja)
        {
            //Update en la BBDD
            SucServ_Controller.bajaSucServicioSuc(suc);
            string query = "update dbo.sucursal set estado_baja  = @estado_baja " +
                "where id = @id ;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", suc.id);
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

        public static List<Sucursal> obtenerTodosSucClienteAdm(Usuario usr)
        {
            List<Sucursal> list = new List<Sucursal>();
            List<int> listId = new List<int>();
            List<int> listIdCliente = new List<int>();
            List<int> listIdDireccion = new List<int>();
            List<String> listTelefono = new List<String>();
            List<int> listEstadoBaja = new List<int>();
            List<Cliente> listCliente = new List<Cliente>();
            List<Direccion> listDireccion = new List<Direccion>();
            string query = "select s.* from administracion a join sucursal s on a.sucursal_id=s.id join usuario u on u.id=a.usuario_id where s.estado_baja=0 and u.id=@id_usuario;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_usuario", usr.id);
            // id, cliente_id, direccion_id, telefono, estado_baja
            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listId.Add(reader.GetInt32(0));
                    listIdCliente.Add(reader.GetInt32(1));
                    listIdDireccion.Add(reader.GetInt32(2));
                    listTelefono.Add(reader.GetString(3));
                    listEstadoBaja.Add(reader.GetInt32(4));
                    Trace.WriteLine("Sucursal encontrada, id: " + reader.GetInt32(0));
                }

                //list.Add(new Sucursal(reader.GetInt32(0), Cliente_Controller.obtenerPorId(reader.GetInt32(1)), Direccion_Controller.obtenerPorId(reader.GetInt32(2)), reader.GetInt32(3), reader.GetInt32(4)));

                reader.Close();

                for (int i = 0; i < listIdCliente.Count; i++)
                {
                    listCliente.Add(Cliente_Controller.obtenerPorId(listIdCliente[i]));
                }

                for (int i = 0; i < listIdDireccion.Count; i++)
                {
                    listDireccion.Add(Direccion_Controller.obtenerPorId(listIdDireccion[i]));
                }

                for (int i = 0; i < listId.Count; i++)
                {
                    list.Add(new Sucursal(listId[i], listCliente[i], listDireccion[i], listTelefono[i], listEstadoBaja[i]));
                }

                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }
    }
}
