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
    
    public partial class HoSo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoSo()
        {
            this.CtNhapKhoes = new HashSet<CtNhapKho>();
            this.CtXuatKhoes = new HashSet<CtXuatKho>();
            this.CtDotChinhLies = new HashSet<CtDotChinhLy>();
            this.CtDeNghis = new HashSet<CtDeNghi>();
            this.CtDotSoHoas = new HashSet<CtDotSoHoa>();
            this.CtDuKiens = new HashSet<CtDuKien>();
            this.CtGiaoNops = new HashSet<CtGiaoNop>();
            this.CtPhucVus = new HashSet<CtPhucVu>();
            this.CtTiepNhans = new HashSet<CtTiepNhan>();
            this.CtTieuHuys = new HashSet<CtTieuHuy>();
            this.VanBans = new HashSet<VanBan>();
        }
    
        public long Id { get; set; }
        public int Type { get; set; }
        public int Class { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string SoLuuTru { get; set; }
        public string SoHoSo { get; set; }
        public string TieuDeHoSo { get; set; }
        public Nullable<int> Nam { get; set; }
        public Nullable<long> PhongLuuTru_Id { get; set; }
        public Nullable<long> DonVi_Id { get; set; }
        public string DonVi_Name { get; set; }
        public Nullable<long> PhongBan_Id { get; set; }
        public string PhongBan_Name { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<long> NguoiLap_Id { get; set; }
        public string NguoiLap_Name { get; set; }
        public Nullable<long> PhanLoai_Id { get; set; }
        public Nullable<long> MucLuc_Id { get; set; }
        public Nullable<int> SoTo { get; set; }
        public string ThoiGianTaiLieu { get; set; }
        public Nullable<long> ThoiHanBaoQuan { get; set; }
        public string CheDoSuDung { get; set; }
        public Nullable<int> TinhTrangVatLy { get; set; }
        public string NgonNgu { get; set; }
        public string KyHieu { get; set; }
        public string ButTich { get; set; }
        public string ChuGiai { get; set; }
        public Nullable<long> Kho_Id { get; set; }
        public Nullable<long> TangPhong_Id { get; set; }
        public Nullable<long> HangDay_Id { get; set; }
        public Nullable<long> GiaKe_Id { get; set; }
        public Nullable<long> NganTang_Id { get; set; }
        public Nullable<long> Hop_Id { get; set; }
        public string ViTri { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public string Guid_Id { get; set; }
        public long CreateBy_Id { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long ModifyBy_Id { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public bool Is_Delete { get; set; }
        public bool Has_File { get; set; }
        public bool Is_Index { get; set; }
        public string SoB { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtNhapKho> CtNhapKhoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtXuatKho> CtXuatKhoes { get; set; }
        public virtual GiaKe GiaKe { get; set; }
        public virtual HangDay HangDay { get; set; }
        public virtual HopCap HopCap { get; set; }
        public virtual Kho Kho { get; set; }
        public virtual NganTang NganTang { get; set; }
        public virtual TangPhong TangPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtDotChinhLy> CtDotChinhLies { get; set; }
        public virtual MucLucHoSo MucLucHoSo { get; set; }
        public virtual DonVi DonVi { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual PhanLoaiHoSo PhanLoaiHoSo { get; set; }
        public virtual PhongBan PhongBan { get; set; }
        public virtual PhongLuuTru PhongLuuTru { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtDeNghi> CtDeNghis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtDotSoHoa> CtDotSoHoas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtDuKien> CtDuKiens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtGiaoNop> CtGiaoNops { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtPhucVu> CtPhucVus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtTiepNhan> CtTiepNhans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtTieuHuy> CtTieuHuys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VanBan> VanBans { get; set; }
    }
}
