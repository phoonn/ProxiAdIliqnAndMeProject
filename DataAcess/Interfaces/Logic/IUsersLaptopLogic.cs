﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUsersLaptopLogic<T>
    {
        IEnumerable<T> GetAllUserLaptops(string userid);
        bool SetLaptop(string userid, int laptopid);
    }
}
