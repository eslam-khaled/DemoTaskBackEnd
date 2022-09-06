using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DemoTask.DAL.BaseRepository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> AddNew(T obj);
        Task<bool> AddList(IEnumerable<T> obj);
        IEnumerable<T> GetAll();
        Task<T> FindById(int id);
        Task<bool> Delete(T id);
        Task<T> GetById(int id);
        Task<bool> Update(T obj);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate);
    }
}
