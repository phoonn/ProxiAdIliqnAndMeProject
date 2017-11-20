using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.Models;
using WebStore.LaptopCrudService;
using WebStore.Controllers;
using Unity;

namespace WebStore.App_Start
{
    public class Startup
    {
        public static Func<UserManager<User>> UserManagerFactory { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions

            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/auth/login")
            });
            
            app.CreatePerOwinContext(() => UnityConfig.GetContainer().Resolve<CrudServiceOf_LaptopClient>());

            // configure the user manager
            UserManagerFactory = () =>
            {
                var usermanager = new UserManager<User>(
                    new UserStore<User>(new WebStoreDbContext()));
                // allow alphanumeric characters in username
                usermanager.UserValidator = new UserValidator<User>(usermanager)
                {
                    AllowOnlyAlphanumericUserNames = false
                };

                return usermanager;
            };

        }
    }
}