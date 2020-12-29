using System;
using System.Collections.Generic;
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
        public ActionResult TimKiem(int? page, string typesearch, string txtsearch, string CurrentTxtSearch, string CurrentTypeSearch)
        {
            int pageSize = 5;
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
            List<VW_TAILIEU> lstTL = new List<VW_TAILIEU>();
            if(typesearch == "1")
            {
                lstTL = qltl.timKiemTheoMaVach(txtsearch);
                
            }
            else if(typesearch == "2")
            {
                lstTL = qltl.timKiemTheoTieuDe(txtsearch);
            }
            else if (typesearch == "3")
            {
                lstTL = qltl.timKiemTheoTacGia(txtsearch);
            }
            else if (typesearch == "4")
            {
                lstTL = qltl.timKiemTheoNhaXuatBan(txtsearch);
            }
            else if (typesearch == "5")
            {
                lstTL = qltl.timKiemTheoChuDe(txtsearch);
            }
            ViewData["listData"] = lstTL;
            List<SearchModel> lstSearchModel = new List<SearchModel>();
            lstSearchModel.Add(new SearchModel("1","Mã vạch"));
            lstSearchModel.Add(new SearchModel("2", "Tiêu đề"));
            lstSearchModel.Add(new SearchModel("3", "Tác giả"));
            lstSearchModel.Add(new SearchModel("4", "Nhà xuất bản"));
            lstSearchModel.Add(new SearchModel("5", "Chủ đề"));

            ViewData["lstSearchModel"] = lstSearchModel;
            return View(lstTL.OrderByDescending(a=>a.MaVach).ToPagedList(pageNumber,pageSize));
        }




        
    }
}