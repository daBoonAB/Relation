using Relation.Core.Class;
using Relation.Core.Models;
using Relation.Core.Services;
using Relation.Infrastructure.Data;
using Relation.Web.ViewModels;

namespace Relation.Web.Controllers
{
    public class OrderUnitController : CrudPageingController<tblOrderUnit, OrderUnitViewModel, OrderUnitViewModel>
    {

        public OrderUnitController() :
            base(new PageingService<tblOrderUnit>(new Repository<tblOrderUnit>(), DynamicLambdaExpressions.LowerContains("strUnit"), "strUnit"),
             new CrudService<tblOrderUnit>(new Repository<tblOrderUnit>())) { }
    }
}
