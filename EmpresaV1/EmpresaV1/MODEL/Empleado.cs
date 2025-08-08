using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaV1.MODEL
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string DocumentoIdentidad { get; set; } = "";
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public double Salario { get; set; }
        public bool Estado { get; set; } = true;

        public Cargo Cargo { get; set; }

    }
}
