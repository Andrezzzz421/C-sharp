using BibliotecaFInal.Models;
using BibliotecaFInal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;

namespace BibliotecaFInal.Controllers
{
    public class LibroController : Controller
    {
        private readonly LibroServices ser;
        private readonly BibliotecaFinalContext db;

        private void CargarCombos(Libro l = null)
        {
            ViewBag.Autore = new SelectList(db.Autores, "IdAutor", "Nombre", l?.IdAutor);
            ViewBag.Categoria = new SelectList(db.Categorias, "IdCategoria", "Nombre", l?.IdCategoria);
            ViewBag.Editoriale = new SelectList(db.Editoriales, "IdEditorial", "Nombre", l?.IdEditorial);
        }

        public LibroController(BibliotecaFinalContext db)
        {
            this.db = db;
            ser = new LibroServices(db);
        }

        public ActionResult Index()
        {
            return View(ser.GetAll());
        }

        public ActionResult Create()
        {
            CargarCombos();
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Libro l,IFormFile arc)
        {
            try
            {
                if (arc != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        arc.CopyTo(ms);
                        l.Portada = ms.ToArray();
                    }
                }

                if (ModelState.IsValid)
                {
                    ser.Add(l);
                    return RedirectToAction(nameof(Index));
                }
                return View(l);
            }
            catch
            {
                return View(l);
            }
        }


        public ActionResult Edit(int id)
        {
            var libro = ser.GetById(id);

            if(libro == null)
            {
                NotFound();
            }

            CargarCombos();

            return View(libro);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Libro l, IFormFile arc)
        {
            ModelState.Remove("IdAutorNavigation");
            ModelState.Remove("IdCategoriaNavigation");
            ModelState.Remove("IdEditorialNavigation");
            ModelState.Remove("Portada"); 
            ModelState.Remove("arc");    

            if (arc != null && arc.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    arc.CopyTo(ms);
                    l.Portada = ms.ToArray();
                }
            }
            else
            {
                var libroExistente = db.Libros.AsNoTracking()
                                       .FirstOrDefault(x => x.IdLibro == l.IdLibro);
                if (libroExistente != null)
                {
                    l.Portada = libroExistente.Portada;
                }
            }

            if (ModelState.IsValid)
            {
                ser.Update(l);
                return RedirectToAction(nameof(Index));
            }

            CargarCombos(l);
            return View(l);
        }



        public ActionResult Delete(int id)
        {
            bool tieneEjemplar = db.Ejemplares.Any(l => l.IdLibro == id);

            if (tieneEjemplar)
            {
                TempData["Error"] = "No puedes borrar este autor porque tiene Ejemplares escritos. Elimina primero sus Ejemplares.";
                return RedirectToAction(nameof(Index));
            }

            ser.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ExportarDetalle(int id)
        {
            var libro = await db.Libros
                .Include(l => l.IdAutorNavigation)
                .Include(l => l.IdCategoriaNavigation)
                .Include(l => l.IdEditorialNavigation)
                .FirstOrDefaultAsync(m => m.IdLibro == id);

            return View("ExportarDetalle", libro);
        }

        public async Task<IActionResult> ExportarListado(int? idCategoria, int? idAutor, int? anio)
        {
            var query = db.Libros
                .Include(l => l.IdAutorNavigation)
                .Include(l => l.IdCategoriaNavigation)
                .Include(l => l.IdEditorialNavigation) 
                .AsQueryable();

            if (idCategoria.HasValue) query = query.Where(l => l.IdCategoria == idCategoria);
            if (idAutor.HasValue) query = query.Where(l => l.IdAutor == idAutor);
            if (anio.HasValue) query = query.Where(l => l.AnioPublicacion == anio);

            var lista = await query.ToListAsync();
            return View("Listado", lista);
        }
    }
}
