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
    
    public partial class eDoc_NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public eDoc_NguoiDung()
        {
            this.eDoc_HoSo = new HashSet<eDoc_HoSo>();
            this.eDoc_NguoiDungPhongBan = new HashSet<eDoc_NguoiDungPhongBan>();
        }
    
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Ten { get; set; }
        public int TrangThai { get; set; }
        public Nullable<long> VaiTro_Id { get; set; }
        public Nullable<long> PhongBan_Id { get; set; }
        public Nullable<long> Edoc_Id { get; set; }
        public string Edoc_Guid_Id { get; set; }
        public Nullable<System.DateTime> GetDate { get; set; }
        public string Guid_Id { get; set; }
        public long CreateBy_Id { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long ModifyBy_Id { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public bool Is_Delete { get; set; }
        public bool Active { get; set; }
    
        public virtual eDoc_DonVi eDoc_DonVi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eDoc_HoSo> eDoc_HoSo { get; set; }
        public virtual eDoc_VaiTro eDoc_VaiTro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eDoc_NguoiDungPhongBan> eDoc_NguoiDungPhongBan { get; set; }
    }
}
