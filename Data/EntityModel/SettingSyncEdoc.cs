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
    
    public partial class SettingSyncEdoc
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public Nullable<int> TimeStart { get; set; }
        public Nullable<int> TimeEnd { get; set; }
        public Nullable<bool> IsStart { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
    }
}
