using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relation.Web.ViewModels
{
    public class OrderViewModel :InputViewModel
    {

        public int CompanyID { get; set; }
        public int UserID { get; set; }
        public int CustomerID { get; set; }
        public int CustomerPersonID { get; set; }
        public int ProductID { get; set; }
        public int Amount { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public bool Invoice { get; set; }
        public bool InvoieOK { get; set; }
        public DateTime When { get; set; }

    }
}