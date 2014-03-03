using Relation.Core.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Relation.Core.Interfaces
{
    public interface IPagedQuery<T>
    {
        Pager<T> Query(string filter, int currentPage, int pageSize);
    }
}
