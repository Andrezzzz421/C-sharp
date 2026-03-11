using Microsoft.EntityFrameworkCore;
using productodb.Models;

namespace productodb.Services
{
    public class ProductosServices
    {
        private readonly ProductosDbContext db;

        public ProductosServices(ProductosDbContext db)
        {
            this.db = db;
        }

        public void Add(Producto obj)
        {
            db.Productos.Add(obj);
            db.SaveChanges();
        }

        public void Update(Producto obj)
        {
            db.Productos.Update(obj);
            db.SaveChanges();
        }

        public void Delete(int id) 
        {
            var x = db.Productos.Find(id);
            if(x != null)
            {
                db.Productos.Remove(x);
                db.SaveChanges();
            }
        }

        public Producto? GetById(int id)
        {
            return db.Productos.Find(id);
        }

        public List<Producto> GetAll()
        {
            return db.Productos.ToList();
        }
    }
}
