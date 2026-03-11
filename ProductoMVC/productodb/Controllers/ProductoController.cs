using Microsoft.AspNetCore.Mvc;
using productodb.Models;
using productodb.Services;

namespace productodb.Controllers
{
    public class ProductoController:Controller
    {
        private readonly ProductosServices ser;

        public ProductoController(ProductosDbContext db)
        {
            ser = new ProductosServices(db);
        }

        //GET: ProductoController

        public ActionResult Index()
        {
            return View(ser.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        //POST: ProductoController//Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Producto p)
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

        //POST:ProductoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Producto ob)
        {
            try
            {
                if (ModelState.IsValid)
                { 
                    ser.Update(ob);
                    return RedirectToAction(nameof(Index));
                }
                return View(ser.GetAll());
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            ser.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
