using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class UserController : Controller
    {
        private WebStoreDbContext Db;
        private UserManager<User> UserManager;

        public UserController(WebStoreDbContext db)
        {
            Db = db;
            UserManager = new UserManager<User>(
                    new UserStore<User>(new WebStoreDbContext()));
            // allow alphanumeric characters in username
            UserManager.UserValidator = new UserValidator<User>(UserManager)
            {
                AllowOnlyAlphanumericUserNames = false
            };
        }

        // GET: User
        public async Task<ActionResult> Index(int page = 1)
        {
            IEnumerable<User> users;
            int pageSize = 10;
            int totalCount = await Db.Users.CountAsync();
            users = Db.Users.OrderBy(u => u.Id).Include("Roles").Skip(pageSize * (page - 1)).Take(pageSize).AsEnumerable();
            int pageCount = (totalCount % pageSize == 0 ? totalCount / pageSize : (totalCount / pageSize + 1));
            var result = new PagedListModel<User>(users, totalCount, pageCount);
            return View(result);
        }

        public async Task<ActionResult> Details(string userName)
        {
            var user = await Db.Users.Include("Roles").SingleOrDefaultAsync(x => x.UserName == userName);
            return View(user);
        }

        [HttpPost]
        public async Task<ActionResult> ChangeRole(string userName, string role)
        {
            var user = await Db.Users.Include("Roles").SingleOrDefaultAsync(x => x.UserName == userName);
            var oldRoleId = user.Roles.SingleOrDefault().RoleId;
            var oldRoleName = Db.Roles.SingleOrDefault(r => r.Id == oldRoleId).Name;

            if (oldRoleName != role)
            {
                UserManager.RemoveFromRole(user.Id, oldRoleName);
                UserManager.AddToRole(user.Id, role);
            }
            Db.Entry(user).State = EntityState.Modified;

            await Db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> ChangeState(string userName, string state)
        {
            bool locked = !state.Equals("0");
            var user = await Db.Users.SingleOrDefaultAsync(x => x.UserName == userName);
            user.LockoutEnabled = locked;
            await Db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string userName)
        {
            var user = await Db.Users.SingleOrDefaultAsync(x => x.UserName == userName);
            Db.Users.Remove(user);
            await Db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}