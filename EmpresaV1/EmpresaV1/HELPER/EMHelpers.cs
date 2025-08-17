using EmpresaV1.DAO;
using EmpresaV1.DTO;
using EmpresaV1.MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmpresaV1.HELPER
{
    public class EMHelpers
    {
        private static EmpleadoDAO dao = new EmpleadoDAO();
        private static CargoDAO cDao = new CargoDAO();

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
                Foto = null
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
                Foto = null

            };

            dao.Add(ob1);
            dao.Add(ob2);
        }
        public static  EmpleadosDTO ToDTO(int  id)
        {
            var x = dao.GetById(id);
            if (x != null) {
                String nombre = cDao.GetById(x.Cargo).Nombre;

                EmpleadosDTO dto = new EmpleadosDTO()
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    DocumentoIdentidad = x.DocumentoIdentidad,
                    NombreCargo = nombre,
                    Foto = x.Foto != null ? EMHelpers.toImage(x.Foto) : null

                };
                return dto;
            }
            return null;
        }

        public static byte[] ToBytes(string ruta)
        {
            using (Image image = Image.FromFile(ruta))
            {
                using( MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
                
            }
        }

        public static Image toImage(byte[] b)
        {
            using (MemoryStream ms = new MemoryStream(b))
            {
                Image image = Image.FromStream(ms);
                return Image.FromStream(ms);
            }
        }

    }
}
