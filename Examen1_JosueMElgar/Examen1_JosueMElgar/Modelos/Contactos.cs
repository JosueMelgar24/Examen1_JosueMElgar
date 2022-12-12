using SQLite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Examen1_JosueMElgar.Models
{
    public  class Contactos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string nombres { get; set; }

        [MaxLength(100)]
        public string apellidos { get; set; }

        [MaxLength(20)]
        public int telefono { get; set; }

        [MaxLength(20)]
        public int edad { get; set; }
        public string pais { get; set; }

        [MaxLength(50)]
        public string nota { get; set; }

        [MaxLength(20)]
        public int latitud { get; set; }

        [MaxLength(20)]
        public int longitud { get; set; }


       
        
    }
}
