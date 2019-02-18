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
    
    public partial class eDoc_VanBan
    {
        public long Id { get; set; }
        public int Type { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public Nullable<long> HoSo_Id { get; set; }
        public Nullable<int> So { get; set; }
        public string KyHieu { get; set; }
        public string SoKyHieu { get; set; }
        public string NoiGui { get; set; }
        public Nullable<System.DateTime> NgayVanBan { get; set; }
        public string NguoiKy { get; set; }
        public string TrichYeu { get; set; }
        public string DoKhan { get; set; }
        public string LoaiSo { get; set; }
        public Nullable<int> SoDen { get; set; }
        public Nullable<int> SoDenPHC { get; set; }
        public Nullable<System.DateTime> NgayDen { get; set; }
        public string LanhDaoXuLy { get; set; }
        public string ChuTriXyLy { get; set; }
        public string PhoiHopXuLy { get; set; }
        public string ThongTinXuLy { get; set; }
        public Nullable<System.DateTime> HanXuLy { get; set; }
        public string ChuTri { get; set; }
        public string PhoiHop { get; set; }
        public Nullable<System.DateTime> NgayBoTra { get; set; }
        public Nullable<System.DateTime> NgayPhucDap { get; set; }
        public string TrinhLanhDao { get; set; }
        public Nullable<int> SoDi { get; set; }
        public Nullable<System.DateTime> NgayPhatHanh { get; set; }
        public string DonViSoanThao { get; set; }
        public Nullable<long> DonViSoanThao_Id { get; set; }
        public string PhongBanSoanThao { get; set; }
        public Nullable<long> PhongBanSoanThao_Id { get; set; }
        public string CanBoSoanThao { get; set; }
        public Nullable<long> CanBoSoanThao_Id { get; set; }
        public string NoiNhanNgoaiNganh { get; set; }
        public string NoiNhanTrongNganh { get; set; }
        public string NoiNhanNoiBo { get; set; }
        public Nullable<int> SoLuongVanBanGiay { get; set; }
        public Nullable<int> SoBanDienTu { get; set; }
        public Nullable<bool> DaPhatHanh { get; set; }
        public string MaToTrinh { get; set; }
        public string NguoiTao { get; set; }
        public Nullable<long> NguoiTao_Id { get; set; }
        public string TinhTrangPheDuyet { get; set; }
        public Nullable<System.DateTime> NgayTrinh { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public string YKien { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string LanhDaoChiDao { get; set; }
        public Nullable<System.DateTime> NgayChiDao { get; set; }
        public string TenCongViec { get; set; }
        public string TinhTrangDonVi { get; set; }
        public string TienDoXuLy { get; set; }
        public string DanhGia { get; set; }
        public string GhiChu { get; set; }
        public Nullable<long> Edoc_Id { get; set; }
        public string Edoc_Guid_Id { get; set; }
        public Nullable<System.DateTime> GetDate { get; set; }
        public string Guid_Id { get; set; }
        public long CreateBy_Id { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long ModifyBy_Id { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public bool Is_Delete { get; set; }
        public bool Has_File { get; set; }
        public bool Is_Index { get; set; }
        public Nullable<long> NoiGui_Id { get; set; }
        public Nullable<long> NguoiChuyen_Id { get; set; }
        public string NguoiChuyen { get; set; }
    
        public virtual eDoc_HoSo eDoc_HoSo { get; set; }
    }
}
