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
        public ActionResult DangNhap(string username, string password, string targetUrl)
        {
            if (qldn.kiemTraDangNhap(username, password))
            {
                DOCGIA dg = qldn.getModelDocGia(username);
                if (dg != null)
                {
                    Session["DocGiaIsLogin"] = dg;
                    if (!string.IsNullOrEmpty(targetUrl))
                    {
                        return new RedirectResult(targetUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ViewBag.username = username;
                ViewData["Msg"] = "Tài khoản và mật khẩu không hợp lệ.";
                return this.View();
            }
            return View();
        }

        public ActionResult DangXuat()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult ChangePassword()
        {
            if (Session["DocGiaIsLogin"] == null)
            {
                return RedirectToAction("DangNhap", "Login");
            }
            return View();
        } 
            [HttpPost]
        public ActionResult ChangePassword(string passwordold, string password, string repassword)
        {
            if(Session["DocGiaIsLogin"] == null)
            {
                return RedirectToAction("DangNhap","Login");
            }    
            else
            {
                if(password.Equals(passwordold))
                {
                    ViewData["Msg"] = "Lỗi: Mật khẩu mới trùng với mật khẩu cũ.";
                    return this.View();
                }
                DOCGIA dg = (DOCGIA)Session["DocGiaIsLogin"];
                if(!qldn.kiemTraMatKhauCu(dg.MaTheThuVien,passwordold))
                {
                    ViewData["Msg"] = "Lỗi: Mật khẩu cũ không đúng.";
                    return this.View();
                }    
                if(qldn.changePassword(dg.MaTheThuVien,password))
                {
                    ViewData["Msg"] = "Thông báo: Thay đổi mật khẩu thành công.";
                    
                }    
                else
                {
                    ViewData["Msg"] = "Lỗi: Thay đổi mật khẩu không thành công.";
                }
                return this.View();
            }    
            return View();
        }
    }
}