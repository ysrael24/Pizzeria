using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Pizzeria.Models
{
    public class Personas
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        [MaxLength(25)]
        public string Nombre { get; set; }

        [MaxLength(25)]
        public string Apellido { get; set; }

        [MaxLength(8)]
        public string Dni { get; set; }

        [Unique,MaxLength(40)]
        public string CorreOnum { get; set; }

        [MaxLength(40)]
        public string Contraseña { get; set; }
    }
}
