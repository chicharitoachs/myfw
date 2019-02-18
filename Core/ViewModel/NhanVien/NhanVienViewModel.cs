using System;
using System.Data.Entity;
using Data;
using Data.EntityModel;

namespace Core.ViewModel.NhanVien
{
    public sealed class NhanVienViewModel : ObjectModel
    {
        public NhanVienViewModel()
        {
                
        }

        public NhanVienViewModel(HSLTEntities entitiesModel, Data.EntityModel.NhanVien model): base(entitiesModel, model)
        {
            Helper.CopyProperty(model, this);
            var phongban = this.PhongBan_Id > 0 ? entitiesModel.PhongBans.Find(this.PhongBan_Id) : null;
            this.DonVi_Id = phongban?.DonVi_Id;
            DonVi_Ten = entitiesModel.DonVis.Find(this.DonVi_Id)?.Ten;
        }

        public long? PhongBan_Id { get; set; }
        public long? DonVi_Id { get; set; }
        public string DonVi_Ten { get; set; }
        public string Ten { get; set; }
        public string ChucDanh { get; set; }
        public string UserName { get; set; }


        public override object CreateModel()
        {
            throw new NotImplementedException();
        }

        public override object GetModel(DbContext entitiesModel)
        {
            model = new Data.EntityModel.NhanVien();
            return model;
        }
    }
}
