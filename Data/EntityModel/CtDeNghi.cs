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
    
    public partial class CtDeNghi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CtDeNghi()
        {
            this.CtTiepNhans = new HashSet<CtTiepNhan>();
        }
    
        public long Id { get; set; }
        public long DmDeNghi_Id { get; set; }
        public Nullable<long> CtDuKien_Id { get; set; }
        public Nullable<long> HoSo_Id { get; set; }
        public Nullable<long> HoSo_eDoc_Id { get; set; }
        public string HopCap { get; set; }
        public string SoHoSo { get; set; }
        public string TieuDeHoSo { get; set; }
        public string ThoiGianTaiLieu { get; set; }
        public Nullable<long> ThoiHanBaoQuan { get; set; }
        public Nullable<int> SoTo { get; set; }
        public Nullable<long> NguoiLap_Id { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public int Loai { get; set; }
        public string GhiChu { get; set; }
        public string Ma { get; set; }
        public Nullable<int> Stt { get; set; }
        public Nullable<long> PhongBan_Id { get; set; }
        public Nullable<long> DonVi_Id { get; set; }
        public Nullable<long> HopCap_Id { get; set; }
    
        public virtual DonVi DonVi { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual PhongBan PhongBan { get; set; }
        public virtual HoSo HoSo { get; set; }
        public virtual eDoc_HoSo eDoc_HoSo { get; set; }
        public virtual CtDuKien CtDuKien { get; set; }
        public virtual DmDeNghi DmDeNghi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtTiepNhan> CtTiepNhans { get; set; }
    }
}