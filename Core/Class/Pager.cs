using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Relation.Core.Class
{
   public class Pager<T>
   {
       public Pager(IQueryable<T> queryToPage, Func<T,string> order, int currentpage, int pagesize)
       {
           Query = queryToPage;
           Hits = Query.Count();

           int start = 0;
           if (currentpage > 1)
               start = pagesize * (currentpage - 1);

           Query = Query.OrderBy(order).Skip(start).Take(pagesize).AsQueryable();
       }

       public int Hits { get; set; }
       public IEnumerable<T> Result
       {
           get
           {
               return Query.AsEnumerable();
           }
       }

       public IQueryable<T> Query { get; private set; }
   }
}
