using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Repositories
{
    public class RepoInjector
    {
        public IUnityContainer container { get; }
        
        public RepoInjector()
        {
            container = new UnityContainer();
            container.RegisterType<DbContext, WebStoreContext>();
        }
    }
}
