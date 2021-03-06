﻿using Relation.Core.Class;
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
    public class CompanyController : CrudPageingController<tblCompany, CompanyViewModel, CompanyViewModel>
    {
        public CompanyController() :
            base(new PageingService<tblCompany>(new Repository<tblCompany>(), DynamicLambdaExpressions.strNameLowerContains, "strName"),
                new CrudService<tblCompany>((new Repository<tblCompany>())))
        {

        }
    }
}
