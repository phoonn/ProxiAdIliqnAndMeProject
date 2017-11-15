using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICrudLogic<T> where T : class, IEntity , new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "", int take = 0);

        List<T> GetAll();

        T GetById(int id);

        void Create(T entity);

        void Delete(T entity);

        void DeleteById(int id);

        void Update(T entity);
    }
}
