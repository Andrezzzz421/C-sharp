using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLosSayayines.MODEL
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public byte[] Foto { get; set; }
        public bool Estado { get; set; }
        public string EstadoDescripcion
        {
            get { return Estado ? "ACTIVO" : "INACTIVO"; }
        }
    }
}
