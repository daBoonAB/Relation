//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Relation.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCustomer
    {
        public tblCustomer()
        {
            this.tblCustomerCategories = new HashSet<tblCustomerCategory>();
            this.tblOrders = new HashSet<tblOrder>();
            this.tblSubscriptions = new HashSet<tblSubscription>();
        }
    
        public int customerID { get; set; }
        public int companyID { get; set; }
        public int intCustomerNumber { get; set; }
        public string strName { get; set; }
        public string strNote { get; set; }
        public string strVAT { get; set; }
        public string strAddress { get; set; }
        public string strZip { get; set; }
        public string strCity { get; set; }
        public string strCountry { get; set; }
        public string strPhone { get; set; }
        public string strFax { get; set; }
        public string strEmail { get; set; }
        public string strUrl { get; set; }
        public bool bitDisabled { get; set; }
    
        public virtual tblCompany tblCompany { get; set; }
        public virtual ICollection<tblCustomerCategory> tblCustomerCategories { get; set; }
        public virtual ICollection<tblOrder> tblOrders { get; set; }
        public virtual ICollection<tblSubscription> tblSubscriptions { get; set; }
    }
}