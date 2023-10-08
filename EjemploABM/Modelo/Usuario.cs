using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public String usuario { get; set; }
        public String Contraseña { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Id_tipo { get; set; }


        public Usuario(int id, string username, string pass, string name, string lastname, int rol)
        {
            Id = id;
            usuario = username;
            Contraseña = pass;
            Nombre = name;
            Apellido = lastname;
            Id_tipo = rol;
        }

        public Usuario()
        {

        }
    }
}
