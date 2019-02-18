using System.Linq;
using Core.ViewModel.NhanVien;


namespace Core.Services.NhanVien
{
    using System;
    using System.Collections.Generic;
    using Data.EntityModel;
    public class DmNhanVienServices : IDmNhanVienServices
    {
        private readonly HSLTEntities _entities;
        private readonly IGenericRepository<NhanVien> _dmnhanvienRepo;

        public DmNhanVienServices(IGenericRepository<NhanVien> dmnhanvienRepo, HSLTEntities entities)
        {
            _dmnhanvienRepo = dmnhanvienRepo;
            _entities = entities;
        }

        public long Add(NhanVien entity)
        {
            if (entity == null)
                return 0;
            try
            {
                _dmnhanvienRepo.Add(entity);
                return entity.Id;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public bool Delete(NhanVien entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NhanVien> GetAll(int page,int pageSize,ref int count)
        {
            var lstId = _dmnhanvienRepo.GetAll().Select(m => m.Id).ToList();
            count = lstId.Count;
            lstId = lstId
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            var rs = _dmnhanvienRepo.GetAll()
                .Where(k => lstId.Contains(k.Id))
                .OrderBy(m => m.Ten)
                .ToList();
            return rs;
        }

        public NhanVien GetById(long? id)
        {
            throw new NotImplementedException();
        }

        public bool Update(NhanVien entity)
        {
            throw new NotImplementedException();
        }

        public List<NhanVienViewModel> GetListNhanVienViewModel(int page, int pageSize, ref int count)
        {
            var lstId = _entities.NhanViens.Where(m => !m.Is_Delete).Select(m => m.Id).ToList();
            count = lstId.Count;
            lstId = lstId
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            var rs = _entities.NhanViens
                .Where(k => lstId.Contains(k.Id))
                .OrderBy(m => m.Ten)
                .ToList()
                .Select(m => new NhanVienViewModel(_entities,m))
                .ToList();
            return rs;
        }
    }
}
