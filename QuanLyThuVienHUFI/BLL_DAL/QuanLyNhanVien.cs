using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyNhanVien
    {
        DB_QLTVDataContext qltv = new DB_QLTVDataContext();

        public IQueryable loadDsLoaiNV() {
            var lnvs = from lnv in qltv.LOAINHANVIENs where lnv.TinhTrangXoa == false select lnv;
            return lnvs;
        }
        public IQueryable loadDsNhanVien()
        {
            var nvs = from nv in qltv.NHANVIENs
                      join lnv in qltv.LOAINHANVIENs on nv.MaLoaiNhanVien equals lnv.MaLoaiNhanVien
                      where nv.TinhTrangXoa == false
                      select new {nv.TenNhanVien, nv.NgaySinh, nv.GioiTinh, nv.SoDienThoai, nv.CMND, nv.DiaChi, nv.NgayVaoLam, nv.TinhTrangTK, nv.MatKhau, lnv.TenLoaiNhanVien,nv.MaNhanVien,nv.HinhAnh};
            
            return nvs;
        }
        public bool xoaNhanVien(int nvx)
        {
            NHANVIEN nvs = qltv.NHANVIENs.Where(n => n.MaNhanVien == nvx).FirstOrDefault();
            if (nvs != null)
            {
                if (!string.IsNullOrEmpty(nvs.HinhAnh))
                {
                    string uploadsPath = System.IO.Path.GetFullPath("..\\..\\..\\");
                    string ext = Path.GetExtension(nvs.HinhAnh);
                    uploadsPath += "Images\\NhanVien\\" + nvs.SoDienThoai.ToString() + ext;
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
                }
                try {
                nvs.TinhTrangXoa = true;
                qltv.SubmitChanges();
                }
                catch (Exception ex) { return false; }
            }
            return false;
        }
        public bool themNhanVien(NHANVIEN nv)
        {
            try
            {
                NHANVIEN nvm = new NHANVIEN();
                nvm.TenNhanVien = nv.TenNhanVien;
                nvm.MatKhau = nv.MatKhau;
                nvm.MaLoaiNhanVien = nv.MaLoaiNhanVien;
                nvm.SoDienThoai = nv.SoDienThoai;
                nvm.CMND = nv.CMND;
                nvm.NgayVaoLam = nv.NgayVaoLam;
                nvm.TinhTrangXoa = false;
                nvm.GioiTinh = nv.GioiTinh;
                nvm.NgaySinh = nv.NgaySinh;
                nvm.TinhTrangTK = nv.TinhTrangTK;
                nvm.DiaChi = nv.DiaChi;
                qltv.NHANVIENs.InsertOnSubmit(nvm);
                qltv.SubmitChanges();
                NHANVIEN nvs = qltv.NHANVIENs.OrderByDescending(n => n.MaNhanVien).First();
                if (nvs != null)
                {
                        string uploadsPath = System.IO.Path.GetFullPath("..\\..\\..\\");
                        string ext = Path.GetExtension(nv.HinhAnh);
                        uploadsPath += "Images\\NhanVien\\" + nvm.MaNhanVien + ext;
                        try
                        {
                            System.IO.File.Copy(nv.HinhAnh, uploadsPath.ToString());
                            nvm.HinhAnh = nvm.MaNhanVien + ext;
                            qltv.SubmitChanges();
                            return true;
                        }
                        catch (Exception ex)
                        {
                        return false;
                        }
                }
               
                    
            }
            catch (Exception ex) { return false; }
        return false;
        }
        public bool suaNhanVien(NHANVIEN nv)
        {
            NHANVIEN nvs = qltv.NHANVIENs.Where(n => n.MaNhanVien == nv.MaNhanVien).FirstOrDefault();
            if (nvs != null)
            {
                if (!string.IsNullOrEmpty(nvs.HinhAnh))
                {
                    string uploadsPath = System.IO.Path.GetFullPath("..\\..\\..\\");
                    string ext = Path.GetExtension(nvs.HinhAnh);
                    string delPath = System.IO.Path.GetFullPath("..\\..\\..\\") + "Images\\NhanVien\\" + nvs.HinhAnh;
                    uploadsPath += "Images\\NhanVien\\" + nvs.MaNhanVien.ToString() + ext;
                    if (System.IO.File.Exists(delPath))
                    {
                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();
                        try
                        {
                            System.IO.File.Delete(delPath);
                        }
                        catch (Exception ex)
                        {

                        }

                    }
                    try
                    {
                        System.IO.File.Copy(nv.HinhAnh, uploadsPath.ToString());
                        nvs.HinhAnh = nvs.MaNhanVien + "" + ext;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                try
                {
                    nvs.TenNhanVien = nv.TenNhanVien;
                    nvs.TinhTrangTK = nv.TinhTrangTK;
                    nvs.NgayVaoLam = nv.NgayVaoLam;
                    nvs.NgaySinh = nv.NgaySinh;
                    nvs.MatKhau = nv.MatKhau;
                    nvs.MaLoaiNhanVien = nv.MaLoaiNhanVien;
                    nvs.GioiTinh = nv.GioiTinh;
                   
                    nvs.DiaChi = nv.DiaChi;
                    nvs.SoDienThoai = nv.SoDienThoai;
                    nvs.CMND = nv.CMND;
       
                    qltv.SubmitChanges();
                    return true;
                }
                catch (Exception ex) { return false; }
            }
            else
                return false;
        }
    }
}
