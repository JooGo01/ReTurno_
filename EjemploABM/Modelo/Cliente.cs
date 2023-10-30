using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Cliente
    {
        public int id { get; set; }
        public String razon_social { get; set; }
        public Rubro rubro { get; set; }
        public String email { get; set; }
        public int estado_baja { get; set; }

        public Cliente(int p_id, string p_razon_social, Rubro p_rubro, String p_email, int p_estado_baja)
        {
            id = p_id;
            razon_social = p_razon_social;
            rubro = p_rubro;
            email = p_email;
            estado_baja = p_estado_baja;
        }

        public Cliente() { }
    }
}
