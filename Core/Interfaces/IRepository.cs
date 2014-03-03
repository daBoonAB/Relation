using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Relation.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T objToCreate);
        void Update(T objToEdit);
        void Remove(T objToDelete);
        void Save();
        T GetByID(dynamic id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Query(Expression<Func<T, bool>> expression);
        IQueryable<T> Queryable();

    }
}







