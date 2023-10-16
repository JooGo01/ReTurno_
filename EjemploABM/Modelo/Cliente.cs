using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Cliente
    {
        public int id;
        public String razon_social;
        public Rubro rubro;
        public int estado_baja;

        public Cliente(int p_id, string p_razon_social, Rubro p_rubro, int p_estado_baja)
        {
            id = p_id;
            razon_social = p_razon_social;
            rubro = p_rubro;
            estado_baja = p_estado_baja;
        }

        public Cliente() { }
    }
}
