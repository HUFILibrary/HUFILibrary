using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
namespace Form_QuanLyThuVien
{
    public partial class UF_NhanVien : UserControl
    {
        QuanLyNhanVien qlnv = new QuanLyNhanVien();
        public UF_NhanVien()
        {
            InitializeComponent();
        }
        string urlNhanVien;
        private void NV_btnEditLoaiNV_Click(object sender, EventArgs e)
        {
            SF_LoaiNV loainv = new SF_LoaiNV();
            loainv.ShowDialog();
            loadCboLoaiNV();
        }

        private void UF_NhanVien_Load(object sender, EventArgs e)
        {
            loadDgvNhanVien();
            loadCboLoaiNV();
            if (NV_dgvDSNV.Rows.Count > 0)
            {
                NV_dgvDSNV.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                NV_dgvDSNV.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                NV_dgvDSNV.Columns[6].MinimumWidth = 150;
                NV_dgvDSNV.Columns[7].MinimumWidth = 200;
            }

        }
        void loadDgvNhanVien()
        {
            NV_dgvDSNV.DataSource = qlnv.loadDsNhanVien();
            NV_btnXoaNV.Enabled = false;
            NV_btnSuaNV.Enabled = false;
            NV_btnLuuNV.Enabled = false;

            //NV_cboLoaiNV.Enabled = false;
            //NV_dtpNgaySinh.Enabled = false;
            //NV_dtpNgayVL.Enabled = false;

            //NV_rdbNam.Enabled = false;
            //NV_rdbNu.Enabled = false;
            NV_txtCMND.Enabled = false;
            //NV_txtDiaChi.Enabled = false;
            //NV_txtMKNV.Enabled = false;
            //NV_txtSDT.Enabled = false;
            //NV_txtTenNV.Enabled = false;
            //NV_rdbDangHD.Enabled = false;
            //NV_rdbNgungHD.Enabled = false;
            


        }
        public void loadCboLoaiNV() {
            NV_cboLoaiNV.DisplayMember = "TenLoaiNhanVien";
            NV_cboLoaiNV.ValueMember = "MaLoaiNhanVien";
            NV_cboLoaiNV.DataSource = qlnv.loadDsLoaiNV();
        }

        private void NV_btnThemNV_Click(object sender, EventArgs e)
        {
            NV_btnLuuNV.Enabled = true;
            NV_btnXoaNV.Enabled = false;
            NV_btnSuaNV.Enabled = false;

            NV_txtCMND.Enabled = true;
            NV_txtCMND.Text = "";
            NV_txtDiaChi.Text = "";
            NV_txtMKNV.Text = "";
            NV_txtSDT.Text = "";
            NV_txtTenNV.Text = "";
            NV_txtTenNV.Focus();
        }

        private void NV_dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NV_cboLoaiNV.Text = NV_dgvDSNV.Rows[e.RowIndex].Cells[9].Value.ToString();
            NV_dtpNgaySinh.Value = DateTime.Parse(NV_dgvDSNV.Rows[e.RowIndex].Cells[1].Value.ToString());
            NV_dtpNgayVL.Value = DateTime.Parse(NV_dgvDSNV.Rows[e.RowIndex].Cells[6].Value.ToString());

            string gtinh = NV_dgvDSNV.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (gtinh == "Nam")
            {
                NV_rdbNam.Checked = true;
            }
            else {
                NV_rdbNu.Checked = true;
            }
            NV_txtCMND.Text = NV_dgvDSNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            NV_txtDiaChi.Text = NV_dgvDSNV.Rows[e.RowIndex].Cells[5].Value.ToString();
            NV_txtMKNV.Text = NV_dgvDSNV.Rows[e.RowIndex].Cells[8].Value.ToString();
            NV_txtSDT.Text = NV_dgvDSNV.Rows[e.RowIndex].Cells[3].Value.ToString();
            NV_txtTenNV.Text = NV_dgvDSNV.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tttk = NV_dgvDSNV.Rows[e.RowIndex].Cells[7].Value.ToString();
            if (tttk == "True")
            {
                NV_rdbDangHD.Checked = true;
            }
            else {
                NV_rdbNgungHD.Checked = true;
            }
            string path;
            if (!string.IsNullOrEmpty(NV_dgvDSNV.Rows[e.RowIndex].Cells[11].Value.ToString()))
            {
                path = System.IO.Path.GetFullPath("..\\..\\..\\");
                path += "Images\\NhanVien\\";
                string urlImage = path + NV_dgvDSNV.Rows[e.RowIndex].Cells[11].Value.ToString();
                using (FileStream stream = new FileStream(urlImage, FileMode.Open, FileAccess.Read))
                {
                    NV_ptbAvatar.Image = new Bitmap(urlImage);
                }
            }
            else {
                path = System.IO.Path.GetFullPath("..\\..\\..\\");
                path += "Images\\NhanVien\\";
                using (FileStream stream = new FileStream(path+"defaul.png", FileMode.Open, FileAccess.Read))
                {
                    NV_ptbAvatar.Image = new Bitmap(path + "defaul.png");
                }
            }
            NV_btnEditLoaiNV.Enabled = true;

