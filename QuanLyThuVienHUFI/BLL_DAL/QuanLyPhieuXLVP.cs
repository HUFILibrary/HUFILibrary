using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyPhieuXLVP
    {
        DB_QLTVDataContext qltv = new DB_QLTVDataContext();
        public IQueryable loadDSPhieuXLVP()
        {
            var pxls = from pxl in qltv.PHIEUXULYVIPHAMs
                       join nv in qltv.NHANVIENs on pxl.MaNhanVien equals nv.MaNhanVien
                       join pt in qltv.PHIEUTRAs on pxl.MaPhieuTra equals pt.MaPhieuTra
                       where pxl.TinhTrangXoa == false
                       select new { pxl.MaXuLyViPham, pt.MaPhieuTra, nv.TenNhanVien, pxl.NgayLap, pxl.TongTienBoiThuong };
            return pxls;
        }
        public IQueryable loadCTXLTheoPXL(int maxl)
        {
            var ctxls = from ctxl in qltv.CT_XULYVIPHAMs
                        join pxl in qltv.PHIEUXULYVIPHAMs on ctxl.MaXuLyViPham equals pxl.MaXuLyViPham
                        join lvp in qltv.LOAIVIPHAMs on ctxl.MaLoaiViPham equals lvp.MaLoaiViPham
                        join mv in qltv.TAILIEUs on ctxl.MaVach equals mv.MaVach
                        where ctxl.TinhTrangXoa == false && ctxl.MaXuLyViPham == maxl
                        select new {ctxl.MaChiTietXuLyViPham, ctxl.MaXuLyViPham, mv.MaVach, mv.TenTaiLieu, lvp.TenLoaiViPham, ctxl.TienBoiThuong };
            return ctxls;
        }
        public bool xoaPXL(PHIEUXULYVIPHAM pxl)
        {
            PHIEUXULYVIPHAM pxlvp = qltv.PHIEUXULYVIPHAMs.Where(p => p.MaXuLyViPham == pxl.MaXuLyViPham).FirstOrDefault();
            if (pxlvp != null)
            {
                try
                {
                    List<CT_XULYVIPHAM> lstCTXL = qltv.CT_XULYVIPHAMs.Where(x => x.MaXuLyViPham == pxlvp.MaXuLyViPham).ToList();
                    foreach (CT_XULYVIPHAM _ctxl in lstCTXL)
                    {
                        qltv.CT_XULYVIPHAMs.DeleteOnSubmit(_ctxl);
                        qltv.SubmitChanges();
                    }
                    qltv.PHIEUXULYVIPHAMs.DeleteOnSubmit(pxlvp);
                    qltv.SubmitChanges();
                    return true;
                }
                catch (Exception ex) { return false; }
            }
            return false;
        }
        public bool xoaCTXL(CT_XULYVIPHAM ct)
        {
            CT_XULYVIPHAM _ct = qltv.CT_XULYVIPHAMs.Where(c => c.MaChiTietXuLyViPham == ct.MaChiTietXuLyViPham).FirstOrDefault();
            if (_ct != null)
            {
                try
                {
                    qltv.CT_XULYVIPHAMs.DeleteOnSubmit(_ct);
                    qltv.SubmitChanges();
                    return true;
                }
                catch (Exception ex) { return false; }
            }
            return false;
        }

    }
}
