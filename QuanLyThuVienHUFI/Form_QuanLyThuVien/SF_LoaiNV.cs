using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
namespace Form_QuanLyThuVien
{
    public partial class SF_LoaiNV : Form
    {
        QuanLyLoaiNhanVien qllnv = new QuanLyLoaiNhanVien();
        UF_NhanVien ufNV = new UF_NhanVien();
        public SF_LoaiNV()
        {
            InitializeComponent();
        }
        
        private void LNV_btnThem_Click(object sender, EventArgs e)
        {
            LNV_txtTenLNV.Text = "";
            LNV_txtTenLNV.Focus();
            LNV_btnLuu.Enabled = true;
            LNV_btnXoa.Enabled = false;
            LNV_btnSua.Enabled = false;
        }

        private void LNV_btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int malnv = int.Parse(LNV_DgvDSLoai.CurrentRow.Cells[0].Value.ToString());
            if (rs == DialogResult.Yes)
            {
                qllnv.xoaLoaiNV(malnv);
                loadDgvDSLoaiNV();
                MessageBox.Show("Xóa thành công !");
                ufNV.loadCboLoaiNV();
            }
            else {
                MessageBox.Show("Xóa thất bại !");
            }
        }

        private void LNV_btnSua_Click(object sender, EventArgs e)
        {

            int malnv = int.Parse(LNV_DgvDSLoai.CurrentRow.Cells[0].Value.ToString());
            if (ufNV.ktraTxtNull(LNV_txtTenLNV) == false)
            {
                MessageBox.Show("Phải nhập tên loại nhân viên");
            }
            else {
                if (qllnv.suaLoaiNV(malnv,LNV_txtTenLNV.Text))
                {
                    loadDgvDSLoaiNV();
                    MessageBox.Show("Sửa thành công !");
                    ufNV.loadCboLoaiNV();

                }
                else { MessageBox.Show("Sửa thất bại !"); }
            }
        }

        private void LNV_btnLuu_Click(object sender, EventArgs e)
        {
            LOAINHANVIEN lnv = new LOAINHANVIEN();
            lnv.TenLoaiNhanVien = LNV_txtTenLNV.Text;
            lnv.TinhTrangXoa = false;
            lnv.MaLoaiNhanVien = int.Parse(LNV_DgvDSLoai.CurrentRow.Cells[0].Value.ToString());

          
               
                if (qllnv.themLoaiNV(lnv))
                {
                    MessageBox.Show("Thêm thành công !");
                    loadDgvDSLoaiNV();
                    ufNV.loadCboLoaiNV();
            }
        }

        private void LNV_DgvDSLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            LNV_btnSua.Enabled = true;
            LNV_btnXoa.Enabled = true;
            LNV_btnLuu.Enabled = false;
            LNV_txtTenLNV.Text = LNV_DgvDSLoai.Rows[e.RowIndex].Cells[1].Value.ToString();
            

        }

        private void SF_LoaiNV_Load(object sender, EventArgs e)
        {
            loadDgvDSLoaiNV();
            LNV_btnLuu.Enabled = false;
            LNV_btnSua.Enabled = false;
            LNV_btnXoa.Enabled = false;
        }
        void loadDgvDSLoaiNV() {
            LNV_DgvDSLoai.DataSource = qllnv.loadDSLoaiNV();
        }
    }
}
