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
            if(mavach == null)
            {
                return RedirectToAction("TimKiem","Home");
            }    
            VW_TAILIEU tl = qltl.getTaiLieuByMaVach(mavach);
            List<string> lstDM = new List<string>();
            List<VW_TAILIEU> lstKhongLuuThong = new List<VW_TAILIEU>();
            List<VW_TAILIEU> lst = qltl.getListTaiLieuByMaTaiLieu(tl.MaTaiLieu,ref lstDM, ref lstKhongLuuThong);
            ViewData["data"] = tl;
            ViewData["listdata"] = lst;
            ViewData["listDangMuon"] = lstDM;
            ViewData["listKhongLuuThong"] = lstKhongLuuThong;
            return View();
        }
    }
}