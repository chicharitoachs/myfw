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
    
    public partial class ChucNang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChucNang()
        {
            this.VaiTroes = new HashSet<VaiTro>();
        }
    
        public long Id { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string TenNhom { get; set; }
        public string GhiChu { get; set; }
        public string Guid_Id { get; set; }
        public Nullable<long> CreateBy_Id { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<long> ModifyBy_Id { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<bool> Is_Delete { get; set; }
        public Nullable<bool> Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaiTro> VaiTroes { get; set; }
    }
}
