using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models
{
    public class Cocteles
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    }
    public class Coctel
    {
        public static List<Cocteles> listaCoctel = new List<Cocteles>
        {
            new Cocteles {Nombre = "Pisco Sour", Precio = 18.0m, Descripcion = "El coctel nacional de Perú, hecho con pisco, jugo de limón fresco, jarabe de goma y clara de huevo. Es una bebida espumosa y refrescante, con un sabor agridulce y un toque de amargura. Ideal para cualquier ocasión especial.", Imagen = "pisco_sour.png"},
            new Cocteles {Nombre = "Mojito", Precio = 18.0m, Descripcion = "Un clásico coctel cubano hecho con ron blanco, menta fresca, lima, azúcar y soda. Es una bebida fresca y refrescante con un sabor dulce y ácido, perfecto para disfrutar en una noche de verano.", Imagen = "mojito.png"},
            new Cocteles {Nombre = "Chilcano", Precio = 18.0m, Descripcion = "Un coctel peruano hecho con pisco, ginger ale y jugo de limón. Es una bebida refrescante con un sabor suave y un toque picante del jengibre. Ideal para acompañar una cena o para disfrutar en una tarde de calor.", Imagen = "chilcano.png"},
            new Cocteles {Nombre = "Piña Colada", Precio = 18.0m, Descripcion = "Un coctel tropical hecho con ron, jugo de piña y crema de coco. Es una bebida dulce y cremosa con un sabor fresco y tropical, ideal para disfrutar en una playa o en cualquier lugar donde se quiera sentir como si estuvieras en el paraíso.", Imagen = "pina_colada.png"}
        };
    }
}
