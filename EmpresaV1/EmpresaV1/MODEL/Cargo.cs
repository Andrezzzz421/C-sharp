using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaV1.MODEL
{
    public class Cargo
    {
        public int Id { get; set; }
        public String Nombre { get; set; } = "";
        public String Descripcion { get; set; } = "";
        public double SalarioBase { get; set; }
        public String departamento { get; set; } = "";
        public Boolean Estado { get; set; } = true;
    }
}
