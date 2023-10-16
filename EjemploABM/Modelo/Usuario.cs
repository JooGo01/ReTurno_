using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Usuario
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String dni { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
        public String contrasenia { get; set; }
        public String tipo_usuario { get; set; }
        public Direccion direccion { get; set; }
        public int estado_baja { get; set; }

        public Usuario(int p_id, String p_nombre, String p_apellido, String p_dni, String p_telefono, String p_email, String p_contrasenia, String p_tipo_usuario, Direccion p_direccion, int p_estado_baja) {
            id = p_id;
            nombre = p_nombre;
            apellido = p_apellido;
            dni = p_dni;
            telefono = p_telefono;
            email = p_email;
            contrasenia = p_contrasenia;
            tipo_usuario = p_tipo_usuario;
            direccion = p_direccion;
            estado_baja = p_estado_baja;
        }

        public Usuario()
        {

        }
    }
}
