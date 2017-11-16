using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebStore.LaptopCrudService;

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

        //[Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Laptop laptop)
        {
            try
            {
                using (client = new CrudServiceOf_LaptopClient())
                {
                    bool isdone = client.CreateLaptop(laptop);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //[Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            Laptop laptop;
            using (client = new CrudServiceOf_LaptopClient())
            {
                laptop = client.GetLaptopById(id);
            }
            return View(model: laptop);
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Laptop laptop)
        {
            try
            {
                using (client = new CrudServiceOf_LaptopClient())
                {
                    bool isdone = client.Update(laptop);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(laptop);
            }
        }

        //[Authorize(Roles = "Admin")]
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

        //[Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmation(int id)
        {
            try
            {
                using (client = new CrudServiceOf_LaptopClient())
                {
                    bool isdone = client.DeleteLaptopById(id);
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
