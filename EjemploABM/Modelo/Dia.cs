using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Dia
    {
        public int id { get; set; }

        public String nombre_dia { get; set; }

        public Dia(int p_id, String p_nombre_dia) { 
            this.id = p_id;
            this.nombre_dia = p_nombre_dia;
        }

        public Dia() { }
    }
}
