using BibliotecaFInal.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaFInal.Services
{
    public class LibroServices
    {
        private readonly BibliotecaFinalContext db;

        public LibroServices(BibliotecaFinalContext db)
        {
            this.db = db;
        }

        public void Add(Libro obj)
        {
            db.Libros.Add(obj);
            db.SaveChanges();
        }

        public void Update(Libro obj)
        {
            db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var x = db.Libros.Find(id);
            if (x != null)
            {
                db.Libros.Remove(x);
                db.SaveChanges();
            }
        }

        public Libro? GetById(int id)
        {
            return db.Libros.Find(id);
        }

        public List<Libro> GetAll()
        {
            return db.Libros
                .Include(l => l.IdAutorNavigation)
                .Include(l => l.IdCategoriaNavigation)
                .Include(l=> l.IdEditorialNavigation)
                .ToList();
        }

    }
}
