using BibliotecaFInal.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaFInal.Services
{
    public class CategoriaServices
    {
        private readonly BibliotecaFinalContext db;

        public CategoriaServices(BibliotecaFinalContext db)
        {
            this.db = db;
        }

        public void Add(Categoria obj)
        {
            db.Categorias.Add(obj);
            db.SaveChanges();
        }

        public void Update(Categoria c)
        {
            var entry = db.Entry(c);
            entry.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }


        public async Task<bool> UpdateConFoto(Categoria c,IFormFile arc)
        {
            var cateDB = await db.Categorias.AsNoTracking().FirstOrDefaultAsync(x => x.IdCategoria == c.IdCategoria);
            if (cateDB == null) return false;

            if(arc != null && arc.Length > 0)
            {
                using var ms = new MemoryStream();
                await arc.CopyToAsync(ms);
                c.Logo = ms.ToArray();
            }
            else
            {
                c.Logo = cateDB.Logo;
            }
            db.Update(c);
            await db.SaveChangesAsync();
            return true;
        }

        public bool Delete(int id)
        {
            bool tienelibro = db.Libros.AsNoTracking().Any(l => l.IdCategoria == id);

            if (tienelibro)
            {
                return false;
            }

            var cate = db.Categorias.Find(id);
            if (cate != null)
            {
                db.Categorias.Remove(cate);
                db.SaveChanges();

            }
            return true;
        }

        public Categoria? GetById(int id)
        {
            return db.Categorias.Find(id);
        }

        public List<Categoria> GetAll()
        {
            return db.Categorias.ToList();
        }


    }
}
