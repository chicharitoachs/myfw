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
    
    public partial class NhapKho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhapKho()
        {
            this.CtNhapKhoes = new HashSet<CtNhapKho>();
        }
    
        public long Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public Nullable<int> Nam { get; set; }
        public System.DateTime NgayNhap { get; set; }
        public Nullable<int> Loai { get; set; }
        public Nullable<long> DotChinhLy_Id { get; set; }
        public string DiaDiem { get; set; }
        public Nullable<long> TinhTrangTaiLieu { get; set; }
        public Nullable<long> NguoiNhap_Id { get; set; }
        public Nullable<long> NguoiGiao_Id { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> SoLuongHop { get; set; }
        public Nullable<int> SoLuongHoSo { get; set; }
        public Nullable<double> SoMetTaiLieu { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public string Guid_Id { get; set; }
        public long CreateBy_Id { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long ModifyBy_Id { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public bool Is_Delete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtNhapKho> CtNhapKhoes { get; set; }
        public virtual DotChinhLy DotChinhLy { get; set; }
    }
}
