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
                PrecioCompra = 1000,
                PrecioVenta = 1500,
                Categoria = 1,
                Disponible = true,
                Foto =null
            };
            Producto ob2 = new Producto()
            {
                Id = 2,
                Nombre = "Cebolla",
                Cantidad = 100,
                PrecioCompra = 1000,
                PrecioVenta = 1500,
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
            if(x != null)
            {
                string nombre = cdao.GetById(x.Categoria).Nombre;
                return new ProductoDTO()
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Cantidad = x.Cantidad,
                    PrecioVenta = x.PrecioVenta,
                    NombreCategoria = nombre,
                    Foto = x.Foto != null ? HELPproductos.toImage(x.Foto): null
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


    }
}
