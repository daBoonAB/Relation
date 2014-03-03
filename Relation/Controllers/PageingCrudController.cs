using Relation.Core.Interfaces;
using Relation.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Relation.Web.Controllers
{

    public abstract class CrudPageingController<TPoco,TViewModel,TListViewModel> : CrudController<TPoco,TViewModel,TListViewModel>
        where TListViewModel : IViewModel
        where TViewModel :IViewModel
    {
        private readonly IPagedQuery<TPoco> _pageing;
        protected int Pagesize = 10;

        protected CrudPageingController(IPagedQuery<TPoco> pageing, ICrudService<TPoco> crudservice)
            : base(crudservice)
        {
            _pageing = pageing;
        }

    
        public override ActionResult Index()
        {
            TempData.Remove("filterText");
            return Page();
        }

        public ActionResult Page([Bind(Prefix="id")]int page = 1, string filterText = "")
        {
            if(!string.IsNullOrEmpty(filterText))
            {
                TempData["filterText"] = filterText;
                ViewBag.filterText = filterText;
            }
            else if (TempData["filterText"] != null)
            {
                ViewBag.filterText = TempData["filterText"];
                filterText = ViewBag.filterText;
                TempData["filterText"] = filterText;
            }

            var dto = _pageing.Query(filterText, page, Pagesize);

            ViewBag.Pager = new Relation.Web.Code.PageingModel(dto.Hits, Pagesize, page);
            
            return View("Index",AutoMapper.Mapper.Map<IEnumerable<TListViewModel>>(dto.Result));
        }

        [HttpPost]
        public ActionResult Page(string filterText)
        {

            TempData.Remove("filterText");
            return Page(1, filterText);
        }
    }
}
