using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL_DAL;
using PagedList;
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

            //*** Tài liệu cùng tác giả
            //List<VW_TAILIEUCUNGTACGIA> lstTLCungTacGia = qltl.lstTLCungTacGia(mavach);
            List<VW_TAILIEU> lstTLCungTacGiaCoMaVach = qltl.lstTLCungTacGiaCoMaVach(mavach);
            List<VW_TAILIEUCUNGTACGIA> lstTLCungTacGia = new List<VW_TAILIEUCUNGTACGIA>();
            Dictionary<string, string> lstDicMaVach = new Dictionary<string, string>();
            Dictionary<string, string> lstDicHinhAnh = new Dictionary<string, string>();
            foreach (VW_TAILIEU item in lstTLCungTacGiaCoMaVach)
            {
                if(!lstDicMaVach.ContainsKey(item.MaTaiLieu))
                {
                    lstDicMaVach.Add(item.MaTaiLieu, item.MaVach);
                }    
                if(!lstDicHinhAnh.ContainsKey(item.MaTaiLieu))
                {
                    lstDicHinhAnh.Add(item.MaTaiLieu, item.HinhAnh);
                }
            }
            foreach (VW_TAILIEU itemFlg in lstTLCungTacGiaCoMaVach)
            {
                VW_TAILIEUCUNGTACGIA item = new VW_TAILIEUCUNGTACGIA();
                item.MaTaiLieu = itemFlg.MaTaiLieu;
                item.TenTacGia = itemFlg.TenTacGia;
                item.TenTaiLieu = itemFlg.TenTaiLieu;

                lstTLCungTacGia.Add(item);
            }
            ViewData["lstDicMaVach"] = lstDicMaVach;
            ViewData["lstDicHinhAnh"] = lstDicHinhAnh;
            ViewData["lstTLCungTacGia"] = lstTLCungTacGia;

            // *** Tài liệu cùng chủ đề
            //List<VW_TAILIEUCUNGCHUDE> lstTLCungChuDe = qltl.lstTLCungChuDe(mavach);
            List<VW_TAILIEUCUNGCHUDE> lstTLCungChuDe = new List<VW_TAILIEUCUNGCHUDE>();
            List<VW_TAILIEU> lstTLCungChuDeCoMaVach = qltl.lstTLCungChuDeCoMaVach(mavach);
            Dictionary<string, string> lstDicMaVachChuDe = new Dictionary<string, string>();
            Dictionary<string, string> lstDicHinhAnhChuDe = new Dictionary<string, string>();
            foreach (VW_TAILIEU item in lstTLCungChuDeCoMaVach)
            {
                if (!lstDicMaVachChuDe.ContainsKey(item.MaTaiLieu))
                {
                    lstDicMaVachChuDe.Add(item.MaTaiLieu, item.MaVach);
                }
                if (!lstDicHinhAnhChuDe.ContainsKey(item.MaTaiLieu))
                {
                    lstDicHinhAnhChuDe.Add(item.MaTaiLieu, item.HinhAnh);
                }
            }
            foreach(VW_TAILIEU itemFlg in lstTLCungChuDeCoMaVach)
            {
                VW_TAILIEUCUNGCHUDE item = new VW_TAILIEUCUNGCHUDE();
                item.MaTaiLieu = itemFlg.MaTaiLieu;
                item.TenChuDe = itemFlg.TenChuDe;
                item.TenTaiLieu = itemFlg.TenTaiLieu;

                lstTLCungChuDe.Add(item);
            }
            ViewData["lstDicMaVachChuDe"] = lstDicMaVachChuDe;
            ViewData["lstDicHinhAnhChuDe"] = lstDicHinhAnhChuDe;
            ViewData["lstTLCungChuDe"] = lstTLCungChuDe;

            ViewData["mavach"] = mavach.ToString();
            return View();
        }
    }
}