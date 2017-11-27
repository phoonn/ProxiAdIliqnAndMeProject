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

        [HttpPost]
        public void ChangeFavourites(int laptopID)
        {
            client.SetLaptop(User.Identity.GetUserId(), laptopID);
            client.Close();
        }
    }
}
