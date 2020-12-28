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

        public DOCGIA getModelDocGia(string username)
        {
            DOCGIA dg = db.DOCGIAs.Where(a => a.MaTheThuVien == username).FirstOrDefault();
            if(dg != null)
            {
                return dg;
            }
            else
            {
                return dg;
            }
        }
    }
}
