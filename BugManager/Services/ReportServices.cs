using Data.Services;
using FlexCelReport;

namespace BugManager.Services
{
    public static class ReportServices
    {
        public static byte[] ExportReport<T>(ExcelReport<T> report, T filter, string extension = "pdf")
        {
            var reportDocument = report.Build(filter, false);
            var filename = report.Attribute.ReportName + "." + extension;
            var filePath = DataServicesLocator.FileManager.CreateCacheFilePath(filename);
            report.Export(reportDocument, filePath, extension);
            var fileContent = System.IO.File.ReadAllBytes(filePath);
            System.IO.File.Delete(filePath);
            return fileContent;
        }

        public static byte[] WordReport<T>(WordReport<T> report, T filter, string extension = "pdf")
        {
            var reportDocument = report.Build(filter, false);
            var filename = report.Attribute.ReportName + "." + extension;
            var filePath = DataServicesLocator.FileManager.CreateCacheFilePath(filename);
            report.Export(reportDocument, filePath, extension);
            var fileContent = System.IO.File.ReadAllBytes(filePath);
            System.IO.File.Delete(filePath);
            return fileContent;
        }

        public static string GetContentType(string extension)
        {
            string contentType = "";
            switch (extension)
            {
                case "pdf":
                    contentType = "application/pdf";
                    break;
                case "doc":
                    contentType = "application/msword";
                    break;
                case "docx":
                    contentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                    break;
                case "xls":
                    contentType = "application/vnd.ms-excel";
                    break;
                case "xlsx":
                    contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    break;
                default:
                    contentType = "application/pdf";
                    break;
            }
            return contentType;
        }
    }
}