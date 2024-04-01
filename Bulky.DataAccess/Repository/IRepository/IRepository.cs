using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // T - Category
        IEnumerable<T> GetAll();

        //u=>u.Id==id can be passed to function as Expression<Func<T,bool>> filter
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
