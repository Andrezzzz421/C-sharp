using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLosSayayines.MODEL
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public String Documento { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public String Direccion { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;



    }
}
