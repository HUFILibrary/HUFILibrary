using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyLoaiNhanVien
    {
        DB_QLTVDataContext qltv = new DB_QLTVDataContext();
        public bool themLoaiNV(LOAINHANVIEN lnvt)
        {
            //LOAINHANVIEN lnv = qltv.LOAINHANVIENs.Where(l => l.MaLoaiNhanVien == lnvt.MaLoaiNhanVien).FirstOrDefault();
            //if (lnv == null)
            //{
                try
                {
                    qltv.LOAINHANVIENs.InsertOnSubmit(lnvt);
                qltv.SubmitChanges();

                // thêm loại nhân viên vào bảng phân quyền cùng với tất cả mã màn hình
                LOAINHANVIEN lnv = qltv.LOAINHANVIENs.OrderByDescending(a => a.MaLoaiNhanVien).First();
                var mhs = qltv.MANHINHs.ToList();
                if(mhs != null)
                {
                    foreach(MANHINH mh in mhs)
                    {
                        PHANQUYEN pq = new PHANQUYEN();
                        pq.MaLoaiNhanVien = lnv.MaLoaiNhanVien;
                        pq.MaManHinh = mh.MaManHinh;
                        pq.CoQuyen = false;
                        qltv.PHANQUYENs.InsertOnSubmit(pq);
                    }
                }
                qltv.SubmitChanges();
                // ------------------
                    
                    return true;
                }
                catch (Exception ex) { return false; }
            //}
            //else { return false; }
        }
        public bool suaLoaiNV(int lnvs, string tenloai)
        {
            LOAINHANVIEN lnv = qltv.LOAINHANVIENs.Where(l => l.MaLoaiNhanVien == lnvs).FirstOrDefault();
            if (lnv != null)
            {
                try {
                    lnv.TenLoaiNhanVien = tenloai;
                    qltv.SubmitChanges();
                    return true;
                } catch (Exception ex) { return false; }
            }
            return false;
        }
        public bool xoaLoaiNV(int malnv)
        {
            LOAINHANVIEN lnv = qltv.LOAINHANVIENs.Where(l => l.MaLoaiNhanVien == malnv).FirstOrDefault();
            if (lnv != null) {
                try {
                    lnv.TinhTrangXoa = true;
                    // xoa phan quyen cua loai nhan vien
                    var pqs = from pq in qltv.PHANQUYENs
                              where pq.MaLoaiNhanVien == malnv
                              select pq;
                    if(pqs != null)
                    {
                        foreach(PHANQUYEN item in pqs)
                        {
                            qltv.PHANQUYENs.DeleteOnSubmit(item);
                        }
                    }
                    // -----------------------------------
                    // set tinh trang xoa cho nhan vien thuoc loai nhan vien nay
                    var nvs = from nv in qltv.NHANVIENs
                              where nv.MaLoaiNhanVien == malnv
                              select nv;
                    if(nvs != null)
                    {
                        foreach(NHANVIEN item in nvs)
                        {
                            item.TinhTrangXoa = true;
                        }
                    }
                    qltv.SubmitChanges();
                    return true;
                }
                catch (Exception ex) { return false; }
            }
            return false;
        }
        public IQueryable loadDSLoaiNV() {
            var lnvs = from lnv in qltv.LOAINHANVIENs where lnv.TinhTrangXoa == false select lnv;
            return lnvs;
        }
    }
}
