using BibliotecaFInal.Models;

namespace BibliotecaFInal.Services
{
    public class PaisesServices
    {
        private readonly BibliotecaFinalContext db;

        public PaisesServices(BibliotecaFinalContext db)
        {
            this.db = db;
        }

        public void Add(Paise obj)
        {
            db.Paises.Add(obj);
            db.SaveChanges();
        }

        public void Update(Paise obj)
        {
            db.Paises.Update(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var x = db.Paises.Find(id);
            if (x != null)
            {
                db.Paises.Remove(x);
                db.SaveChanges();
            }
        }

        public  Paise? GetById(int id)
        {
            return db.Paises.Find(id);
        }

        public List<Paise> GetAll()
        {
            return db.Paises.ToList();
        }


    }
}
