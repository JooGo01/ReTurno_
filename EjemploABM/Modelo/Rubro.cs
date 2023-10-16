using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Rubro
    {
        public int id { get; set; }
        public String nombre { get; set; }

        public Rubro(int p_id, String p_nombre) {
            id = p_id;
            nombre = p_nombre;
        }
        public Rubro() { }
    }
}
