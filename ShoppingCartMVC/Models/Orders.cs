//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeShopIL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int OrderId { get; set; }
        public Nullable<int> ProID { get; set; }
        public string Contact { get; set; }
        public Nullable<int> Unit { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> InvoiceId { get; set; }
    
        public virtual Invoices Invoices { get; set; }
        public virtual Products Products { get; set; }
    }
}