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
    public partial class UF_PhanQuyen : UserControl
    {
        PhanQuyen pq = new PhanQuyen();
        public UF_PhanQuyen()
        {
            InitializeComponent();
            loadDgvManHinh();
        }
        public void loadDgvManHinh()
        {
            PQ_MH_dgvManHinh.DataSource = pq.loadDgvManHinhs();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PQ_MH_txtMaManHinh.Clear();
            PQ_MH_txtTenManHinh.Clear();
            PQ_MH_btnXoa.Enabled = false;
            PQ_MH_btnSua.Enabled = false;
            PQ_MH_btnLuu.Enabled = true;
            PQ_MH_btnThem.Enabled = true;
            PQ_MH_txtMaManHinh.Enabled = true;
        }

        private void UF_PhanQuyen_Load(object sender, EventArgs e)
        {
            loadDgvManHinh();
            loadDgvPhanQuyen();
        }

        private void PQ_MH_dgvManHinh_SelectionChanged(object sender, EventArgs e)
        {
            PQ_MH_txtMaManHinh.Text = PQ_MH_dgvManHinh.CurrentRow.Cells["MaManHinh"].Value.ToString();
            PQ_MH_txtTenManHinh.Text = PQ_MH_dgvManHinh.CurrentRow.Cells["TenManHinh"].Value.ToString();
            PQ_MH_btnXoa.Enabled = true;
            PQ_MH_btnSua.Enabled = true;
            PQ_MH_txtMaManHinh.Enabled = false;
        }

        private void PQ_MH_btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(PQ_MH_txtTenManHinh.Text) || string.IsNullOrEmpty(PQ_MH_txtMaManHinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.");
                return;
            }
            bool flg = pq.themManHinh(PQ_MH_txtMaManHinh.Text, PQ_MH_txtTenManHinh.Text);
            if(flg)
            {
                MessageBox.Show("Thêm màn hình thành công.");
                loadDgvManHinh();

            }
            else
            {
                MessageBox.Show("Thêm màn hình không thành công.");
                return;
            }

            PQ_MH_btnLuu.Enabled = false;
            PQ_MH_txtMaManHinh.Enabled = false;
        }

        private void PQ_MH_dgvManHinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PQ_MH_btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xoá?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }    
            bool flg = pq.xoaManHinh(PQ_MH_dgvManHinh.CurrentRow.Cells["MaManHinh"].Value.ToString());
            if(flg)
            {
                MessageBox.Show("Xoá màn hình thành công.");
            }
            else
            {
                MessageBox.Show("Xoá màn hình không thành công.");
                return;
            }
            loadDgvManHinh();
        }

        private void PQ_MH_btnSua_Click(object sender, EventArgs e)
        {
            bool flg = pq.suaManHinh(PQ_MH_txtMaManHinh.Text, PQ_MH_txtTenManHinh.Text);
            if (flg)
            {
                MessageBox.Show("Sửa màn hình thành công.");
            }
            else
            {
                MessageBox.Show("Sửa màn hình không thành công.");
                return;
            }
            loadDgvManHinh();
        }

        private void QLPQ_dgvPhanQuyen_SelectionChanged(object sender, EventArgs e)
        {
            QPPQ_txtNhomTK.Text = QLPQ_dgvPhanQuyen.CurrentRow.Cells["PQ_MaLoaiNhanVien"].Value.ToString();
            QLPQ_txtMaMH.Text = QLPQ_dgvPhanQuyen.CurrentRow.Cells["PQ_MaManHinh"].Value.ToString();
            if(QLPQ_dgvPhanQuyen.CurrentRow.Cells["PQ_CoQuyen"].Value.ToString() == "True")
            {
                QLPQ_chkQuyen.Checked = true;
            }
            else if(QLPQ_dgvPhanQuyen.CurrentRow.Cells["PQ_CoQuyen"].Value.ToString() == "False")
            {
                QLPQ_chkQuyen.Checked = false;
            }
        }
        public void loadDgvPhanQuyen()
        {
            QLPQ_dgvPhanQuyen.DataSource = pq.loadDgvPhanQuyen();
        }
        private void QLPQ_btnSua_Click(object sender, EventArgs e)
        {
            bool coquyen = false;
            if(QLPQ_chkQuyen.Checked)
            {
                coquyen = true;
            }
            else
            {
                coquyen = false;
            }
            bool flg = pq.suaPhanQuyen(QPPQ_txtNhomTK.Text, QLPQ_txtMaMH.Text, coquyen);
            if(flg)
            {
                MessageBox.Show("Sửa phân quyền thành công.");
            }
            else
            {
                MessageBox.Show("Sửa phân quyền không thành công.");
                return;
            }
            loadDgvPhanQuyen();
        }
    }
}
