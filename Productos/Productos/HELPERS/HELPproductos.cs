using Productos.DAO;
using Productos.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.HELPERS
{
    public class HELPproductos
    {
        private static ProductoDAO dao = new ProductoDAO();

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
                Foto = ""
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
                Foto = ""
            };
        }
    }
}
