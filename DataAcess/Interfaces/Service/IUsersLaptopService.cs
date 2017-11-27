using Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    [ServiceContract]
    public interface IUsersLaptopService<T> where T: class
    {
        [OperationContract]
        [ApplyDataContractResolver]
        IEnumerable<T> GetAllUserLaptops(string userid);

        [OperationContract]
        bool SetLaptop(string userid, int laptopid);
    }
}