            NV_btnXoaNV.Enabled = true;
            NV_btnSuaNV.Enabled = true;
            NV_btnLuuNV.Enabled = false;


        }

        private void NV_btnXoaNV_Click(object sender, EventArgs e)
        {

            int manv = int.Parse(NV_dgvDSNV.CurrentRow.Cells[10].Value.ToString());
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                qlnv.xoaNhanVien(manv);
                loadDgvNhanVien();
                MessageBox.Show("Xóa thành công !");
            }
            else {
                MessageBox.Show("Xóa thất bại !");
            }
        }

        private void NV_btnLuuNV_Click(object sender, EventArgs e)
        {
            NHANVIEN nvm = new NHANVIEN();
            nvm.TenNhanVien = NV_txtTenNV.Text;
            nvm.MatKhau = NV_txtMKNV.Text;
            nvm.MaLoaiNhanVien = int.Parse(NV_cboLoaiNV.SelectedValue.ToString());
            nvm.SoDienThoai = NV_txtSDT.Text;
            nvm.CMND = NV_txtCMND.Text;
            nvm.NgayVaoLam = NV_dtpNgayVL.Value;
            nvm.TinhTrangXoa = false;
            if (NV_rdbNam.Checked)
            {
                nvm.GioiTinh = NV_rdbNam.Text;
            }
            else {
                nvm.GioiTinh = NV_rdbNu.Text;
            }
            nvm.NgaySinh = NV_dtpNgaySinh.Value;
            if (NV_rdbDangHD.Checked)
            {
                nvm.TinhTrangTK = true;
            }
            else { nvm.TinhTrangTK = false; }
            nvm.DiaChi = NV_txtDiaChi.Text;
            nvm.HinhAnh = urlNhanVien;
            if (ktraTxtNull(NV_txtTenNV) == false)
            {
                MessageBox.Show("Họ tên không được bỏ trống !");
            }
            else if (ktraTxtChuaChu(NV_txtTenNV) == false)
            {
                MessageBox.Show("Tên chỉ chứa chữ cái !");
            }
            else if (ktraTxtNull(NV_txtMKNV) == false)
            {
                MessageBox.Show("Mật khẩu không được bỏ trống");
            }
            else if (ktraTxtChuaSo(NV_txtSDT) == false || NV_txtSDT.TextLength != 10)
            {
                MessageBox.Show("Số điện thoại chỉ chứa số và bao gồm 10 chữ số !");
            }
            else if (ktraTxtChuaSo(NV_txtCMND) == false || NV_txtCMND.TextLength != 12)
            {
                MessageBox.Show("CMND chỉ chứa số và bao gồm 12 chữ số !");
            }
            else if (NV_rdbNam.Checked == false && NV_rdbNu.Checked == false)
            {
                MessageBox.Show("Phải chọn giới tính !");
            }
            else if (ktraTxtNull(NV_txtDiaChi) == false)
            {
                MessageBox.Show("Địa chỉ không được bỏ trống !");
            }
            else if (NV_rdbDangHD.Checked == false && NV_rdbNgungHD.Checked == false)
            {
                MessageBox.Show("Phải chọn tình trạng tài khoản !");
            }
            else if (tinhKhCachNam(NV_dtpNgaySinh.Value, NV_dtpNgayVL.Value, 18) == 0)
            {
                MessageBox.Show("Ngày sinh hoặc ngày vào làm không hợp lệ ! Phải trên 18 tuổi mới được vào làm !");
            }
            else if (string.IsNullOrEmpty(urlNhanVien))
            {
                MessageBox.Show("Vui lòng chọn hình ảnh");
            } else
            {
                if (qlnv.themNhanVien(nvm))
                {
                    loadDgvNhanVien();
                    MessageBox.Show("Thêm thành công !");

                }
                else
                {
                    MessageBox.Show("Thêm thất bại !");
                }
            }

            
        }
        public bool ktraTxtNull(Control ctrl)
        {
            if (string.IsNullOrEmpty(ctrl.Text))
            {
                return false;
            }
            else { return true; }

        }
        public bool ktraTxtChuaSo(Control ctrl)
        {
            foreach (char c in ctrl.Text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public bool ktraTxtChuaChu(Control ctrl)
        {
            foreach (char c in ctrl.Text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }

        public int tinhKhCachNam(DateTime dt1, DateTime dt2, int sonam)
        {
            //dt1 ngay sinh
            //dt2 ngay vao lam
            //neu ngay sinh + 18 > ngay vao lam => false
            //1999+18 >2020
            DateTime kqua = dt1.AddYears(sonam);

            if (kqua > dt2)
            {
                return 0;
            }
            return 1;

        }

        private void NV_btnSuaNV_Click(object sender, EventArgs e)
        {
            NHANVIEN nvm = new NHANVIEN();
            nvm.MaNhanVien = int.Parse(NV_dgvDSNV.CurrentRow.Cells[10].Value.ToString());
            nvm.TenNhanVien = NV_txtTenNV.Text;
            nvm.MatKhau = NV_txtMKNV.Text;
            nvm.MaLoaiNhanVien = int.Parse(NV_cboLoaiNV.SelectedValue.ToString());
            nvm.SoDienThoai = NV_txtSDT.Text;
            nvm.CMND = NV_txtCMND.Text;
            nvm.NgayVaoLam = NV_dtpNgayVL.Value;
            nvm.TinhTrangXoa = false;
            if (NV_rdbNam.Checked)
            {
                nvm.GioiTinh = NV_rdbNam.Text;
            }
            else
            {
                nvm.GioiTinh = NV_rdbNu.Text;
            }
            nvm.NgaySinh = NV_dtpNgaySinh.Value;
            if (NV_rdbDangHD.Checked)
            {
                nvm.TinhTrangTK = true;
            }
            else { nvm.TinhTrangTK = false; }
            nvm.DiaChi = NV_txtDiaChi.Text;
            nvm.HinhAnh = urlNhanVien;

            if (ktraTxtNull(NV_txtTenNV) == false)
            {
                MessageBox.Show("Họ tên không được bỏ trống !");
            }
            else if (ktraTxtChuaChu(NV_txtTenNV) == false)
            {
                MessageBox.Show("Tên chỉ chứa chữ cái !");
            }
            else if (ktraTxtNull(NV_txtMKNV) == false)
            {
                MessageBox.Show("Mật khẩu không được bỏ trống");
            }
            else if (ktraTxtChuaSo(NV_txtSDT) == false ||  NV_txtSDT.TextLength > 10 || NV_txtSDT.TextLength < 10)
            {
                MessageBox.Show("CMND chỉ chứa số và bao gồm 12 chữ số !");
            }
            else if (ktraTxtNull(NV_txtDiaChi) == false)
            {
                MessageBox.Show("Địa chỉ không được bỏ trống");
            }
            else if(tinhKhCachNam(NV_dtpNgaySinh.Value,NV_dtpNgayVL.Value,18) == 0)
            {
                MessageBox.Show("Ngày sinh hoặc ngày vào làm không hợp lệ ! Phải trên 18 tuổi mới được vào làm !");       
            }
            else {
                if (qlnv.suaNhanVien(nvm))
                {
                    loadDgvNhanVien();
                    MessageBox.Show("Sửa thành công !");
                    
                }
                else {
                    MessageBox.Show("Sửa thất bại !");
                }
            }
        }

        private void NV_btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            fd.Multiselect = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                var fileName = fd.FileName;
                NV_ptbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                NV_ptbAvatar.Image = new Bitmap(fd.FileName);
                urlNhanVien = fd.FileName;
                fd.Dispose();
            }
        }
    }
}
