using Microsoft.Practices.Unity;
using Unity.Wcf;
using Models;
using BusinessServices;
using Interfaces;
using System.Data.Entity;
using Repositories;

namespace WcfServiceApp
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<ICrudLogic<Laptop>, LaptopsLogic>();
            container.RegisterType<ICrudService<Laptop>, LaptopCrudService>();
            container.RegisterType<DbContext, WebStoreContext>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
        }
    }    
}