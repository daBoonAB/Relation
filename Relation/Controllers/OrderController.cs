using Relation.Core.Class;
using Relation.Core.Models;
using Relation.Core.Services;
using Relation.Infrastructure.Data;
using Relation.Web.ViewModels;

namespace Relation.Web.Controllers
{
    public class OrderController : CrudPageingController<tblOrder, OrderViewModel, OrderViewModel>
    {

        public OrderController() :
            base(new PageingService<tblOrder>(new Repository<tblOrder>(), DynamicLambdaExpressions.LowerContains("strDescription"), "dtmWhen"),
             new CrudService<tblOrder>(new Repository<tblOrder>())) { }
    }
}
