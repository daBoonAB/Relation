using Relation.Core.Class;
using Relation.Core.Models;
using Relation.Core.Services;
using Relation.Infrastructure.Data;
using Relation.Web.ViewModels;

namespace Relation.Web.Controllers
{
    public class CategoryController : CrudPageingController<tblCategory,CategoryViewModel,CategoryViewModel>
    {
      
        public CategoryController():
            base(new PageingService<tblCategory>(new Repository<tblCategory>(),DynamicLambdaExpressions.strNameLowerContains,"strName"),
            new CrudService<tblCategory>(new Repository<tblCategory>())) { }
    }
}
