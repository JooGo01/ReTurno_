using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Atencion
    {
        public int id {  get; set; }
        public Dia dia_id { get; set; }

        public SucursalServicio sucursal_servicio_id { get; set; }

        public int hora_apertura { get; set; }

        public int hora_cierre { get; set; }

        public int personal_servicio { get; set; }

        public int estado_baja { get; set; }


        public Atencion(int p_id, Dia p_dia_id, SucursalServicio p_sucursal_servicio_id, int p_hora_apertura, int p_hora_cierre, int p_personal_servicio, int p_estado_baja)
        {
            this.id = p_id;
            this.dia_id = p_dia_id;
            this.sucursal_servicio_id = p_sucursal_servicio_id;
            this.hora_apertura = p_hora_apertura;
            this.hora_cierre = p_hora_cierre;
            this.personal_servicio = p_personal_servicio;
            this.estado_baja = p_estado_baja;
        }

        public Atencion() { }

    }
}
