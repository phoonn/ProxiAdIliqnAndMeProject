using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;
using WebStore.UsersLaptopService;

namespace WebStore.Controllers
{
    public class FavouriteLaptopsController : Controller
    {
        UsersLaptopServiceOf_LaptopsClient client = new UsersLaptopServiceOf_LaptopsClient();
        // GET: FavouriteLaptops
        public ActionResult Index()
        {
            IEnumerable<Laptops> laptops = client.GetAllUserLaptops(User.Identity.GetUserId());
            client.Close();
            return View(laptops);
        }

        // GET: FavouriteLaptops/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FavouriteLaptops/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FavouriteLaptops/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FavouriteLaptops/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FavouriteLaptops/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FavouriteLaptops/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FavouriteLaptops/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
