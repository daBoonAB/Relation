using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relation.Web.ViewModels
{
    public class PersonViewModel :InputViewModel
    {
        public override string Name
        {
            get
            {
                return Firstname + " " + Lastname;
            }
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Saturation { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public DateTime? Birthday { get; set; }

    }
}