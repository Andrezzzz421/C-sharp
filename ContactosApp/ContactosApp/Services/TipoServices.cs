using ContactosApp.Data;
using ContactosApp.Models;

namespace ContactosApp.Services
{
    public class TipoServices
    {
        private readonly ContactosDbContext db;

        public TipoServices(ContactosDbContext db)
        {
            this.db = db;
        }

        public void Add(Tipo obj)
        {
            db.Tipos.Add(obj);
            db.SaveChanges();
        }

        public void Update(Tipo obj)
        {
            db.Tipos.Update(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var x = db.Tipos.Find(id);
            if(x != null)
            {
                db.Tipos.Remove(x);
                db.SaveChanges();
            }
        }

        public Tipo? GetById(int id)
        {
            return db.Tipos.Find(id);
        }

        public IEnumerable<Tipo?>? GetAll()
        {
            return db.Tipos.ToList();
        }

        
    }
}
