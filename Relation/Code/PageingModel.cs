using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relation.Web.Code
{
    public class PageingModel
    {
        public int Hits { get; private set; }
        public int PageSize { get; private set; }
        public int ActivePage { get; private set; }
        public int PageCount
        {
            get
            {
                if (Hits % PageSize == 0)
                    return (Hits / PageSize);

                return (Hits / PageSize) + 1;
            }

        }

        public PageingModel(int hits, int pagesize, int activepage)
        {
            Hits = hits;
            PageSize = pagesize;
            ActivePage = activepage;
        }
    }
}