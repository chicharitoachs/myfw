using Report.Metadata;
using System.Linq;
using BugManager.Models;
using Data.EntityModel;
using Data.Services;
using FlexCelReport;


namespace BugManager.Reports.NhanVien
{
    using FlexCel.Report;
    [ExcelReport(ReportName = "NhanVien_DanhSachNhanVien"
        , ID = "E2FA8511-04E8-409B-BEDF-9BA834D3980A"
        , ReportExt = "xlsx"
        , Title = "Danh sách nhân viên")]
    public class Report_DanhSachNhanVien<T> : ExcelReport<T>
        where T : ReportFilter_DanhSachNhanVien
    {
        protected override void SetReportLocation(string temFile = null)
        {
            base.SetReportLocation(DataServicesLocator.FileManager.TemFolder);
        }
        protected override bool OnLoad(FlexCelReport flexcelReport, T filter)
        {
            var mainList = filter.DbEntities.NhanViens
                .Where(k => !k.Is_Delete)
                .ToList();
            flexcelReport.AddTable("DT", mainList);
            return true;
        }
    }

    public class ReportFilter_DanhSachNhanVien : FilterModelBase
    {
        public ReportFilter_DanhSachNhanVien(HSLTEntities entities)
            : base(entities)
        {
        }
    }
}