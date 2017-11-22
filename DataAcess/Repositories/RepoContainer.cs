using Interfaces;
using Microsoft.Practices.Unity;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    static class RepoContainer
    {
        public static UnityContainer container { get; private set; }
        
        static RepoContainer()
        {
            container = new UnityContainer();
            container.RegisterType<IRepository<Laptop>, BaseRepository<Laptop>>(new InjectionConstructor(new InjectionParameter<DbContext>(null)));
            container.RegisterType<IRepository<PC>, BaseRepository<PC>>(new InjectionConstructor(new InjectionParameter<DbContext>(null)));
        }
    }
}
