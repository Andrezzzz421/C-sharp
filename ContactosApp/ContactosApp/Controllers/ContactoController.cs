using ContactosApp.Models;
using ContactosApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContactosApp.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ContactoService ser;
        private readonly TipoServices tser;

        public ContactoController(ContactoService ser,TipoServices tser)
        {   
            this.ser = ser;
            this.tser = tser;
        }

        //public ActionResult Index()
        //{
        //    return View(ser.GetAll());
        //}
        public async Task<IActionResult> Index(int pageNumber = 1,int pageSize = 3)
        {
            var pags = await ser.GetAllPages(pageNumber, pageSize);
            return View(pags);
        }
        public ActionResult Create()
        {
            var x = tser.GetAll().Select(p => new SelectListItem()
            {
                Value = p.IdTipo.ToString(),
                Text = p.Nombre.ToUpper()
            });
            ViewBag.Tipos = x;
            return View(new Contacto());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contacto obj,IFormFile f)
        {
            try
            {
                ser.Add(obj,f);
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View(ser.GetAll());
            }
        }

        public ActionResult Edit(int id)
        {
            var x = tser.GetAll().Select(p => new SelectListItem()
            {
                Value = p.IdTipo.ToString(),
                Text = p.Nombre.ToUpper()
            });
            ViewBag.Tipos = x;
            return View(ser.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Contacto obj,IFormFile f)
        {
            try
            {
                ser.Update(obj, f);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(ser.GetAll());
            }
        }

        public ActionResult Delete(int id)
        {
            ser.Delte(id);
            return View(ser.GetAll());
        }
    }
}
