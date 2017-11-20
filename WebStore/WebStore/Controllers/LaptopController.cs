using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;
using Unity.Attributes;
using WebStore.LaptopCrudService;

namespace WebStore.Controllers
{
    [Route("/Laptop")]
    public class LaptopController : Controller
    {
        private ICrudServiceOf_Laptop client;

        public LaptopController(ICrudServiceOf_Laptop client)
        {
            this.client = client;
        }

        // GET: Laptop
        [Route("Index")]
        public ActionResult Index()
        {
            Laptop[] laptops;
            laptops = client.GetAllLaptops();
            ((ICommunicationObject)client).Close();
            return View(model: laptops);
        }

        // GET: Laptop/Details/5
        [Route("Detalis/{int id}")]
        public ActionResult Details(int id)
        {
            Laptop laptop;
            laptop = client.GetLaptopById(id);
            ((ICommunicationObject)client).Close();
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
                bool isdone = client.CreateLaptop(laptop);
                ((ICommunicationObject)client).Close();
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        //[Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            Laptop laptop;
            laptop = client.GetLaptopById(id);
            ((ICommunicationObject)client).Close();
            return View(model: laptop);
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Laptop laptop)
        {
            try
            {
                bool isdone = client.Update(laptop);
                ((ICommunicationObject)client).Close();
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
            laptop = client.GetLaptopById((int)id);
            ((ICommunicationObject)client).Close();
            return View(laptop);
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmation(int id)
        {
            try
            {
                bool isdone = client.DeleteLaptopById(id);
                ((ICommunicationObject)client).Close();
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }
    }
}
