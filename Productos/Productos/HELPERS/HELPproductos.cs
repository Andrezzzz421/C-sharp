using Productos.DAO;
using Productos.DTO;
using Productos.MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Productos.HELPERS
{
    public class HELPproductos
    {
        private static ProductoDAO dao = new ProductoDAO();
        private static CategoriaDAO cdao = new CategoriaDAO();

        public static void Seed()
        {
            Producto ob1 = new Producto()
            {
                Id = 1,
                Nombre = "Papa",
                Cantidad = 100,
                PrecioCompra = 1500,
                PrecioVenta = 1700,
                Categoria = 1,
                Disponible = true,
                Foto = null
            };
            Producto ob2 = new Producto()
            {
                Id = 2,
                Nombre = "Cebolla",
                Cantidad = 100,
                PrecioCompra = 2000,
                PrecioVenta = 2200,
                Categoria = 1,
                Disponible = true,
                Foto = null

            };
            dao.Add(ob1);
            dao.Add(ob2);


        }

        public static ProductoDTO ToDTO(int id)
        {
            var x = dao.GetById(id);
            if (x != null)
            {
                string nombre = cdao.GetById(x.Categoria).Nombre;
                return new ProductoDTO()
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Cantidad = x.Cantidad,
                    PrecioVenta = x.PrecioVenta,
                    PrecioCompra = x.PrecioCompra,
                    NombreCategoria = nombre,
                    Foto = x.Foto != null ? HELPproductos.toImage(x.Foto) : null
                };
            }
            else
            {
                return null;
            }
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

        public static List<ProductoDTO> BuscarPorNombre(string nombre)
        {
            var lista = dao.GetAll();

            return lista
                .Where(e => e.Nombre != null &&
                e.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .Select(e => ToDTO(e.Id))
                .ToList();
        }

        public static List<ProductoDTO> OrdenarPorPrecioVenta(string orden, double precio = 0)
        {
            var lista = dao.GetDTO();

            switch ((orden ?? "").Trim().ToLowerInvariant())
            {
                case "mayor":
                    return lista.OrderByDescending(p => p.PrecioVenta).ToList();

                case "menor":
                    return lista.OrderBy(p => p.PrecioVenta).ToList();

                case "igual":
                    return lista.Where(p => p.PrecioVenta == precio).ToList();

                default:
                    return lista;
            }


        }
        public static List<ProductoDTO> BuscarPorCategoria(string nombreCategoria)
        {
            var lista = dao.GetDTO();

            if (string.IsNullOrWhiteSpace(nombreCategoria) || nombreCategoria == "Todos")
                return lista;

            return lista
                .Where(p => p.NombreCategoria != null &&
                            p.NombreCategoria.Equals(nombreCategoria, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

    }
}
