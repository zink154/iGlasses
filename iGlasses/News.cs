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
    
    public partial class News
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int author_id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}