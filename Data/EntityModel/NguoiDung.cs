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
    
    public partial class NguoiDung
    {
        public long Id { get; set; }
        public string HoVaTen { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Nullable<bool> EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<bool> PhoneNumberConfirmed { get; set; }
        public Nullable<long> NhanVien_Id { get; set; }
        public string Guid_Id { get; set; }
        public Nullable<long> CreateBy_Id { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<long> ModifyBy_Id { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<bool> Is_Delete { get; set; }
        public bool Active { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
