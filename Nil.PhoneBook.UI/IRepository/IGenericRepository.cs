using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Nil.PhoneBook.UI.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetAll(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> ordeby = null,
            List<string> includes = null
            );
        Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null);
        Task Insert(T entity);
        Task InsertRange(IEnumerable<T> entites);
        Task Delete(int id);
        void  DeleteRange(IEnumerable<T> entites);

        void Update(T entity);
    }
}
