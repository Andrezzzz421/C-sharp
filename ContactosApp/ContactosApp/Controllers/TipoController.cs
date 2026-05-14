using ContactosApp.Models;
using ContactosApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactosApp.Controllers
{
    public class TipoController: Controller
    {
        private readonly TipoServices ser;

        public TipoController(TipoServices ser)
        {
            this.ser = ser;
        }

        public ActionResult Index()
        {
            return View(ser.GetAll());
        }

        public ActionResult Create()
        {
            return View(new Tipo());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tipo obj)
        {
            try
            {
                ser.Add(obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(ser.GetAll());
            }
        }

        public ActionResult Edit(int id)
        {
            return View(ser.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Tipo obj)
        {
            try
            {
                ser.Update(obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(ser.GetAll());
            }
        }

        public ActionResult Delete(int id)
        {
            ser.Delete(id);
            return View(ser.GetAll());
        }
    }
}
