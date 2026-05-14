using BibliotecaFInal.Models;
using BibliotecaFInal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BibliotecaFInal.Controllers
{
    public class EditorialeController : Controller
    {
        private readonly EditorialeServices ser;
        private readonly BibliotecaFinalContext db;

        public EditorialeController(BibliotecaFinalContext db)
        {
            this.db = db;
            ser = new EditorialeServices(db);
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
        public ActionResult Create(Editoriale e)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ser.Add(e);
                    return RedirectToAction(nameof(Index));
                }
                return View(e);
            }
            catch
            {
                return View(e);
            }
        }

        public ActionResult Edit(int id)
        {
            var editorial = ser.GetById(id);

            if (editorial == null)
            {
                return NotFound();
            }
            ViewBag.Paises = new SelectList(db.Paises, "IdPais", "Nombre", editorial.IdPais);

            return View(editorial);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Editoriale e)
        {
            if (ModelState.IsValid)
            {
                ser.Update(e);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Paises = new SelectList(db.Paises, "IdPais", "Nombre", e.IdPais);
            return View(e);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                bool exito = ser.Delete(id);
                if (exito)
                {
                    TempData["Error"] = "No se puede eliminar la editorial porque tiene libros asociados. Primero elimina o reasigna sus libros.";
                    return RedirectToAction(nameof(Index));
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Ocurrió un error inesperado: " + ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
