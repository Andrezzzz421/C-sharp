using BibliotecaFInal.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaFInal.Services
{
    public class EditorialeServices
    {
        private readonly BibliotecaFinalContext db;

        public EditorialeServices(BibliotecaFinalContext db)
        { 
            this.db = db;
        }

        public void Add(Editoriale obj)
        {
            db.Editoriales.Add(obj);
            db.SaveChanges();
        }

        public void Update(Editoriale obj)
        {
            db.Editoriales.Update(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            bool tienelibro= db.Libros.AsNoTracking().Any(l => l.IdEditorial == id);

            if (tienelibro)
            {
                return false;
            }
            var edit = db.Editoriales.Find(id);
            if(edit != null)
            {
                db.Editoriales.Remove(edit);
                db.SaveChanges();
            }
            return true;

        }

        public Editoriale? GetById(int id)
        {
            return db.Editoriales.Find(id);
        }

        public List<Editoriale> GetAll()
        {
            return db.Editoriales
                .Include(p => p.IdPaisNavigation)
                .ToList();
        }


    }
}
