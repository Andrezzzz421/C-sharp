using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaV1.DTO
{
    public class EmpleadosDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        
        public string DocumentoIdentidad { get; set; } = "";

        [DisplayName("Nombre del cargo")]
        public string NombreCargo { get; set; } = "";

        public String Genero { get; set; } = "";

        public double Salario { get; set; }
        public Image Foto { get; set; }
    }
}
