using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Direccion
    {
        public int id { get; set; }
        public String calle { get; set; }

        public int altura { get; set; }

        public String codigo_postal { get; set; }

        public String provincia { get; set; }

        public String ciudad { get; set; }

        public String departamento { get; set; }

        public Direccion(int p_id, String p_calle, int p_altura, string p_codigo_postal, String p_provincia, String p_ciudad, String p_departamento)
        {
            id = p_id;
            calle = p_calle;
            altura = p_altura;
            codigo_postal = p_codigo_postal;
            provincia = p_provincia;
            ciudad = p_ciudad;
            departamento = p_departamento;
        }

        public Direccion() { }
    }
}
