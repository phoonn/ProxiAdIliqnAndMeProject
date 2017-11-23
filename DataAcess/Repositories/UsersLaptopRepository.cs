using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UsersLaptopRepository : BaseRepository<UsersLaptops>
    {
        public UsersLaptopRepository(UnitOfWork unit) : base(unit.Context)
        {

        }

        public IEnumerable<int> GetAllLaptopIds(string userid)
        {
            IQueryable<int> query;
            query = Items.Where(i => i.UserID == userid).Select(i => i.LaptopID);
            return query;
        }
    }
}
