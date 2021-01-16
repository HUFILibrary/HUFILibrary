using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHUFILibrary.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult getImage(string hinhanh, string type)
        {
            string uploadsPath = System.Web.HttpContext.Current.Server.MapPath("..//");
            string url = uploadsPath.Replace("WebHUFILibrary", "Images");
            string urlImage = Path.Combine(url, type, hinhanh);

            return File(urlImage, "image/jpeg");
        }

        public ActionResult getImageIndex(string matintuc, string logo)
        {
            string path = System.Web.HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["LogoTinTuc"]);
            
            string urlImage = Path.Combine(path, matintuc, logo);

            return File(urlImage, "image/jpeg");
        }
    }
}