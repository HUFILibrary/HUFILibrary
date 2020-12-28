using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL_DAL;
namespace WebHUFILibrary.Controllers
{
    public class TaiLieuController : Controller
    {
        QuanLyTaiLieu qltl = new QuanLyTaiLieu();
        // GET: TaiLieu
        public ActionResult ThongTinChiTiet(string mavach)
        {
            TAILIEU tl = qltl.getTaiLieuByMaVach(mavach);
            ViewData["data"] = tl;
            return View();
        }
    }
}