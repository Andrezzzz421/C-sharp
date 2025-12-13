using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLosSayayines.MODEL
{
    public class Autor
    {
        public int id_autor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int id_genero { get; set; }
        public string pais_origen { get; set; }
        public DateTime fehcanacimiento { get; set; }

        public string biografia { get; set; }
    }
}
