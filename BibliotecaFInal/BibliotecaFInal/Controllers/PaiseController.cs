using BibliotecaFInal.Models;
using BibliotecaFInal.Services;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaFInal.Controllers
{
    public class PaiseController:Controller
    {
        private readonly PaisesServices ser;
        private readonly BibliotecaFinalContext db;

        public PaiseController(BibliotecaFinalContext db)
        {
            this.db = db;
            ser = new PaisesServices(db);
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
        public ActionResult Create(Paise p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ser.Add(p);
                    return RedirectToAction(nameof(Index));
                }
                return View(ser.GetAll());
            }
            catch
            {
                return View(ser.GetAll());
            }
        }

        public ActionResult Edit(int id)
        {
            var pais = ser.GetById(id);

            if(pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Paise p)
        {
            if (ModelState.IsValid)
            {
                ser.Update(p);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            try
            {
                bool tieneAutores = db.Autores.Any(a => a.IdPaisOrigen == id);

                bool tieneEditoriales = db.Editoriales.Any(e => e.IdPais == id);

                if (tieneAutores || tieneEditoriales)
                {
                    string mensaje = "No se puede eliminar el país porque tiene: ";
                    if (tieneAutores) mensaje += "Autores asociados. ";
                    if (tieneEditoriales) mensaje += "Editoriales asociadas.";

                    TempData["Error"] = mensaje;
                    return RedirectToAction(nameof(Index));
                }

                var pais = db.Paises.Find(id);
                if (pais != null)
                {
                    db.Paises.Remove(pais);
                    db.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error inesperado: " + ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }

    }
}
