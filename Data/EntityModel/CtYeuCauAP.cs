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
    
    public partial class CtYeuCauAP
    {
        public long Id { get; set; }
        public long PhieuYeuCau_Id { get; set; }
        public long LoaiAnPham_Id { get; set; }
        public Nullable<long> AnPham_Id { get; set; }
        public Nullable<long> SoLuong { get; set; }
        public string GhiChu { get; set; }
        public string ViTri { get; set; }
        public Nullable<long> PhieuXuat_Id { get; set; }
        public Nullable<long> PhieuNhap_Id { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public string Guid_Id { get; set; }
        public long CreateBy_Id { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long ModifyBy_Id { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public bool Is_Delete { get; set; }
    
        public virtual AnPham AnPham { get; set; }
        public virtual PhieuYeuCauAP PhieuYeuCauAP { get; set; }
    }
}
