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
    
    public partial class eDoc_NguoiDungPhongBan
    {
        public long NguoiDung_Id { get; set; }
        public long PhongBan_Id { get; set; }
        public long VaiTro_Id { get; set; }
        public long Edoc_NguoiDung_Id { get; set; }
        public long Edoc_PhongBan_Id { get; set; }
        public long Edoc_VaiTro_Id { get; set; }
    
        public virtual eDoc_DonVi eDoc_DonVi { get; set; }
        public virtual eDoc_NguoiDung eDoc_NguoiDung { get; set; }
        public virtual eDoc_VaiTro eDoc_VaiTro { get; set; }
    }
}