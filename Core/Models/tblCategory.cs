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
    
    public partial class tblCategory
    {
        public tblCategory()
        {
            this.tblCustomerCategories = new HashSet<tblCustomerCategory>();
            this.tblCustomerPersonCategories = new HashSet<tblCustomerPersonCategory>();
        }
    
        public int categoryID { get; set; }
        public string strName { get; set; }
        public int categoryTypeID { get; set; }
    
        public virtual tblCategoryType tblCategoryType { get; set; }
        public virtual ICollection<tblCustomerCategory> tblCustomerCategories { get; set; }
        public virtual ICollection<tblCustomerPersonCategory> tblCustomerPersonCategories { get; set; }
    }
}
