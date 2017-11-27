using Microsoft.Practices.Unity;
using Unity.Wcf;
using Models;
using BusinessServices;
using Interfaces;
using System.Data.Entity;
using Repositories;
using Interfaces.Repositories;
using AutoMapper;
using Models.DTO;

namespace WcfServiceApp
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<ICrudLogic<Laptops,LaptopDTO>, LaptopsLogic>();
            container.RegisterType<ICrudService<Laptops,LaptopDTO>, LaptopCrudService>();
            container.RegisterType<DbContext, WebStoreContext>();
            container.RegisterType<IUnitOfWork, UnitOfWork>(new PerResolveLifetimeManager());
            container.RegisterType<IRepository<Laptops>,BaseRepository<Laptops>>();
            //second service
            container.RegisterType<IUserLaptopRepository<UsersLaptops>,UsersLaptopRepository>();
            container.RegisterType<IUsersLaptopLogic<Laptops>, UsersLaptopLogic>();
            container.RegisterType<IUsersLaptopService<Laptops>, UsersLaptopService>();
            
        }
    }    
}