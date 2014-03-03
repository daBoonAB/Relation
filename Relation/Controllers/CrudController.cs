using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Relation.Core.Interfaces;
using Relation.Web.Interfaces;
using Relation.Core.Services;
using Relation.Core.Models;
using Relation.Infrastructure.Data;
using Relation.Web.ViewModels;

namespace Relation.Web.Controllers
{
    public abstract class CrudController<TPoco,TViewModel,TListViewModel> : Controller
        where TViewModel :IViewModel
        where TListViewModel : IViewModel

    {
        private readonly ICrudService<TPoco> _service;

        public CrudController(ICrudService<TPoco> service)
        {
            _service = service;

        }

        public virtual ActionResult Create()
        {
            return View("Edit", Activator.CreateInstance<TViewModel>());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create(TViewModel viewModel)
        {
            //call service to create
            if (ModelState.IsValid)
            {
                var dto = Mapper.Map<TPoco>(viewModel);
                if (_service.Create(dto))
                {
                    viewModel = Mapper.Map<TViewModel>(dto);
                    return RedirectToAction("Edit", new { id = viewModel.ID });
                }
            }

            return View(viewModel);
        }

        public virtual ActionResult Edit(dynamic id)
        {
            var poco = _service.GetByID(int.Parse(id));
            var viewModel = Mapper.Map<TViewModel>(poco);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit(TViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var dto = _service.GetByID(viewModel.ID);
                Mapper.Map(viewModel, dto);
                _service.Edit(dto);

               viewModel = (Mapper.Map<TViewModel>(dto));
            }

            return View(viewModel);
        }


        public virtual ActionResult Delete(dynamic id)
        {
            var dto = _service.GetByID(id);
            _service.Delete(dto);
            return RedirectToAction("Index");
        }

        public virtual ActionResult Index()
        {
            var dto = _service.All();
            return View("Index", Mapper.Map<IEnumerable<TViewModel>>(dto));
        }
    }
}
