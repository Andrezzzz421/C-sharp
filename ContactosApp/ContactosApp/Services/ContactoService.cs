using ContactosApp.Data;
using ContactosApp.Helpers;
using ContactosApp.Models;
using ContactosApp.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ContactosApp.Services
{
    public class ContactoService
    {
        private readonly ContactosDbContext db;
        public ContactoService(ContactosDbContext db)
        {
            this.db = db;
        }

        public void Add(Contacto obj,IFormFile? f)
        {
            if (f != null)
                obj.Foto = APImage.Tobyte(f);

            db.Contactos.Add(obj);
            db.SaveChanges();     
        }

        public void Update(Contacto obj, IFormFile? f)
        {
            var x = db.Contactos.Find(obj.IdContactos);
            if (x != null)
            {
                x.Nombre = obj.Nombre;
                x.Apellido = obj.Apellido;
                x.Direccion = obj.Direccion;
                x.Telefono = obj.Telefono;
                x.Correo = obj.Correo;
                x.IdTipo = obj.IdTipo;

                if(f != null)
                     x.Foto = APImage.Tobyte(f);

                db.Contactos.Update(x);
                db.SaveChanges();
                
            }
        }

        public void Delte(int id)
        {
            var x = db.Contactos.Find(id);
            if(x != null)
            {
                db.Contactos.Remove(x);
                db.SaveChanges();
            }
        }

        public Contacto? GetById(int id)
        {
            return db.Contactos.Find(id);
        }

        public IEnumerable<ContactosViewModel?>? GetAll()
        {
            return db.Contactos
                .Include(x => x.IdTipoNavigation)
                .Select(x => ContactosViewModel.MapTo(x))
                .ToList();
        }

        public async Task<Pager<ContactosViewModel>> GetAllPages(int pageNumber,
            int pageSize)
        {
            var totalItems = await db.Contactos.CountAsync();

            var items = await db.Contactos
                .OrderBy(p => p.IdContactos)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(c => new ContactosViewModel
                {
                    Id = c.IdContactos,
                    Contacto = c.Nombre.ToUpper() + " " + c.Apellido.ToUpper(),
                    Telefono = c.Telefono,
                    Correo = c.Correo,
                    Estado = c.Estado,
                    Tipo = c.IdTipoNavigation.Nombre
                })
                .ToListAsync();

            return new Pager<ContactosViewModel>
            {
                Items = items,
                TotalItems = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
    }
}
