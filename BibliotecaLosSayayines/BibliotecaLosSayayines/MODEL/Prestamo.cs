using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace BibliotecaLosSayayines.MODEL
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }

        public DateTime FechaPrestamo { get; set; }

        public DateTime FechaEntrega { get; set; }
        public string Observaciones { get; set; }

    }
}
