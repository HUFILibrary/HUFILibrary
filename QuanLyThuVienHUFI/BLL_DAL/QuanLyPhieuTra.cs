using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyPhieuTra
    {
        DB_QLTVDataContext qltv = new DB_QLTVDataContext();
        public IQueryable loadPhieuTra()
        {
            var pts = from pt in qltv.PHIEUTRAs

                      join nv in qltv.NHANVIENs on pt.MaNhanVien equals nv.MaNhanVien
                      where pt.TinhTrangXoa == false
                      select new { pt.MaPhieuTra, nv.TenNhanVien, pt.NgayLap, pt.SoLuongSachTra };
            return pts;
        }
        public IQueryable loadCTPT(int mapt)
        {
            var cts = from ct in qltv.CT_PHIEUTRAs
                      join tl in qltv.TAILIEUs on ct.MaVach equals tl.MaVach
                      join cd in qltv.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                      join ltl in qltv.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                      where ct.MaPhieuTra == mapt && ct.TinhTrangXoa == false
                      select new {ct.MaChiTietPhieuTra, ct.MaPhieuTra, ct.MaPhieuMuon, tl.MaVach, tl.TenTaiLieu,cd.TenChuDe, ltl.TenLoaiTaiLieu, tl.MaTap};
            return cts;
        }
        public bool xoaPhieuTra(PHIEUTRA xpt)
        {
            PHIEUTRA pt = qltv.PHIEUTRAs.Where(t => t.MaPhieuTra == xpt.MaPhieuTra).FirstOrDefault();
            if (pt != null)
            {
                try {
                    List<CT_PHIEUTRA> lstCTPT = qltv.CT_PHIEUTRAs.Where(t => t.MaPhieuTra == pt.MaPhieuTra).ToList();
                    foreach (CT_PHIEUTRA _ctpt in lstCTPT)
                    {
                        PHIEUMUON _pm = qltv.PHIEUMUONs.Where(m => m.MaPhieuMuon == _ctpt.MaPhieuMuon).FirstOrDefault();
                        List<CT_PHIEUMUON> lstCTPM = qltv.CT_PHIEUMUONs.Where(ct => ct.MaPhieuMuon == _pm.MaPhieuMuon && ct.MaVach == _ctpt.MaVach).ToList();
                        foreach (CT_PHIEUMUON _ctpm in lstCTPM)
                        {
                            if (_ctpm.TinhTrangTraCT == true)
                            {
                                _ctpm.TinhTrangTraCT = false;
                            }
                        }
                        _pm.TinhTrangTra = false;
                        qltv.CT_PHIEUTRAs.DeleteOnSubmit(_ctpt);
                        qltv.SubmitChanges();
                    }
                    qltv.PHIEUTRAs.DeleteOnSubmit(pt);
                    qltv.SubmitChanges();
                    return true;
                }
                catch (Exception ex) {

                    return false;
                }
            }
            return false;
        }
        public bool xoaCTPT(CT_PHIEUTRA ct)
        {
            CT_PHIEUTRA _ct = qltv.CT_PHIEUTRAs.Where(c => c.MaChiTietPhieuTra == ct.MaChiTietPhieuTra).FirstOrDefault();
            if (_ct != null)
            {

                PHIEUTRA _pt = qltv.PHIEUTRAs.Where(t => t.MaPhieuTra == _ct.MaPhieuTra).FirstOrDefault();
                try
                {
                    _pt.SoLuongSachTra = _pt.SoLuongSachTra - 1;
                    qltv.CT_PHIEUTRAs.DeleteOnSubmit(_ct);
                    qltv.SubmitChanges();

                    PHIEUMUON _pm = qltv.PHIEUMUONs.Where(m => m.MaPhieuMuon == _ct.MaPhieuMuon).FirstOrDefault();
                    if (_pm != null)
                    {
                        CT_PHIEUMUON _ctpm = qltv.CT_PHIEUMUONs.Where(t => t.MaVach == _ct.MaVach && t.MaPhieuMuon == _pm.MaPhieuMuon).FirstOrDefault();
                        _ctpm.TinhTrangTraCT = false;
                        _pm.TinhTrangTra = false;
                        qltv.SubmitChanges();
                    }

                    return true;
                }
                catch (Exception ex) { return false; }
            }
            return false;
        }
    }
}
