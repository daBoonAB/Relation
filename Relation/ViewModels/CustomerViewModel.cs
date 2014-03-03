using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relation.Web.ViewModels
{
    public class CustomerViewModel:InputViewModel
    {
        public string Note { get; set; }
        public string VAT { get; set; }
        public int CustomerNumber { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
    }
}