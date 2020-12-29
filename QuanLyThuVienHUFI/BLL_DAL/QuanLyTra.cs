using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyTra
    {
        DB_QLTVDataContext qltv = new DB_QLTVDataContext();
        public IQueryable layMVtuCTPM(string matl)
        {
            var mv = from pm in qltv.PHIEUMUONs
                     join ctpm in qltv.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                     join tls in qltv.TAILIEUs on ctpm.MaVach equals tls.MaVach
                     join cd in qltv.CHUDEs on tls.MaChuDe equals cd.MaChuDe
                     join nn in qltv.NGONNGUs on tls.MaNgonNgu equals nn.MaNgonNgu
                     join loaitl in qltv.LOAITAILIEUs on tls.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                     join tg in qltv.TACGIAs on tls.MaTacGia equals tg.MaTacGia
                     join nxb in qltv.NHAXUATBANs on tls.MaNhaXuatBan equals nxb.MaNhaXuatBan
                     join vt in qltv.VITRIs on tls.MaViTri equals vt.MaViTri
                     where matl == ctpm.MaVach && tls.TinhTrangXoa == false && ctpm.TinhTrangTraCT == false && pm.TinhTrangTra == false
                     select new { tls.MaVach, pm.MaPhieuMuon, tls.TenTaiLieu, cd.TenChuDe, tls.MaTap, nn.TenNgonNgu, nxb.TenNhaXuatBan, tg.TenTacGia, pm.NgayLap, tls.Gia };
            return mv;
        }

        public DOCGIA layMaDG(DOCGIA dg, string mavach, ref string pmc)
        {
            DOCGIA dgs = new DOCGIA();
            CT_PHIEUMUON ctpm = qltv.CT_PHIEUMUONs.Where(m => m.MaVach == mavach && m.TinhTrangTraCT == false).FirstOrDefault(); //mv
            if (ctpm != null)
            {
                PHIEUMUON pm = qltv.PHIEUMUONs.Where(p => p.MaPhieuMuon == ctpm.MaPhieuMuon && p.TinhTrangTra == false).FirstOrDefault();
                if (pm != null)
                {
                    dgs = qltv.DOCGIAs.Where(d => d.MaTheThuVien == pm.MaTheThuVien).FirstOrDefault();
                    dg = dgs;
                    pmc = pm.PhiCoc.ToString();

                }
            }
            return dg;
        }
        public float tinhPhiBT(LOAIVIPHAM lvp, int songay, float giatl)
        {
            float tongtien = 0;
            LOAIVIPHAM vp = qltv.LOAIVIPHAMs.Where(v => v.MaLoaiViPham == lvp.MaLoaiViPham).FirstOrDefault();

            if (vp.MaLoaiViPham == 1)
            {
                HINHTHUCXULY xl = qltv.HINHTHUCXULies.Where(l => l.MaHinhThucXuLy == vp.MaHinhThucXuLy).FirstOrDefault();
                tongtien = float.Parse(xl.PhiBoiThuong.ToString()) * float.Parse(songay.ToString());
            }
            else {
                HINHTHUCXULY xl = qltv.HINHTHUCXULies.Where(l => l.MaHinhThucXuLy == vp.MaHinhThucXuLy).FirstOrDefault();
                tongtien = float.Parse(xl.PhiBoiThuong.ToString()) * giatl;
            }
            return tongtien;

        }
        public IQueryable loadLoaiVP() {
            var lvp = from l in qltv.LOAIVIPHAMs select new { l.MaLoaiViPham, l.TenLoaiViPham };
            return lvp;
        }

        public bool updateTinhTrangPM(string mapm)
        {
            PHIEUMUON pm = qltv.PHIEUMUONs.Where(m => m.MaPhieuMuon == int.Parse(mapm)).FirstOrDefault();
            if (pm != null)
            {
                List<CT_PHIEUMUON> lstCTPM = qltv.CT_PHIEUMUONs.Where(m => m.MaPhieuMuon == pm.MaPhieuMuon).ToList();
                if (lstCTPM == null)
                {
                    return false;
                }
                foreach (CT_PHIEUMUON _ct in lstCTPM)
                {
                    if (_ct.TinhTrangTraCT == false)
                    {
                        return false;
                    }
                }
                pm.TinhTrangTra = true;
                return true;
            }
            return false;
        }
        public bool luuPhieuTra(int mapm, int manv, DateTime ngaytra, int sltra, bool tiencoc, string tiencocdg, List<CT_PHIEUTRA> lstCTPT)
        {
            PHIEUTRA pt = new PHIEUTRA();
            try
            {
                //pt.MaPhieuMuon = mapm;
                pt.MaNhanVien = manv;
                pt.NgayLap = ngaytra;
                pt.SoLuongSachTra = sltra;
                pt.TinhTrangXoa = false;
                qltv.PHIEUTRAs.InsertOnSubmit(pt);
                qltv.SubmitChanges();
                PHIEUTRA mapt = qltv.PHIEUTRAs.Where(n => n.TinhTrangXoa == false).OrderByDescending(x => x.MaPhieuTra).First();
                foreach (CT_PHIEUTRA ctpt in lstCTPT)
                {
                    CT_PHIEUTRA _ctpt = new CT_PHIEUTRA();
                    _ctpt.MaPhieuTra = mapt.MaPhieuTra;
                    _ctpt.MaPhieuMuon = ctpt.MaPhieuMuon;
                    _ctpt.MaVach = ctpt.MaVach;
                    _ctpt.TinhTrangXoa = false;

                    CT_PHIEUMUON _ctpm = qltv.CT_PHIEUMUONs.Where(m => m.MaPhieuMuon == ctpt.MaPhieuMuon && m.MaVach == ctpt.MaVach).FirstOrDefault();
                    if (_ctpm.TinhTrangTraCT == false)
                    {
                        _ctpm.TinhTrangTraCT = true;
                    }
                    if (updateTinhTrangPM(ctpt.MaPhieuMuon.ToString()))
                    {
                        if (tiencoc == true)
                        {
                            PHIEUMUON _pm = qltv.PHIEUMUONs.Where(m => m.MaPhieuMuon == ctpt.MaPhieuMuon).FirstOrDefault();
                            _pm.PhiCoc = 0;
                            tiencocdg = _pm.PhiCoc.ToString();
                        }
                    }
                    qltv.CT_PHIEUTRAs.InsertOnSubmit(_ctpt);
                    qltv.SubmitChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string layMaTVTheoPM(string mapm)
        {
            PHIEUMUON pm = qltv.PHIEUMUONs.Where(m => m.MaPhieuMuon == int.Parse(mapm)).FirstOrDefault();
            if (pm != null)
            {
                return pm.MaTheThuVien;
            }
            return "";

        }


        public PHIEUMUON tinhTienCoc(DOCGIA dg, float money)
        {
            PHIEUMUON d = qltv.PHIEUMUONs.Where(n => n.MaTheThuVien == dg.MaTheThuVien).FirstOrDefault();
            if (d != null)
            {
                d.PhiCoc -= money;
                qltv.SubmitChanges();
            }
            return d;
        }
        public bool luuPhieuXLVP(DateTime ngaylap, float tongtien, List<CT_XULYVIPHAM> lstCTVP, int manv)
        {

            PHIEUTRA mapt = qltv.PHIEUTRAs.Where(n => n.TinhTrangXoa == false).OrderByDescending(x => x.MaPhieuTra).First();
           
            PHIEUXULYVIPHAM pxlvp = qltv.PHIEUXULYVIPHAMs.Where(l => l.MaPhieuTra == mapt.MaPhieuTra).FirstOrDefault();
            if (pxlvp == null)
            {
                try
                {
                    PHIEUXULYVIPHAM pxl = new PHIEUXULYVIPHAM();
                    pxl.MaPhieuTra = mapt.MaPhieuTra;
                    pxl.NgayLap = ngaylap;
                    pxl.MaNhanVien = manv;
                    pxl.TongTienBoiThuong = tongtien;
                    pxl.TinhTrangXoa = false;
                    qltv.PHIEUXULYVIPHAMs.InsertOnSubmit(pxl);
                    qltv.SubmitChanges();
                    for (int i = 0; i < lstCTVP.Count(); i++)
                    {
                        PHIEUXULYVIPHAM pxl_fi = qltv.PHIEUXULYVIPHAMs.Where(p => p.MaPhieuTra == pxl.MaPhieuTra && p.TinhTrangXoa == false).OrderByDescending(s => s.MaXuLyViPham).First();
                        //CT_XULYVIPHAM ct = qltv.CT_XULYVIPHAMs.Where(c => c.MaXuLyViPham == pxl_fi.MaXuLyViPham).FirstOrDefault();
                        CT_XULYVIPHAM ctxl = new CT_XULYVIPHAM();
                        ctxl.MaXuLyViPham = pxl_fi.MaXuLyViPham;
                        ctxl.MaLoaiViPham = lstCTVP[i].MaLoaiViPham;
                        ctxl.TienBoiThuong = lstCTVP[i].TienBoiThuong;
                        ctxl.MaVach = lstCTVP[i].MaVach;
                        ctxl.TinhTrangXoa = false;
                        qltv.CT_XULYVIPHAMs.InsertOnSubmit(ctxl);
                        qltv.SubmitChanges();
                        
                    }
                    return true;


                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }

        public IQueryable layDGTuPMChuaTra(string mathetv)
        {
            var mdg = from dg in qltv.DOCGIAs
                      join pm in qltv.PHIEUMUONs on dg.MaTheThuVien equals pm.MaTheThuVien
                      join ctpm in qltv.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                      join mv in qltv.TAILIEUs on ctpm.MaVach equals mv.MaVach
                      join cd in qltv.CHUDEs on mv.MaChuDe equals cd.MaChuDe
                      join nn in qltv.NGONNGUs on mv.MaNgonNgu equals nn.MaNgonNgu
                      join loaitl in qltv.LOAITAILIEUs on mv.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                      join tg in qltv.TACGIAs on mv.MaTacGia equals tg.MaTacGia
                      join nxb in qltv.NHAXUATBANs on mv.MaNhaXuatBan equals nxb.MaNhaXuatBan
                      where pm.MaTheThuVien == mathetv && pm.TinhTrangTra == false
                      select new { pm.MaPhieuMuon, mv.MaVach,  mv.TenTaiLieu, cd.TenChuDe, mv.MaTap, nn.TenNgonNgu, nxb.TenNhaXuatBan, tg.TenTacGia, pm.NgayLap, mv.Gia,ctpm.MaChiTietPhieuMuon };
            return mdg;
        }
        public int ktraTonTaiDG(DOCGIA dg)
        {
            DOCGIA dgs = qltv.DOCGIAs.Where(d => d.MaTheThuVien == dg.MaTheThuVien).FirstOrDefault();
            if (dgs != null)
            {
                return 1;
            }
            else { return -1; }
        }
        public int ktraDGTrongPM(DOCGIA dg)
        {
            PHIEUMUON pms = qltv.PHIEUMUONs.Where(d => d.MaTheThuVien == dg.MaTheThuVien && d.TinhTrangTra == false).FirstOrDefault();
            if (pms != null)
            {
                return 1;
            }
            else { return -1; }
        }
        public DOCGIA layDGtuPM(DOCGIA dg, ref string tiencoc)
        {
            DOCGIA dgs = qltv.DOCGIAs.Where(d => d.MaTheThuVien == dg.MaTheThuVien).FirstOrDefault();
            PHIEUMUON pms = qltv.PHIEUMUONs.Where(m => m.MaTheThuVien == dg.MaTheThuVien).FirstOrDefault();
            dg = dgs;
            tiencoc = pms.PhiCoc.ToString();
            return dg;
        }

        public bool layTTtra(int mactpm)
        {
            CT_PHIEUMUON _ct = qltv.CT_PHIEUMUONs.Where(t => t.MaChiTietPhieuMuon == mactpm && t.TinhTrangTraCT == true).FirstOrDefault();
            if(_ct != null)
            {
                return true;
            }
            return false;
        }
    }
}
