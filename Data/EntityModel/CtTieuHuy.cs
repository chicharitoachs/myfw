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
    
    public partial class CtTieuHuy
    {
        public long Id { get; set; }
        public long DotTieuhuy_Id { get; set; }
        public long HoSo_Id { get; set; }
        public int Loai { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public string Guid_Id { get; set; }
        public long CreateBy_Id { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long ModifyBy_Id { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public bool Is_Delete { get; set; }
        public Nullable<long> LyDoHuy_Id { get; set; }
    
        public virtual HoSo HoSo { get; set; }
        public virtual DotTieuHuy DotTieuHuy { get; set; }
    }
}