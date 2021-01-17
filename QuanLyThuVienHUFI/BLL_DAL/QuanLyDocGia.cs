using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_DAL
{
    public class QuanLyDocGia
    {
        DB_QLTVDataContext db = new DB_QLTVDataContext();
        
        public IQueryable loadKhoas()
        {
            var khoas = from khoa in db.KHOAs
                        where khoa.TinhTrangXoa == false
                        select new { khoa.TenKhoa, khoa.MaKhoa };
            return khoas;
        }
        public IQueryable loadComboboxNganh(string makhoa)
        {
            var ns = from n in db.NGANHs
                     where (n.MaKhoa == int.Parse(makhoa))
                     select new
                     {
                         n.MaNganh,
                         n.TenNganh
                     };
            return ns;

        }
        public IQueryable loadComboboxNganhByKhoa(string makhoa, string manganh)
        {
            
                var ns = from n in db.NGANHs
                         where (n.MaKhoa == int.Parse(makhoa)) && (n.MaNganh == manganh)
                         select new
                         {
                             n.MaNganh,
                             n.TenNganh
                         };
                return ns;
            
            
        }
        public IQueryable loadDgvNganh()
        {
            var nganhs = from nganh in db.NGANHs
                         join khoa in db.KHOAs on nganh.MaKhoa equals khoa.MaKhoa
                         select new { nganh.MaNganh, nganh.TenNganh, khoa.TenKhoa };
            return nganhs;
        }
        
        public IQueryable loadDgvDocGia()
        {
            var dgs = from dg in db.DOCGIAs
                      join ldg in db.LOAIDOCGIAs on dg.MaLoaiDocGia equals ldg.MaLoaiDocGia
                      join nganh in db.NGANHs on dg.MaNganh equals nganh.MaNganh
                      join khoa in db.KHOAs on nganh.MaKhoa equals khoa.MaKhoa
                      where dg.TinhTrangXoa == false
                      select new { dg.MaTheThuVien,ldg.TenLoaiDocGia,nganh.TenNganh,khoa.TenKhoa,dg.TenDocGia,dg.CMND,dg.NgaySinh,dg.GioiTinh,dg.SoDienThoai,dg.DiaChi,dg.Email,dg.HanSuDungTheThuVien,dg.TinhTrangTheThuVien,dg.NgayLamThe,dg.MatKhau,dg.TinhTrangXoa,dg.HinhAnh };
            return dgs;
        }
        public bool checkMaThe(string mathe)
        {
            DOCGIA dg = db.DOCGIAs.Where(a => a.MaTheThuVien == mathe).FirstOrDefault();
            if(dg != null)
            {
                return true;
            }
            return false;
        }
        public void xoaDocGia(string mathe)
        {
            if(string.IsNullOrEmpty(mathe))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để xoá.");
            }    
            DOCGIA dg = db.DOCGIAs.Where(a => a.MaTheThuVien == mathe).FirstOrDefault();
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (dg != null)
                {
                    dg.TinhTrangXoa = true;
                    db.SubmitChanges();
                    MessageBox.Show("Xoá thành công.");
                }
                else
                {
                    MessageBox.Show("Xoá không thành công.");
                }
            }
            else
            {
                return;
            }
        }
        public void suaDocGia(string mathethuvien, string tendocgia, string maloaidocgia, string manganh, string cmnd, string ngaysinh, string gioitinh, string sdt, string diachi, string email, string hansudungthethuvien, bool tinhtrangthethuvien, string ngaylamthe, string hinhanh, string matkhau)
        {
            if (!checkMaThe(mathethuvien))
            {
                MessageBox.Show("Mã thẻ thư viện không tồn tại.");
                return;
            }
            if (string.IsNullOrEmpty(mathethuvien) || string.IsNullOrEmpty(maloaidocgia) || string.IsNullOrEmpty(manganh) || string.IsNullOrEmpty(tendocgia) || string.IsNullOrEmpty(cmnd) || string.IsNullOrEmpty(ngaysinh) || string.IsNullOrEmpty(gioitinh) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(hansudungthethuvien) || string.IsNullOrEmpty(tinhtrangthethuvien.ToString()) || string.IsNullOrEmpty(ngaylamthe))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu");
                return;
            }

            DOCGIA item = db.DOCGIAs.Where(a=>a.MaTheThuVien == mathethuvien).FirstOrDefault();
            item.MaTheThuVien = mathethuvien;
            item.TenDocGia = tendocgia;
            item.MaLoaiDocGia = int.Parse(maloaidocgia);
            item.MaNganh = manganh;
            item.CMND = cmnd;
            item.NgaySinh = DateTime.Parse(ngaysinh);
            item.GioiTinh = gioitinh;
            item.SoDienThoai = sdt;
            item.DiaChi = diachi;
            item.Email = email;
            item.HanSuDungTheThuVien = DateTime.Parse(hansudungthethuvien);
            item.TinhTrangTheThuVien = tinhtrangthethuvien;
            item.NgayLamThe = DateTime.Parse(ngaylamthe);
            if (!string.IsNullOrEmpty(hinhanh))
            {
                string uploadsPath = System.IO.Path.GetFullPath("..\\..\\..\\");
                string ext = Path.GetExtension(hinhanh);
                string delPath = System.IO.Path.GetFullPath("..\\..\\..\\") + "Images\\DocGia\\" + item.HinhAnh;
                uploadsPath += "Images\\DocGia\\" + item.MaTheThuVien.ToString() + ext;
                if(System.IO.File.Exists(delPath))
                {
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    try
                    {
                        System.IO.File.Delete(delPath);
                    }
                    catch(Exception ex)
                    {

                    }
                    
                }    
                try
                {
                    System.IO.File.Copy(hinhanh, uploadsPath.ToString());
                    item.HinhAnh = item.MaTheThuVien + "" + ext;
                }
                catch (Exception ex)
                {

                }
            }
            //item.MatKhau = matkhau;
            item.TinhTrangXoa = false;
            db.SubmitChanges();
            MessageBox.Show("Sửa thành công.");
            
        }
        public bool luuDocGia(string mathethuvien, string tendocgia, string maloaidocgia, string manganh, string cmnd, string ngaysinh, string gioitinh, string sdt, string diachi, string email, string hansudungthethuvien, bool tinhtrangthethuvien, string ngaylamthe, string hinhanh, string matkhau)
        {
            if (checkMaThe(mathethuvien))
            {
                MessageBox.Show("Mã thẻ thư viện đã tồn tại.");
                return false;
            }
            if(string.IsNullOrEmpty(mathethuvien) || string.IsNullOrEmpty(maloaidocgia) || string.IsNullOrEmpty(manganh) || string.IsNullOrEmpty(tendocgia) || string.IsNullOrEmpty(cmnd) || string.IsNullOrEmpty(ngaysinh) || string.IsNullOrEmpty(gioitinh) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(hansudungthethuvien) || string.IsNullOrEmpty(tinhtrangthethuvien.ToString()) || string.IsNullOrEmpty(ngaylamthe))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu");
                return false;
            }

            try
            {
                DOCGIA item = new DOCGIA();
                item.MaTheThuVien = mathethuvien;
                item.TenDocGia = tendocgia;
                item.MaLoaiDocGia = int.Parse(maloaidocgia);
                item.MaNganh = manganh;
                item.CMND = cmnd;
                item.NgaySinh = DateTime.Parse(ngaysinh);
                item.GioiTinh = gioitinh;
                item.SoDienThoai = sdt;
                item.DiaChi = diachi;
                item.Email = email;
                item.HanSuDungTheThuVien = DateTime.Parse(hansudungthethuvien);
                item.TinhTrangTheThuVien = tinhtrangthethuvien;
                item.NgayLamThe = DateTime.Parse(ngaylamthe);
                if(!string.IsNullOrEmpty(hinhanh))
                {
                    string uploadsPath = System.IO.Path.GetFullPath("..\\..\\..\\");
                    string ext = Path.GetExtension(hinhanh);
                    uploadsPath += "Images\\DocGia\\" + item.MaTheThuVien.ToString() + ext;
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
                        System.IO.File.Copy(hinhanh, uploadsPath.ToString());
                        item.HinhAnh = item.MaTheThuVien + "" + ext;
                    }
                    catch (Exception ex)
                    {
                        
                    }
                    
                }
                item.MatKhau = matkhau;
                item.TinhTrangXoa = false;
                db.DOCGIAs.InsertOnSubmit(item);
                db.SubmitChanges();
                MessageBox.Show("Lưu thành công.");
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lưu không thành công.");
                return false;
            }
        }
       
        public void themLoaiDocGia(string tenLDG)
        {
            if(string.IsNullOrEmpty(tenLDG))
            {
                MessageBox.Show("Vui lòng nhập đẩy đủ thông tin.");
                return;
            }

            LOAIDOCGIA newItem = new LOAIDOCGIA();
            newItem.TenLoaiDocGia = tenLDG;
            newItem.TinhTrangXoa = false;
            try
            {
                db.LOAIDOCGIAs.InsertOnSubmit(newItem);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công.");
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm không thành công.");
                return;
            }
        }

        public void xoaLoaiDocGia(string maLoai)
        {
            if (string.IsNullOrEmpty(maLoai))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để xoá.");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                LOAIDOCGIA l = db.LOAIDOCGIAs.Where(a => a.MaLoaiDocGia == int.Parse(maLoai)).FirstOrDefault();
                if(l != null)
                {
                    l.TinhTrangXoa = true;
                    db.SubmitChanges();
                    MessageBox.Show("Xoá thành công.");
                    return;
                }
                else
                {
                    MessageBox.Show("Xoá không thành công.");
                    return;
                }
            } 
            else
            {
                return;
            }    
        }

        public void suaLoaiDocGia(string maLoai, string tenLoai)
        {
            if (string.IsNullOrEmpty(maLoai))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để sửa.");
                return;
            }
            LOAIDOCGIA l = db.LOAIDOCGIAs.Where(a => a.MaLoaiDocGia == int.Parse(maLoai)).FirstOrDefault();
            if (l != null)
            {
                l.TenLoaiDocGia = tenLoai;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công.");
                return;
            }
            else
            {
                MessageBox.Show("Sửa không thành công.");
                return;
            }
        }
        public void reseedLoaiDocGia()
        {
            db.ExecuteCommand("DBCC CHECKIDENT('LOAIDOCGIA',RESEED,0)");
            
        }
        public IQueryable loadLoaiDocGia()
        {
            var ldg = from ldgs in db.LOAIDOCGIAs
                      where ldgs.TinhTrangXoa == false
                      select new { ldgs.MaLoaiDocGia, ldgs.TenLoaiDocGia };
            
            return ldg;
        }

        public bool xoaNganhs(string manganh)
        {
            NGANH nganh = db.NGANHs.Where(a => a.MaNganh == manganh).FirstOrDefault();
            if(nganh != null)
            {
                try
                {
                    db.NGANHs.DeleteOnSubmit(nganh);
                    db.SubmitChanges();
                }
                catch(Exception ex)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool suaNganh(string manganh, string tennganh, string makhoa)
        {
            NGANH nganh = db.NGANHs.Where(a => a.MaNganh == manganh).FirstOrDefault();
            if(nganh != null)
            {
                try
                {
                    nganh.TenNganh = tennganh;
                    nganh.MaKhoa = int.Parse(makhoa);
                    db.SubmitChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
