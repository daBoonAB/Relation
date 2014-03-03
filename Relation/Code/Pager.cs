using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relation.Web.Models
{
    public class Pager<T>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public IQueryable<T> QueryForPageing { get; set; }
    }
}