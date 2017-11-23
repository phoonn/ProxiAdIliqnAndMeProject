using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;
using Unity.Attributes;
using WebStore.LaptopCrudService;
using WebStore.Models;

namespace WebStore.Controllers
{
    [Route("/Laptop")]
    public class LaptopController : Controller
    {
        private ICrudServiceOf_Laptops client;

        public LaptopController(ICrudServiceOf_Laptops client)
        {
            this.client = client;
        }

        // GET: Laptop
        [Route("Index")]
        public ActionResult Index()
        {
            Laptops[] laptops;
            laptops = client.GetAllLaptops();
            ((ICommunicationObject)client).Close();
            return View(model: laptops);
        }

        // GET: Laptop/Details/5
        [Route("Detalis/{int id}")]
        public ActionResult Details(int id)
        {
            Laptops laptop;
            laptop = client.GetLaptopById(id);
            ((ICommunicationObject)client).Close();
            return View(model: laptop);
        }

        [Authorize(Roles = "Administrator, Moderator")]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Administrator, Moderator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateLaptopModel laptop)
        {
            try
            {
                byte[] fileData = null;
                using (var binaryReader = new BinaryReader(Request.Files["photo"].InputStream))
                {
                    fileData = binaryReader.ReadBytes(Request.Files["photo"].ContentLength);
                }
                var newLaptop = new Laptops
                {
                    Brand = laptop.Brand,
                    Model = laptop.Model,
                    Price = laptop.Price,
                    OS = laptop.OS,
                    Image = fileData,
                    Ram = laptop.Ram,
                    Processor = laptop.Processor,
                    HardDisk = laptop.HardDisk,
                    Screen = laptop.Screen
                };

                bool isdone = client.CreateLaptop(newLaptop);
                ((ICommunicationObject)client).Close();
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        [Authorize(Roles = "Administrator, Moderator")]
        public ActionResult Edit(int id)
        {
            Laptops laptop;
            laptop = client.GetLaptopById(id);
            ((ICommunicationObject)client).Close();
            return View(model: laptop);
        }

        [Authorize(Roles = "Administrator, Moderator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CreateLaptopModel laptop)
        {
            try
            {
                var newLaptop = new Laptops
                {
                    Brand = laptop.Brand,
                    Model = laptop.Model,
                    Price = laptop.Price,
                    OS = laptop.OS,
                    Ram = laptop.Ram,
                    Processor = laptop.Processor,
                    HardDisk = laptop.HardDisk,
                    Screen = laptop.Screen
                };

                bool isdone = client.Update(newLaptop);
                ((ICommunicationObject)client).Close();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(laptop);
            }
        }

        [Authorize(Roles = "Administrator, Moderator")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Laptops laptop;
            laptop = client.GetLaptopById((int)id);
            ((ICommunicationObject)client).Close();
            return View(laptop);
        }

        [Authorize(Roles = "Administrator, Moderator")]
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
