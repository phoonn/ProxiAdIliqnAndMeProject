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
                client.Close();
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
                client.Close();
            }
            return View(model: laptop);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Laptop laptop)
        {
            try
            {
                using (client = new CrudServiceOf_LaptopClient())
                {
                   bool isdone = client.CreateLaptop(laptop);
                   client.Close();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Edit(int id)
        {
            Laptop laptop;
            using (client = new CrudServiceOf_LaptopClient())
            {
                laptop = client.GetLaptopById(id);
                client.Close();
            }
            return View(model: laptop);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Laptop laptop)
        {
            try
            {
                using (client = new CrudServiceOf_LaptopClient())
                {
                    bool isdone = client.Update(laptop);
                    client.Close();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(laptop);
            }
        }

        [Authorize(Roles = "Administrator")]
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
                client.Close();
            }
            return View(laptop);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmation(int id)
        {
            try
            {
                using (client = new CrudServiceOf_LaptopClient())
                {
                    bool isdone = client.DeleteLaptopById(id);
                    client.Close();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }
    }
}
