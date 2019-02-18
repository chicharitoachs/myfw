using System.Web.Mvc;
using BugManager.Reports.NhanVien;
using BugManager.Services;
using Data.EntityModel;

namespace BugManager.Controllers
{
    public class ReportsController : Controller
    {
        private readonly HSLTEntities _entities = new HSLTEntities();

        #region Nhân viên

        public ActionResult InDanhSachNhanVien(string extension = "pdf")
        {
            var report = new Report_DanhSachNhanVien<ReportFilter_DanhSachNhanVien>();
            var filter = new ReportFilter_DanhSachNhanVien(_entities){};
            var filePath = ReportServices.ExportReport(report, filter, extension);
            return new FileContentResult(filePath, ReportServices.GetContentType(extension));
        }



        #endregion
    }
}