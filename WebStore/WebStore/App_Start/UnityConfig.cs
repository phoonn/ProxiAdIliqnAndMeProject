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

        static UnityConfig()
        {
            Container = new UnityContainer();
        }
        public static UnityContainer GetContainer()
        {
            return Container;
        }

        public static void ConfigureUnityInj()
        {
            
            Container.RegisterType<ICrudServiceOf_Laptops, CrudServiceOf_LaptopsClient>(new InjectionConstructor());

            DependencyResolver.SetResolver(new ServiceDependencyResolver(Container));
        }
    }
}