using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Services.NhanVien;

namespace BugManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDmNhanVienServices _dmnhanvienServices;

        public HomeController(IDmNhanVienServices dmnhanvienServices)
        {
            _dmnhanvienServices = dmnhanvienServices;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetList(int page, int pageSize)
        {
            var count = 0;
            var rs = _dmnhanvienServices.GetListNhanVienViewModel(page, pageSize, ref count);
            
            return Json(new
            {
                Items = rs,
                Count = count,
                pageSize,
                page
            }, JsonRequestBehavior.AllowGet);
        }
    }
}