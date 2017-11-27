using BusinessServices;
using Interfaces;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using AutoMapper;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LaptopCrudService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LaptopCrudService.svc or LaptopCrudService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class LaptopCrudService : ICrudService<Laptops,LaptopDTO> , IDisposable
    {
        private ICrudLogic<Laptops,LaptopDTO> LaptopLogic;

        public LaptopCrudService (ICrudLogic<Laptops,LaptopDTO> LaptopLogic)
        {
            this.LaptopLogic = LaptopLogic;
        }

        public IEnumerable<Laptops> GetAllLaptops()
        {
            IEnumerable<Laptops> laptops = LaptopLogic.GetAll();
            return laptops;
        }

        public IEnumerable<LaptopDTO> GetAllLaptopMapped()
        {
            IEnumerable<LaptopDTO> laptopsdto = LaptopLogic.GetAllMapped();
            return laptopsdto;
        }

        public Laptops GetLaptopById(int id)
        {
            Laptops laptop = LaptopLogic.GetById(id);
            return laptop;
        }

        public bool DeleteLaptop(Laptops laptop)
        {
            try
            {
                LaptopLogic.Delete(laptop);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteLaptopById(int id)
        {
            try
            {
                LaptopLogic.DeleteById(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateLaptop(Laptops laptop)
        {
            try
            {
                LaptopLogic.Create(laptop);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Laptops laptop)
        {
            //try
            //{
                LaptopLogic.Update(laptop);
                return true;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    LaptopLogic.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~LaptopCrudService() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        
        #endregion
    }
}
