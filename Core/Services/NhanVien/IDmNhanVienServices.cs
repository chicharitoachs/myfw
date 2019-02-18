using System.Collections.Generic;
using Core.ViewModel.NhanVien;

namespace Core.Services.NhanVien
{
    using Data.EntityModel;
    public interface IDmNhanVienServices
    {
        NhanVien GetById(long? id);
        IEnumerable<NhanVien> GetAll(int page, int pageSize, ref int count);
        List<NhanVienViewModel> GetListNhanVienViewModel(int page, int pageSize, ref int count);
        long Add(NhanVien entity);
        bool Update(NhanVien entity);
        bool Delete(NhanVien entity);
    }
}
