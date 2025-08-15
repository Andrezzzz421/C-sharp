using Productos.DAO;
using Productos.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.HELPERS
{
    public class HELPcategoria
    {
        private static CategoriaDAO dao = new CategoriaDAO();

        public static void Seed()
        {
            Categoria ob1 = new Categoria()
            {
                Id = 1,
                Nombre = "Comida"
            };

            Categoria ob2 = new Categoria()
            {
                Id = 2,
                Nombre ="Herramienta"
            };
        }
    }
}
