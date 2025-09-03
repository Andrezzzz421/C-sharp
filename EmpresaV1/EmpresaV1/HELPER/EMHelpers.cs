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
                Genero = "Masculino",
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
                Genero = "Femenino",
                FechaContratacion = new DateTime(2021, 5, 5),
                Salario = 3500.00,
                Estado = true,
                Cargo = 2,
                Foto = null

            };

            dao.Add(ob1);
            dao.Add(ob2);
        }
        public static EmpleadosDTO ToDTO(int id)
        {
            var x = dao.GetById(id);
            if (x != null)
            {
                String nombre = cDao.GetById(x.Cargo).Nombre;
                EmpleadosDTO dto = new EmpleadosDTO()
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    DocumentoIdentidad = x.DocumentoIdentidad,
                    Genero = x.Genero,
                    NombreCargo = nombre,
                    Salario = x.Salario,
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
                using (MemoryStream ms = new MemoryStream())
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
        public static List<EmpleadosDTO> BuscarPorNombre(string filtro, string tipo)
        {
            var lista = dao.GetDTO();

            filtro = filtro.ToLower();

            switch (tipo.ToLower())
            {
                case "Inicia":
                    return lista.Where(e => e.Nombre.ToLower().StartsWith(filtro)).ToList();

                case "Termina":
                    return lista.Where(e => e.Nombre.ToLower().EndsWith(filtro)).ToList();

                default:
                    return lista.Where(e => e.Nombre.ToLower().Contains(filtro)).ToList();
            }
        }

        public static List<EmpleadosDTO> BuscarPorGenero(string genero, string generoPersonalizado = "")
        {
            var lista = dao.GetDTO();

            if (string.IsNullOrWhiteSpace(genero))
                return lista;

            genero = genero.ToLower();

            if (genero == "otro" && !string.IsNullOrWhiteSpace(generoPersonalizado))
            {
                return lista.Where(e => e.Genero.ToLower() == generoPersonalizado.ToLower()).ToList();
            }
            else
            {
                return lista.Where(e => e.Genero.ToLower() == genero).ToList();
            }
        }

        public static List<EmpleadosDTO> BuscarPorCargo(string nombreCategoria)
        {
            var lista = dao.GetDTO();

            if (string.IsNullOrWhiteSpace(nombreCategoria))
                return lista;

            return lista
                .Where(p => p.NombreCargo != null &&
                            p.NombreCargo.Equals(nombreCategoria, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        public static List<EmpleadosDTO> OrdenarPorSalario(string orden, double salario = 0)
        {
            var lista = dao.GetDTO();

            switch ((orden ?? "").Trim().ToLowerInvariant())
            {
                case "mayor":
                    return lista.OrderByDescending(p => p.Salario).ToList();

                case "menor":
                    return lista.OrderBy(p => p.Salario).ToList();

                case "igual":
                    return lista.Where(p => p.Salario == salario).ToList();

                default:
                    return lista;
            }

        }
    }
}
