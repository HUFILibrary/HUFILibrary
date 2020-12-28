using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL_DAL;
namespace WebHUFILibrary.Controllers
{
    public class HomeController : Controller
    {
        QuanLyTaiLieu qltl = new QuanLyTaiLieu();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TimKiem()
        {

            return View();
        }

        [HttpPost]
        public ActionResult TimKiem(string typesearch, string txtsearch)
        {
            List<VW_TAILIEU> lstTL = new List<VW_TAILIEU>();
            if(typesearch == "1")
            {
                lstTL = qltl.timKiemTheoMaVach(txtsearch);
                
            }
            ViewData["listData"] = lstTL;
            return View();
        }


        
    }
}