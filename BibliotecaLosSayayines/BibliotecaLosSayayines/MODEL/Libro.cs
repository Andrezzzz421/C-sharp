using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLosSayayines.MODEL
{
    public class Libro
    {
        public int Id_libro { get; set; }
        public string Titulo { get; set; }
        public int Id_autor { get; set; }
        public int Id_editorial { get; set; }
        public int Id_Categoria { get; set; }

        public int AnioPublicacion { get; set; }
        public String Descripcion { get; set; }
        public byte[] Portada { get; set; }

        public String Estado { get; set; }
    }
}
