using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class SubServicio
    {
        public int id { get; set; }
        public String nombre_servicio { get; set; }
        public Servicio id_servicio { get; set; }

        public SubServicio(int p_id, String p_nombre_servicio, Servicio p_id_servicio)
        {
            this.id = p_id;
            this.nombre_servicio = p_nombre_servicio;
            this.id_servicio = p_id_servicio;
        }

        public SubServicio() { }
    }
}
