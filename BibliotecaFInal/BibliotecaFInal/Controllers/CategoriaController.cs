using BibliotecaFInal.Models;
using BibliotecaFInal.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BibliotecaFInal.Controllers
{
    public class CategoriaController: Controller
    {
        private readonly CategoriaServices ser;
        private readonly BibliotecaFinalContext db;

        public CategoriaController(BibliotecaFinalContext db)
        {
            this.db = db;
            ser = new CategoriaServices(db);
        }

        public ActionResult Index()
        {
            return View(ser.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria c,IFormFile arc)
        {
            try
            {
                if (arc != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        arc.CopyTo(ms);
                        c.Logo = ms.ToArray();
                    }
                }

                if (ModelState.IsValid)
                {
                    ser.Add(c);
                    return RedirectToAction(nameof(Index));
                }
                return View(c);
            }
            catch
            {
                return View(c);
            }
        }

        public ActionResult Edit(int id)
        {
            var categoria = ser.GetById(id);

            if(categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Categoria c, IFormFile arc)
        {

            if(await ser.UpdateConFoto(c, arc))
            {
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError("", "No se pudo actualizar la categoria");
            return View(c);
        }
        public ActionResult Delete(int id)
        {
            bool exito = ser.Delete(id);
            if (exito)
            {
                TempData["Error"] = "Esta categoría no se puede borrar porque tiene libros asignados.";
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }    
    }
}
