using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.DTO
{
    public class EstudianteDTO
    {
        public int IdEstudiante { get; set; }
        public String Documento { get; set; } = "";
        public String Nombre { get; set; } = "";
        public String Apellido { get; set; } = "";
        public String TipoSanguineo { get; set; } = "";
        public decimal Peso { get; set; }
        public decimal Estatura { get; set; }
        public bool Minoria { get; set; }
        public String Correo { get; set; } = "";
        public String NombreCurso { get; set; } = "";
        public Image Foto { get; set; }
    }
}
