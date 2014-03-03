using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Relation.Core.Interfaces
{
    public interface ICrudService<T>
    {
        bool Create(T objToCreate);
        bool Edit(T objToEdit);
        bool Delete(T objToDelete);
        T GetByID(dynamic id);
        IEnumerable<T> All();
        IEnumerable<T> Query(Expression<Func<T, bool>> expression);
    }
}
