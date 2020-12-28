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
        public ActionResult getImage(string hinhanh)
        {
            string uploadsPath = System.Web.HttpContext.Current.Server.MapPath("..//");
            string url = uploadsPath.Replace("WebHUFILibrary", "Images");
            string urlImage = Path.Combine(url, "TaiLieu", hinhanh);

            return File(urlImage, "image/jpeg");
        }
    }
}