using Productos.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.DAO
{

    public class CategoriaDAO
    {
        public static List<Categoria> categoria = new List<Categoria>();

        public List<Categoria> GetAll()
        {
            return categoria;
        }

        public Categoria GetById(int id)
        {
            foreach (var ct in categoria)
            {
                if (ct.Id == id) return ct;
            }
            return null;
        }

        public void Add(Categoria cat)
        {
            var cte = GetById(cat.Id);
            if (cte != null)
            {
                categoria.Add(cte);
            }
            else
            {
                cte.Nombre = cat.Nombre;
            }
        }

        public void Update(Categoria cte)
        {
            var ct = GetById(cte.Id);
            if (ct != null)
            {
                ct.Nombre = cte.Nombre;
            }
        }
        public void Delete(int id)
        {
            var cte = GetById(id);
            if(cte != null)
            {
                categoria.Remove(cte);
            }
        }
    }
}
