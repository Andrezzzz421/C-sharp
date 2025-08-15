using Productos.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.DAO
{
    public class ProductoDAO
    {
        public static List<Producto> productos = new List<Producto>();

        public List<Producto> GetAll()
        {
            return productos;
        }

        public Producto GetById(int id)
        {
            foreach (var p in productos)
            {
                if (p.Id == id) return p;
            }
            return null;
        }

        public void Add(Producto prd)
        {
            var pr = GetById(prd.Id);
            if (pr != null)
            {
                productos.Add(pr);
            }
            else
            {
                pr.Nombre = prd.Nombre;
                pr.Cantidad = prd.Cantidad;
                pr.PrecioCompra = prd.PrecioCompra;
                pr.PrecioVenta = prd.PrecioVenta;
                pr.Categoria = prd.Categoria;
                pr.Disponible = prd.Disponible;
                pr.Foto = prd.Foto;
            }
        }

        public void Update(Producto prd)
        {
            var pr = GetById(prd.Id);
            if (pr != null)
            {
                pr.Nombre = prd.Nombre;
                pr.Cantidad = prd.Cantidad;
                pr.PrecioCompra = prd.PrecioCompra;
                pr.PrecioVenta = prd.PrecioVenta;
                pr.Categoria = prd.Categoria;
                pr.Disponible = prd.Disponible;
                pr.Foto = prd.Foto;
            }
        
        }
        
        public void Delete(int id)
        {
            var pr = GetById(id);
            if (pr != null)
            {
                productos.Remove(pr);
        }   }
    }
}
