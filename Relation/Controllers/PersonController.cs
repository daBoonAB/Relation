using Relation.Core.Class;
using Relation.Core.Models;
using Relation.Core.Services;
using Relation.Infrastructure.Data;
using Relation.Web.ViewModels;

namespace Relation.Web.Controllers
{
    public class PersonController : CrudPageingController<tblCustomerPerson, PersonViewModel, PersonViewModel>
    {

        public PersonController() :
            base(new PageingService<tblCustomerPerson>(new Repository<tblCustomerPerson>(), DynamicLambdaExpressions.strNameLowerContains, "strName"),
             new CrudService<tblCustomerPerson>(new Repository<tblCustomerPerson>())) { }
    }
}
