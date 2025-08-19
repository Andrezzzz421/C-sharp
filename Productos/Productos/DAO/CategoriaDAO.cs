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
            if (cat.Id == 0)
            {
                cat.Id = categoria.Count > 0 ? categoria.Max(c => c.Id) + 1 : 1;
            }

            var existente = GetById(cat.Id);
            if (existente == null)
            {
                categoria.Add(cat);
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
