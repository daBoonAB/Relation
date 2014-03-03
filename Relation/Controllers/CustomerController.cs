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
    public class CustomerController : CrudPageingController<tblCustomer, CustomerViewModel, CustomerViewModel>
    {
        public CustomerController() : 
            base(new PageingService<tblCustomer>(new Repository<tblCustomer>(),DynamicLambdaExpressions.strNameLowerContains,"strName"), 
                new CrudService<tblCustomer>((new Repository<tblCustomer>())))
        {
   
        }
    }
}
