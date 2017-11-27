using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Interfaces.Repositories;
using System.Threading.Tasks;

namespace Repositories
{
    public class UsersLaptopRepository : BaseRepository<UsersLaptops> , IUserLaptopRepository<UsersLaptops>
    {
        public UsersLaptopRepository(IUnitOfWork unit) : base(unit)
        {

        }

        public UsersLaptops FindUserLaptop(string userid, int laptopid)
        {
            UsersLaptops usersLaptops = Items.FirstOrDefault(p => (p.UserID == userid)&& p.LaptopID==laptopid);
            return usersLaptops;
        }

        public IEnumerable<int> GetAllLaptopIds(string userid)
        {
            IQueryable<int> query;
            query = Items.Where(i => i.UserID == userid).Select(i => i.LaptopID);
            return query;
        }
    }
}
