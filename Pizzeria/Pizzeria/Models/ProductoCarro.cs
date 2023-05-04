using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models
{
    public class ProductoCarro
    {
        public string Nombre { get; set; }
        public decimal Precio  { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string Imagen { get; set; }
        public string SubTotal { get; set; }
    }
}
