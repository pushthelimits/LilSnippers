//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LilSnippers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public Service()
        {
            this.Transaction_Details = new HashSet<Transaction_Details>();
        }
    
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public decimal ServicePrice { get; set; }
    
        public virtual ICollection<Transaction_Details> Transaction_Details { get; set; }
    }
}
