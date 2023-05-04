using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models
{
    public class Productos
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    }
    public class Pizza
    {
        public static List<Productos> listaPizza = new List<Productos>
        {
            new Productos{Nombre = "Pizza Parrillera", Precio = 44.0m,    Descripcion = "Nuestra pizza parrillera ofrece una combinación de sabores ahumados y frescos con una masa crujiente, carne a la parrilla, pimientos, cebolla y queso derretido, sazonado con especias exclusivas.", Imagen = "pizza1.png"},
            new Productos{Nombre = "Pizza Tropical",   Precio = 37.0m,    Descripcion = "Disfruta del sabor del paraíso en cada bocado con nuestra deliciosa pizza tropical. Una combinación perfecta de piña fresca, jamón, queso derretido y salsa de tomate casera sobre nuestra masa crujiente recién horneada.", Imagen = "pizza2.png"},
            new Productos{Nombre = "Pizza Alemana",    Precio = 39.0m,    Descripcion = "Embárcate en un viaje culinario a Alemania con nuestra pizza alemana. Saborea la deliciosa combinación de salchicha ahumada, chucrut, queso derretido y mostaza en una masa crujiente y dorada.", Imagen = "pizza3.png"},
            new Productos{Nombre = "Pizza Húngara",    Precio = 44.0m,    Descripcion = "Embárcate en un viaje culinario a Hungría con nuestra pizza húngara. Disfruta de una masa crujiente cubierta con una deliciosa mezcla de salchicha húngara, pimientos picantes, cebolla roja y queso mozzarella derretido.", Imagen = "pizza4.png"}
        };
    }
}
