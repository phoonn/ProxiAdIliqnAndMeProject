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
        IEnumerable<T> GetAllUserLaptops(string userid);
    }
}
