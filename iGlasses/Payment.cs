//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iGlasses
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public decimal amount { get; set; }
        public string method { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
    
        public virtual Order Order { get; set; }
    }
}