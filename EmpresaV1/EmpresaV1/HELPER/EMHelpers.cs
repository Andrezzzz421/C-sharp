using EmpresaV1.DAO;
using EmpresaV1.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaV1.HELPER
{
    public class EMHelpers
    {
        public static EmpleadoDAO dao = new EmpleadoDAO();

        public static void Seed()
        {
            Empleado ob1 = new Empleado()
            {
                Id = 1,
                Nombre = "Juan Perez",
                Apellido = "Gomez",
                DocumentoIdentidad = "12345678",
                FechaNacimiento = new DateTime(1990, 1, 1),
                FechaContratacion = new DateTime(2020, 1, 1),
                Salario = 3000.00,
                Estado = true,
                Cargo = 1,
                Foto = ""
            };

            Empleado ob2 = new Empleado()
            {
                Id = 2,
                Nombre = "Maria Lopez",
                Apellido = "Martinez",
                DocumentoIdentidad = "87654321",
                FechaNacimiento = new DateTime(1995, 5, 5),
                FechaContratacion = new DateTime(2021, 5, 5),
                Salario = 3500.00,
                Estado = true,
                Cargo = 2,
                Foto = ""

            };

            dao.Add(ob1);
            dao.Add(ob2);
        }
    }
}
