using Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Interfaces
// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
{   [ServiceContract]
    public interface ICrudService<T,R>  where T: class where R:class
    {
        //Laptos
        [OperationContract]
        [ApplyDataContractResolver]
        IEnumerable<T> GetAllLaptops();

        [OperationContract]
        IEnumerable<R> GetAllLaptopMapped();

        [OperationContract]
        [ApplyDataContractResolver]
        T GetLaptopById(int id);

        [OperationContract]
        bool DeleteLaptop(T entity);

        [OperationContract]
        bool DeleteLaptopById(int id);

        [OperationContract]
        bool CreateLaptop(T entity);

        [OperationContract]
        bool Update(T entity);
        // TODO: Add your service operations here
    }
}
