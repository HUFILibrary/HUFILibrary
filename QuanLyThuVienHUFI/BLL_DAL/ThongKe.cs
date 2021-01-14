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

        public List<PhieuMuonTreHanModel> loadPMTheooNgay(DateTime dt1, DateTime dt2)
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
                      group new { tl, ltl, cd, tg, nxb, vt } by new
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
                          MaChuDe = int.Parse(solan.Key.MaChuDe.ToString())
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
                      group new { tl, ltl, cd, tg, nxb, vt } by new
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
                      group new { tl, ltl, cd, tg, nxb, vt } by new
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
                           }).OrderByDescending(s => s.SoLanMuon);
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
                      select new { pt.MaPhieuTra, nv.TenNhanVien, pt.NgayLap, pt.SoLuongSachTra };
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
                      group new { ctpn, pn, nv, ncc } by new { nv.TenNhanVien, ncc.TenNhaCungCap, ctpn.MaPhieuNhap, pn.TongTien, pn.NgayNhap } into s
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



        // thống kê mới
        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

        // code TL theo 1 ngay
        public List<DSTK_TLPM> dsTlTrongNgay(string dt)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       where pm.TinhTrangXoa == false && pm.NgayLap == DateTime.Parse(dt)
                       group new { pm, ctpm, tl } by new { tl.TenTaiLieu, pm.NgayLap } into m
                       select new DSTK_TLPM
                       {
                           TenTaiLieu = m.Key.TenTaiLieu,
                           NgayLap = m.Key.NgayLap.ToString(),
                           SoLuongTL = m.Count(c => c.tl.MaTaiLieu != null).ToString()

                       }).ToList();
            return pms;
        }

        //code tài liệu trong 1 tháng
        public List<DSTK_TLPM> dsTlTrongThang(int thang, int nam) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Month == thang && pm.NgayLap.Value.Year == nam
                       group new { pm, ctpm, tl } by new { tl.TenTaiLieu, pm.NgayLap } into m
                       select new DSTK_TLPM
                       {
                           TenTaiLieu = m.Key.TenTaiLieu,
                           NgayLap = m.Key.NgayLap.ToString(),
                           SoLuongTL = m.Count(c => c.tl.MaTaiLieu != null).ToString()

                       }).OrderBy(c=>c.NgayLap).ToList();
            return pms;
        }

        //code tài liệu trong 1 năm
        public List<DSTK_TLPM> dsTlTrongNam(int nam) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Year == nam
                       group new { pm, ctpm, tl } by new { tl.TenTaiLieu, pm.NgayLap } into m
                       select new DSTK_TLPM
                       {
                           TenTaiLieu = m.Key.TenTaiLieu,
                           NgayLap = m.Key.NgayLap.ToString(),
                           SoLuongTL = m.Count(c => c.tl.MaTaiLieu != null).ToString()

                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }



        //code loại tài liệu trong 1 ngày
        public List<DSTK_LTL> dsLoaiTLTrongNgay(string dt) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                       where pm.TinhTrangXoa == false && pm.NgayLap == DateTime.Parse(dt)
                       group new { pm,ltl } by new {ltl.TenLoaiTaiLieu, pm.NgayLap } into m
                       select new DSTK_LTL
                       {
                           TenLoaiTaiLieu = m.Key.TenLoaiTaiLieu,
                           NgayLap = m.Key.NgayLap.ToString(),
                           SoLuongLTL = m.Count(c => c.ltl.TenLoaiTaiLieu != null).ToString()

                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }

        //code loại tài liệu trong 1 tháng
        public List<DSTK_LTL> dsLoaiTLTrongThang(int thang, int nam) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Month == thang && pm.NgayLap.Value.Year == nam
                       group new { pm, ltl } by new { ltl.TenLoaiTaiLieu, pm.NgayLap } into m
                       select new DSTK_LTL
                       {
                           TenLoaiTaiLieu = m.Key.TenLoaiTaiLieu,
                           NgayLap = m.Key.NgayLap.ToString(),
                           SoLuongLTL = m.Count(c => c.ltl.TenLoaiTaiLieu != null).ToString()

                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }

        //code loại tài liệu trong 1 năm
        public List<DSTK_LTL> dsLoaiTLTrongNam(int nam) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Year == nam
                       group new { pm, ltl } by new { ltl.TenLoaiTaiLieu, pm.NgayLap } into m
                       select new DSTK_LTL
                       {
                           TenLoaiTaiLieu = m.Key.TenLoaiTaiLieu,
                           NgayLap = m.Key.NgayLap.ToString(),
                           SoLuongLTL = m.Count(c => c.ltl.TenLoaiTaiLieu != null).ToString()

                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }


        //code chủ đề trong 1 ngày
        public List<DSTK_CD> dsChuDeTrongNgay(string dt) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                       where pm.TinhTrangXoa == false && pm.NgayLap == DateTime.Parse(dt)
                       group new { pm, cd } by new { cd.TenChuDe, pm.NgayLap } into m
                       select new DSTK_CD
                       {
                           TenChuDe = m.Key.TenChuDe,
                           NgayLap = m.Key.NgayLap.ToString(),
                           SoLuongCD = m.Count(c => c.cd.TenChuDe != null).ToString()

                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }

        //code chủ đề trong 1 tháng
        public List<DSTK_CD> dsChuDeTrongThang(int thang, int nam) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Month == thang && pm.NgayLap.Value.Year == nam
                       group new { pm, cd } by new { cd.TenChuDe, pm.NgayLap } into m
                       select new DSTK_CD
                       {
                           TenChuDe = m.Key.TenChuDe,
                           NgayLap = m.Key.NgayLap.ToString(),
                           SoLuongCD = m.Count(c => c.cd.TenChuDe != null).ToString()

                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }

        //code chủ đề trong 1 năm
        public List<DSTK_CD> dsChuDeTrongNam(int nam) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Year == nam
                       group new { pm, cd } by new { cd.TenChuDe, pm.NgayLap } into m
                       select new DSTK_CD
                       {
                           TenChuDe = m.Key.TenChuDe,
                           NgayLap = m.Key.NgayLap.ToString(),
                           SoLuongCD = m.Count(c => c.cd.TenChuDe != null).ToString()

                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }


        //code Khoa trong 1 ngày
        public List<DSTK_Khoa> dsKhoaTrongNgay(string dt) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join dg in db.DOCGIAs on pm.MaTheThuVien equals dg.MaTheThuVien
                       join n in db.NGANHs on dg.MaNganh equals n.MaNganh
                       join k in db.KHOAs on n.MaKhoa equals k.MaKhoa
                       where pm.TinhTrangXoa == false && pm.NgayLap == DateTime.Parse(dt)
                       group new { pm, k } by new { k.TenKhoa, pm.NgayLap } into m
                       select new DSTK_Khoa
                       {
                           TenKhoa = m.Key.TenKhoa,
                           NgayLap = m.Key.NgayLap.ToString(),
                           SoLuongKhoa = m.Count(c => c.k.TenKhoa != null).ToString()

                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }

        //code Khoa trong 1 tháng
        public List<DSTK_Khoa> dsKhoaTrongThang(int thang, int nam) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                      join dg in db.DOCGIAs on pm.MaTheThuVien equals dg.MaTheThuVien
                      join n in db.NGANHs on dg.MaNganh equals n.MaNganh
                      join k in db.KHOAs on n.MaKhoa equals k.MaKhoa
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Month == thang && pm.NgayLap.Value.Year == nam
                       group new { pm, k } by new { k.TenKhoa, pm.NgayLap } into m
                       select new DSTK_Khoa
                       {
                           TenKhoa = m.Key.TenKhoa,
                           NgayLap = m.Key.NgayLap.ToString(),
                           SoLuongKhoa = m.Count(c => c.k.TenKhoa != null).ToString()

                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }

        //code Khoa trong 1 năm
        public List<DSTK_Khoa> dsKhoaTrongNam(int nam) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join dg in db.DOCGIAs on pm.MaTheThuVien equals dg.MaTheThuVien
                       join n in db.NGANHs on dg.MaNganh equals n.MaNganh
                       join k in db.KHOAs on n.MaKhoa equals k.MaKhoa
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Year == nam
                       group new { pm, k } by new { k.TenKhoa, pm.NgayLap } into m
                       select new DSTK_Khoa
                       {
                           TenKhoa = m.Key.TenKhoa,
                           NgayLap = m.Key.NgayLap.ToString(),
                           SoLuongKhoa = m.Count(c => c.k.TenKhoa != null).ToString()

                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }


        //code phi coc trong 1 ngày
        public List<DSTK_PhiCoc> dsPhiCocTrongNgay(string dt) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       where pm.TinhTrangXoa == false && pm.NgayLap == DateTime.Parse(dt)
                       group new { pm } by new { pm.NgayLap } into m
                       select new DSTK_PhiCoc
                       {
                           NgayLap = m.Key.NgayLap.ToString(),
                           TongTien = double.Parse(m.Sum(c => c.pm.PhiCoc).ToString())

                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }

        //code phi coc trong 1 tháng
        public List<DSTK_PhiCoc> dsPhiCocTrongThang(int thang, int nam) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Month == thang && pm.NgayLap.Value.Year == nam
                       group new { pm } by new { pm.NgayLap } into m
                       select new DSTK_PhiCoc
                       {
                           NgayLap = m.Key.NgayLap.ToString(),
                           TongTien = double.Parse(m.Sum(c => c.pm.PhiCoc).ToString())

                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }

        //code phi coc trong 1 năm
        public List<DSTK_PhiCoc> dsPhiCocTrongNam(int nam) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Year == nam
                       group new { pm } by new { pm.NgayLap } into m
                       select new DSTK_PhiCoc
                       {
                           NgayLap = m.Key.NgayLap.ToString(),
                           TongTien = double.Parse(m.Sum(c => c.pm.PhiCoc).ToString())

                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }


        // Tl theo ngay
        public List<DSTK_TLTheoKhoang> dsTimeTheoKhoang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { pm} by new {pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           NgayLap = m.Key.NgayLap.ToString()
                       }).ToList();
            return pms;
        }
        public List<DSTK_TLTheoKhoang> dsTenTheoKhoang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new {tl } by new { tl.TenTaiLieu} into m
                       select new DSTK_TLTheoKhoang
                       {
                           Ten = m.Key.TenTaiLieu
                       }).ToList();
            return pms;
        }
        public DSTK_TLTheoKhoang dsSLTheoKhoang(string ten, string ngayloc )
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       where pm.TinhTrangXoa == false &&  tl.TenTaiLieu == ten && pm.NgayLap == DateTime.Parse(ngayloc)
                       group new { tl, pm } by new { tl.TenTaiLieu, pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           SoLuong = m.Count(c => c.tl.TenTaiLieu != null && c.pm.NgayLap != null).ToString()
                       }).FirstOrDefault();
            return pms;
        }


        //Loai TL theo ngay
        public List<DSTK_TLTheoKhoang> dsLTLTimeTheoKhoang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { pm } by new { pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           NgayLap = m.Key.NgayLap.ToString()
                       }).ToList();
            return pms;
        }
        public List<DSTK_TLTheoKhoang> dsLTLTenTheoKhoang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { ltl } by new { ltl.TenLoaiTaiLieu } into m
                       select new DSTK_TLTheoKhoang
                       {
                           Ten = m.Key.TenLoaiTaiLieu
                       }).ToList();
            return pms;
        }
        public DSTK_TLTheoKhoang dsLTLSLTheoKhoang(string ten, string ngayloc)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                       where pm.TinhTrangXoa == false && ltl.TenLoaiTaiLieu == ten && pm.NgayLap == DateTime.Parse(ngayloc)
                       group new { tl, pm,ltl } by new { ltl.TenLoaiTaiLieu, pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           SoLuong = m.Count(c => c.ltl.TenLoaiTaiLieu != null && c.pm.NgayLap != null).ToString()
                       }).FirstOrDefault();
            return pms;
        }


        //chu de theo ngay

        public List<DSTK_TLTheoKhoang> dsCDTimeTheoKhoang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { pm } by new { pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           NgayLap = m.Key.NgayLap.ToString()
                       }).ToList();
            return pms;
        }
        public List<DSTK_TLTheoKhoang> dsCDTenTheoKhoang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { cd } by new { cd.TenChuDe} into m
                       select new DSTK_TLTheoKhoang
                       {
                           Ten = m.Key.TenChuDe
                       }).ToList();
            return pms;
        }
        public DSTK_TLTheoKhoang dsCDSLTheoKhoang(string ten, string ngayloc)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                       where pm.TinhTrangXoa == false && cd.TenChuDe == ten && pm.NgayLap == DateTime.Parse(ngayloc)
                       group new { tl, pm, cd } by new { cd.TenChuDe, pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           SoLuong = m.Count(c => c.cd.TenChuDe != null && c.pm.NgayLap != null).ToString()
                       }).FirstOrDefault();
            return pms;
        }


        //khoa theo ngay
        public List<DSTK_TLTheoKhoang> dsKhoaTimeTheoKhoang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { pm } by new { pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           NgayLap = m.Key.NgayLap.ToString()
                       }).ToList();
            return pms;
        }
        public List<DSTK_TLTheoKhoang> dsKhoaTenTheoKhoang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                         join dg in db.DOCGIAs on pm.MaTheThuVien equals dg.MaTheThuVien
                       join n in db.NGANHs on dg.MaNganh equals n.MaNganh
                       join k in db.KHOAs on n.MaKhoa equals k.MaKhoa
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { k } by new { k.TenKhoa } into m
                       select new DSTK_TLTheoKhoang
                       {
                           Ten = m.Key.TenKhoa
                       }).ToList();
            return pms;
        }
        public DSTK_TLTheoKhoang dsKhoaSLTheoKhoang(string ten, string ngayloc)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join dg in db.DOCGIAs on pm.MaTheThuVien equals dg.MaTheThuVien
                       join n in db.NGANHs on dg.MaNganh equals n.MaNganh
                       join k in db.KHOAs on n.MaKhoa equals k.MaKhoa
                       where pm.TinhTrangXoa == false && k.TenKhoa == ten && pm.NgayLap == DateTime.Parse(ngayloc)
                       group new { pm, k } by new { k.TenKhoa, pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           SoLuong = m.Count(c => c.k.TenKhoa != null && c.pm.NgayLap != null).ToString()
                       }).FirstOrDefault();
            return pms;
        }


        //PhiCoc theo ngay
        public List<DSTK_TLTheoKhoang> dsPhiCocKhoangNgay(string dt1, string dt2) //input ngay
        {
            var pms = (from pm in db.PHIEUMUONs
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { pm } by new { pm.NgayLap, pm.PhiCoc } into m
                       select new DSTK_TLTheoKhoang
                       {
                           NgayLap = m.Key.NgayLap.ToString(),
                           PhiCoc = double.Parse(m.Sum(c => c.pm.PhiCoc).ToString())
                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }




        // Ngaylap theo thang
        public List<DSTK_TLTheoKhoang> dsNgayLapTheoKhoangThang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { pm } by new { pm.NgayLap.Value.Month, pm.NgayLap.Value.Year} into m
                       select new DSTK_TLTheoKhoang
                       {
                           NgayLap = m.Key.Month.ToString(),
                           NamLap = m.Key.Year.ToString()
                           
                       }).OrderByDescending(c=>c.NamLap).ToList();
            return pms;
        }
        ////SL theo thang
        public DSTK_TLTheoKhoang dsTLSLTheoKhoangThang(string ten, int thloc, int nloc)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       where pm.TinhTrangXoa == false && tl.TenTaiLieu == ten && pm.NgayLap.Value.Month == thloc && pm.NgayLap.Value.Year == nloc
                       group new { tl, pm } by new { tl.TenTaiLieu, pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           SoLuong = m.Count(c => c.tl.TenTaiLieu != null && c.pm.NgayLap != null).ToString()
                       }).FirstOrDefault();
            return pms;
        }

        //// Ten Tl theo thang
        public List<DSTK_TLTheoKhoang> dsTLTenkhoangThang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { tl } by new { tl.TenTaiLieu } into m
                       select new DSTK_TLTheoKhoang
                       {
                           Ten = m.Key.TenTaiLieu
                       }).ToList();
            return pms;
        }

        ////SL LTL  theo thang
        public DSTK_TLTheoKhoang dsLTLSLTheoKhoangThang(string ten, int thloc, int nloc)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                       where pm.TinhTrangXoa == false && ltl.TenLoaiTaiLieu == ten && pm.NgayLap.Value.Month == thloc && pm.NgayLap.Value.Year == nloc
                       group new { tl, pm, ltl } by new { ltl.TenLoaiTaiLieu, pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           SoLuong = m.Count(c => c.ltl.TenLoaiTaiLieu != null && c.pm.NgayLap != null).ToString()
                       }).FirstOrDefault();
            return pms;
        }

        //// Ten LTl theo thang
        public List<DSTK_TLTheoKhoang> dsLTLTenkhoangThang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { ltl } by new { ltl.TenLoaiTaiLieu } into m
                       select new DSTK_TLTheoKhoang
                       {
                           Ten = m.Key.TenLoaiTaiLieu
                       }).ToList();
            return pms;
        }


        ////SL Chu De  theo thang
        public DSTK_TLTheoKhoang dsCDSLTheoKhoangThang(string ten, int thloc, int nloc)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                       where pm.TinhTrangXoa == false && cd.TenChuDe == ten && pm.NgayLap.Value.Month == thloc && pm.NgayLap.Value.Year == nloc
                       group new { tl, pm, cd } by new { cd.TenChuDe, pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           SoLuong = m.Count(c => c.cd.TenChuDe != null && c.pm.NgayLap != null).ToString()
                       }).FirstOrDefault();
            return pms;
        }

        //// Ten ChuDE theo thang
        public List<DSTK_TLTheoKhoang> dsCDTenkhoangThang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { cd } by new { cd.TenChuDe } into m
                       select new DSTK_TLTheoKhoang
                       {
                           Ten = m.Key.TenChuDe
                       }).ToList();
            return pms;
        }



        ////SL KHoa  theo thang
        public DSTK_TLTheoKhoang dsKhoaSLTheoKhoangThang(string ten, int thloc, int nloc)
        {
            var pms = (from pm in db.PHIEUMUONs
                      join dg in db.DOCGIAs on pm.MaTheThuVien equals dg.MaTheThuVien
                      join n in db.NGANHs on dg.MaNganh equals n.MaNganh
                      join k in db.KHOAs on n.MaKhoa equals k.MaKhoa
                       where pm.TinhTrangXoa == false && k.TenKhoa == ten && pm.NgayLap.Value.Month == thloc && pm.NgayLap.Value.Year == nloc
                       group new {  pm, k  } by new { k.TenKhoa, pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           SoLuong = m.Count(c => c.k.TenKhoa != null && c.pm.NgayLap != null).ToString()
                       }).FirstOrDefault();
            return pms;
        }

        //// Ten khoa theo thang
        public List<DSTK_TLTheoKhoang> dsKhoaTenkhoangThang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join dg in db.DOCGIAs on pm.MaTheThuVien equals dg.MaTheThuVien
                       join n in db.NGANHs on dg.MaNganh equals n.MaNganh
                       join k in db.KHOAs on n.MaKhoa equals k.MaKhoa
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { pm, k } by new { k.TenKhoa} into m
                       select new DSTK_TLTheoKhoang
                       {
                           Ten = m.Key.TenKhoa
                       }).ToList();
            return pms;
        }



        //SL Phi coc  theo thang
        public List<DSTK_TLTheoKhoang> dsPhiCocSLTheoKhoangThang(string dt1, string dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       where pm.TinhTrangXoa == false && pm.NgayLap >= DateTime.Parse(dt1) && pm.NgayLap <= DateTime.Parse(dt2)
                       group new { pm } by new { pm.NgayLap.Value.Month, pm.NgayLap.Value.Year } into m
                       select new DSTK_TLTheoKhoang
                       {
                           NgayLap = m.Key.Month.ToString(),
                           NamLap = m.Key.Year.ToString(),
                           PhiCoc = double.Parse(m.Sum(c => c.pm.PhiCoc).ToString())
                       }).OrderBy(c => c.NamLap).ToList();
            return pms;
        }



        //Ngay lap theo nam
        public List<DSTK_TLTheoKhoang> dsNgayLapTheoKhoangNam(int nbd, int nkt)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Year >= nbd && pm.NgayLap.Value.Year <= nkt
                       group new { pm } by new {pm.NgayLap.Value.Year } into m
                       select new DSTK_TLTheoKhoang
                       {
                           NgayLap = m.Key.Year.ToString(),
                       }).OrderByDescending(c => c.NgayLap).ToList();
            return pms;
        }


        ////SL TL theo nam
        public DSTK_TLTheoKhoang dsTLSLTheoKhoangNam(string ten, int nloc)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       where pm.TinhTrangXoa == false && tl.TenTaiLieu == ten  && pm.NgayLap.Value.Year == nloc
                       group new { tl, pm } by new { tl.TenTaiLieu, pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           SoLuong = m.Count(c => c.tl.TenTaiLieu != null && c.pm.NgayLap != null).ToString()
                       }).FirstOrDefault();
            return pms;
        }
        //// Ten Tl theo nam
        public List<DSTK_TLTheoKhoang> dsTLTenkhoangNam(int dt1, int dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Year >= dt1 && pm.NgayLap.Value.Year <= dt2
                       group new { tl } by new { tl.TenTaiLieu } into m
                       select new DSTK_TLTheoKhoang
                       {
                           Ten = m.Key.TenTaiLieu
                       }).ToList();
            return pms;
        }


        ////SL LTL theo nam
        public DSTK_TLTheoKhoang dsLTLSLTheoKhoangNam(string ten, int nloc)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                       where pm.TinhTrangXoa == false && ltl.TenLoaiTaiLieu == ten && pm.NgayLap.Value.Year == nloc
                       group new { ltl, pm } by new { ltl.TenLoaiTaiLieu, pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           SoLuong = m.Count(c => c.ltl.TenLoaiTaiLieu != null && c.pm.NgayLap != null).ToString()
                       }).FirstOrDefault();
            return pms;
        }
        //// Ten LTl theo nam
        public List<DSTK_TLTheoKhoang> dsLTLTenkhoangNam(int dt1, int dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Year >= dt1 && pm.NgayLap.Value.Year <= dt2
                       group new { ltl } by new { ltl.TenLoaiTaiLieu } into m
                       select new DSTK_TLTheoKhoang
                       {
                           Ten = m.Key.TenLoaiTaiLieu
                       }).ToList();
            return pms;
        }


        ////SL CD theo nam
        public DSTK_TLTheoKhoang dsCDSLTheoKhoangNam(string ten, int nloc)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                       where pm.TinhTrangXoa == false && cd.TenChuDe == ten && pm.NgayLap.Value.Year == nloc
                       group new { cd, pm } by new { cd.TenChuDe, pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           SoLuong = m.Count(c => c.cd.TenChuDe != null && c.pm.NgayLap != null).ToString()
                       }).FirstOrDefault();
            return pms;
        }
        //// Ten CD theo nam
        public List<DSTK_TLTheoKhoang> dsCDTenkhoangNam(int dt1, int dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                       join tl in db.TAILIEUs on ctpm.MaVach equals tl.MaVach
                       join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Year >= dt1 && pm.NgayLap.Value.Year <= dt2
                       group new { cd} by new { cd.TenChuDe } into m
                       select new DSTK_TLTheoKhoang
                       {
                           Ten = m.Key.TenChuDe
                       }).ToList();
            return pms;
        }


        ////SL Khoa theo nam
        public DSTK_TLTheoKhoang dsKhoaSLTheoKhoangNam(string ten, int nloc)
        {
            var pms = (from pm in db.PHIEUMUONs
                        join dg in db.DOCGIAs on pm.MaTheThuVien equals dg.MaTheThuVien
                        join n in db.NGANHs on dg.MaNganh equals n.MaNganh
                        join k in db.KHOAs on n.MaKhoa equals k.MaKhoa
                       where pm.TinhTrangXoa == false && k.TenKhoa == ten && pm.NgayLap.Value.Year == nloc
                       group new { k, pm } by new {k.TenKhoa, pm.NgayLap } into m
                       select new DSTK_TLTheoKhoang
                       {
                           SoLuong = m.Count(c => c.k.TenKhoa != null && c.pm.NgayLap != null).ToString()
                       }).FirstOrDefault();
            return pms;
        }
        //// Ten Khoa theo nam
        public List<DSTK_TLTheoKhoang> dsKhoaTenkhoangNam(int dt1, int dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       join dg in db.DOCGIAs on pm.MaTheThuVien equals dg.MaTheThuVien
                       join n in db.NGANHs on dg.MaNganh equals n.MaNganh
                       join k in db.KHOAs on n.MaKhoa equals k.MaKhoa
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Year >= dt1 && pm.NgayLap.Value.Year <= dt2
                       group new { k} by new { k.TenKhoa } into m
                       select new DSTK_TLTheoKhoang
                       {
                           Ten = m.Key.TenKhoa
                       }).ToList();
            return pms;
        }

        //phi coc theo nam
        public List<DSTK_TLTheoKhoang> dsPhiCocSLTheoKhoangNam(int dt1, int dt2)
        {
            var pms = (from pm in db.PHIEUMUONs
                       where pm.TinhTrangXoa == false && pm.NgayLap.Value.Year >= dt1 && pm.NgayLap.Value.Year <= dt2
                       group new { pm } by new { pm.NgayLap.Value.Year } into m
                       select new DSTK_TLTheoKhoang
                       {
                           NgayLap = m.Key.Year.ToString(),
                           PhiCoc = double.Parse(m.Sum(c => c.pm.PhiCoc).ToString())
                       }).OrderBy(c => c.NgayLap).ToList();
            return pms;
        }
    }



}
