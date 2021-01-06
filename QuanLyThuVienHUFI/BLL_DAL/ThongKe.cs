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
        public List<PhieuMuonTreHanModel> loadPhieuMuonTreHan()
        {
            var pms = (from pm in db.PHIEUMUONs
                       join nv in db.NHANVIENs on pm.MaNhanVien equals nv.MaNhanVien
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       group new { pm, nv, ctpm } by new { pm.TinhTrangTra, ctpm.MaPhieuMuon, ctpm.TinhTrangTraCT, pm.MaTheThuVien, nv.TenNhanVien, pm.NgayLap, pm.ThoiHanMuon } into m
                       where m.Key.TinhTrangTra == false && m.Key.TinhTrangTraCT == false && m.Key.ThoiHanMuon < DateTime.Now
                       select new PhieuMuonTreHanModel
                       {
                           MaPhieuMuon = m.Key.MaPhieuMuon.ToString(),
                           MaTheThuVien = m.Key.MaTheThuVien,
                           TenNhanVien = m.Key.TenNhanVien,
                           NgayLap = m.Key.NgayLap.ToString(),
                           ThoiHanMuon = m.Key.ThoiHanMuon.ToString(),
                           SoLuongTreHan = m.Count(c => c.ctpm.MaPhieuMuon != null).ToString()
                       }).ToList();
            return pms;
        }

        public List<PhieuMuonTreHanModel> loadDSPM()
        {
            var pms = (from pm in db.PHIEUMUONs
                       join nv in db.NHANVIENs on pm.MaNhanVien equals nv.MaNhanVien
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       group new { pm, nv, ctpm } by new { pm.TinhTrangTra, ctpm.MaPhieuMuon, ctpm.TinhTrangTraCT, pm.MaTheThuVien, nv.TenNhanVien, pm.NgayLap, pm.ThoiHanMuon } into m
                       select new PhieuMuonTreHanModel
                       {
                           MaPhieuMuon = m.Key.MaPhieuMuon.ToString(),
                           MaTheThuVien = m.Key.MaTheThuVien,
                           TenNhanVien = m.Key.TenNhanVien,
                           NgayLap = m.Key.NgayLap.ToString(),
                           ThoiHanMuon = m.Key.ThoiHanMuon.ToString(),
                           SoLuongTreHan = m.Count(c => c.ctpm.MaPhieuMuon != null).ToString()
                       }).ToList();
            return pms;
        }
        public List<PhieuMuonTreHanModel> loadPMDaTra()
        {
            var pms = (from pm in db.PHIEUMUONs
                       join nv in db.NHANVIENs on pm.MaNhanVien equals nv.MaNhanVien
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       group new { pm, nv, ctpm } by new { pm.TinhTrangTra, ctpm.MaPhieuMuon, ctpm.TinhTrangTraCT, pm.MaTheThuVien, nv.TenNhanVien, pm.NgayLap, pm.ThoiHanMuon } into m
                       where m.Key.TinhTrangTra == true
                       select new PhieuMuonTreHanModel
                       {
                           MaPhieuMuon = m.Key.MaPhieuMuon.ToString(),
                           MaTheThuVien = m.Key.MaTheThuVien,
                           TenNhanVien = m.Key.TenNhanVien,
                           NgayLap = m.Key.NgayLap.ToString(),
                           ThoiHanMuon = m.Key.ThoiHanMuon.ToString(),
                           SoLuongTreHan = m.Count(c => c.ctpm.MaPhieuMuon != null).ToString()
                       }).ToList();
            return pms;
        }


        public List<PhieuMuonTreHanModel> loadPMChuaTra()
        {
            var pms = (from pm in db.PHIEUMUONs
                       join nv in db.NHANVIENs on pm.MaNhanVien equals nv.MaNhanVien
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       group new { pm, nv, ctpm } by new { pm.TinhTrangTra, ctpm.MaPhieuMuon, ctpm.TinhTrangTraCT, pm.MaTheThuVien, nv.TenNhanVien, pm.NgayLap, pm.ThoiHanMuon } into m
                       where m.Key.TinhTrangTra == false
                       select new PhieuMuonTreHanModel
                       {
                           MaPhieuMuon = m.Key.MaPhieuMuon.ToString(),
                           MaTheThuVien = m.Key.MaTheThuVien,
                           TenNhanVien = m.Key.TenNhanVien,
                           NgayLap = m.Key.NgayLap.ToString(),
                           ThoiHanMuon = m.Key.ThoiHanMuon.ToString(),
                           SoLuongTreHan = m.Count(c => c.ctpm.MaPhieuMuon != null).ToString()
                       }).ToList();
            return pms;
        }

        public List<PhieuMuonTreHanModel> loadPMTheooNgay( DateTime dt1, DateTime dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join nv in db.NHANVIENs on pm.MaNhanVien equals nv.MaNhanVien
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       group new { pm, nv, ctpm } by new { pm.TinhTrangTra, ctpm.MaPhieuMuon, ctpm.TinhTrangTraCT, pm.MaTheThuVien, nv.TenNhanVien, pm.NgayLap, pm.ThoiHanMuon } into m
                       where m.Key.NgayLap >= dt1 && m.Key.NgayLap <= dt2
                       select new PhieuMuonTreHanModel
                       {
                           MaPhieuMuon = m.Key.MaPhieuMuon.ToString(),
                           MaTheThuVien = m.Key.MaTheThuVien,
                           TenNhanVien = m.Key.TenNhanVien,
                           NgayLap = m.Key.NgayLap.ToString(),
                           ThoiHanMuon = m.Key.ThoiHanMuon.ToString(),
                           SoLuongTreHan = m.Count(c => c.ctpm.MaPhieuMuon != null).ToString()
                       }).ToList();
            return pms;
        }

        public int tinhSoNgayTre(DateTime dt1)
        {
            DateTime now = DateTime.Now;
            TimeSpan rs = now - dt1;
            int days = Math.Abs(now.Subtract(dt1).Days);
            return days;
            
        }

        // độc giả
        public IQueryable loadDG()
        {
            var dgs = from dg in db.DOCGIAs
                      join n in db.NGANHs on dg.MaNganh equals n.MaNganh
                      join k in db.KHOAs on n.MaKhoa equals k.MaKhoa
                      join ldg in db.LOAIDOCGIAs on dg.MaLoaiDocGia equals ldg.MaLoaiDocGia
                      select new { dg.MaTheThuVien, dg.TenDocGia, ldg.TenLoaiDocGia, n.TenNganh, k.TenKhoa,
                          dg.CMND, dg.NgaySinh, dg.GioiTinh, dg.SoDienThoai, dg.DiaChi, dg.Email, dg.NgayLamThe,
                          dg.HanSuDungTheThuVien, dg.TinhTrangTheThuVien, dg.MatKhau };
            return dgs;
        }
        public bool ktraTheNHD(DOCGIA _dg)
        {
            DOCGIA dg = db.DOCGIAs.Where(d => d.MaTheThuVien == _dg.MaTheThuVien).FirstOrDefault();
            if (dg != null)
            {
                if (dg.TinhTrangTheThuVien == false)
                {
                    return true;
                }
            }
            return false;
        }
        public IQueryable loadDGDHD()
        {
            var dgs = from dg in db.DOCGIAs
                      join n in db.NGANHs on dg.MaNganh equals n.MaNganh
                      join k in db.KHOAs on n.MaKhoa equals k.MaKhoa
                      join ldg in db.LOAIDOCGIAs on dg.MaLoaiDocGia equals ldg.MaLoaiDocGia
                      where dg.TinhTrangTheThuVien == false
                      select new
                      {
                          dg.MaTheThuVien,
                          dg.TenDocGia,
                          ldg.TenLoaiDocGia,
                          n.TenNganh,
                          k.TenKhoa,
                          dg.CMND,
                          dg.NgaySinh,
                          dg.GioiTinh,
                          dg.SoDienThoai,
                          dg.DiaChi,
                          dg.Email,
                          dg.NgayLamThe,
                          dg.HanSuDungTheThuVien,
                          dg.TinhTrangTheThuVien,
                          dg.MatKhau
                      };
            return dgs;
        }
        public IQueryable loadDGNHD()
        {
            var dgs = from dg in db.DOCGIAs
                      join n in db.NGANHs on dg.MaNganh equals n.MaNganh
                      join k in db.KHOAs on n.MaKhoa equals k.MaKhoa
                      join ldg in db.LOAIDOCGIAs on dg.MaLoaiDocGia equals ldg.MaLoaiDocGia
                      where dg.TinhTrangTheThuVien == true
                      select new
                      {
                          dg.MaTheThuVien,
                          dg.TenDocGia,
                          ldg.TenLoaiDocGia,
                          n.TenNganh,
                          k.TenKhoa,
                          dg.CMND,
                          dg.NgaySinh,
                          dg.GioiTinh,
                          dg.SoDienThoai,
                          dg.DiaChi,
                          dg.Email,
                          dg.NgayLamThe,
                          dg.HanSuDungTheThuVien,
                          dg.TinhTrangTheThuVien,
                          dg.MatKhau
                      };
            return dgs;
        }

        // tài liệu
        public IQueryable loadTL()
        {
            var tls = from tl in db.TAILIEUs
                       join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                       join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                       join tg in db.TACGIAs on tl.MaTacGia equals tg.MaTacGia
                       join nxb in db.NHAXUATBANs on tl.MaNhaXuatBan equals nxb.MaNhaXuatBan
                       join vt in db.VITRIs on tl.MaViTri equals vt.MaViTri
                       join ctpm in db.CT_PHIEUMUONs on tl.MaVach equals ctpm.MaVach

                       group new { tl, ltl, cd, tg, nxb, vt, ctpm } by new
                       {
                           tl.MaTaiLieu,
                           tl.TenTaiLieu,
                           ltl.TenLoaiTaiLieu,
                           cd.TenChuDe,
                           tl.MaTap,
                           tl.SoTrang,
                           tl.Gia,
                           tl.NamXuatBan,
                           nxb.TenNhaXuatBan,
                           tg.TenTacGia,
                           tl.ThongTinTaiLieu,
                           vt.MaViTri,
                           ltl.MaLoaiTaiLieu,
                           cd.MaChuDe
                       } into solan
                       select new
                       {
                           MaTaiLieu = int.Parse(solan.Key.MaTaiLieu),
                           TenTaiLieu = solan.Key.TenTaiLieu.ToString(),
                           TenLoaiTaiLieu = solan.Key.TenLoaiTaiLieu.ToString(),
                           TenChuDe = solan.Key.TenChuDe.ToString(),
                           MaTap = solan.Key.MaTap.ToString(),
                           SoTrang = int.Parse(solan.Key.SoTrang.ToString()),
                           Gia = double.Parse(solan.Key.Gia.ToString()),
                           NamXuatBan = int.Parse(solan.Key.NamXuatBan.ToString()),
                           TenNhaXuatBan = solan.Key.TenNhaXuatBan.ToString(),
                           TenTacGia = solan.Key.TenTacGia.ToString(),
                           ThongTinTaiLieu = solan.Key.ThongTinTaiLieu.ToString(),
                           MaViTri = solan.Key.MaViTri.ToString(),
                           MaLoaiTaiLieu = int.Parse(solan.Key.MaLoaiTaiLieu.ToString()),
                           MaChuDe = int.Parse(solan.Key.MaChuDe.ToString()),
                           SoLanMuon = solan.Count(s => s.tl.MaTaiLieu != null)
                       };
            return tls;
        }

        public IQueryable tlChuaDuocMuon()
        {

            var tls = from tl in db.TAILIEUs
                      join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                      join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                      join tg in db.TACGIAs on tl.MaTacGia equals tg.MaTacGia
                      join nxb in db.NHAXUATBANs on tl.MaNhaXuatBan equals nxb.MaNhaXuatBan
                      join vt in db.VITRIs on tl.MaViTri equals vt.MaViTri
                      where !(from ct in db.CT_PHIEUMUONs select ct.MaVach).Contains(tl.MaVach)
                      select new
                      {
                          tl.MaVach,
                          tl.MaTaiLieu,
                          tl.TenTaiLieu,
                          ltl.TenLoaiTaiLieu,
                          cd.TenChuDe,
                          tl.MaTap,
                          tl.SoTrang,
                          tl.Gia,
                          tl.NamXuatBan,
                          nxb.TenNhaXuatBan,
                          tg.TenTacGia,
                          tl.ThongTinTaiLieu,
                          vt.MaViTri,
                          ltl.MaLoaiTaiLieu,
                          cd.MaChuDe
                      };
            return tls;
        }
        public IQueryable loaitlChuaDuocMuon()
        {

            var tls = from tl in db.TAILIEUs
                      join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                      join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                      join tg in db.TACGIAs on tl.MaTacGia equals tg.MaTacGia
                      join nxb in db.NHAXUATBANs on tl.MaNhaXuatBan equals nxb.MaNhaXuatBan
                      join vt in db.VITRIs on tl.MaViTri equals vt.MaViTri
                      where !(from ct in db.CT_PHIEUMUONs
                              join tl in db.TAILIEUs on ct.MaVach equals tl.MaVach
                              join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                              select ltl.MaLoaiTaiLieu).Contains(ltl.MaLoaiTaiLieu)
                      select new
                      {
                          tl.MaVach,
                          tl.MaTaiLieu,
                          tl.TenTaiLieu,
                          ltl.TenLoaiTaiLieu,
                          cd.TenChuDe,
                          tl.MaTap,
                          tl.SoTrang,
                          tl.Gia,
                          tl.NamXuatBan,
                          nxb.TenNhaXuatBan,
                          tg.TenTacGia,
                          tl.ThongTinTaiLieu,
                          vt.MaViTri,
                          ltl.MaLoaiTaiLieu,
                          cd.MaChuDe
                      };
            return tls;
        }
        public IQueryable cdChuaDuocMuon()
        {
            var tls = from tl in db.TAILIEUs
                      join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                      join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                      join tg in db.TACGIAs on tl.MaTacGia equals tg.MaTacGia
                      join nxb in db.NHAXUATBANs on tl.MaNhaXuatBan equals nxb.MaNhaXuatBan
                      join vt in db.VITRIs on tl.MaViTri equals vt.MaViTri
                      where !(from ct in db.CT_PHIEUMUONs
                              join tl in db.TAILIEUs on ct.MaVach equals tl.MaVach
                              join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                              select cd.MaChuDe).Contains(cd.MaChuDe)
                      select new
                      {
                          tl.MaVach,
                          tl.MaTaiLieu,
                          tl.TenTaiLieu,
                          ltl.TenLoaiTaiLieu,
                          cd.TenChuDe,
                          tl.MaTap,
                          tl.SoTrang,
                          tl.Gia,
                          tl.NamXuatBan,
                          nxb.TenNhaXuatBan,
                          tg.TenTacGia,
                          tl.ThongTinTaiLieu,
                          vt.MaViTri,
                          ltl.MaLoaiTaiLieu,
                          cd.MaChuDe
                      };
            return tls;
        }

        public IQueryable loadTangGiamTheoTL(int tg_value)
        {
            if (tg_value == 2)
            {
                    var tls = (from tl in db.TAILIEUs
                              join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                              join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                              join tg in db.TACGIAs on tl.MaTacGia equals tg.MaTacGia
                              join nxb in db.NHAXUATBANs on tl.MaNhaXuatBan equals nxb.MaNhaXuatBan
                              join vt in db.VITRIs on tl.MaViTri equals vt.MaViTri
                              join ctpm in db.CT_PHIEUMUONs on tl.MaVach equals ctpm.MaVach

                              group new { tl,ltl,cd,tg,nxb,vt,ctpm } by new
                              {
                                  tl.MaTaiLieu,
                                  tl.TenTaiLieu,
                                  ltl.TenLoaiTaiLieu,
                                  cd.TenChuDe,
                                  tl.MaTap,
                                  tl.SoTrang,
                                  tl.Gia,
                                  tl.NamXuatBan,
                                  nxb.TenNhaXuatBan,
                                  tg.TenTacGia,
                                  tl.ThongTinTaiLieu,
                                  vt.MaViTri,
                                  ltl.MaLoaiTaiLieu,
                                  cd.MaChuDe
                              } into solan
                    select new
                              {
                                  MaTaiLieu = int.Parse(solan.Key.MaTaiLieu),
                                  TenTaiLieu = solan.Key.TenTaiLieu.ToString(),
                                  TenLoaiTaiLieu = solan.Key.TenLoaiTaiLieu.ToString(),
                                    TenChuDe = solan.Key.TenChuDe.ToString(),
                                    MaTap = solan.Key.MaTap.ToString(),
                                    SoTrang = int.Parse(solan.Key.SoTrang.ToString()),
                                    Gia = double.Parse(solan.Key.Gia.ToString()),
                                    NamXuatBan = int.Parse(solan.Key.NamXuatBan.ToString()),
                                    TenNhaXuatBan = solan.Key.TenNhaXuatBan.ToString(),
                                    TenTacGia = solan.Key.TenTacGia.ToString(),
                                    ThongTinTaiLieu = solan.Key.ThongTinTaiLieu.ToString(),
                                    MaViTri = solan.Key.MaViTri.ToString(),
                                    MaLoaiTaiLieu = int.Parse(solan.Key.MaLoaiTaiLieu.ToString()),
                                    MaChuDe = int.Parse(solan.Key.MaChuDe.ToString()),
                                    SoLanMuon = solan.Count(s => s.tl.MaTaiLieu != null)
                    }).OrderByDescending(s=>s.SoLanMuon);
                    return tls;
            }
            else
            {
                    var tls = (from tl in db.TAILIEUs
                               join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                               join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                               join tg in db.TACGIAs on tl.MaTacGia equals tg.MaTacGia
                               join nxb in db.NHAXUATBANs on tl.MaNhaXuatBan equals nxb.MaNhaXuatBan
                               join vt in db.VITRIs on tl.MaViTri equals vt.MaViTri
                               join ctpm in db.CT_PHIEUMUONs on tl.MaVach equals ctpm.MaVach

                               group new { tl, ltl, cd, tg, nxb, vt, ctpm } by new
                               {
                                   tl.MaTaiLieu,
                                   tl.TenTaiLieu,
                                   ltl.TenLoaiTaiLieu,
                                   cd.TenChuDe,
                                   tl.MaTap,
                                   tl.SoTrang,
                                   tl.Gia,
                                   tl.NamXuatBan,
                                   nxb.TenNhaXuatBan,
                                   tg.TenTacGia,
                                   tl.ThongTinTaiLieu,
                                   vt.MaViTri,
                                   ltl.MaLoaiTaiLieu,
                                   cd.MaChuDe
                               } into solan
                               select new
                               {
                                   MaTaiLieu = int.Parse(solan.Key.MaTaiLieu),
                                   TenTaiLieu = solan.Key.TenTaiLieu.ToString(),
                                   TenLoaiTaiLieu = solan.Key.TenLoaiTaiLieu.ToString(),
                                   TenChuDe = solan.Key.TenChuDe.ToString(),
                                   MaTap = solan.Key.MaTap.ToString(),
                                   SoTrang = int.Parse(solan.Key.SoTrang.ToString()),
                                   Gia = double.Parse(solan.Key.Gia.ToString()),
                                   NamXuatBan = int.Parse(solan.Key.NamXuatBan.ToString()),
                                   TenNhaXuatBan = solan.Key.TenNhaXuatBan.ToString(),
                                   TenTacGia = solan.Key.TenTacGia.ToString(),
                                   ThongTinTaiLieu = solan.Key.ThongTinTaiLieu.ToString(),
                                   MaViTri = solan.Key.MaViTri.ToString(),
                                   MaLoaiTaiLieu = int.Parse(solan.Key.MaLoaiTaiLieu.ToString()),
                                   MaChuDe = int.Parse(solan.Key.MaChuDe.ToString()),
                                   SoLanMuon = solan.Count(s => s.tl.MaTaiLieu != null)
                               }).OrderBy(s => s.SoLanMuon);
                    return tls;
            }

        }

        ///Nhân viên
        public IQueryable loadLoaiNV()
        {
            var lnvs = from lnv in db.LOAINHANVIENs select lnv;
            return lnvs;
        }
        public IQueryable loadNV(int rdb)
        {
            if (rdb == 0)
            {
                var nvs = from nv in db.NHANVIENs
                          join lnv in db.LOAINHANVIENs on nv.MaLoaiNhanVien equals lnv.MaLoaiNhanVien
                          select new { nv.MaNhanVien, nv.TenNhanVien, lnv.TenLoaiNhanVien, nv.NgaySinh, nv.GioiTinh, nv.SoDienThoai, nv.CMND, nv.DiaChi, nv.NgayVaoLam, nv.TinhTrangTK, nv.MatKhau };
                return nvs;
            }
            else if (rdb == 1)
            {
                var nvs = from nv in db.NHANVIENs
                          join lnv in db.LOAINHANVIENs on nv.MaLoaiNhanVien equals lnv.MaLoaiNhanVien
                          where nv.TinhTrangTK == true
                          select new { nv.MaNhanVien, nv.TenNhanVien, lnv.TenLoaiNhanVien, nv.NgaySinh, nv.GioiTinh, nv.SoDienThoai, nv.CMND, nv.DiaChi, nv.NgayVaoLam, nv.TinhTrangTK, nv.MatKhau };
                return nvs;
            }
            else {
                var nvs = from nv in db.NHANVIENs
                          join lnv in db.LOAINHANVIENs on nv.MaLoaiNhanVien equals lnv.MaLoaiNhanVien
                          where nv.TinhTrangTK == false
                          select new { nv.MaNhanVien, nv.TenNhanVien, lnv.TenLoaiNhanVien, nv.NgaySinh, nv.GioiTinh, nv.SoDienThoai, nv.CMND, nv.DiaChi, nv.NgayVaoLam, nv.TinhTrangTK, nv.MatKhau };
                return nvs;
            }
        }
        public IQueryable loadNVTheoLoai(int maloainv)
        {
            var nvs = from nv in db.NHANVIENs
                      join lnv in db.LOAINHANVIENs on nv.MaLoaiNhanVien equals lnv.MaLoaiNhanVien
                      where lnv.MaLoaiNhanVien == maloainv
                      select new { nv.MaNhanVien, nv.TenNhanVien, lnv.TenLoaiNhanVien, nv.NgaySinh, nv.GioiTinh, nv.SoDienThoai, nv.CMND, nv.DiaChi, nv.NgayVaoLam, nv.TinhTrangTK, nv.MatKhau };
            return nvs;
        }


        //Phiếu trả
        public IQueryable loadPTTheoNgay(DateTime dt_start, DateTime dt_end)
        {
            var pts = from pt in db.PHIEUTRAs
                      join nv in db.NHANVIENs on pt.MaNhanVien equals nv.MaNhanVien
                      where pt.NgayLap >= dt_start && pt.NgayLap <= dt_end
                      select new { pt.MaPhieuTra, nv.TenNhanVien, pt.NgayLap, pt.SoLuongSachTra};
            return pts;
        }
        public IQueryable loadPT()
        {
            var pts = from pt in db.PHIEUTRAs
                      join nv in db.NHANVIENs on pt.MaNhanVien equals nv.MaNhanVien
                      select new { pt.MaPhieuTra, nv.TenNhanVien, pt.NgayLap, pt.SoLuongSachTra };
            return pts;
        }


        // Phiếu nhập
        public IQueryable loadDSPN()
        {
            var pns = from pn in db.PHIEUNHAPs
                      join ctpn in db.CT_PHIEUNHAPs on pn.MaPhieuNhap equals ctpn.MaPhieuNhap
                      join nv in db.NHANVIENs on pn.MaNhanVien equals nv.MaNhanVien
                      join ncc in db.NHACUNGCAPs on ctpn.MaNhaCungCap equals ncc.MaNhaCungCap
                      group new { ctpn, pn, nv,ncc } by new { nv.TenNhanVien,ncc.TenNhaCungCap, ctpn.MaPhieuNhap, pn.TongTien, pn.NgayNhap } into s
                      select new
                      {
                          MaPhieuNhap = s.Key.MaPhieuNhap,
                          TenNhanVien = s.Key.TenNhanVien,
                          TenNhaCungCap = s.Key.TenNhaCungCap,
                          NgayNhap = s.Key.NgayNhap,
                          SoLuongNhap = s.Count(c => c.ctpn.MaPhieuNhap != null),
                          TongTien = s.Key.TongTien
                      };
            return pns;
        }
        public IQueryable loadDSPNTheoNgay(DateTime dt_start, DateTime dt_end)
        {
            var pns = from pn in db.PHIEUNHAPs
                      join ctpn in db.CT_PHIEUNHAPs on pn.MaPhieuNhap equals ctpn.MaPhieuNhap
                      join nv in db.NHANVIENs on pn.MaNhanVien equals nv.MaNhanVien
                      join ncc in db.NHACUNGCAPs on ctpn.MaNhaCungCap equals ncc.MaNhaCungCap
                      group new { ctpn, pn, nv, ncc } by new { nv.TenNhanVien, ncc.TenNhaCungCap, ctpn.MaPhieuNhap, pn.TongTien, pn.NgayNhap } into s
                      where s.Key.NgayNhap >= dt_start && s.Key.NgayNhap <= dt_end
                      select new
                      {
                          MaPhieuNhap = s.Key.MaPhieuNhap,
                          TenNhanVien = s.Key.TenNhanVien,
                          TenNhaCungCap = s.Key.TenNhaCungCap,
                          NgayNhap = s.Key.NgayNhap,
                          SoLuongNhap = s.Count(c => c.ctpn.MaPhieuNhap != null),
                          TongTien = s.Key.TongTien
                      };
            return pns;
        }


        //Phiêu xử lý 
        public IQueryable loadDSPXL()
        {
            var pxls = from pxl in db.PHIEUXULYVIPHAMs
                       join pt in db.PHIEUTRAs on pxl.MaPhieuTra equals pt.MaPhieuTra
                       join nv in db.NHANVIENs on pxl.MaNhanVien equals nv.MaNhanVien
                       select new
                       {
                           pxl.MaXuLyViPham, pt.MaPhieuTra, nv.TenNhanVien, pxl.NgayLap, pxl.TongTienBoiThuong
                       };
            return pxls;
        }

        public IQueryable loadDSPXLTheoNgay(DateTime dt1, DateTime dt2)
        {
            var pxls = from pxl in db.PHIEUXULYVIPHAMs
                       join pt in db.PHIEUTRAs on pxl.MaPhieuTra equals pt.MaPhieuTra
                       join nv in db.NHANVIENs on pxl.MaNhanVien equals nv.MaNhanVien
                       where pxl.NgayLap >= dt1 && pxl.NgayLap <= dt2
                       select new
                       {
                           pxl.MaXuLyViPham,
                           pt.MaPhieuTra,
                           nv.TenNhanVien,
                           pxl.NgayLap,
                           pxl.TongTienBoiThuong
                       };
            return pxls;
        }
    }
}
