using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relation.Web.ViewModels
{
    public class OrderUnitViewModel :InputViewModel
    {
        public string Unit { get; set; }
        public string Description { get; set; }
        public bool Integer { get; set; }
        public bool Disabled { get; set; }
    }
}