//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        public long Id { get; set; }
        public string Signal { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<long> Manager { get; set; }
        public bool Active { get; set; }
        public long CreatedById { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public long ModifiedById { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool Is_Delete { get; set; }
    }
}
