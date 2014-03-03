using Relation.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relation.Web.ViewModels
{
    public class InputViewModel :IViewModel
    {
        public int ID { get; set; }
        public virtual string Name { get; set; }
    }
}