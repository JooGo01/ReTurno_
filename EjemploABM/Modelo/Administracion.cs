using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Administracion
    {
        public int id {  get; set; }
        public Cliente cliente { get; set; }

        public Sucursal suc {get; set; }

        public Usuario usuario { get; set; }

        public int estado_baja { get; set; }

        public Administracion(int p_id, Cliente p_cliente, Sucursal p_suc, Usuario p_usuario, int p_estado_baja)
        {
            id = p_id;
            cliente = p_cliente;
            suc = p_suc;
            usuario = p_usuario;
            estado_baja = p_estado_baja;
        }

        public Administracion() { }
    }
}
