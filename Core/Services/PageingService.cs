using Relation.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;

namespace Relation.Core.Services
{
    public class PageingService<T> : IPagedQuery<T> where T : class
    {
        private readonly string _searchLambda;
        private readonly string _orderByColumn;
        private readonly IRepository<T> _repo;

        public PageingService(IRepository<T> repo, string searchLambda, string orderByColumn)
        {
            _searchLambda = searchLambda;
            _orderByColumn = orderByColumn;
            _repo = repo;
        }

        public Class.Pager<T> Query(string filter, int currentPage, int pageSize)
        {
            var q = _repo.Queryable();
            if (!string.IsNullOrEmpty(filter))
                q = q.Where(_searchLambda,filter);

            return new Class.Pager<T>(q, c =>_orderByColumn, currentPage, pageSize);

        }
    }
}
