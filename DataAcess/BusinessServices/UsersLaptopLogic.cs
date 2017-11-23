using Interfaces;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class UsersLaptopLogic : IUsersLaptopLogic<Laptops>
    {
        UnitOfWork Unit;
        LaptopRepository laptoprepo;
        UsersLaptopRepository userslaptoprepo;

        public UsersLaptopLogic(UnitOfWork Unit)
        {
            this.Unit = Unit;
            laptoprepo = new LaptopRepository(Unit);
            userslaptoprepo = new UsersLaptopRepository(Unit);
        }

        public IEnumerable<Laptops> GetAllUserLaptops(string userid)
        {
            List<int> laptopids = userslaptoprepo.GetAllLaptopIds(userid).ToList();
            //var values = new StringBuilder();
            //values.AppendFormat("{0}", laptopids[0]);
            //for (int i = 1; i < laptopids.Count; i++)
            //    values.AppendFormat(", {0}", laptopids[i]);
            //var sql = string.Format(
            //"SELECT * FROM [dbo].[Laptops] WHERE [LaptopID] IN ({0})",
            //values);

            return laptoprepo.GetLaptopsById(laptopids);
        }
    }
}
