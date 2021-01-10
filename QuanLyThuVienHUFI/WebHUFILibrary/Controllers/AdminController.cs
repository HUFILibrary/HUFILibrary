using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL_DAL;
using System.IO;
using PagedList;
using WebHUFILibrary.Models;
namespace WebHUFILibrary.Controllers
{
    public class AdminController : Controller
    {
        QuanLyDangNhap qldn = new QuanLyDangNhap();
        QuanLyTinTuc qltt = new QuanLyTinTuc();
        DB_QLTVDataContext db = new DB_QLTVDataContext();
        // GET: Admin
        public ActionResult Index()
        {
            //if(Session["AdminIsLogin"] == null)
            //{
            //    return RedirectToAction("Login","Admin");
            //}
            if(Session["AdminIsLogin"] == null)
            {
                return RedirectToAction("Login","Admin");
            }
            return View();
        }
        public ActionResult TinTuc(int? page, string typesearch, string txtsearch, string CurrentTxtSearch,string CurrentTypeSearch)
        {
            if (Session["AdminIsLogin"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            if (txtsearch != null)
            {
                page = 1;
            }
            else
            {
                txtsearch = CurrentTxtSearch;
                typesearch = CurrentTypeSearch;
            }
            ViewBag.CurrentTxtSearch = txtsearch;
            ViewBag.CurrentTypeSearch = typesearch;
            List<VW_TINTUC> lstTT = new List<VW_TINTUC>();
            if (string.IsNullOrEmpty(txtsearch))
            {
                lstTT = qltt.getListTinTuc();
            }
            else
            {
                lstTT = qltt.getListTinTucBysearch(txtsearch,typesearch);
            }
            
            ViewData["lstTinTuc"] = lstTT;

            List<SearchModel> lstSearchModel1 = new List<SearchModel>();
            lstSearchModel1.Add(new SearchModel("Ma", "Mã"));
            lstSearchModel1.Add(new SearchModel("TieuDe", "Tiêu đề"));
            lstSearchModel1.Add(new SearchModel("LoaiTin", "Loại tin"));
            ViewData["lstTypeSearch"] = lstSearchModel1;

            return View(lstTT.OrderByDescending(a => a.MaTinTuc).ToPagedList(pageNumber, pageSize));
        }
        [ValidateInput(false)]
        public ActionResult SuaTinTuc(string matintuc)
        {
            if (Session["AdminIsLogin"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            if (string.IsNullOrEmpty(matintuc))
            {
                return RedirectToAction("TinTuc","Admin");
            }
            VW_TINTUC tt = qltt.getTinTuc(matintuc);
            ViewData["data"] = tt;

            List<LOAITINTUC> lstLoaiTT = qltt.getListLoaiTinTuc();
            ViewData["lstLoaiTinTuc"] = lstLoaiTT;
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SuaTinTuc(FormCollection collection,HttpPostedFileBase logotintuc, string matintuc, string loaitintuc, string tieude,
                                      string motangan, string ngaytao, string noidung
                                      )
        {


            bool flg = false;
            TINTUC item = db.TINTUCs.Where(a => a.MaTinTuc == int.Parse(matintuc)).FirstOrDefault();
            if (item != null)
            {
               
                    var files = Request.Files;
                    var uploadFile = files["logotintuc"];
                    
                    
                    string filename = uploadFile.FileName;
                    
                if (!string.IsNullOrEmpty(filename))
                    {
                        string[] arr = filename.Split('.');
                        filename = item.MaTinTuc.ToString() + "." + arr[1].ToString();
                    string uploads = System.Web.HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["LogoTinTuc"]);
                        string savePath = Path.Combine(uploads,item.MaTinTuc.ToString());
                        if (!Directory.Exists(savePath))
                        {
                            Directory.CreateDirectory(savePath);
                        }
                        string delPath = Path.Combine(savePath, item.Logo.ToString());
                        if (System.IO.File.Exists(delPath))
                        {
                            System.GC.Collect();
                            System.GC.WaitForPendingFinalizers();
                            System.IO.File.Delete(delPath);
                        }
                        MemoryStream ms = new MemoryStream();
                        using (var stream = new FileStream(Path.Combine(savePath, filename), FileMode.Create))
                        {
                            uploadFile.InputStream.CopyTo(stream);
                            stream.Close();
                        }
                    item.Logo = filename;
                }

                
                item.MaLoaiTinTuc = int.Parse(loaitintuc);
                item.TieuDe = tieude;
                item.MoTaNgan = motangan;
                string ht = collection["hienthitrangchu"];
                if(ht != null)
                {
                    item.HienThiTrangChu = true;
                }
                else
                {
                    item.HienThiTrangChu = false;
                }
                
                item.NgayTao = DateTime.Parse(ngaytao);
                item.NoiDung = noidung;
                db.SubmitChanges();
                flg = true;
            }

            if (flg)
            {
                return RedirectToAction("SuaTinTuc", "Admin", new { matintuc = matintuc });
            }
            else
            {
                ViewData["Msg"] = "Thêm không thành công.";
            }
            return View();
        }

        [HttpPost]
        public JsonResult xoaTinTucAjax(string matintuc)
        {

            bool flg = qltt.xoaTinTuc(matintuc);
            if(flg)
            {
                return Json(new
                {
                    rs = true,
                    matintuc = matintuc
                });
            }
            else
            {
                return Json(new
                {
                    rs = false
                });
            }    
        }

        //[HttpPost]
        //public JsonResult suaTinTucAjax(string logotintuc, string matintuc, string loaitintuc, string tieude,
        //                              string motangan, bool hienthitrangchu, string ngaytao, string noidung)
        //{
        //    string path = "";
        //    //bool flg = qltt.suaTinTuc(logotintuc, matintuc, loaitintuc, tieude,
        //    //                          motangan, hienthitrangchu, ngaytao, noidung,path);
        //    //if(flg)
        //    //{
        //    //    return Json(new
        //    //    {
        //    //        rs = "true"
        //    //    });
        //    //}
        //    //else
        //    //{
        //    //    return Json(new
        //    //    {
        //    //        rs = "false"
        //    //    });
        //    //}

        //}

        //[HttpPost]
        //[ValidateInput(false)]
        //public JsonResult ThemTinTucAjax(FormCollection collection, HttpPostedFileBase logotintuc, string loaitintuc, string tieude,
        //                                string motangan, string ngaytao, string noidung)
        //{
            
        //    VW_NHANVIEN nv = (VW_NHANVIEN)Session["AdminIsLogin"];
        //    TINTUC item = new TINTUC();
        //    item.SoLuongLuotXem = 0;
        //    item.NguoiLap = 10000001;
        //    item.MaLoaiTinTuc = int.Parse(loaitintuc);
        //    item.TieuDe = tieude;
        //    item.MoTaNgan = motangan;
        //    string ht = collection["hienthitrangchu"];
        //    if (ht != null)
        //    {
        //        item.HienThiTrangChu = true;
        //    }
        //    else
        //    {
        //        item.HienThiTrangChu = false;
        //    }
        //    item.TinhTrangXoa = false;
        //    item.NgayTao = DateTime.Now;
        //    item.NoiDung = noidung;
        //    item.Logo = "";
        //    db.TINTUCs.InsertOnSubmit(item);
        //    db.SubmitChanges();

        //    bool upSc = false;
        //    var files = Request.Files;
        //    var uploadFile = files["logotintuc"];
        //    string filename = uploadFile.FileName;

        //    if (!string.IsNullOrEmpty(filename))
        //    {
        //        string[] arr = filename.Split('.');
        //        filename = item.MaTinTuc.ToString() + "." + arr[1].ToString();
        //        string uploads = System.Web.HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["LogoTinTuc"]);
        //        string savePath = Path.Combine(uploads, item.MaTinTuc.ToString());
        //        if (!Directory.Exists(savePath))
        //        {
        //            Directory.CreateDirectory(savePath);
        //        }
        //        string delPath = Path.Combine(savePath, item.Logo.ToString());
        //        if (System.IO.File.Exists(delPath))
        //        {
        //            System.GC.Collect();
        //            System.GC.WaitForPendingFinalizers();
        //            System.IO.File.Delete(delPath);
        //        }
        //        MemoryStream ms = new MemoryStream();
        //        using (var stream = new FileStream(Path.Combine(savePath, filename), FileMode.Create))
        //        {
        //            uploadFile.InputStream.CopyTo(stream);
        //            stream.Close();
        //        }
        //        upSc = true;
        //    }
        //    if(upSc)
        //    {
        //        try
        //        {
        //            item.Logo = filename;
        //            db.SubmitChanges();
        //            return Json(new
        //            {
        //                rs = true,
        //                matintuc = item.MaTinTuc
        //            });
        //        }
        //        catch
        //        {
        //            return Json(new
        //            {
        //                rs = false
        //            });
        //        }
        //    }

        //    return Json(new
        //    {
        //        rs = false
        //    });
        //}
        [HttpGet]
        public ActionResult ThemTinTuc(FormCollection collection, HttpPostedFileBase logotintuc, string matintuc, string loaitintuc, string tieude,
                                       string motangan, string ngaytao, string noidung
                                       )
        {
            if (Session["AdminIsLogin"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            //bool flg = false;
            //TINTUC item = db.TINTUCs.Where(a => a.MaTinTuc == int.Parse(matintuc)).FirstOrDefault();
            //if (item != null)
            //{

            //    var files = Request.Files;
            //    var uploadFile = files["logotintuc"];


            //    string filename = uploadFile.FileName;

            //    if (!string.IsNullOrEmpty(filename))
            //    {
            //        string[] arr = filename.Split('.');
            //        filename = item.MaTinTuc.ToString() + "." + arr[1].ToString();
            //        string uploads = System.Web.HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["LogoTinTuc"]);
            //        string savePath = Path.Combine(uploads, item.MaTinTuc.ToString());
            //        if (!Directory.Exists(savePath))
            //        {
            //            Directory.CreateDirectory(savePath);
            //        }
            //        string delPath = Path.Combine(savePath, item.Logo.ToString());
            //        if (System.IO.File.Exists(delPath))
            //        {
            //            System.GC.Collect();
            //            System.GC.WaitForPendingFinalizers();
            //            System.IO.File.Delete(delPath);
            //        }
            //        MemoryStream ms = new MemoryStream();
            //        using (var stream = new FileStream(Path.Combine(savePath, filename), FileMode.Create))
            //        {
            //            uploadFile.InputStream.CopyTo(stream);
            //            stream.Close();
            //        }
            //    }


            //    item.MaLoaiTinTuc = int.Parse(loaitintuc);
            //    item.TieuDe = tieude;
            //    item.MoTaNgan = motangan;
            //    string ht = collection["hienthitrangchu"];
            //    if (ht != null)
            //    {
            //        item.HienThiTrangChu = true;
            //    }
            //    else
            //    {
            //        item.HienThiTrangChu = false;
            //    }

            //    item.NgayTao = DateTime.Parse(ngaytao);
            //    item.NoiDung = noidung;
            //    db.SubmitChanges();
            //    flg = true;
            //}

            //if (flg)
            //{
            //    return RedirectToAction("SuaTinTuc", "Admin", new { matintuc = matintuc });
            //}
            //else
            //{
            //    ViewData["Msg"] = "Thêm không thành công.";
            //}
            List<LOAITINTUC> lstLoaiTT = qltt.getListLoaiTinTuc();
            ViewData["lstLoaiTinTuc"] = lstLoaiTT;
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemTinTuc(FormCollection collection, HttpPostedFileBase logotintuc, string loaitintuc, string tieude,
                                        string motangan, string ngaytao, string noidung)
        {

            VW_NHANVIEN nv = (VW_NHANVIEN)Session["AdminIsLogin"];
            TINTUC item = new TINTUC();
            item.SoLuongLuotXem = 0;
            item.NguoiLap = nv.MaNhanVien;
            item.MaLoaiTinTuc = int.Parse(loaitintuc);
            item.TieuDe = tieude;
            item.MoTaNgan = motangan;
            string ht = collection["hienthitrangchu"];
            if (ht != null)
            {
                item.HienThiTrangChu = true;
            }
            else
            {
                item.HienThiTrangChu = false;
            }
            item.TinhTrangXoa = false;
            item.NgayTao = DateTime.Now;
            item.NoiDung = noidung;
            item.Logo = "";
            db.TINTUCs.InsertOnSubmit(item);
            db.SubmitChanges();

            bool upSc = false;
            var files = Request.Files;
            var uploadFile = files["logotintuc"];
            string filename = uploadFile.FileName;

            if (!string.IsNullOrEmpty(filename))
            {
                string[] arr = filename.Split('.');
                filename = item.MaTinTuc.ToString() + "." + arr[1].ToString();
                string uploads = System.Web.HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["LogoTinTuc"]);
                string savePath = Path.Combine(uploads, item.MaTinTuc.ToString());
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);
                }
                string delPath = Path.Combine(savePath, item.Logo.ToString());
                if (System.IO.File.Exists(delPath))
                {
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    System.IO.File.Delete(delPath);
                }
                MemoryStream ms = new MemoryStream();
                using (var stream = new FileStream(Path.Combine(savePath, filename), FileMode.Create))
                {
                    uploadFile.InputStream.CopyTo(stream);
                    stream.Close();
                }
                upSc = true;
            }
            if (upSc)
            {
                try
                {
                    item.Logo = filename;
                    db.SubmitChanges();
                    return RedirectToAction("ThongTinTinTuc", "Admin", new { matintuc = item.MaTinTuc.ToString() });
                }
                catch
                {
                    ViewData["Msg"] = "Quá trình thêm không thành công.";
                    return this.View();
                }
            }
            ViewData["Msg"] = "Quá trình thêm không thành công.";
            return this.View();
        }

        public ActionResult ThongTinTinTuc(string matintuc)
        {
            if (Session["AdminIsLogin"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            if (string.IsNullOrEmpty(matintuc))
            {
                return RedirectToAction("TinTuc", "Admin");
            }
            VW_TINTUC tt = qltt.getTinTuc(matintuc);
            ViewData["data"] = tt;

            List<LOAITINTUC> lstLoaiTT = qltt.getListLoaiTinTuc();
            ViewData["lstLoaiTinTuc"] = lstLoaiTT;
            return View();
        }
        public ActionResult Login(string targetUrl = null)
        {
            TempData["targetUrl"] = targetUrl;
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            string targetUrl = "";
            if (TempData["targetUrl"] != null)
            {
                targetUrl = TempData["targetUrl"].ToString();
                TempData.Keep("targetUrl");
            }
            if (qldn.kiemTraDangNhapAdmin(username, password))
            {
                VW_NHANVIEN dg = qldn.getModelNhanVien(username);
                if (dg != null)
                {
                    Session["AdminIsLogin"] = dg;
                    if (!string.IsNullOrEmpty(targetUrl))
                    {
                        return new RedirectResult(targetUrl);
                    }
                    return RedirectToAction("Index", "Admin");
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
    }
}