using Relation.Core.Class;
using Relation.Core.Models;
using Relation.Core.Services;
using Relation.Infrastructure.Data;
using Relation.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Relation.Web.Controllers
{
    public class CategoryTypeController : CrudPageingController<tblCategoryType,InputViewModel,InputViewModel>
    {
       
        public CategoryTypeController():base(new PageingService<tblCategoryType>(new Repository<tblCategoryType>(),DynamicLambdaExpressions.strNameLowerContains,"strName"),
            new CrudService<tblCategoryType>(new Repository<tblCategoryType>())) { }
           
    }
}
