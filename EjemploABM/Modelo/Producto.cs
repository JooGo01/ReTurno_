using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Producto
    {

        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Categoria Cat { get; set; }
        public String Imagen { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }


        public Producto(int id, string name, string desc, Categoria cat, string img, int precio, int stock)
        {
            Id = id;
            Nombre = name;
            Descripcion = desc;
            Cat = cat;
            Imagen = img;
            Precio = precio;
            Stock = stock;
        }

        public Producto()
        {
        }


    }
}
