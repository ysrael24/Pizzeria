using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models
{
    
        public class Bebidas
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public string Descripcion { get; set; }
            public string Imagen { get; set; }
        }
        
        public class bebida
    {
        public static List<Bebidas> listBebidas = new List<Bebidas>
        {
            new Bebidas {Nombre = "Chicha Morada", Precio = 8.0m, Descripcion = "Una refrescante bebida hecha de maíz morado, piña, canela y clavos de olor, con un sabor dulce y un toque de especias.Disfrútala fría en cualquier momento del día.", Imagen = "morada01.png",},
            new Bebidas {Nombre = "Maracuyá", Precio = 8.0m,Descripcion = "Un jugo deliciosamente dulce y ligeramente ácido hecho de la fruta de la pasión. Refréscate con su sabor tropical y disfrútalo en cualquier momento del día", Imagen = "maracuya.png"},
            new Bebidas {Nombre = "Limonada", Precio = 6.0m, Descripcion = "Una bebida clásica y refrescante hecha con limones frescos, agua y azúcar,con un sabor equilibrado entre lo dulce y lo ácido. Ideal para acompañar cualquier comida o simplemente para refrescarte en un día caluroso.",Imagen = "Limonada.png" },
            new Bebidas {Nombre = "Inca Cola",Precio = 8.0m, Descripcion = "Una bebida carbonatada y dulce de color amarillo brillante que tiene un sabor único y distintivo. Es una bebida nacional de Perú y su dulzura es perfecta para disfrutar en cualquier momento del día.",Imagen = "incakola.png"}
        };
    }
}
