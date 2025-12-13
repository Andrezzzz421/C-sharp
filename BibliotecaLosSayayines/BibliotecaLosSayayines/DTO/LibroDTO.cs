using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLosSayayines.DTO
{
    public class LibroDTO
    { 
        public int id_libro { get; set; }
        public string titulo { get; set; }

        [DisplayName("Autor")]
        public string Nombreautor { get; set; }
        [DisplayName("Editorial")]
        public string Nombreeditorial { get; set; }
        [DisplayName("Categoría")]
        public string Nombrecategoria { get; set; }

        [DisplayName("Año de Publicación")]
        public int anio_publicacion { get; set; }
        public string descripcion { get; set; }
        public Image Portada { get; set; }

        public string Estado { get; set; }

    }
}
