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
    
    public partial class tblOrderUnit
    {
        public tblOrderUnit()
        {
            this.tblOrders = new HashSet<tblOrder>();
        }
    
        public int orderUnitID { get; set; }
        public int companyID { get; set; }
        public string strUnit { get; set; }
        public string strDescription { get; set; }
        public bool bitInteger { get; set; }
        public bool bitDisabled { get; set; }
    
        public virtual tblCompany tblCompany { get; set; }
        public virtual ICollection<tblOrder> tblOrders { get; set; }
    }
}
