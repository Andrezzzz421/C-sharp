using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLosSayayines.DTO
{
    public class AutorDTO
    {

        public int id_autor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        [DisplayName("Genero")]
        public string nombregenero { get; set; }

        [DisplayName("Nacionalidad")]
        public string pais_origen { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        public DateTime fecha_nacimiento { get; set; }

        public string biografia { get; set; }
    }
}
