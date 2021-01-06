using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyPhieuNhap
    {
        DB_QLTVDataContext db = new DB_QLTVDataContext();
        QuanLyTaiLieu qltl = new QuanLyTaiLieu();
        public bool taoPhieuNhap(string manhanvien)
        {
            PHIEUNHAP item = new PHIEUNHAP();
            item.MaNhanVien = int.Parse(manhanvien);
            item.NgayNhap = DateTime.Now;
            item.TinhTrangXoa = false;
            try
            {
                db.PHIEUNHAPs.InsertOnSubmit(item);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public IQueryable loadComboboxNhaCungCap()
        {
            var nccs = from ncc in db.NHACUNGCAPs
                       select ncc;
            return nccs;
        }
        public IQueryable loadTLtheoMaTL(string mav)
        {
            var tls = from tl in db.TAILIEUs
                      join ltl in db.LOAITAILIEUs on tl.MaLoaiTaiLieu equals ltl.MaLoaiTaiLieu
                      join cd in db.CHUDEs on tl.MaChuDe equals cd.MaChuDe
                      where tl.MaVach == mav select new {tl.MaVach, ltl.TenLoaiTaiLieu, cd.TenChuDe, tl.TenTaiLieu};
            return tls;
        }
        public bool themCT_PhieuNhap(string maphieunhap, string manhacungcap, List<TAILIEU> dsTL)
        {
            int madausach = 1;
            foreach (TAILIEU tl in dsTL)
            {
                TAILIEU tlNew = new TAILIEU();
                tlNew.MaTaiLieu = tl.MaTaiLieu;
                tlNew.MaLoaiTaiLieu = tl.MaLoaiTaiLieu;
                tlNew.MaChuDe = tl.MaChuDe;
                tlNew.TenTaiLieu = tl.TenTaiLieu;
                tlNew.SoTrang = tl.SoTrang;
                tlNew.Gia = tl.Gia;
                tlNew.NamXuatBan = tl.NamXuatBan;
                tlNew.MaTacGia = tl.MaTacGia;
                tlNew.MaNhaXuatBan = tl.MaNhaXuatBan;
                tlNew.ThongTinTaiLieu = tl.ThongTinTaiLieu;
                tlNew.MaNgonNgu = tl.MaNgonNgu;
                tlNew.MaViTri = tl.MaViTri;
                
                TAILIEU mavach = db.TAILIEUs.OrderByDescending(a => a.MaVach).First();
                string mv = (int.Parse(mavach.MaVach.ToString()) + 1).ToString();
                tlNew.MaVach = mv;

                if (!string.IsNullOrEmpty(tl.HinhAnh))
                {
                    string uploadsPath = System.IO.Path.GetFullPath("..\\..\\..\\");
                    string ext = Path.GetExtension(tl.HinhAnh);
                    uploadsPath += "Images\\TaiLieu\\" + tlNew.MaVach.ToString() + ext;
                    if (System.IO.File.Exists(uploadsPath))
                    {
                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();
                        try
                        {
                            System.IO.File.Delete(uploadsPath);
                        }
                        catch (Exception ex)
                        {

                        }

                    }
                    try
                    {
                        System.IO.File.Copy(tl.HinhAnh.ToString(), uploadsPath.ToString());
                        tlNew.HinhAnh = tlNew.MaVach + "" + ext;
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
                tlNew.TinhTrangXoa = false;
                tlNew.MaDauTaiLieu = madausach.ToString();
                madausach++;

                CT_PHIEUNHAP item = new CT_PHIEUNHAP();
                item.MaVach = tlNew.MaVach;
                item.MaPhieuNhap = int.Parse(maphieunhap);
                item.MaNhaCungCap = int.Parse(manhacungcap);
                try
                {
                    db.TAILIEUs.InsertOnSubmit(tlNew);
                    db.CT_PHIEUNHAPs.InsertOnSubmit(item);
                    db.SubmitChanges();
                }
                catch(Exception ex)
                {
                    return false;
                }
            }

            return true;
        }
        public IQueryable loadDgvChiTietPhieuNhap(string maphieunhap)
        {
            var ctpns = from ctpn in db.CT_PHIEUNHAPs
                        join tls in db.TAILIEUs on ctpn.MaVach equals tls.MaVach
                        join cd in db.CHUDEs on tls.MaChuDe equals cd.MaChuDe
                        join nn in db.NGONNGUs on tls.MaNgonNgu equals nn.MaNgonNgu
                        join loaitl in db.LOAITAILIEUs on tls.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                        join tg in db.TACGIAs on tls.MaTacGia equals tg.MaTacGia
                        join nxb in db.NHAXUATBANs on tls.MaNhaXuatBan equals nxb.MaNhaXuatBan
                        join vt in db.VITRIs on tls.MaViTri equals vt.MaViTri
                        where (ctpn.MaPhieuNhap == int.Parse(maphieunhap)) && (ctpn.TinhTrangXoa == false)
                        select new {ctpn.MaPhieuNhap, loaitl.TenLoaiTaiLieu,tls.TenTaiLieu,cd.TenChuDe,tg.TenTacGia,tls.SoTrang,tls.Gia,tls.NamXuatBan,nxb.TenNhaXuatBan,nn.TenNgonNgu,tls.ThongTinTaiLieu,vt.MaViTri,ctpn.MaChiTietPhieuNhap,tls.HinhAnh,tls.MaTaiLieu,tls.MaVach};
            return ctpns;
        }
        public string getLastMaPhieuNhap()
        {
            PHIEUNHAP pn = db.PHIEUNHAPs.OrderByDescending(a => a.MaPhieuNhap).First();
            if (pn != null)
            {
                return pn.MaPhieuNhap.ToString();
            }
            else
            {
                return null;
            }
        }
        public IQueryable loadDgvPhieuNhap()
        {
            var pns = from pn in db.PHIEUNHAPs
                      join nv in db.NHANVIENs on pn.MaNhanVien equals nv.MaNhanVien
                      where pn.TinhTrangXoa == false
                      select new { pn.MaPhieuNhap, nv.TenNhanVien , pn.NgayNhap, pn.TongTien };
            return pns;
        }

        public bool nhapTaiLieu(TAILIEU tl, int soluong, string maphieunhap, string manhacungcap)
        {
            TAILIEU matailieu = db.TAILIEUs.OrderByDescending(a => a.MaTaiLieu).First();
            string matl = (int.Parse(matailieu.MaTaiLieu.ToString()) + 1).ToString();
            double? tongtien = 0;
            for (int i = 0; i < soluong; i++)
            {
                TAILIEU rs = new TAILIEU();
                rs.TenTaiLieu = tl.TenTaiLieu;
                rs.MaLoaiTaiLieu = tl.MaLoaiTaiLieu;
                rs.SoTrang = tl.SoTrang;
                rs.Gia = tl.Gia;
                rs.NamXuatBan = tl.NamXuatBan;
                rs.MaTacGia = tl.MaTacGia;
                rs.MaNhaXuatBan = tl.MaNhaXuatBan;
                rs.ThongTinTaiLieu = tl.ThongTinTaiLieu;
                rs.MaNgonNgu = tl.MaNgonNgu;
                rs.MaChuDe = tl.MaChuDe;
                rs.MaTap = tl.MaTap;
                rs.MaViTri = tl.MaViTri;
                rs.TinhTrangXoa = false;
                tongtien += rs.Gia != null?rs.Gia:0;
                TAILIEU mavach = db.TAILIEUs.OrderByDescending(a => a.MaVach).First();
                string mv = (int.Parse(mavach.MaVach.ToString()) + 1).ToString();
                rs.MaVach = mv;

                rs.MaTaiLieu = matl;

                rs.MaDauTaiLieu = (i + 1).ToString();

                if (!string.IsNullOrEmpty(tl.HinhAnh))
                {
                    string uploadsPath = System.IO.Path.GetFullPath("..\\..\\..\\");
                    string ext = Path.GetExtension(tl.HinhAnh);
                    uploadsPath += "Images\\TaiLieu\\" + rs.MaVach.ToString() + ext;
                    if (System.IO.File.Exists(uploadsPath))
                    {
                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();
                        try
                        {
                            System.IO.File.Delete(uploadsPath);
                        }
                        catch (Exception ex)
                        {

                        }

                    }
                    try
                    {
                        System.IO.File.Copy(tl.HinhAnh.ToString(), uploadsPath.ToString());
                        rs.HinhAnh = rs.MaVach + "" + ext;
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
                CT_PHIEUNHAP item = new CT_PHIEUNHAP();
                item.MaVach = rs.MaVach;
                item.MaPhieuNhap = int.Parse(maphieunhap);
                item.MaNhaCungCap = int.Parse(manhacungcap);
                try
                {
                    db.TAILIEUs.InsertOnSubmit(rs);
                    db.CT_PHIEUNHAPs.InsertOnSubmit(item);
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            PHIEUNHAP pn = db.PHIEUNHAPs.Where(a => a.MaPhieuNhap == int.Parse(maphieunhap)).FirstOrDefault();
            if(pn != null)
            {
                pn.TongTien += tongtien;
                db.SubmitChanges();
            }

            return true;
        }

        public bool xoaCT_PhieuNhap(string mactpn)
        {
            CT_PHIEUNHAP ct = db.CT_PHIEUNHAPs.Where(a => a.MaChiTietPhieuNhap == int.Parse(mactpn)).FirstOrDefault();
            string mavach = ct.MaVach;
            TAILIEU tl = db.TAILIEUs.Where(a => a.MaVach == mavach).FirstOrDefault();
            string matailieu = tl.MaTaiLieu;
            if(ct != null)
            {
                ct.TinhTrangXoa = true;
                if (tl != null)
                {
                    tl.TinhTrangXoa = true;
                }
                else
                {
                    return false;
                }
                db.SubmitChanges();
                qltl.updateMaDauTaiLieu(matailieu);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public bool xoaPhieuNhap(string maphieunhap)
        {
            PHIEUNHAP pn = db.PHIEUNHAPs.Where(a => a.MaPhieuNhap == int.Parse(maphieunhap)).FirstOrDefault();
            var ctpn = from ctpns in db.CT_PHIEUNHAPs
                       where ctpns.MaPhieuNhap == int.Parse(maphieunhap)
                       select ctpns;
            List<string> lstMaVach = db.CT_PHIEUNHAPs.Where(a => a.MaPhieuNhap == int.Parse(maphieunhap)).Select(a => a.MaVach).ToList();
            if (pn != null)
            {
                pn.TinhTrangXoa = true;
                db.SubmitChanges();
                if (ctpn != null)
                {
                    foreach (CT_PHIEUNHAP item in ctpn)
                    {
                        item.TinhTrangXoa = true;
                        TAILIEU tl = db.TAILIEUs.Where(a => a.MaVach == item.MaVach).FirstOrDefault();
                        if(tl != null)
                        {
                            tl.TinhTrangXoa = true;
                        }    
                        db.SubmitChanges();
                    }

                }
                return true;
            }
            else
            {
                return false;
            }
            
            

        }

        public bool themTaiLieuCu(string mavach, string soluong, string maphieunhap, string manhacungcap)
        {
            TAILIEU tl = db.TAILIEUs.Where(a => a.MaVach == mavach).FirstOrDefault();
            if(tl != null)
            {
                string matailieu = tl.MaTaiLieu;
                TAILIEU madtl = db.TAILIEUs.Where(a => a.MaTaiLieu == tl.MaTaiLieu).OrderByDescending(a => a.MaDauTaiLieu).First();
                int madautailieu = int.Parse(madtl.MaDauTaiLieu) + 1;
                for(int i = 0;i<int.Parse(soluong);i++)
                {
                    TAILIEU item = new TAILIEU();
                    item.MaTaiLieu = tl.MaTaiLieu;
                    item.MaLoaiTaiLieu = tl.MaLoaiTaiLieu;
                    item.MaDauTaiLieu = madautailieu.ToString();
                    madautailieu++;
                    item.MaChuDe = tl.MaChuDe;
                    item.MaTap = tl.MaTap;
                    item.TenTaiLieu = tl.TenTaiLieu;
                    item.SoTrang = tl.SoTrang;
                    item.Gia = tl.Gia;
                    item.NamXuatBan = tl.NamXuatBan;
                    item.MaTacGia = tl.MaTacGia;
                    item.MaNhaXuatBan = tl.MaNhaXuatBan;
                    item.ThongTinTaiLieu = tl.ThongTinTaiLieu;
                    item.MaViTri = tl.MaViTri;
                    item.MaNgonNgu = tl.MaNgonNgu;
                    item.TinhTrangXoa = false;
                    TAILIEU flg = db.TAILIEUs.OrderByDescending(a => a.MaVach).First();
                    string mv = (int.Parse(flg.MaVach.ToString()) + 1).ToString();
                    item.MaVach = mv;
                    if (!string.IsNullOrEmpty(tl.HinhAnh))
                    {
                        string uploadsPath = System.IO.Path.GetFullPath("..\\..\\..\\");
                        string[] arr = tl.HinhAnh.Split('.');
                        string old = System.IO.Path.GetFullPath("..\\..\\..\\");
                        old += "Images\\TaiLieu\\" + tl.HinhAnh;
                        uploadsPath += "Images\\TaiLieu\\" + item.MaVach.ToString()+"." + arr[1];
                        if (System.IO.File.Exists(uploadsPath))
                        {
                            System.GC.Collect();
                            System.GC.WaitForPendingFinalizers();
                            try
                            {
                                System.IO.File.Delete(uploadsPath);
                            }
                            catch (Exception ex)
                            {

                            }

                        }
                        try
                        {
                            System.IO.File.Copy(old, uploadsPath.ToString());
                            item.HinhAnh = item.MaVach + "." + arr[1];
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }
                    }
                    CT_PHIEUNHAP itemct = new CT_PHIEUNHAP();
                    itemct.MaVach = item.MaVach;
                    itemct.MaPhieuNhap = int.Parse(maphieunhap);
                    itemct.MaNhaCungCap = int.Parse(manhacungcap);
                    try
                    {
                        db.TAILIEUs.InsertOnSubmit(item);
                        db.CT_PHIEUNHAPs.InsertOnSubmit(itemct);
                        db.SubmitChanges();
                        
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                }
                return true;
            }
           
                return false;
            
        }

        public IQueryable loadDgvTaiLieu()
        {
            var dsTL = from tls in db.TAILIEUs
                       join cd in db.CHUDEs on tls.MaChuDe equals cd.MaChuDe
                       join nn in db.NGONNGUs on tls.MaNgonNgu equals nn.MaNgonNgu
                       join loaitl in db.LOAITAILIEUs on tls.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                       join tg in db.TACGIAs on tls.MaTacGia equals tg.MaTacGia
                       join nxb in db.NHAXUATBANs on tls.MaNhaXuatBan equals nxb.MaNhaXuatBan
                       join vt in db.VITRIs on tls.MaViTri equals vt.MaViTri
                       where tls.TinhTrangXoa == false
                       select new { tls.MaVach, loaitl.TenLoaiTaiLieu, tls.TenTaiLieu, cd.TenChuDe};
            return dsTL;
        }
    }
}
