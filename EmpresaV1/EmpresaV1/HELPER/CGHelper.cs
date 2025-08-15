using EmpresaV1.DAO;
using EmpresaV1.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaV1.HELPER
{
    public class CGHelper
    {
        private static CargoDAO dao = new CargoDAO();
        
        public static void Seed()
        {
            Cargo ob1 = new Cargo()
            {
                Id = 1,
                Nombre = "Gerente",
                Estado = true
            };
            Cargo ob2 = new Cargo()
            {
                Id = 2,
                Nombre = "Asistente",
                Estado = true
            };
            dao.Add(ob1);
            dao.Add(ob2);
        }
    }
}
