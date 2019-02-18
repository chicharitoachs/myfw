using System;

namespace Data.EntityModel
{
    public interface ISystemPropertyModel
    {
        string Guid_Id { get; set; }
        long CreateBy_Id { get; set; }
        DateTime CreateDate { get; set; }
        long ModifyBy_Id { get; set; }
        DateTime ModifyDate { get; set; }
    }
    public interface ISystemPropertyAllowNullModel
    {
        string Guid_Id { get; set; }
        long? CreateBy_Id { get; set; }
        DateTime? CreateDate { get; set; }
        long? ModifyBy_Id { get; set; }
        DateTime? ModifyDate { get; set; }
    }

    public partial class DmDuKien : ISystemPropertyModel { }
    public partial class TongHopDmDuKien : ISystemPropertyModel { }
    public partial class KeHoachGiaoNop : ISystemPropertyModel { }
    public partial class DmDeNghi : ISystemPropertyModel { }
    public partial class DmTiepNhan : ISystemPropertyModel { }
    public partial class HoSo : ISystemPropertyModel { }
    public partial class VanBan : ISystemPropertyModel { }
    public partial class DocumentFile : ISystemPropertyModel { }
    public partial class NhanVien : ISystemPropertyAllowNullModel { }
    public partial class PhongBan : ISystemPropertyModel { }
    public partial class DonVi : ISystemPropertyModel { }
    public partial class PhongLuuTru : ISystemPropertyModel { }
    public partial class eDoc_HoSo : ISystemPropertyModel { }
    public partial class Kho : ISystemPropertyModel { }
    public partial class TangPhong : ISystemPropertyModel { }
    public partial class HangDay : ISystemPropertyModel { }
    public partial class GiaKe : ISystemPropertyModel { }
    public partial class NganTang : ISystemPropertyModel { }
    public partial class TonDauKy : ISystemPropertyModel { }
    public partial class NhapKho : ISystemPropertyModel { }
    public partial class CtNhapKho : ISystemPropertyModel { }
    public partial class XuatKho : ISystemPropertyModel { }
    public partial class CtXuatKho : ISystemPropertyModel { }
    public partial class PhieuYeuCau : ISystemPropertyModel { }
    public partial class CtYeuCau : ISystemPropertyModel { }
    public partial class PhieuPhucVu : ISystemPropertyModel { }
    public partial class CtPhucVu : ISystemPropertyModel { }
    public partial class NhapKhaiThac : ISystemPropertyModel { }
    public partial class XuatKhaiThac : ISystemPropertyModel { }
    public partial class CtTonDauKy : ISystemPropertyModel { }
    public partial class ChuyenKho : ISystemPropertyModel { }
    //NQMINH ADD
    public partial class NgonNgu : ISystemPropertyModel { }
    public partial class TinhTrangVatLy : ISystemPropertyModel { }
    public partial class LoaiVanBan : ISystemPropertyModel { }
    public partial class HinhThucKhaiThac : ISystemPropertyModel { }
    public partial class LoaiAnPham : ISystemPropertyModel { }
    public partial class ThoiHanBaoQuan : ISystemPropertyModel { }
    public partial class PhanLoaiHoSo : ISystemPropertyModel { }
    public partial class NhapKhoAP : ISystemPropertyModel { }
    public partial class CtNhapKhoAP : ISystemPropertyModel { }
    public partial class XuatKhoAP : ISystemPropertyModel { }
    public partial class CtXuatKhoAP : ISystemPropertyModel { }
    public partial class DotChinhLy : ISystemPropertyModel { }
    public partial class CtDotChinhLy : ISystemPropertyModel { }
    public partial class HopCap : ISystemPropertyModel { }
    public partial class DotTieuHuy : ISystemPropertyModel { }
    public partial class CtTieuHuy : ISystemPropertyModel { }
    public partial class DotGiaoNop : ISystemPropertyModel { }
    public partial class CtGiaoNop : ISystemPropertyModel { }
    public partial class ChucNang : ISystemPropertyAllowNullModel { }
    public partial class VaiTro : ISystemPropertyAllowNullModel { }
    public partial class NguoiKy : ISystemPropertyModel { }
    public partial class PhieuYeuCauAP : ISystemPropertyModel { }
    public partial class CtYeuCauAP : ISystemPropertyModel { }
    public partial class NhapKhaiThacAP : ISystemPropertyModel { }
    public partial class AnPham : ISystemPropertyModel { }
    public partial class XuatKhaiThacAP : ISystemPropertyModel { }

    public partial class MucLucHoSo : ISystemPropertyModel { }

    public partial class eDoc_VanBan : ISystemPropertyModel { }
    public partial class eDoc_DonVi : ISystemPropertyModel { }
    public partial class ChuDeAnPham : ISystemPropertyModel { }
    public partial class Comment : ISystemPropertyModel { }
    public partial class eDoc_NguoiDung : ISystemPropertyModel { }
    public partial class KichThuocAnPham : ISystemPropertyModel { }
    public partial class ThongTinVanBan : ISystemPropertyModel { }
    //NQMINH END
    public partial class DotSoHoa : ISystemPropertyModel { }
    public partial class CtDotSoHoa : ISystemPropertyModel { }
}