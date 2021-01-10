using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public List<VW_TINTUC> getListTinTucBysearch(string txtSearch, string typeSearch)
        {
            List<VW_TINTUC> lstTL = new List<VW_TINTUC>();
            List<SqlParameter> param_list = new List<SqlParameter>();

            string select = "";
            select += " SELECT * ";
            select += " FROM VW_TINTUC ";
            select += " WHERE VW_TINTUC.TinhTrangXoa = 0 ";
            if (typeSearch == "Ma")
            {
                select += " AND VW_TINTUC.MaTinTuc LIKE {0} ";
                param_list.Add(new SqlParameter("MaTinTuc", "%" + txtSearch + "%"));
            }
            else if (typeSearch == "TieuDe")
            {

                select += " AND VW_TINTUC.TieuDe LIKE {0} ";
                param_list.Add(new SqlParameter("TieuDe", "%" + txtSearch + "%"));
            }
            else if (typeSearch == "LoaiTin")
            {

                select += " AND VW_TINTUC.TenMaLoaiTinTuc LIKE {0} ";
                param_list.Add(new SqlParameter("TenMaLoaiTinTuc", "%" + txtSearch + "%"));
            }

            select += " ORDER BY VW_TINTUC.MaTinTuc ";

            try
            {
                
                lstTL = db.ExecuteQuery<VW_TINTUC>(select, getSqlParameters(param_list)).ToList();
            }
            catch (Exception ex)
            {
                string temp = ex.ToString();
            }

            return lstTL;
        }
        public Object[] getSqlParameters(List<SqlParameter> param_list)
        {

            var param_count = param_list.Count;
            var sql_parameters = new Object[param_count];

            for (var i = 0; i < param_count; i++)
            {
                sql_parameters[i] = param_list[i].Value;
            }

            return sql_parameters;
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
        //public bool themTinTuc(string maloaitintuc, string tieude, string motangan, string noidung, string manhanvien, bool hienthitrangchu, string logo)
        //{

        //}
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

        public List<VW_TINTUC> getLstTinTucSuKien()
        {
            List<VW_TINTUC> lst = db.VW_TINTUCs.Where(a => a.HienThiTrangChu == true && a.MaLoaiTinTuc == 1).ToList();
            return lst;
        }

        public List<VW_TINTUC> getLstThongBao()
        {
            List<VW_TINTUC> lst = db.VW_TINTUCs.Where(a => a.HienThiTrangChu == true && a.MaLoaiTinTuc == 2).ToList();
            return lst;
        }

        public void updateView(string matintuc)
        {
            TINTUC item = db.TINTUCs.Where(a => a.MaTinTuc == int.Parse(matintuc)).FirstOrDefault();
            if(item != null)
            {
                item.SoLuongLuotXem++;
                db.SubmitChanges();
            }
        }
    }
}
