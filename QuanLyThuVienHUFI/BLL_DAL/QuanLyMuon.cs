using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyMuon
    {
        DB_QLTVDataContext db = new DB_QLTVDataContext();
        public DOCGIA timKiemDocGiaByMaThe(string mathe)
        {
            DOCGIA rs = new DOCGIA();
            DOCGIA item = db.DOCGIAs.Where(a => a.MaTheThuVien == mathe).FirstOrDefault();
            if (item != null)
            {
                return item;
            }
            else
            {
                return null;
            }
        }

        public void returnThongtinmuon(string mathethuvien, ref int sotailieumuon, ref double sotiencoc)
        {
            int soluong = 0;
            double sotiendc = 0;
            var phieumuon = from pm in db.PHIEUMUONs
                            where (pm.TinhTrangTra == false) && (pm.MaTheThuVien == mathethuvien)
                            select pm;
            if (phieumuon != null)
            {
                foreach (PHIEUMUON pm in phieumuon)
                {
                    var chitietphieumuon = from ctpm in db.CT_PHIEUMUONs
                                           where (ctpm.MaPhieuMuon == pm.MaPhieuMuon) && (ctpm.TinhTrangTraCT == false)
                                           select ctpm;
                    if (chitietphieumuon != null)
                    {
                        soluong += chitietphieumuon.Count();
                    }
                    sotiendc += double.Parse(pm.PhiCoc.ToString());
                }
            }
            sotailieumuon = soluong;
            sotiencoc = sotiendc;
        }
        public IQueryable getDSTLDangMuon(string mathethuvien)
        {
            var phieumuon = from pm in db.PHIEUMUONs
                            join ctpm in db.CT_PHIEUMUONs on pm.MaPhieuMuon equals ctpm.MaPhieuMuon
                            join tls in db.TAILIEUs on ctpm.MaVach equals tls.MaVach
                            join cd in db.CHUDEs on tls.MaChuDe equals cd.MaChuDe
                            join nn in db.NGONNGUs on tls.MaNgonNgu equals nn.MaNgonNgu
                            join loaitl in db.LOAITAILIEUs on tls.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                            join tg in db.TACGIAs on tls.MaTacGia equals tg.MaTacGia
                            join nxb in db.NHAXUATBANs on tls.MaNhaXuatBan equals nxb.MaNhaXuatBan
                            join vt in db.VITRIs on tls.MaViTri equals vt.MaViTri
                            where (pm.TinhTrangTra == false) && (pm.MaTheThuVien == mathethuvien) && (ctpm.TinhTrangTraCT == false)
                            select new { tls.MaVach, tls.TenTaiLieu, cd.TenChuDe, nn.TenNgonNgu, nxb.TenNhaXuatBan };
            return phieumuon;
        }

        public IQueryable loadDgvTaiLieu()
        {
            List<string> dsPM = db.CT_PHIEUMUONs.Where(a => a.TinhTrangTraCT == false).Select(b=>b.MaVach).ToList();
            var dsTL = from tls in db.TAILIEUs
                       join cd in db.CHUDEs on tls.MaChuDe equals cd.MaChuDe
                       join nn in db.NGONNGUs on tls.MaNgonNgu equals nn.MaNgonNgu
                       join loaitl in db.LOAITAILIEUs on tls.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                       join tg in db.TACGIAs on tls.MaTacGia equals tg.MaTacGia
                       join nxb in db.NHAXUATBANs on tls.MaNhaXuatBan equals nxb.MaNhaXuatBan
                       join vt in db.VITRIs on tls.MaViTri equals vt.MaViTri
                       where (tls.TinhTrangXoa == false) && (!dsPM.Contains(tls.MaVach))
                       select new { tls.MaVach, tls.TenTaiLieu, cd.TenChuDe, tls.MaTap, nn.TenNgonNgu, nxb.TenNhaXuatBan, tg.TenTacGia, tls.MaViTri };
            return dsTL;

        }
        public IQueryable loadDgvTaiLieuByMaVach(string mavach)
        {
            if (string.IsNullOrEmpty(mavach))
            {
                var dsTL = from tls in db.TAILIEUs
                           join cd in db.CHUDEs on tls.MaChuDe equals cd.MaChuDe
                           join nn in db.NGONNGUs on tls.MaNgonNgu equals nn.MaNgonNgu
                           join loaitl in db.LOAITAILIEUs on tls.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                           join tg in db.TACGIAs on tls.MaTacGia equals tg.MaTacGia
                           join nxb in db.NHAXUATBANs on tls.MaNhaXuatBan equals nxb.MaNhaXuatBan
                           join vt in db.VITRIs on tls.MaViTri equals vt.MaViTri
                           where (tls.TinhTrangXoa == false)
                           select new { tls.MaVach, tls.TenTaiLieu, cd.TenChuDe, tls.MaTap, nn.TenNgonNgu, nxb.TenNhaXuatBan, tg.TenTacGia, tls.MaViTri };
                return dsTL;
            }
            else
            {
                var dsTL = from tls in db.TAILIEUs
                           join cd in db.CHUDEs on tls.MaChuDe equals cd.MaChuDe
                           join nn in db.NGONNGUs on tls.MaNgonNgu equals nn.MaNgonNgu
                           join loaitl in db.LOAITAILIEUs on tls.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                           join tg in db.TACGIAs on tls.MaTacGia equals tg.MaTacGia
                           join nxb in db.NHAXUATBANs on tls.MaNhaXuatBan equals nxb.MaNhaXuatBan
                           join vt in db.VITRIs on tls.MaViTri equals vt.MaViTri
                           where (tls.TinhTrangXoa == false) && (tls.MaVach == mavach)
                           select new { tls.MaVach, tls.TenTaiLieu, cd.TenChuDe, tls.MaTap, nn.TenNgonNgu, nxb.TenNhaXuatBan, tg.TenTacGia, tls.MaViTri };
                return dsTL;
            }

        }

        public IQueryable chonTaiLieuMuon(string mavach)
        {
            var dsTL = from tls in db.TAILIEUs
                       join cd in db.CHUDEs on tls.MaChuDe equals cd.MaChuDe
                       join nn in db.NGONNGUs on tls.MaNgonNgu equals nn.MaNgonNgu
                       join loaitl in db.LOAITAILIEUs on tls.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                       join tg in db.TACGIAs on tls.MaTacGia equals tg.MaTacGia
                       join nxb in db.NHAXUATBANs on tls.MaNhaXuatBan equals nxb.MaNhaXuatBan
                       join vt in db.VITRIs on tls.MaViTri equals vt.MaViTri
                       where (tls.TinhTrangXoa == false) && (tls.MaVach == mavach)
                       select new { tls.MaVach, tls.TenTaiLieu, cd.TenChuDe, tls.MaTap, nn.TenNgonNgu, nxb.TenNhaXuatBan, tg.TenTacGia, tls.MaViTri };
            return dsTL;
        }

        public TAILIEU chonTaiLieu(string mavach, List<TAILIEU> dsTaiLieuChon)
        {
            foreach (TAILIEU item in dsTaiLieuChon)
            {
                if (item.MaVach == mavach)
                {
                    return null;
                }
            }
            TAILIEU tl = db.TAILIEUs.Where(a => a.MaVach == mavach).FirstOrDefault();
            if (tl != null)
            {
                return tl;
            }
            else
            {
                return null;
            }
        }
        public TAILIEU huyChonTaiLieu(string mavach, List<TAILIEU> dsTaiLieuChon)
        {
            TAILIEU tl = db.TAILIEUs.Where(a => a.MaVach == mavach).FirstOrDefault();
            if(tl != null)
            {
                return tl;
            }
            return null;
        }
        public IQueryable dsTaiLieuChon(List<TAILIEU> lstTaiLieuChon)
        {
            string matailieu = "";
            int i = 0;
            foreach (TAILIEU item in lstTaiLieuChon)
            {
                if (lstTaiLieuChon.Count() == 1)
                {
                    matailieu += "" + item.MaVach;
                }
                else
                {
                    if (i == 0)
                    {
                        matailieu += "" + item.MaVach + ",";
                    }
                    else
                    {
                        matailieu += "," + item.MaVach;
                    }
                }

                i++;
            }
            string[] arrTaiLieu = matailieu.Split(',');
            //var dsTaiLieuChon = db.TAILIEUs.Where(a => arrTaiLieu.Contains(a.MaVach));
            var dsTaiLieuChon = from tls in db.TAILIEUs
                                join cd in db.CHUDEs on tls.MaChuDe equals cd.MaChuDe
                                join nn in db.NGONNGUs on tls.MaNgonNgu equals nn.MaNgonNgu
                                join loaitl in db.LOAITAILIEUs on tls.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                                join tg in db.TACGIAs on tls.MaTacGia equals tg.MaTacGia
                                join nxb in db.NHAXUATBANs on tls.MaNhaXuatBan equals nxb.MaNhaXuatBan
                                join vt in db.VITRIs on tls.MaViTri equals vt.MaViTri
                                where (tls.TinhTrangXoa == false) && (arrTaiLieu.Contains(tls.MaVach))
                                select new { tls.MaVach, tls.TenTaiLieu, cd.TenChuDe, tls.MaTap, nn.TenNgonNgu, nxb.TenNhaXuatBan,tg.TenTacGia,vt.MaViTri };


            return dsTaiLieuChon;
        }

        public bool muonTaiLieu(List<TAILIEU> dsTaiLieuMuon, string mathethuvien,string manhanvien, ref string phicoc)
        {
            double tongphicoc = 0;
            int tisonhan = 0;
            DOCGIA dg = db.DOCGIAs.Where(a => a.MaTheThuVien == mathethuvien).FirstOrDefault();
            if(dg.MaLoaiDocGia == 1)
            {
                tisonhan = 1;
            }
            else if(dg.MaLoaiDocGia == 2)
            {
                tisonhan = 0;
            }
            else if(dg.MaLoaiDocGia == 3)
            {
                tisonhan = 2;
            }
            foreach (TAILIEU item in dsTaiLieuMuon)
            {
                tongphicoc += double.Parse(item.Gia.ToString());
            }
            double dPhicoc = tongphicoc * tisonhan;
            phicoc = dPhicoc.ToString();

            string maphieumuon = "";
            PHIEUMUON newPM = new PHIEUMUON();
            newPM.MaTheThuVien = mathethuvien;
            newPM.NgayLap = DateTime.Now;
            DateTime thoihanmuon = DateTime.Now.AddMonths(1);
            newPM.ThoiHanMuon = thoihanmuon;
            newPM.SoSachMuon = dsTaiLieuMuon.Count();
            newPM.TinhTrangTra = false;
            //newPM.PhiCoc = double.Parse(phicoc);
            newPM.PhiCoc = dPhicoc;
            newPM.MaNhanVien = int.Parse(manhanvien);
            newPM.TinhTrangXoa = false;
            try
            {
                db.PHIEUMUONs.InsertOnSubmit(newPM);
                db.SubmitChanges();
                PHIEUMUON pm = db.PHIEUMUONs.OrderByDescending(a => a.MaPhieuMuon).First();
                maphieumuon = pm.MaPhieuMuon.ToString();
            }
            catch(Exception ex)
            {
                return false;
            }
            foreach (TAILIEU item in dsTaiLieuMuon)
            {
                CT_PHIEUMUON newCTPM = new CT_PHIEUMUON();
                //newCTPM.MaPhieuMuon = newPM.MaPhieuMuon;
                newCTPM.MaPhieuMuon = int.Parse(maphieumuon);
                newCTPM.MaVach = item.MaVach;
                newCTPM.TinhTrangTraCT = false;
                newCTPM.TinhTrangXoa = false;
                try
                {
                    db.CT_PHIEUMUONs.InsertOnSubmit(newCTPM);
                    db.SubmitChanges();
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
            return true;
        }

        public IQueryable timKiemMaVachTaiLieu(string mavach)
        {
            var tl = from tls in db.TAILIEUs
                      join cd in db.CHUDEs on tls.MaChuDe equals cd.MaChuDe
                      join nn in db.NGONNGUs on tls.MaNgonNgu equals nn.MaNgonNgu
                      join loaitl in db.LOAITAILIEUs on tls.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                      join tg in db.TACGIAs on tls.MaTacGia equals tg.MaTacGia
                      join nxb in db.NHAXUATBANs on tls.MaNhaXuatBan equals nxb.MaNhaXuatBan
                      join vt in db.VITRIs on tls.MaViTri equals vt.MaViTri
                      where (tls.TinhTrangXoa == false) && (tls.MaVach.Contains(mavach))
                     select new { tls.MaVach, tls.TenTaiLieu, cd.TenChuDe, tls.MaTap, nn.TenNgonNgu, nxb.TenNhaXuatBan, tg.TenTacGia, tls.MaViTri };
            return tl;
        }

        
    }
}
