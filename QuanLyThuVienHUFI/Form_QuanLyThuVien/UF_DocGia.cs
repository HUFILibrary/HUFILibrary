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
    public partial class UF_DocGia : UserControl
    {
        string makhoa;
        string maloaidocgia;
        string mathethuvien;
        string DG_urlImage = "";
        string manganh = "";
        bool checkSelection = false;
        QuanLyKhoa qlk = new QuanLyKhoa();
        QuanLyDocGia qldg = new QuanLyDocGia();
        
        public UF_DocGia()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel14_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadComboboxLoaiDocGia()
        {
            DG_cboLoaiDG.DisplayMember = "TenLoaiDocGia";
            DG_cboLoaiDG.ValueMember = "MaLoaiDocGia";
            DG_cboLoaiDG.DataSource = qldg.loadLoaiDocGia();
            
        }
        private void loadDgvKhoas()
        {
            DG_K_dgvDSKhoa.DataSource = qlk.loadKhoas();
        }
        private void loadComboboxKhoas()
        {
            DG_N_cboTenKhoa.DisplayMember = "TenKhoa";
            DG_N_cboTenKhoa.ValueMember = "MaKhoa";
            DG_N_cboTenKhoa.DataSource = qlk.loadKhoas();
            
        }
        private void loadDgvDocGias()
        {
            DG_dgvDSDG.DataSource = qldg.loadDgvDocGia();
        }
        private void loadDgvLoaiDocGia()
        {
            dgvLoaiDocGia.DataSource = qldg.loadLoaiDocGia();
        }
        private void loadComboboxKhoa()
        {
            DG_cboKhoa.DisplayMember = "TenKhoa";
            DG_cboKhoa.ValueMember = "MaKhoa";
            DG_cboKhoa.DataSource = qlk.loadKhoas();
            
        }

        private void loadComboboxNganh()
        {
            string maKhoa = DG_cboKhoa.SelectedValue.ToString();
            DG_cboNganh.DisplayMember = "TenNganh";
            DG_cboNganh.ValueMember = "MaNganh";
            DG_cboNganh.DataSource = qlk.loadNganhByKhoa(maKhoa);
            
        }
        private void loadDgvNganh()
        {
            DG_N_dgvDSNganh.DataSource = qlk.loadDgvNganh();

        }
        
        private void UF_DocGia_Load(object sender, EventArgs e)
        {
            loadDgvKhoas();
            loadDgvLoaiDocGia();
            loadDgvDocGias();
            loadComboboxLoaiDocGia();
            loadComboboxKhoa();
            loadDgvNganh();
            loadComboboxNganh();
            loadComboboxKhoas();
            
            DG_btnLuu.Enabled = false;
            DG_K_btnLuu.Enabled = false;
            DG_N_btnLuu.Enabled = false;
            LDG_btnLuu.Enabled = false;
        }

        private void DG_K__btnThem_Click(object sender, EventArgs e)
        {
            DG_K_txtTenKhoa.Text = "";
            DG_K_txtTenKhoa.Focus();
            DG_K_btnXoa.Enabled = false;
            DG_K_btnSua.Enabled = false;
            DG_K_btnLuu.Enabled = true;

        }

        private void DG_K_btnXoa_Click(object sender, EventArgs e)
        {
            qlk.xoaKhoa(makhoa);
            loadDgvKhoas();
        }

        private void DG_K_btnSua_Click(object sender, EventArgs e)
        {
            qlk.suaKhoa(makhoa, DG_K_dgvDSKhoa.CurrentRow.Cells[0].Value.ToString());
            loadDgvKhoas();
        }

        private void DG_K_dgvDSKhoa_SelectionChanged(object sender, EventArgs e)
        {
            DG_K_txtTenKhoa.Text = DG_K_dgvDSKhoa.CurrentRow.Cells[1].Value.ToString();
            makhoa = DG_K_dgvDSKhoa.CurrentRow.Cells[0].Value.ToString();
        }

        private void LDG_btnThem_Click(object sender, EventArgs e)
        {
            LDG_btnXoa.Enabled = false;
            LDG_btnSua.Enabled = false;
            LDG_btnLuu.Enabled = true;
            txtTenLoaiDocGia.Text = "";
            txtTenLoaiDocGia.Focus();
        }

        private void LDG_btnXoa_Click(object sender, EventArgs e)
        {
            qldg.xoaLoaiDocGia(maloaidocgia);
            loadDgvLoaiDocGia();
        }

        private void dgvLoaiDocGia_SelectionChanged(object sender, EventArgs e)
        {
            maloaidocgia = dgvLoaiDocGia.CurrentRow.Cells[0].Value.ToString();
            txtTenLoaiDocGia.Text = dgvLoaiDocGia.CurrentRow.Cells[1].Value.ToString();
        }

        private void LDG_btnSua_Click(object sender, EventArgs e)
        {
            qldg.suaLoaiDocGia(maloaidocgia, txtTenLoaiDocGia.Text);
            loadDgvLoaiDocGia();
        }

        private void DG_btnThem_Click(object sender, EventArgs e)
        {
            DG_btnXoa.Enabled = false;
            DG_btnSua.Enabled = false;
            DG_btnLuu.Enabled = true;
            DG_txtMaThe.Enabled = true;
            clearText();
            DG_txtMaThe.Focus();

        }
        public void clearText()
        {
            DG_txtMaThe.Text = "";
            DG_txtTenDG.Text = "";
            DG_rdbNam.Checked = true;
            DG_txtSDT.Text = "";
            DG_txtCMND.Text = "";
            DG_txtEmail.Text = "";
            DG_txtDiaChi.Text = "";
            DG_rdbDangSD.Checked = true;

        }
        private void DG_btnXoa_Click(object sender, EventArgs e)
        {
            
            qldg.xoaDocGia(DG_txtMaThe.Text);
            loadDgvDocGias();
        }

        private void DG_btnSua_Click(object sender, EventArgs e)
        {
            DOCGIA dg = new DOCGIA();
            dg.MaTheThuVien = DG_txtMaThe.Text;
            dg.TenDocGia = DG_txtTenDG.Text;
            dg.MaLoaiDocGia = int.Parse(DG_cboLoaiDG.SelectedValue.ToString());
            dg.MaNganh = DG_cboNganh.SelectedValue.ToString();
            dg.CMND = DG_txtCMND.Text;
            dg.NgaySinh = DG_dtpNgaySinh.Value;
            string gioitinh = "";
            if (DG_rdbNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            dg.SoDienThoai = DG_txtSDT.Text;
            dg.DiaChi = DG_txtDiaChi.Text;
            dg.Email = DG_txtEmail.Text;
            dg.HanSuDungTheThuVien = DG_dtpHanSuDung.Value;
            bool tinhtrangthethuvien = false;
            if (DG_rdbDangSD.Checked)
            {
                tinhtrangthethuvien = false;
            }
            else
            {
                tinhtrangthethuvien = true;
            }
            dg.NgayLamThe = DG_dtpNgayLamThe.Value;

            dg.MatKhau = DG_txtMaThe.Text.ToString();
            dg.TinhTrangXoa = false;
            string hinhanh = "";
            if (!string.IsNullOrEmpty(DG_urlImage))
            {
                hinhanh = DG_urlImage;
            }
            qldg.suaDocGia(DG_txtMaThe.Text, DG_txtTenDG.Text, DG_cboLoaiDG.SelectedValue.ToString(), DG_cboNganh.SelectedValue.ToString(), DG_txtCMND.Text, DG_dtpNgaySinh.Value.ToString(), gioitinh,
                DG_txtSDT.Text, DG_txtDiaChi.Text, DG_txtEmail.Text, DG_dtpHanSuDung.Value.ToString(), tinhtrangthethuvien, DG_dtpNgayLamThe.Value.ToString(),
                hinhanh, DG_txtMaThe.Text.ToString());
            loadDgvDocGias();
        }

        private void DG_btnLuu_Click(object sender, EventArgs e)
        {
            DOCGIA dg = new DOCGIA();
            if(string.IsNullOrEmpty(DG_txtMaThe.Text) || string.IsNullOrEmpty(DG_txtTenDG.Text) ||
                string.IsNullOrEmpty(DG_txtCMND.Text) || DG_dtpNgaySinh.Value == null || string.IsNullOrEmpty(DG_txtSDT.Text) ||
                string.IsNullOrEmpty(DG_txtDiaChi.Text) || string.IsNullOrEmpty(DG_txtEmail.Text) || DG_dtpHanSuDung.Value == null ||
                DG_dtpNgayLamThe.Value == null || string.IsNullOrEmpty(DG_urlImage))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.");
                return;
            }    
            dg.MaTheThuVien = DG_txtMaThe.Text;
            dg.TenDocGia = DG_txtTenDG.Text;
            dg.MaLoaiDocGia = int.Parse(DG_cboLoaiDG.SelectedValue.ToString());
            dg.MaNganh = DG_cboNganh.SelectedValue.ToString();
            dg.CMND = DG_txtCMND.Text;
            dg.NgaySinh = DG_dtpNgaySinh.Value;
            string gioitinh = "";
            if(DG_rdbNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            dg.SoDienThoai = DG_txtSDT.Text;
            dg.DiaChi = DG_txtDiaChi.Text;
            dg.Email = DG_txtEmail.Text;
            dg.HanSuDungTheThuVien = DG_dtpHanSuDung.Value;
            bool tinhtrangthethuvien = false;
            if(DG_rdbDangSD.Checked)
            {
                tinhtrangthethuvien = false;
            }
            else
            {
                tinhtrangthethuvien = true;
            }
            dg.NgayLamThe = DG_dtpNgayLamThe.Value;
            string hinhanh = "";
            if(!string.IsNullOrEmpty(DG_urlImage))
            {
                hinhanh = DG_urlImage;
            }    
            dg.MatKhau = DG_txtMaThe.Text.ToString();
            dg.TinhTrangXoa = false;
            qldg.luuDocGia(DG_txtMaThe.Text, DG_txtTenDG.Text, DG_cboLoaiDG.SelectedValue.ToString(), DG_cboNganh.SelectedValue.ToString(), DG_txtCMND.Text, DG_dtpNgaySinh.Value.ToString(), gioitinh,
                DG_txtSDT.Text, DG_txtDiaChi.Text, DG_txtEmail.Text, DG_dtpHanSuDung.Value.ToString(), tinhtrangthethuvien, DG_dtpNgayLamThe.Value.ToString(),
                hinhanh, DG_txtMaThe.Text.ToString());
            loadDgvDocGias();
            DG_btnLuu.Enabled = false;
            DG_btnThem.Enabled = true;
            DG_btnSua.Enabled = true;
            DG_btnXoa.Enabled = true;
            DG_txtMaThe.Enabled = false;
        }

        private void DG_dgvDSDG_SelectionChanged(object sender, EventArgs e)
        {
            //DG_btnXoa.Enabled = true;
            //DG_btnSua.Enabled = true;
            //checkSelection = true;
            //DG_txtMaThe.Text = DG_dgvDSDG.CurrentRow.Cells[0].Value.ToString();
            //DG_txtTenDG.Text = DG_dgvDSDG.CurrentRow.Cells[4].Value.ToString();
            //DG_cboLoaiDG.Text = DG_dgvDSDG.CurrentRow.Cells[1].Value.ToString();
            //DG_cboNganh.Text = DG_dgvDSDG.CurrentRow.Cells[2].Value.ToString();
            //DG_cboKhoa.Text = DG_dgvDSDG.CurrentRow.Cells[3].Value.ToString();
            //DG_txtCMND.Text = DG_dgvDSDG.CurrentRow.Cells[5].Value.ToString();
            //DG_dtpNgaySinh.Value = Convert.ToDateTime(DG_dgvDSDG.CurrentRow.Cells[6].Value.ToString());
            //if (DG_dgvDSDG.CurrentRow.Cells[7].Value.ToString() == "Nam")
            //{
            //    DG_rdbNam.Checked = true;
            //}
            //else
            //{
            //    DG_rdbNu.Checked = true;
            //}
            //DG_txtSDT.Text = DG_dgvDSDG.CurrentRow.Cells[8].Value.ToString();
            //DG_txtDiaChi.Text = DG_dgvDSDG.CurrentRow.Cells[9].Value.ToString();
            //DG_txtEmail.Text = DG_dgvDSDG.CurrentRow.Cells[10].Value.ToString();
            //DG_dtpNgayLamThe.Value = Convert.ToDateTime(DG_dgvDSDG.CurrentRow.Cells[13].Value.ToString());
            //DG_dtpHanSuDung.Value = Convert.ToDateTime(DG_dgvDSDG.CurrentRow.Cells[11].Value.ToString());
            //if (DG_dgvDSDG.CurrentRow.Cells[12].Value.ToString() == "True")
            //{
            //    DG_rdbNgungSD.Checked = true;
            //}
            //else if(DG_dgvDSDG.CurrentRow.Cells[12].Value.ToString() == "False")
            //{
            //    DG_rdbDangSD.Checked = true;
            //}
            //if(!string.IsNullOrEmpty(DG_dgvDSDG.CurrentRow.Cells[16].Value.ToString()))
            //{
            //    string path = System.IO.Path.GetFullPath("..\\..\\..\\");
            //    path += "Images\\DocGia\\";
            //    string urlImage = path + DG_dgvDSDG.CurrentRow.Cells[16].Value.ToString();
            //    using (FileStream stream = new FileStream(urlImage, FileMode.Open, FileAccess.Read))
            //    {
            //        DG_pbAvatar.Image = new Bitmap(urlImage);
            //    }
                
            //}
        }

        private void DG_cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkSelection == true)
            {
                //DG_cboNganh.DisplayMember = "TenNganh";
                //DG_cboNganh.ValueMember = "MaNganh";
                //DG_cboNganh.DataSource = qldg.loadComboboxNganhByKhoa(DG_cboKhoa.SelectedValue.ToString(), );
                //checkSelection = false;
                checkSelection = false;
                return;
            }    
            else
            {
                DG_cboNganh.DisplayMember = "TenNganh";
                DG_cboNganh.ValueMember = "MaNganh";
                DG_cboNganh.DataSource = qldg.loadComboboxNganh(DG_cboKhoa.SelectedValue.ToString());
                checkSelection = false;
            }
            
        }

        private void DG_cboKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void LDG_btnLuu_Click(object sender, EventArgs e)
        {
            qldg.themLoaiDocGia(txtTenLoaiDocGia.Text);
            loadDgvLoaiDocGia();
            LDG_btnThem.Enabled = false;
        }

        private void DG_K_btnLuu_Click(object sender, EventArgs e)
        {
            qlk.themKhoa(DG_K_txtTenKhoa.Text);
            loadDgvKhoas();
            loadComboboxKhoas();
            DG_K_btnLuu.Enabled = false;
        }

        private void DG_N_btnThem_Click(object sender, EventArgs e)
        {
            DG_N_txtMaNganh.Text = "";
            DG_N_txtTenNganh.Text = "";
            DG_N_btnSua.Enabled = false;
            DG_N_btnXoa.Enabled = false;
            DG_N_btnLuu.Enabled = true;
            DG_N_txtMaNganh.Focus();
        }

        private void DG_N_dgvDSNganh_SelectionChanged(object sender, EventArgs e)
        {
            DG_N_txtMaNganh.Text = DG_N_dgvDSNganh.CurrentRow.Cells[0].Value.ToString();
            DG_N_txtTenNganh.Text = DG_N_dgvDSNganh.CurrentRow.Cells[1].Value.ToString();
            DG_N_cboTenKhoa.Text = DG_N_dgvDSNganh.CurrentRow.Cells[2].Value.ToString();
        }

        private void DG_N_btnLuu_Click(object sender, EventArgs e)
        {
            qlk.themNganh(DG_N_txtMaNganh.Text,DG_N_txtTenNganh.Text, DG_N_cboTenKhoa.SelectedValue.ToString());
            loadDgvNganh();
            DG_N_btnSua.Enabled = true;
            DG_N_btnXoa.Enabled = true;
            DG_N_btnLuu.Enabled = false;
        }

        private void DG_N_cboTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DG_N_dgvDSNganh.DataSource = qlk.loadNganhByKhoa(DG_N_cboTenKhoa.SelectedValue.ToString());

        }

        private void DG_btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            fd.Multiselect = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                var fileName = fd.FileName;
                DG_pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                DG_pbAvatar.Image = new Bitmap(fd.FileName);
                DG_urlImage = fd.FileName;
                fd.Dispose();
            }
            
        }

        private void DG_dtpHanSuDung_Click(object sender, EventArgs e)
        {
            
        }

        private void DG_cboKhoa_Click(object sender, EventArgs e)
        {
            
        }

        private void DG_cboKhoa_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void DG_cboLoaiDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DG_cboLoaiDG.SelectedValue != null)
            {
                if(DG_cboLoaiDG.SelectedValue.ToString() == "3")
                {
                    DG_cboKhoa.Enabled = false;
                    DG_cboNganh.Enabled = false;
                    DG_cboKhoa.SelectedValue = 8;
                    qldg.loadComboboxNganh("8");
                    
                }
                else
                {
                    DG_cboKhoa.Enabled = true;
                    DG_cboNganh.Enabled = true;
                }    
            }    
        }

        private void DG_dgvDSDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DG_btnXoa.Enabled = true;
            DG_btnSua.Enabled = true;
            checkSelection = true;
            DG_txtMaThe.Text = DG_dgvDSDG.CurrentRow.Cells[0].Value.ToString();
            DG_txtTenDG.Text = DG_dgvDSDG.CurrentRow.Cells[4].Value.ToString();
            DG_cboLoaiDG.Text = DG_dgvDSDG.CurrentRow.Cells[1].Value.ToString();
            DG_cboNganh.Text = DG_dgvDSDG.CurrentRow.Cells[2].Value.ToString();
            DG_cboKhoa.Text = DG_dgvDSDG.CurrentRow.Cells[3].Value.ToString();
            DG_txtCMND.Text = DG_dgvDSDG.CurrentRow.Cells[5].Value.ToString();
            DG_dtpNgaySinh.Value = Convert.ToDateTime(DG_dgvDSDG.CurrentRow.Cells[6].Value.ToString());
            if (DG_dgvDSDG.CurrentRow.Cells[7].Value.ToString() == "Nam")
            {
                DG_rdbNam.Checked = true;
            }
            else
            {
                DG_rdbNu.Checked = true;
            }
            DG_txtSDT.Text = DG_dgvDSDG.CurrentRow.Cells[8].Value.ToString();
            DG_txtDiaChi.Text = DG_dgvDSDG.CurrentRow.Cells[9].Value.ToString();
            DG_txtEmail.Text = DG_dgvDSDG.CurrentRow.Cells[10].Value.ToString();
            DG_dtpNgayLamThe.Value = Convert.ToDateTime(DG_dgvDSDG.CurrentRow.Cells[13].Value.ToString());
            DG_dtpHanSuDung.Value = Convert.ToDateTime(DG_dgvDSDG.CurrentRow.Cells[11].Value.ToString());
            if (DG_dgvDSDG.CurrentRow.Cells[12].Value.ToString() == "True")
            {
                DG_rdbNgungSD.Checked = true;
            }
            else if (DG_dgvDSDG.CurrentRow.Cells[12].Value.ToString() == "False")
            {
                DG_rdbDangSD.Checked = true;
            }
            if (!string.IsNullOrEmpty(DG_dgvDSDG.CurrentRow.Cells[16].Value.ToString()))
            {
                string path = System.IO.Path.GetFullPath("..\\..\\..\\");
                path += "Images\\DocGia\\";
                string urlImage = path + DG_dgvDSDG.CurrentRow.Cells[16].Value.ToString();
                using (FileStream stream = new FileStream(urlImage, FileMode.Open, FileAccess.Read))
                {
                    DG_pbAvatar.Image = new Bitmap(urlImage);
                }

            }
        }

        private void DG_N_btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn xoá?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }    
            bool flg = qldg.xoaNganhs(DG_N_dgvDSNganh.CurrentRow.Cells[0].Value.ToString());
            if(flg)
            {
                MessageBox.Show("Xoá thành công.");
                loadDgvNganh();
            }
            else
            {
                MessageBox.Show("Xoá không thành công.");
                return;
            }    
        }

        private void DG_N_btnSua_Click(object sender, EventArgs e)
        {

            bool flg = qldg.suaNganh(DG_N_dgvDSNganh.CurrentRow.Cells[0].Value.ToString(), DG_N_dgvDSNganh.CurrentRow.Cells[2].Value.ToString(), DG_N_dgvDSNganh.CurrentRow.Cells[2].Value.ToString());
            if (flg)
            {
                MessageBox.Show("Sửa thành công.");
            }
            else
            {
                MessageBox.Show("Sửa không thành công.");
                return;
            }
        }
    }
}
