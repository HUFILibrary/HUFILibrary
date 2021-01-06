using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyThongTinDocGia
    {
        DB_QLTVDataContext db = new DB_QLTVDataContext();
        public List<VW_TAILIEUDANGMUON> getDSTLDangMuon(string mathethuvien)
        {
            List<VW_TAILIEUDANGMUON> lstTaiLieuDangMuon = db.VW_TAILIEUDANGMUONs.Where(a => a.MaTheThuVien == mathethuvien && a.TinhTrangTra == false && a.TinhTrangTraCT == false).ToList();
            return lstTaiLieuDangMuon;
        }

        public List<VW_TAILIEUDAMUON> getDSTLDaMuon(string mathethuvien)
        {
            List<VW_TAILIEUDAMUON> lstTaiLieuDangMuon = db.VW_TAILIEUDAMUONs.Where(a => a.MaTheThuVien == mathethuvien && a.TinhTrangTra == true && a.TinhTrangTraCT == true).ToList();
            return lstTaiLieuDangMuon;
        }
    }
}
