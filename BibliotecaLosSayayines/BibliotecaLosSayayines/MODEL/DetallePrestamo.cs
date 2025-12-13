using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLosSayayines.MODEL
{
    public class DetallePrestamo
    {
        private Usuario usuarioActual;
         
        public int IdDetalle { get; set; }
        public int IdPrestamo { get; set; }
        public int IdLibro { get; set; }
        public DateTime FechaDevolucionReal { get; set; }
        public string Estado { get; set; } = "prestado";

    }
}
