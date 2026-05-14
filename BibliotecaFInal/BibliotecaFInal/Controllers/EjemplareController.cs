using BibliotecaFInal.Models;
using BibliotecaFInal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BibliotecaFInal.Controllers
{
    public class EjemplareController:Controller
    {
        private readonly EjemplareServices ser;
        private readonly BibliotecaFinalContext db;

        public EjemplareController(BibliotecaFinalContext db)
        {
            this.db = db;
            ser = new EjemplareServices(db);
        }

        public ActionResult Index()
        {
            return View(ser.GetAll());
        }

        public ActionResult Create()
        {
            ViewBag.Libros = new SelectList(db.Libros, "IdLibro", "Titulo");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ejemplare e)
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
                ViewBag.Libros = new SelectList(db.Libros, "IdLibro", "Titulo", e.IdLibro);
                ViewBag.Estados = new SelectList(new[] { "Disponible", "Prestado", "Reservado" }, e.Estado);
                return View(e);
            }
        }

        public ActionResult Edit(int id)
        {
            var ejemplare = ser.GetById(id);

            if(ejemplare == null)
            {
                return NotFound();
            }
            ViewBag.Libros = new SelectList(db.Libros, "IdLibro", "Titulo",ejemplare.IdLibro);

            return View(ejemplare);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Ejemplare e)
        {
            if (ModelState.IsValid)
            {
                ser.Update(e);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Libros = new SelectList(db.Libros, "IdLibro", "Titulo" ,e.IdLibro);
            return View(e);

        }

        public ActionResult Delete(int id)
        {
            ser.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
