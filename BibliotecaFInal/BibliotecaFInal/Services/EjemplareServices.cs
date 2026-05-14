using BibliotecaFInal.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaFInal.Services
{
    public class EjemplareServices
    {
        private readonly BibliotecaFinalContext db;

        public EjemplareServices(BibliotecaFinalContext db)
        {
            this.db = db;
        }

        public void Add(Ejemplare obj)
        {
            db.Ejemplares.Add(obj);
            db.SaveChanges();
        }

        public void Update(Ejemplare obj)
        {
            db.Ejemplares.Update(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var x = db.Ejemplares.Find(id);
            if (x != null)
            {
                db.Ejemplares.Remove(x);
                db.SaveChanges();
            }
        }

        public Ejemplare? GetById(int id)
        {
            return db.Ejemplares.Find(id);
        }

        public List<Ejemplare> GetAll()
        {
            return db.Ejemplares
                .Include(p => p.IdLibroNavigation)
                .ToList();
        }

    }
}
