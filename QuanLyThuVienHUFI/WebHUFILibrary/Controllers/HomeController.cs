using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL_DAL;
using PagedList;
using WebHUFILibrary.Models;
namespace WebHUFILibrary.Controllers
{
    public class HomeController : Controller
    {
        QuanLyTaiLieu qltl = new QuanLyTaiLieu();
        DB_QLTVDataContext ent = new DB_QLTVDataContext();
        public ActionResult Index()
        {
              
            return View();
        }

        //[HttpGet]
        //public ActionResult TimKiem(int? page,string currentFilter)
        //{
        //    int pageSize = 5;
        //    int pageNumber = (page ?? 1);
        //    if (mavach != null)
        //    {
        //        page = 1;
        //    }

        //        mavach = currentFilter;
            
        //        return View();
        //}

        [HttpGet]
        public ActionResult TimKiem(int? page, string typesearch, string txtsearch, string CurrentTxtSearch, 
            string CurrentTypeSearch, string selection__toantu1, string selection__toantu2, string selection__toantu3, 
            string txtSearchNangCao1, string txtSearchNangCao2, string txtSearchNangCao3,
            string selection__noidung1, string selection__noidung2, string selection__noidung3,
            string CurrentSelectionToanTu1, string CurrentSelectionToanTu2, string CurrentSelectionToanTu3,
            string CurrentTxtSearchNangCao1, string CurrentTxtSearchNangCao2, string CurrentTxtSearchNangCao3,
            string CurrentSelectionNoiDung1, string CurrentSelectionNoiDung2, string CurrentSelectionNoiDung3)
        {
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            if (txtsearch != null)
            {
                page = 1;
            }
            else
            {
                txtsearch = CurrentTxtSearch;
                typesearch = CurrentTypeSearch;
                txtSearchNangCao1 = CurrentTxtSearchNangCao1;
                txtSearchNangCao2 = CurrentTxtSearchNangCao2;
                txtSearchNangCao3 = CurrentTxtSearchNangCao3;
                selection__toantu1 = CurrentSelectionToanTu1;
                selection__toantu2 = CurrentSelectionToanTu2;
                selection__toantu3 = CurrentSelectionToanTu3;
                selection__noidung1 = CurrentSelectionNoiDung1;
                selection__noidung2 = CurrentSelectionNoiDung2;
                selection__noidung3 = CurrentSelectionNoiDung3;
            }
            ViewBag.CurrentTxtSearch = txtsearch;
            ViewBag.CurrentTypeSearch = typesearch;
            ViewBag.CurrentTxtSearchNangCao1 = txtSearchNangCao1;
            ViewBag.CurrentTxtSearchNangCao2 = txtSearchNangCao2;
            ViewBag.CurrentTxtSearchNangCao3 = txtSearchNangCao3;
            ViewBag.CurrentSelectionToanTu1 = selection__toantu1;
            ViewBag.CurrentSelectionToanTu2 = selection__toantu2;
            ViewBag.CurrentSelectionToanTu3 = selection__toantu3;
            ViewBag.CurrentSelectionNoiDung1 = selection__noidung1;
            ViewBag.CurrentSelectionNoiDung2 = selection__noidung2;
            ViewBag.CurrentSelectionNoiDung3 = selection__noidung3;

            List<VW_TAILIEU> lstTL = new List<VW_TAILIEU>();
            if(string.IsNullOrEmpty(txtsearch) && string.IsNullOrEmpty(txtSearchNangCao1))
            {
                
            }
            else
            {
                lstTL = qltl.getList(typesearch, txtsearch, selection__toantu1, txtSearchNangCao1, selection__noidung1, selection__toantu2, txtSearchNangCao2, selection__noidung2, selection__toantu3, txtSearchNangCao3, selection__noidung3);
            }
            //// sql query
            //List<SqlParameter> param_list = new List<SqlParameter>();
            //string select = "";
            //select += " SELECT * ";
            //select += " FROM VW_TAILIEU ";
            //select += " WHERE VW_TAILIEU.TinhTrangXoa = 0 ";

            //if(typesearch == "1")
            //{
            //    lstTL = qltl.timKiemTheoMaVach(txtsearch);
            //    select += " AND VW_TAILIEU.MaVach LIKE @MaVach1 ";
            //    param_list.Add(new SqlParameter("MaVach1", txtsearch));
            //}
            //else if(typesearch == "2")
            //{
            //    lstTL = qltl.timKiemTheoTieuDe(txtsearch);
            //    select += " AND VW_TAILIEU.TenTaiLieu LIKE @TenTaiLieu1 ";
            //    param_list.Add(new SqlParameter("TenTaiLieu1", txtsearch));
            //}
            //else if (typesearch == "3")
            //{
            //    lstTL = qltl.timKiemTheoTacGia(txtsearch);
            //    select += " AND VW_TAILIEU.TenTacGia LIKE @TenTacGia1 ";
            //    param_list.Add(new SqlParameter("TenTacGia1", txtsearch));
            //}
            //else if (typesearch == "4")
            //{
            //    lstTL = qltl.timKiemTheoNhaXuatBan(txtsearch);
            //    select += " AND VW_TAILIEU.TenNhaXuatBan LIKE @TenNhaXuatBan1 ";
            //    param_list.Add(new SqlParameter("TenNhaXuatBan1", txtsearch));
            //}
            //else if (typesearch == "5")
            //{
            //    lstTL = qltl.timKiemTheoChuDe(txtsearch);
            //    select += " AND VW_TAILIEU.TenChuDe LIKE @TenChuDe1 ";
            //    param_list.Add(new SqlParameter("TenChuDe1", txtsearch));
            //}


            //#region ORDER BY
            //select += " ORDER BY VW_TAILIEU.MaVach ";
            //#endregion

            //lstTL = ent.ExecuteStoreQuery


            ViewData["listData"] = lstTL;
            List<SearchModel> lstSearchModel = new List<SearchModel>();
            lstSearchModel.Add(new SearchModel("1","Mã vạch"));
            lstSearchModel.Add(new SearchModel("2", "Tiêu đề"));
            lstSearchModel.Add(new SearchModel("3", "Tác giả"));
            lstSearchModel.Add(new SearchModel("4", "Nhà xuất bản"));
            lstSearchModel.Add(new SearchModel("5", "Chủ đề"));

            List<SearchModel> lstSearchModel1 = new List<SearchModel>();
            lstSearchModel1.Add(new SearchModel("MaVach", "Mã vạch"));
            lstSearchModel1.Add(new SearchModel("TenTaiLieu", "Tiêu đề"));
            lstSearchModel1.Add(new SearchModel("TenTacGia", "Tác giả"));
            lstSearchModel1.Add(new SearchModel("TenNhaXuatBan", "Nhà xuất bản"));
            lstSearchModel1.Add(new SearchModel("TenChuDe", "Chủ đề"));

            List<SearchModel> lstToanTu = new List<SearchModel>();
            lstToanTu.Add(new SearchModel("AND","AND"));
            lstToanTu.Add(new SearchModel("OR", "OR"));
            lstToanTu.Add(new SearchModel("AND NOT", "NOT"));

            ViewData["lstToanTu"] = lstToanTu;
            ViewData["lstSearchModel"] = lstSearchModel;
            ViewData["lstSearchModel1"] = lstSearchModel1;
            return View(lstTL.OrderByDescending(a=>a.MaVach).ToPagedList(pageNumber,pageSize));
        }




        
    }
}