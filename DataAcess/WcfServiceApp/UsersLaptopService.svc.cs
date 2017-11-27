using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Interfaces;
using Models;
using BusinessServices;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UsersLaptopService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UsersLaptopService.svc or UsersLaptopService.svc.cs at the Solution Explorer and start debugging.
    public class UsersLaptopService : IUsersLaptopService<Laptops>
    {
        IUsersLaptopLogic<Laptops> logic;

        public UsersLaptopService(IUsersLaptopLogic<Laptops> logic)
        {
            this.logic = logic;
        }

        public IEnumerable<Laptops> GetAllUserLaptops(string userid)
        {
            return logic.GetAllUserLaptops(userid);
        }

        public bool SetLaptop(string userid, int laptopid)
        {
            return logic.SetLaptop(userid, laptopid);
           
        }
    }
}
