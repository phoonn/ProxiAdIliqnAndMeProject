using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using WebStore.LaptopCrudService;
using WebStore.Models;

namespace WebStore.App_Start
{
    public class UnityConfig
    {
        private static UnityContainer Container;

        public UnityConfig()
        {
            Container = new UnityContainer();
        }

        public static UnityContainer GetContainer()
        {
            return Container;
        }

        public static void ConfigureUnityInj()
        {
            Container.RegisterType<ICrudServiceOf_Laptop, CrudServiceOf_LaptopClient>(new InjectionConstructor());

            //DependencyResolver.SetResolver(new ServiceDependencyResolver(Container));
        }
    }
}