using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebStore.LaptopsCrudService;

namespace WebStore.Controllers
{
    [Route("/Laptop")]
    public class LaptopController : Controller
    {
        private CrudServiceOf_LaptopClient client;
        // GET: Laptop
        [Route("Index")]
        public ActionResult Index()
        {
            Laptop[] laptops;
            using (client = new CrudServiceOf_LaptopClient())
            {
                laptops = client.GetAllLaptops();
            }
            return View(model: laptops);
        }

        // GET: Laptop/Details/5
        [Route("Detalis/{int id}")]
        public ActionResult Details(int id)
        {
            Laptop laptop;
            using (client = new CrudServiceOf_LaptopClient())
            {
               laptop = client.GetLaptopById(id);
            }
            return View(model: laptop);
        }

        // GET: Laptop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Laptop/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Laptop/Edit/5
        public ActionResult Edit(int id)
        {
            Laptop laptop;
            using (client = new CrudServiceOf_LaptopClient())
            {
                laptop = client.GetLaptopById(id);
            }
            return View(model: laptop);
        }

        // POST: Laptop/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Laptop laptop)
        {
            try
            {
                using (client = new CrudServiceOf_LaptopClient())
                {
                    client.Update(laptop);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(laptop);
            }
        }

        // GET: Laptop/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laptop laptop;
            using (client = new CrudServiceOf_LaptopClient())
            {
                laptop = client.GetLaptopById((int)id);
            }
            return View(laptop);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmation(int id)
        {
            try
            {
                using (client = new CrudServiceOf_LaptopClient())
                {
                    client.DeleteLaptopById(id);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
