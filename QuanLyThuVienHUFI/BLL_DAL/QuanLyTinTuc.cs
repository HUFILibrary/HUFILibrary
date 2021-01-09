using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace BLL_DAL
{
    
    public class QuanLyTinTuc
    {
        DB_QLTVDataContext db = new DB_QLTVDataContext();
        public List<VW_TINTUC> getListTinTuc()
        {
            List<VW_TINTUC> lstTinTuc = db.VW_TINTUCs.Where(a=>a.TinhTrangXoa == false).ToList();
            return lstTinTuc;
        }

        public VW_TINTUC getTinTuc(string id)
        {
            VW_TINTUC tt = db.VW_TINTUCs.Where(a => a.MaTinTuc == int.Parse(id)).FirstOrDefault();
            if(tt != null)
            {
                return tt;
            }
            else
            {
                VW_TINTUC ts = new VW_TINTUC();
                return ts;
            }
        }
        public bool xoaTinTuc(string matintuc)
        {
            TINTUC tt = db.TINTUCs.Where(a => a.MaTinTuc == int.Parse(matintuc)).FirstOrDefault();
            if(tt != null)
            {
                tt.TinhTrangXoa = true;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool suaTinTuc(string matintuc, string loaitintuc, string tieude,
                                      string motangan, bool? hienthitrangchu, string ngaytao, string noidung)
        {
            //TINTUC item = db.TINTUCs.Where(a => a.MaTinTuc == int.Parse(matintuc)).FirstOrDefault();
            //if(item != null)
            //{
            //    if(!string.IsNullOrEmpty(logotintuc))
            //    {

            //        //string uploadsPath = logotintuc;
            //        //string ext = Path.GetExtension(logotintuc);
            //        //uploadsPath += "Images\\TaiLieu\\" + item.MaTinTuc + ext;
            //        //if (System.IO.File.Exists(uploadsPath))
            //        //{
            //        //    System.GC.Collect();
            //        //    System.GC.WaitForPendingFinalizers();
            //        //    try
            //        //    {
            //        //        System.IO.File.Delete(uploadsPath);
            //        //    }
            //        //    catch (Exception ex)
            //        //    {

            //        //    }

            //        //}
            //        //try
            //        //{
            //        //    System.IO.File.Copy(logotintuc, uploadsPath.ToString());
            //        //    rs.HinhAnh = rs.MaVach + "" + ext;
            //        //}
            //        //catch (Exception ex)
            //        //{
            //        //    continue;
            //        //}
            //    }
            //    item.MaLoaiTinTuc = int.Parse(loaitintuc);
            //    item.TieuDe = tieude;
            //    item.MoTaNgan = motangan;
            //    item.HienThiTrangChu = bool.Parse(hienthitrangchu.ToString());
            //    item.NgayTao = DateTime.Parse(ngaytao);
            //    item.NoiDung = noidung;
            //    db.SubmitChanges();
            //    return true;
            //}

            return false;
        }
        public List<LOAITINTUC> getListLoaiTinTuc()
        {
            List<LOAITINTUC> lst = db.LOAITINTUCs.ToList();
            return lst;
        }
    }
}
