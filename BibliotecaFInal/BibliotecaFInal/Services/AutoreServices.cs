using BibliotecaFInal.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaFInal.Services
{
    public class AutoreServices
    {
        private readonly BibliotecaFinalContext db;

        public AutoreServices(BibliotecaFinalContext db)
        {
            this.db = db;
        }

        public void Add(Autore obj,IFormFile? arc =null)
        {
            if (arc != null && arc.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    arc.CopyTo(ms);
                    obj.Foto = ms.ToArray();
                }
            }
            db.Autores.Add(obj);
            db.SaveChanges();
        }

        public async Task Update(Autore a,IFormFile? arc = null)
        {
            var autorActual = await db.Autores
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.IdAutor == a.IdAutor);

            if (arc != null && arc.Length > 0)
            {
                using var ms = new MemoryStream();
                await arc.CopyToAsync(ms);
                a.Foto = ms.ToArray();
            }
            else
            {
                a.Foto = autorActual?.Foto;
            }

            db.Update(a);
            await db.SaveChangesAsync();
        }

        public bool Delete(int id)
        {
            bool tienelibro =db.Libros.AsNoTracking().Any(l => l.IdAutor == id);

            if (tienelibro)
            {
                return false;
            }

            var autor = db.Autores.Find(id);
            if(autor != null)
            {
                db.Autores.Remove(autor);
                db.SaveChanges();
                
            }
            return true;
        }

        public Autore? GetById(int id)
        {
            return db.Autores.Find(id);
        }

        public List<Autore> GetAll()
        { 
            return db.Autores
                .Include(p => p.IdPaisOrigenNavigation)
                .ToList();
        }


    }
}
