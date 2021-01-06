using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL_DAL;
namespace WebHUFILibrary.Controllers
{
    public class DocGiaController : Controller
    {
        QuanLyThongTinDocGia qlttdg = new QuanLyThongTinDocGia();
        // GET: DocGia
        public ActionResult ThongTinTaiKhoan()
        {
            if(Session["DocGiaIsLogin"] == null)
            {
                return RedirectToAction("DangNhap", "Login");
            }
            else
            {
                VW_DOCGIA dg = (VW_DOCGIA)Session["DocGiaIsLogin"];
                ViewData["DocGiaInfo"] = dg;
                List<VW_TAILIEUDANGMUON> lstTaiLieuDangMuon = qlttdg.getDSTLDangMuon(dg.MaTheThuVien);
                ViewData["lstTaiLieuDangMuon"] = lstTaiLieuDangMuon;
                List<VW_TAILIEUDAMUON> lstTaiLieuDaMuon = qlttdg.getDSTLDaMuon(dg.MaTheThuVien);
                ViewData["lstTaiLieuDaMuon"] = lstTaiLieuDaMuon;
            }
            
            return View();
        }
    }
}