using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class SucursalServicio
    {
        public int id { get; set; }
        public Sucursal id_sucursal { get; set; }
        public SubServicio id_subservicio { get; set; }

        public int tiempo_servicio { get; set; }

        public int estado_baja { get; set; }

        public SucursalServicio(int p_id, Sucursal p_id_sucursal, SubServicio p_id_subservicio, int p_tiempo_servicio, int p_estado_baja)
        {
            this.id = p_id;
            this.id_sucursal = p_id_sucursal;
            this.id_subservicio = p_id_subservicio;
            this.tiempo_servicio = p_tiempo_servicio;
            this.estado_baja = p_estado_baja;
        }

        public SucursalServicio() { }
    }
}
