using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.MODEL
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }
        public String Documento { get; set; } = "";
        public String Nombre { get; set; } = "";
        public String Apellido { get; set; } = "";
        public String TipoSanguineo { get; set; } = "";
        public Decimal Peso { get; set; }
        public Decimal Estatura { get; set; }
        public bool Minoria { get; set; }  
        public String Correo { get; set; } = "";
        public int IdCurso { get; set; }
        public byte[] Foto { get; set; } 

    }
}
