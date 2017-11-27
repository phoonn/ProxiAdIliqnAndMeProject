using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Repositories
{
    public interface IUserLaptopRepository<T> : IRepository<T> where T:class,new()
    {
        T FindUserLaptop(string userid, int laptopid);
    }
}
