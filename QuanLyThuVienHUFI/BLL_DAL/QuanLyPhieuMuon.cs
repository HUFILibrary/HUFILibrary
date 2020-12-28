using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL_DAL
{
    public class QuanLyPhieuMuon
    {
        DB_QLTVDataContext db = new DB_QLTVDataContext();
        public IQueryable loadDgvPhieuMuon()
        {
            var pms = from pm in db.PHIEUMUONs
                      join nv in db.NHANVIENs on pm.MaNhanVien equals nv.MaNhanVien
                      join dg in db.DOCGIAs on pm.MaTheThuVien equals dg.MaTheThuVien
                      where pm.TinhTrangXoa == false
                      select new { pm.MaPhieuMuon, pm.MaTheThuVien, nv.TenNhanVien, pm.NgayLap, pm.SoSachMuon, pm.TinhTrangTra, pm.PhiCoc,pm.ThoiHanMuon };
            return pms;
        }

        public bool suaPhieuMuon(string maphieumuon, bool tinhtrangtra, string phicoc, string ngaymuon, string thoihanmuon)
        {
            if(string.IsNullOrEmpty(maphieumuon) || string.IsNullOrEmpty(tinhtrangtra.ToString()) || string.IsNullOrEmpty(phicoc) || string.IsNullOrEmpty(ngaymuon) || string.IsNullOrEmpty(thoihanmuon))
            {
                return false;
            }
            PHIEUMUON pm = db.PHIEUMUONs.Where(a => a.MaPhieuMuon == int.Parse(maphieumuon)).FirstOrDefault();

            var cts = from ct in db.CT_PHIEUMUONs
                      where ct.MaPhieuMuon == pm.MaPhieuMuon
                      select ct;

            if(pm != null)
            {
                if(tinhtrangtra)
                {
                    pm.TinhTrangTra = true;
                    foreach(CT_PHIEUMUON ct in cts)
                    {
                        ct.TinhTrangTraCT = true;
                    }
                }   
                else
                {
                    pm.TinhTrangTra = false;
                }
                pm.PhiCoc = double.Parse(phicoc);
                pm.NgayLap = DateTime.Parse(ngaymuon);
                pm.ThoiHanMuon = DateTime.Parse(thoihanmuon);
                db.SubmitChanges();
                return true;
            }    
            else
            {
                return false;
            }    
        }

       
        public bool xoaPhieuMuon(string maphieumuon)
        {
            PHIEUMUON delItem = db.PHIEUMUONs.Where(a => a.MaPhieuMuon == int.Parse(maphieumuon)).FirstOrDefault();
            if(delItem != null)
            {
                delItem.TinhTrangXoa = true;
                var cts = from ct in db.CT_PHIEUMUONs
                          where ct.MaPhieuMuon == int.Parse(maphieumuon)
                          select ct;
                if(cts != null)
                {
                    foreach(CT_PHIEUMUON item in cts)
                    {
                        db.CT_PHIEUMUONs.DeleteOnSubmit(item);
                    }
                }
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }   
        }
        public IQueryable loadDgvCT_Phieumuon(string maphieumuon)
        {
            
            var cts = from ct in db.CT_PHIEUMUONs
                      join pm in db.PHIEUMUONs on ct.MaPhieuMuon equals pm.MaPhieuMuon
                      join tls in db.TAILIEUs on ct.MaVach equals tls.MaVach
                      join cd in db.CHUDEs on tls.MaChuDe equals cd.MaChuDe
                      join nn in db.NGONNGUs on tls.MaNgonNgu equals nn.MaNgonNgu
                      join loaitl in db.LOAITAILIEUs on tls.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                      join tg in db.TACGIAs on tls.MaTacGia equals tg.MaTacGia
                      join nxb in db.NHAXUATBANs on tls.MaNhaXuatBan equals nxb.MaNhaXuatBan
                      join vt in db.VITRIs on tls.MaViTri equals vt.MaViTri
                      where  (ct.MaPhieuMuon == int.Parse(maphieumuon)) && (ct.TinhTrangXoa == false)
                      select new { ct.MaChiTietPhieuMuon, ct.MaVach,tls.TenTaiLieu,loaitl.TenLoaiTaiLieu,ct.TinhTrangTraCT};
            return cts;
        }
        public bool xoaCT_PhieuMuon(string mact)
        {
            
            CT_PHIEUMUON ct = db.CT_PHIEUMUONs.Where(a => a.MaChiTietPhieuMuon == int.Parse(mact)).FirstOrDefault();
            if(ct != null)
            {
                ct.TinhTrangXoa = true;
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool suaCT_PhieuMuon(string mact, bool tinhtrangtra)
        {
            CT_PHIEUMUON ct = db.CT_PHIEUMUONs.Where(a => a.MaChiTietPhieuMuon == int.Parse(mact)).FirstOrDefault();
            if(ct != null)
            {
                ct.TinhTrangTraCT = tinhtrangtra;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
