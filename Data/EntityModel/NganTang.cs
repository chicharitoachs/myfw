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
    
    public partial class NganTang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NganTang()
        {
            this.AnPhams = new HashSet<AnPham>();
            this.HopCaps = new HashSet<HopCap>();
            this.HoSoes = new HashSet<HoSo>();
        }
    
        public long Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public int TongSoHop { get; set; }
        public long Kho_Id { get; set; }
        public long TangPhong_Id { get; set; }
        public long HangDay_Id { get; set; }
        public long GiaKe_Id { get; set; }
        public string ViTri { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public bool Active { get; set; }
        public string Guid_Id { get; set; }
        public long CreateBy_Id { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long ModifyBy_Id { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public bool Is_Delete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnPham> AnPhams { get; set; }
        public virtual GiaKe GiaKe { get; set; }
        public virtual HangDay HangDay { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopCap> HopCaps { get; set; }
        public virtual Kho Kho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoSo> HoSoes { get; set; }
        public virtual TangPhong TangPhong { get; set; }
    }
}
