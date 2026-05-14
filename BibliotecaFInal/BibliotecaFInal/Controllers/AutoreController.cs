using BibliotecaFInal.Models;
using BibliotecaFInal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaFInal.Controllers
{
    public class AutoreController:Controller
    {
        private readonly AutoreServices ser;
        private readonly BibliotecaFinalContext db;


        public AutoreController(BibliotecaFinalContext db)
        {
            this.db = db;
            ser = new AutoreServices(db);
        }

        public ActionResult Index()
        {
            return View(ser.GetAll());
        }

        public ActionResult Create()
        {
            ViewBag.Paises = new SelectList(db.Paises, "IdPais", "Nombre");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Autore a,IFormFile arc)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    ser.Add(a,arc);
                    return RedirectToAction(nameof(Index));
                }
                return View(a);
            }
            catch
            {
                return View(a);
            }
        }

        public ActionResult Edit(int id)
        {
            var actor = ser.GetById(id);

            if(actor == null)
            {
                NotFound();
            }
            ViewBag.Paises = new SelectList(db.Paises, "IdPais", "Nombre",actor.IdPaisOrigen);

            return View(actor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Autore a, IFormFile arc)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await ser.Update(a, arc);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error al actualizar: " + ex.Message);
                }
            }

            ViewBag.Paises = new SelectList(db.Paises, "IdPais", "Nombre", a.IdPaisOrigen);
            return View(a);

        }
        public ActionResult Delete(int id)
        {
            bool exito = ser.Delete(id);
            if (exito)
            {
                TempData["Error"] = "No puedes borrar este autor porque tiene libros escritos.";
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}