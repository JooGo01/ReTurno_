using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Categoria
    {

        public int Id { get; set; }
        public String Nombre { get; set; }

        public Categoria(int id, string name)
        {
            Id = id;
            Nombre = name;
        }

        public Categoria()
        {
        }
    }
}
