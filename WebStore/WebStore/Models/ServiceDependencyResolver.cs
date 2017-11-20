using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace WebStore.Models
{
    public class ServiceDependencyResolver : IDependencyResolver
    {
        private UnityContainer container;

        public ServiceDependencyResolver (UnityContainer container)
        {
            this.container = container;
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return container.Resolve(serviceType);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return container.ResolveAll(serviceType);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}