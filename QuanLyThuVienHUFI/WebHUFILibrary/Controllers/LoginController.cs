using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL_DAL;
namespace WebHUFILibrary.Controllers
{
    public class LoginController : Controller
    {
        QuanLyDangNhap qldn = new QuanLyDangNhap();
        // GET: Login
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string username, string password)
        {
            if (qldn.kiemTraDangNhap(username, password))
            {
                DOCGIA dg = qldn.getModelDocGia(username);
                if (dg != null)
                {
                    Session["DocGiaIsLogin"] = dg;
                    return RedirectToAction("Index","Home");
                }
            }
            else
            {
                ViewData["FailedLogin"] = "Tài khoản và mật khẩu không hợp lệ.";
                return this.View();
            }
            return View();
        }

        public ActionResult DangXuat()
        {
            Session.Clear();
            return RedirectToAction("Index","Home");
        }
    }
}