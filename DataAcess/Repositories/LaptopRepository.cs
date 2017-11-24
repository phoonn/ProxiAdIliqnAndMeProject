using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class LaptopRepository : BaseRepository<Laptops>
    {
        public LaptopRepository(IUnitOfWork unit) : base(unit)
        {

        }

        public IEnumerable<Laptops> GetLaptopsById(List<int> laptopids)
        {
            IQueryable<Laptops> query;
            query = Items.Where(r => laptopids.Contains(r.LaptopID));
            //var result = context.Database.SqlQuery<Laptops>(sql).ToList();
            return query.ToList();
        }
    }
}
