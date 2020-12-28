using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class ThongKe
    {
        DB_QLTVDataContext db = new DB_QLTVDataContext();
        public IQueryable loadPhieuMuonTreHan()
        {
            var pms = from pm in db.PHIEUMUONs
                      join nv in db.NHANVIENs on pm.MaNhanVien equals nv.MaNhanVien
                      where (pm.TinhTrangTra == false) && (pm.TinhTrangXoa == false) && (pm.ThoiHanMuon < DateTime.Now)

                      select new { pm.MaPhieuMuon, pm.MaTheThuVien,nv.MaNhanVien, nv.TenNhanVien, pm.NgayLap, pm.ThoiHanMuon, pm.TinhTrangTra, pm.PhiCoc };
            return pms;
        }
    }
}
