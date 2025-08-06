using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO.Model
{
    public class Libro
    {
        public int Id { get; set; }
        public String Titulo { get; set; } = "";
        public String Autor { get; set; } = "";
        public String Genero { get; set; } = "";
        public String Editorial { get; set; } = "";
        public String Portada { get; set; } = "";
        public int AnioPublicacion { get; set; } 
        public String Sinopsis { get; set; } = "";
    }
}
