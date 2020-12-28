using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class QuanLyKhoa
    {
        DB_QLTVDataContext db = new DB_QLTVDataContext();
        public void themKhoa(string tenKhoa)
        {
            if (string.IsNullOrEmpty(tenKhoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để thêm.");
                return;
            }
            KHOA newKhoa = new KHOA();
            newKhoa.TenKhoa = tenKhoa;
            newKhoa.TinhTrangXoa = false;
            try
            {
                db.KHOAs.InsertOnSubmit(newKhoa);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công.");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công.");
            }
        }
        public void themNganh(string manganh, string tennganh, string makhoa)
        {
            if (string.IsNullOrEmpty(tennganh) || string.IsNullOrEmpty(manganh) || string.IsNullOrEmpty(makhoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để thêm.");
                return;
            }
            NGANH newNganh = new NGANH();
            newNganh.TenNganh = tennganh;
            newNganh.MaNganh = manganh;
            newNganh.MaKhoa = int.Parse(makhoa);
            try
            {
                db.NGANHs.InsertOnSubmit(newNganh);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công.");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công.");
            }
        }

        public void xoaKhoa(string maKhoa)
        {
            if(string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để xoá.");
                return;
            }
            if(MessageBox.Show("Bạn có muốn xoá?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                KHOA delItem = db.KHOAs.Where(a => a.MaKhoa == int.Parse(maKhoa)).FirstOrDefault();
                if (delItem != null)
                {
                    delItem.TinhTrangXoa = true;
                    db.SubmitChanges();
                    MessageBox.Show("Xoá thành công.");
                    return;
                }
                else
                {
                    MessageBox.Show("Dữ liệu không tồn tại.");
                    return;
                }
            }    
            else
            {
                return;
            }    
            

        }
        public void xoaNganh(string maNganh)
        {
            if (string.IsNullOrEmpty(maNganh))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để xoá.");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                NGANH delItem = db.NGANHs.Where(a => a.MaNganh == maNganh).FirstOrDefault();
                if (delItem != null)
                {
                    db.NGANHs.DeleteOnSubmit(delItem);
                    db.SubmitChanges();
                    MessageBox.Show("Xoá thành công.");
                    return;
                }
                else
                {
                    MessageBox.Show("Dữ liệu không tồn tại.");
                    return;
                }
            }
            else
            {
                return;
            }


        }
        public IQueryable loadNganhByKhoa(string maKhoa)
        {
            var nganhs = from nganh in db.NGANHs
                         join khoa in db.KHOAs on nganh.MaKhoa equals khoa.MaKhoa
                         where (nganh.MaKhoa == int.Parse(maKhoa)) && (khoa.TinhTrangXoa == false)
                         select new { nganh.MaNganh,nganh.TenNganh,khoa.MaKhoa,khoa.TenKhoa };
            return nganhs;
        }
        public IQueryable loadDgvNganh()
        {
            var nganhs = from nganh in db.NGANHs
                         join khoa in db.KHOAs on nganh.MaKhoa equals khoa.MaKhoa
                         where (khoa.TinhTrangXoa == false)
                         select new { nganh.MaNganh,nganh.TenNganh,khoa.MaKhoa,khoa.TenKhoa };
            return nganhs;
        }
        public void suaKhoa(string maKhoa, string tenKhoa)
        {
            if (string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để sửa.");
                return;
            }
            KHOA suaKhoa = db.KHOAs.Where(a => a.MaKhoa == int.Parse(maKhoa)).FirstOrDefault();
            if(suaKhoa != null)
            {
                suaKhoa.TenKhoa = tenKhoa;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công.");
                return;
            }
            else
            {
                MessageBox.Show("Dữ liệu không tồn tại.");
                return;
            }    
        }

        public void suaNganh(string manganh, string tennganh, string makhoa)
        {
            if (string.IsNullOrEmpty(tennganh) || string.IsNullOrEmpty(manganh) || string.IsNullOrEmpty(makhoa))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để sửa.");
                return;
            }
            NGANH suaNganh = db.NGANHs.Where(a => a.MaNganh == manganh).FirstOrDefault();
            if (suaNganh != null)
            {
                suaNganh.TenNganh = tennganh;
                suaNganh.MaKhoa = int.Parse(makhoa);
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công.");
                return;
            }
            else
            {
                MessageBox.Show("Dữ liệu không tồn tại.");
                return;
            }
        }

        public IQueryable loadKhoas()
        {
            var khoas = from khoa in db.KHOAs
                        where khoa.TinhTrangXoa == false
                        select new { khoa.MaKhoa,khoa.TenKhoa };
            return khoas;
        }

       
    }
}
