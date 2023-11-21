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
    class Dia_Contoller
    {
        public static Dia obtenerPorId(int id)
        {
            string query = "select * from dbo.dia where id = @id;";
            String nombre_dia = "";
            Dia dia = new Dia();
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nombre_dia = reader.GetString(1);
                    Trace.WriteLine("Dia encontrado, nombre: " + reader.GetString(1));
                }
                dia = new Dia(id, nombre_dia);

                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return dia;
        }

        public static List<Dia> obtenerTodos()
        {
            string query = "select * from dbo.dia;";
            String nombre_dia = "";
            int id_dia = 0;
            Dia dia = new Dia();
            List<Dia> dia_list = new List<Dia>();
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id_dia = reader.GetInt32(0);
                    nombre_dia = reader.GetString(1);
                    Trace.WriteLine("Dia encontrado, nombre: " + reader.GetString(1));
                    dia = new Dia(id_dia, nombre_dia);
                    dia_list.Add(dia);
                }
                reader.Close();
                DB_Controller.close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return dia_list;
        }
    }
}
