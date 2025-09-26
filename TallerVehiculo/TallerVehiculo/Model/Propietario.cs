using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVehiculo.Model
{
    public class Propietario
    {
        public int Id { get; set; }
        [DisplayName("Nombre y Apellido")]
        public string Nombre { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string Telefono { get; set; } = "";

        public string Correo { get; set; } = "";
        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
