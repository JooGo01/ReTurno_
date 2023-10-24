using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Sucursal
    {
        public int id { get; set; }
        public Cliente cliente { get; set; }

        public Direccion direccion { get; set; }

        public String telefono { get; set; }

        public int estado_baja { get; set; }


        public Sucursal(int p_id, Cliente p_cliente, Direccion p_direccion, String p_telefono, int p_estado_baja)
        {
            id = p_id;
            cliente = p_cliente;
            direccion = p_direccion;
            telefono = p_telefono;
            estado_baja = p_estado_baja;
        }

        public Sucursal() { }

        public Sucursal(int p_id) { id = p_id; }

    }
}
