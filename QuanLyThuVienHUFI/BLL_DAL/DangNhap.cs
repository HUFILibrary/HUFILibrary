using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DangNhap
    {
        DB_QLTVDataContext qltv = new DB_QLTVDataContext();
        public int ktraDangNhapTK(NHANVIEN nvtk, ref string username, ref string hoten)
        {
            NHANVIEN nv = qltv.NHANVIENs.Where(t => t.MaNhanVien == nvtk.MaNhanVien).FirstOrDefault();
            if (nv == null)
            {
                return 0;
            }
            else if ( nv.TinhTrangXoa == true)
            {
                return 2;
            }    
            else {
                if (nv.MatKhau != nvtk.MatKhau)
                {
                    return -1;
                }
                username = nv.MaNhanVien.ToString();
                hoten = nv.TenNhanVien;
                return 1;
            }
        }
    }
}
