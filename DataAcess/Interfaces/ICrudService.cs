using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Interfaces
// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
{   [ServiceContract]
    public interface ICrudService<T>  where T: class,IEntity,new()
    {
        //Laptos
        [OperationContract]
        List<T> GetAllLaptops();

        [OperationContract]
        T GetLaptopById(int id);

        [OperationContract(IsOneWay =true)]
        void DeleteLaptop(T entity);

        [OperationContract(IsOneWay = true)]
        void DeleteLaptopById(int id);

        [OperationContract(IsOneWay = true)]
        void CreateLaptop(T entity);

        [OperationContract(IsOneWay = true)]
        void Update(T entity);
        // TODO: Add your service operations here
    }
}
