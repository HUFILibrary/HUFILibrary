using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyDangNhap
    {
        DB_QLTVDataContext db = new DB_QLTVDataContext();

        public bool kiemTraDangNhap(string username, string password)
        {
            DOCGIA dg = db.DOCGIAs.Where(a => a.MaTheThuVien == username && a.MatKhau == password).FirstOrDefault();
            if(dg != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public VW_DOCGIA getModelDocGia(string username)
        {
            VW_DOCGIA dg = db.VW_DOCGIAs.Where(a => a.MaTheThuVien == username).FirstOrDefault();
            if(dg != null)
            {
                return dg;
            }
            else
            {
                return dg;
            }
        }

        public bool changePassword(string mathethuvien, string matkhau)
        {
            DOCGIA dg = db.DOCGIAs.Where(a => a.MaTheThuVien == mathethuvien).FirstOrDefault();
            if(dg != null)
            {
                dg.MatKhau = matkhau;
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool kiemTraMatKhauCu(string mathethuvien, string matkhaucu)
        {
            DOCGIA dg = db.DOCGIAs.Where(a => a.MaTheThuVien == mathethuvien).FirstOrDefault();
            if (dg != null)
            {
                if(dg.MatKhau != matkhaucu)
                {
                    return false;
                }    
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
