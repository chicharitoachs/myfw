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
    
    public partial class eDoc_HoSo_bak
    {
        public long Id { get; set; }
        public int Type { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string SoHoSo { get; set; }
        public string TieuDeHoSo { get; set; }
        public Nullable<int> Nam { get; set; }
        public Nullable<long> DonVi_Id { get; set; }
        public string DonVi_Name { get; set; }
        public Nullable<long> PhongBan_Id { get; set; }
        public string PhongBan_Name { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<long> NguoiLap_Id { get; set; }
        public string NguoiLap_Name { get; set; }
        public Nullable<int> SoTo { get; set; }
        public Nullable<long> ThoiHanBaoQuan { get; set; }
        public string CheDoSuDung { get; set; }
        public string LoaiCongViec { get; set; }
        public Nullable<long> Edoc_Id { get; set; }
        public string Edoc_Guid_Id { get; set; }
        public Nullable<System.DateTime> GetDate { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public string Guid_Id { get; set; }
        public long CreateBy_Id { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long ModifyBy_Id { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public bool Is_Delete { get; set; }
        public bool Has_File { get; set; }
        public bool Is_Index { get; set; }
        public Nullable<long> NguoiChuyen_Id { get; set; }
        public string NguoiChuyen { get; set; }
    }
}
