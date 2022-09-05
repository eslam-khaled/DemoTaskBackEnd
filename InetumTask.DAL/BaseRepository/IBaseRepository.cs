using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DemoTask.DAL.BaseRepository
{
    public interface IBaseRepository<T> where T : class
    {
        T AddNew(T obj);
        void AddList(IEnumerable<T> obj);
        IEnumerable<T> GetAll();
        void FindById(int id);
        void Delete(T id);
        T GetById(int id);
        void Update(T obj);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate);
    }
}
