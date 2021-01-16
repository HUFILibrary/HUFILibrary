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
    public partial class UF_PHIEU : UserControl
    {
        QuanLyTaiLieu qltl = new QuanLyTaiLieu();
        QuanLyPhieuMuon qlpm = new QuanLyPhieuMuon();
        
        PHIEUNHAP phieunhap = new PHIEUNHAP();
        QuanLyPhieuNhap qlpn = new QuanLyPhieuNhap();
        PhanQuyen pq = new PhanQuyen();
        List<CT_PHIEUNHAP> dsCTPN = new List<CT_PHIEUNHAP>();
        List<TAILIEU> dsTL = new List<TAILIEU>();
        public static string manhanvien = "";
        string TL_urlImage = "";


        QuanLyPhieuTra qlpt = new QuanLyPhieuTra();
        QuanLyPhieuXLVP qlvp = new QuanLyPhieuXLVP();
        public UF_PHIEU()
        {
            InitializeComponent();
            chk_enableText();
        }
        private void loadComboboxVitris()
        {
            QLP_N_cboVitri.DisplayMember = "MaViTri";
            QLP_N_cboVitri.ValueMember = "MaViTri";
            QLP_N_cboVitri.DataSource = qltl.loadMaViTri();
        }
        private void loadComboboxChuDes()
        {
            QLP_N_cboChuDe.DisplayMember = "TenChuDe";
            QLP_N_cboChuDe.ValueMember = "MaChuDe";
            QLP_N_cboChuDe.DataSource = qltl.loadChudes();
        }
        private void loadComboboxNgonNgus()
        {
            QLP_N_cboNgonNgu.DisplayMember = "TenNgonNgu";
            QLP_N_cboNgonNgu.ValueMember = "MaNgonNgu";
            QLP_N_cboNgonNgu.DataSource = qltl.loadNgonNgus();
        }
        private void loadComboboxTacGias()
        {
            QLP_N_cboTacGia.DisplayMember = "TenTacGia";
            QLP_N_cboTacGia.ValueMember = "MaTacGia";
            QLP_N_cboTacGia.DataSource = qltl.loadTacGias();
        }
        private void loadComboboxNXBs()
        {
            QLP_N_cboNhaXB.DisplayMember = "TenNhaXuatBan";
            QLP_N_cboNhaXB.ValueMember = "MaNhaXuatBan";
            QLP_N_cboNhaXB.DataSource = qltl.loadNXBs();
        }
        private void loadComboboxLoaiTaiLieus()
        {
            QLP_N_cboLoaiTL.DisplayMember = "TenLoaiTaiLieu";
            QLP_N_cboLoaiTL.ValueMember = "MaLoaiTaiLieu";
            QLP_N_cboLoaiTL.DataSource = qltl.loadLoaiTaiLieus();
        }
        public void phanQuyen()
        {
            foreach(TabPage tab in tabControl1.TabPages)
            {
                foreach(PHANQUYEN pq in pq.getPhanQuyens(Frm_Main.username))
                {
                    if (tab.Tag.ToString() == pq.MaManHinh)
                    {
                        if(pq.CoQuyen == false)
                        {
                            ((Control)tab).Enabled = false;
                        }    
                    }    
                }    
                
            }    
        }
        private void UF_PHIEU_Load(object sender, EventArgs e)
        {

            phanQuyen();
            chk_enableText();
            loadComboboxVitris();
            loadComboboxLoaiTaiLieus();
            loadComboboxNXBs();
            loadComboboxTacGias();
            loadComboboxNgonNgus();
            loadComboboxChuDes();
            loadDgvPhieuNhaps();
            loadComboboxNhaCungCap();
            loadDgvPhieuNhapCus();
            loadDgvTaiLieuPhieuNhapCu();
            loadComboboxNCC();
            QLP_N_cboChuDe.Enabled = false;

            QLP_N_cboLoaiTL.Enabled = false;
            QLP_N_cboNgonNgu.Enabled = false;
            QLP_N_cboNhaXB.Enabled = false;
            QLP_N_cboTacGia.Enabled = false;
            QLP_N_cboVitri.Enabled = false;
            QLN_cboNhaCungCap.Enabled = false;



            QLP_N_ptbHinhAnh.Enabled = false;
            if(!string.IsNullOrEmpty(Frm_Main.username))
            {
                manhanvien = Frm_Main.username;
            }    



            QLP_N_txtMoTa.Enabled = false;
            QLP_N_txtNamXB.Enabled = false;

            QLP_N_txtSoTrang.Enabled = false;


            QLP_N_txtSL.Enabled = false;

            QLP_N_btnChonAnh.Enabled = false;
            QLP_N_btnLuu.Enabled = false;
            QLP_N_btnLuuPhieu.Enabled = false;
            QLP_N_btnSua.Enabled = false;
            QLP_N_btnXoa.Enabled = false;


            QLP_N_NC_txtTimTL.Enabled = false;
            QLP_N_NC_btnTimTL.Enabled = false;

            loadDgvPhieuMuon();
            load_dgvDSPhieuXLVP();
            load_dgvDSPT();

            if (QLP_M_dgvDSM.Rows.Count > 0)
            {
                QLP_M_dgvDSM.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (QLP_T_dgvDSPT.Rows.Count > 0)
            {
                QLP_T_dgvDSPT.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (QLP_N_dgvDanhSachPN.Rows.Count > 0)
            {
                QLP_N_dgvDanhSachPN.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (NTLC_dgvPhieuNhap.Rows.Count > 0)
            {
                NTLC_dgvPhieuNhap.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (QLP_VP_dgvDSPhieuXLVP.Rows.Count > 0)
            {
                QLP_VP_dgvDSPhieuXLVP.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            }




        }
        public void taoPhieuNhap()
        {
            bool taoPN = qlpn.taoPhieuNhap(manhanvien);
            if(!taoPN)
            {
                MessageBox.Show("Tạo phiếu nhập thất bại.");
                return;
            }
        }
        private void loadDgvPhieuNhaps()
        {
            QLP_N_dgvDanhSachPN.DataSource = qlpn.loadDgvPhieuNhap();
            
        }
        private void QLP_N_btnTaoPN_Click(object sender, EventArgs e)
        {
            //tạo phiếu hiển thị trên dgv
            
            taoPhieuNhap();
            loadDgvPhieuNhaps();
            loadDgvPhieuNhapCus();
            if (!string.IsNullOrEmpty(qlpn.getLastMaPhieuNhap()))
            {
                QLN_lblMaPhieuNhap.Text = qlpn.getLastMaPhieuNhap();
            }


        }
        void chk_enableText()
        {
            
        }

        private void QLP_N_dgvDanhSachPN_SelectionChanged(object sender, EventArgs e)
        {
            QLN_lblMaPhieuNhap.Text = QLP_N_dgvDanhSachPN.CurrentRow.Cells[0].Value.ToString();
            loadDgvChiTietPhieuNhap();
        }
        public void loadDgvChiTietPhieuNhap()
        {

            QLP_N_dgvChiTietPN.DataSource = qlpn.loadDgvChiTietPhieuNhap(QLP_N_dgvDanhSachPN.CurrentRow.Cells[0].Value.ToString());
        }
        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadComboboxNhaCungCap()
        {
            QLN_cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            QLN_cboNhaCungCap.ValueMember = "MaNhaCungCap";
            QLN_cboNhaCungCap.DataSource = qlpn.loadComboboxNhaCungCap();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QLP_N_btnLuu_Click(object sender, EventArgs e)
        {
            // số lượng tài liệu cần thêm
            int soluongtailieu = int.Parse(QLP_N_txtSL.Text);


            TAILIEU tl = new TAILIEU();
            tl.MaLoaiTaiLieu = int.Parse(QLP_N_cboLoaiTL.SelectedValue.ToString());
            tl.MaChuDe = int.Parse(QLP_N_cboChuDe.SelectedValue.ToString());
            tl.MaTap = "0";
            tl.TenTaiLieu = QLP_N_txtTLMoi.Text;
            tl.SoTrang = int.Parse(QLP_N_txtSoTrang.Text);
            tl.Gia = double.Parse(QLP_N_txtGiaMoi.Text);
            tl.NamXuatBan = int.Parse(QLP_N_txtNamXB.Text);
            tl.MaTacGia = int.Parse(QLP_N_cboTacGia.SelectedValue.ToString());
            tl.MaNhaXuatBan = int.Parse(QLP_N_cboNhaXB.SelectedValue.ToString());
            tl.ThongTinTaiLieu = QLP_N_txtMoTa.Text;
            tl.MaNgonNgu = int.Parse(QLP_N_cboNgonNgu.SelectedValue.ToString());
            tl.MaViTri = QLP_N_cboVitri.SelectedValue.ToString();
            if (string.IsNullOrEmpty(QLP_N_txtSL.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng.");
                return;
            }
            if(string.IsNullOrEmpty(QLP_N_txtNamXB.Text))
            {
                MessageBox.Show("Vui lòng nhập năm xuất bản.");
                return;
            }
            if (string.IsNullOrEmpty(QLP_N_txtGiaMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập giá.");
                return;
            }
            if (string.IsNullOrEmpty(QLP_N_txtSoTrang.Text))
            {
                MessageBox.Show("Vui lòng nhập số trang.");
                return;
            }
            if (string.IsNullOrEmpty(QLP_N_txtTLMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài liệu.");
                return;
            }
            if(string.IsNullOrEmpty(QLP_N_txtMoTa.Text))
            {
                MessageBox.Show("Vui lòng nhập mô tả của tài liệu.");
                return;
            }    
            if (!string.IsNullOrEmpty(TL_urlImage.ToString()))
            {
                tl.HinhAnh = TL_urlImage.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hình ảnh.");
                return;
            }    

            string maphieunhap = QLP_N_dgvDanhSachPN.CurrentRow.Cells[0].Value.ToString();
            string mancc = QLN_cboNhaCungCap.SelectedValue.ToString();
            bool flag = qlpn.nhapTaiLieu(tl,soluongtailieu,maphieunhap, mancc);
            if(flag)
            {
                MessageBox.Show("Nhập tài liệu thành công.");
                loadDgvChiTietPhieuNhap();
                loadDgvPhieuNhaps();
            }   
            else
            {
                MessageBox.Show("Nhập tài liệu không thành công.");
                return;
            }    
        }

        private void QLP_N_btnLuuPhieu_Click(object sender, EventArgs e)
        {

        }

        private void QLP_N_btnThem_Click(object sender, EventArgs e)
        {
            //hiển thị phiếu vừa tạo vào lbl mã phiếu nhập

            QLP_N_cboChuDe.Enabled = true;

            QLP_N_cboLoaiTL.Enabled = true;
            QLP_N_cboNgonNgu.Enabled = true;
            QLP_N_cboNhaXB.Enabled = true;
            QLP_N_cboTacGia.Enabled = true;
            QLP_N_cboVitri.Enabled = true;
            QLN_cboNhaCungCap.Enabled = true;



            QLP_N_txtMoTa.Enabled = true;
            QLP_N_txtNamXB.Enabled = true;
            QLP_N_txtSoTrang.Enabled = true;
            QLP_N_txtSL.Enabled = true;

            QLP_N_ptbHinhAnh.Enabled = true;

            QLP_N_btnChonAnh.Enabled = true;
            QLP_N_btnLuu.Enabled = true;
            chk_enableText();
        }

        private void QLP_N_btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            fd.Multiselect = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                var fileName = fd.FileName;
                QLP_N_ptbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                QLP_N_ptbHinhAnh.Image = new Bitmap(fd.FileName);
                TL_urlImage = fd.FileName;
            }
        }

        private void QLP_N_btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xoá?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            bool flg = qlpn.xoaCT_PhieuNhap(QLP_N_dgvChiTietPN.CurrentRow.Cells[12].Value.ToString());
            if(flg)
            {
                MessageBox.Show("Xoá thành công.");
                loadDgvChiTietPhieuNhap();
            }
            else
            {
                MessageBox.Show("Xoá không thành công.");
                return;
            }    
        }

        private void QLP_N_dgvChiTietPN_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void QLN_btnXoaPhieu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            string maphieunhap = QLP_N_dgvDanhSachPN.CurrentRow.Cells[0].Value.ToString();
            bool flg = qlpn.xoaPhieuNhap(maphieunhap);
            if(flg)
            {
                MessageBox.Show("Xoá phiếu nhập thành công.");
            }
            else
            {
                MessageBox.Show("Xoá phiếu nhập không thành công.");
                return;
            }    
            loadDgvPhieuNhaps();
            loadDgvPhieuNhapCus();
        }
        // phiếu mượn
        public void loadDgvPhieuMuon()
        {
            QLP_M_dgvDSM.DataSource = qlpm.loadDgvPhieuMuon();
            
        }
        private void QLP_M_dgvDSM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QLP_M_lblMaPhieuMuon.Text = QLP_M_dgvDSM.CurrentRow.Cells[0].Value.ToString();
            QLP_M_txtMatheTV.Text = QLP_M_dgvDSM.CurrentRow.Cells[1].Value.ToString();
            QLP_M_txtSoLuong.Text = QLP_M_dgvDSM.CurrentRow.Cells[4].Value.ToString();
            QLP_M_txtPhicoc.Text = QLP_M_dgvDSM.CurrentRow.Cells[6].Value.ToString();
            QLP_M_txtTenNV.Text = QLP_M_dgvDSM.CurrentRow.Cells[2].Value.ToString();
            if(QLP_M_dgvDSM.CurrentRow.Cells[5].Value.ToString() == "False")
            {
                QLP_M_rdbChuaTra.Checked = true;
            }
            else if(QLP_M_dgvDSM.CurrentRow.Cells[5].Value.ToString() == "True")
            {
                QLP_M_rdbDaTra.Checked = true;
            }
            QLP_M_dpkNgayMuon.Value = DateTime.Parse(QLP_M_dgvDSM.CurrentRow.Cells[3].Value.ToString());
            QLP_M_dtpThoiHanMuon.Value = DateTime.Parse(QLP_M_dgvDSM.CurrentRow.Cells[7].Value.ToString());


            QLP_M_dgvCTPM.DataSource = qlpm.loadDgvCT_Phieumuon(QLP_M_dgvDSM.CurrentRow.Cells[0].Value.ToString());
        }

        private void QLP_M_dgvCTPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QLP_M_btnThem_Click(object sender, EventArgs e)
        {

        }

        private void QLP_M_btnSua_Click(object sender, EventArgs e)
        {
            bool tinhtrangtra = false;
            if(QLP_M_rdbChuaTra.Checked)
            {
                tinhtrangtra = false;
            }    
            else if(QLP_M_rdbDaTra.Checked)
            {
                tinhtrangtra = true;
            }    
            bool flg = qlpm.suaPhieuMuon(QLP_M_lblMaPhieuMuon.Text, tinhtrangtra, QLP_M_txtPhicoc.Text, QLP_M_dpkNgayMuon.Value.ToString(), QLP_M_dtpThoiHanMuon.Value.ToString());
            if(!flg)
            {
                MessageBox.Show("Sửa phiếu mượn không thành công.");
                return;
            }
            else
            {
                MessageBox.Show("Sửa phiếu mượn thành công.");
            }    
            loadDgvPhieuMuon();
        }
        public void loadComboboxLoaiTaiLieu()
        {
            QLP_CTM_cboLoaiTL.DisplayMember = "TenLoaiTaiLieu";
            QLP_CTM_cboLoaiTL.ValueMember = "MaLoaiTaiLieu";
            QLP_CTM_cboLoaiTL.DataSource = qltl.loadLoaiTaiLieus();
        }
        private void QLP_M_btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                bool flg = qlpm.xoaPhieuMuon(QLP_M_dgvDSM.CurrentRow.Cells[0].Value.ToString());
                if (flg)
                {
                    MessageBox.Show("Xoá phiếu mượn thành công.");
                }
                else
                {
                    MessageBox.Show("Xoá phiếu mượn không thành công.");
                    return;
                }
            }
            else
            {
                return;
            }
              
        }

        private void QLP_M_dgvCTPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(QLP_M_dgvCTPM.CurrentRow.Cells[1].Value == null)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
                return;
            }
            QLP_CTM_lblMaPM.Text = QLP_M_dgvCTPM.CurrentRow.Cells[0].Value.ToString();
            QLP_CTM_cboLoaiTL.Text = QLP_M_dgvCTPM.CurrentRow.Cells[3].Value.ToString();
            QLP_CTM_txtMaVach.Text = QLP_M_dgvCTPM.CurrentRow.Cells[1].Value.ToString();
            if (QLP_M_dgvCTPM.CurrentRow.Cells[4].Value.ToString() == "False")
            {
                QLP_CTM_rdbChuaTra.Checked = true;
            }    
            else if(QLP_M_dgvCTPM.CurrentRow.Cells[4].Value.ToString() == "True")
            {
                QLP_CTM_rdbDatra.Checked = true;
            }
            QLP_CTM_txtTenTL.Text = QLP_M_dgvCTPM.CurrentRow.Cells[2].Value.ToString();
        }

        private void QLP_CTM_btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xoá không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                bool flg = qlpm.xoaCT_PhieuMuon(QLP_M_dgvCTPM.CurrentRow.Cells[0].Value.ToString());
                if (flg)
                {
                    MessageBox.Show("Xoá chi tiết phiếu mượn thành công.");
                    QLP_M_dgvCTPM.DataSource = qlpm.loadDgvCT_Phieumuon(QLP_M_dgvDSM.CurrentRow.Cells[0].Value.ToString());
                    loadDgvPhieuMuon();
                }
                else
                {
                    MessageBox.Show("Xoá chi tiết phiếu mượn không thành công.");
                    return;
                }
            }
            else
            {
                return;
            }
            
        }

        private void QLP_CTM_btnSua_Click(object sender, EventArgs e)
        {
            bool tinhtrangtract = false;
            if(QLP_CTM_rdbChuaTra.Checked)
            {
                tinhtrangtract = false;
            }
            else if(QLP_CTM_rdbDatra.Checked)
            {
                tinhtrangtract = true;
            }
            qlpm.suaCT_PhieuMuon(QLP_M_dgvCTPM.CurrentRow.Cells[0].Value.ToString(), tinhtrangtract);
        }

        private void QLP_N_btnSua_Click(object sender, EventArgs e)
        {

        }

        private void QLP_M_btnLuu_Click(object sender, EventArgs e)
        {

        }




        // Phiếu trả ////

        void load_dgvDSPT()
        {
            QLP_T_dgvDSPT.DataSource = qlpt.loadPhieuTra();
        }
        void loadCTPTTheoPT(int mapt)
        {
            QLP_T_dgvDSCT.DataSource = qlpt.loadCTPT(mapt);
        }
        private void QLP_T_btnXoa_Click(object sender, EventArgs e)
        {
            PHIEUTRA pt = new PHIEUTRA();
            pt.MaPhieuTra = int.Parse(QLP_T_dgvDSPT.CurrentRow.Cells[0].Value.ToString());
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa mã phiếu trả" + pt.MaPhieuTra.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (qlpt.xoaPhieuTra(pt))
                {
                    MessageBox.Show("Xóa thành công !");
                    load_dgvDSPT();
                    loadCTPTTheoPT(pt.MaPhieuTra);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !");
                }
            }
        }

        private void QLP_T_btnXoa_CT_Click(object sender, EventArgs e)
        {
            CT_PHIEUTRA ct = new CT_PHIEUTRA();
            ct.MaChiTietPhieuTra = int.Parse(QLP_T_dgvDSCT.CurrentRow.Cells[0].Value.ToString());
            ct.MaPhieuTra = int.Parse(QLP_T_dgvDSCT.CurrentRow.Cells[1].Value.ToString());
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa mã phiếu trả " + ct.MaPhieuTra, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (qlpt.xoaCTPT(ct))
                {
                    MessageBox.Show("Xóa thành công !");
                    loadCTPTTheoPT(int.Parse(ct.MaPhieuTra.ToString()));
                    load_dgvDSPT();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !");
                }
            }
        }

        private void QLP_T_dgvDSPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadCTPTTheoPT(int.Parse(QLP_T_dgvDSPT.Rows[e.RowIndex].Cells[0].Value.ToString()));
        }




        //phiếu xử lý vi phạm
        void load_dgvDSPhieuXLVP()
        {
            QLP_VP_dgvDSPhieuXLVP.DataSource = qlvp.loadDSPhieuXLVP();
        }
        void load_dgvCTXLTheoPXL(int maxl)
        {
            QLP_VP_dgvDSCTPhieuXLVP.DataSource = qlvp.loadCTXLTheoPXL(maxl);
        }
        private void QLP_VP_dgvDSPhieuXLVP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            load_dgvCTXLTheoPXL(int.Parse(QLP_VP_dgvDSPhieuXLVP.Rows[e.RowIndex].Cells[0].Value.ToString()));
        }

        private void QLP_VP_btnXoa_Click(object sender, EventArgs e)
        {

            PHIEUXULYVIPHAM pxl = new PHIEUXULYVIPHAM();
            pxl.MaXuLyViPham = int.Parse(QLP_VP_dgvDSPhieuXLVP.CurrentRow.Cells[0].Value.ToString());
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa mã phiếu xử lý " + pxl.MaXuLyViPham.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (qlvp.xoaPXL(pxl))
                {
                    MessageBox.Show("Xóa thành công !");
                    load_dgvDSPhieuXLVP();
                    load_dgvCTXLTheoPXL(pxl.MaXuLyViPham);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !");
                }
            }
        }

        private void QLP_VP_btnXoaCT_Click(object sender, EventArgs e)
        {
            CT_XULYVIPHAM ct_pxl = new CT_XULYVIPHAM();
            ct_pxl.MaChiTietXuLyViPham = int.Parse(QLP_VP_dgvDSCTPhieuXLVP.CurrentRow.Cells[0].Value.ToString());
            ct_pxl.MaXuLyViPham = int.Parse(QLP_VP_dgvDSCTPhieuXLVP.CurrentRow.Cells[1].Value.ToString());
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa mã phiếu xử lý " + ct_pxl.MaXuLyViPham, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (qlvp.xoaCTXL(ct_pxl))
                {
                    MessageBox.Show("Xóa thành công !");
                    load_dgvCTXLTheoPXL(int.Parse(ct_pxl.MaXuLyViPham.ToString()));
                    load_dgvDSPhieuXLVP();
                   
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !");
                }
            }
        }




        // phiếu nhập củ


        private void QLP_N_btnSua_Click_1(object sender, EventArgs e)
        {
            qltl.suaTaiLieu(QLP_N_dgvChiTietPN.CurrentRow.Cells["MaVach"].Value.ToString(), QLP_N_cboLoaiTL.SelectedValue.ToString(), QLP_N_cboChuDe.SelectedValue.ToString(), QLP_N_cboTacGia.SelectedValue.ToString(), QLP_N_cboNhaXB.SelectedValue.ToString(), QLP_N_txtTLMoi.Text, QLP_N_txtSoTrang.Text, QLP_N_txtGiaMoi.Text, QLP_N_txtNamXB.Text, QLP_N_txtMoTa.Text, QLP_N_cboNgonNgu.SelectedValue.ToString(), TL_urlImage, QLP_N_cboVitri.SelectedValue.ToString(), QLP_N_dgvChiTietPN.CurrentRow.Cells["MaTaiLieu"].Value.ToString());
            loadDgvChiTietPhieuNhap();
        }

        private void QLP_N_dgvChiTietPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QLP_N_cboLoaiTL.Enabled = true;
            QLP_N_cboTacGia.Enabled = true;
            QLP_N_cboNhaXB.Enabled = true;
            QLP_N_cboVitri.Enabled = true;
            QLP_N_cboChuDe.Enabled = true;
            QLP_N_cboNgonNgu.Enabled = true;
            QLN_cboNhaCungCap.Enabled = true;
            QLP_N_txtNamXB.Enabled = true;
            QLP_N_txtGiaMoi.Enabled = true;
            QLP_N_txtSoTrang.Enabled = true;
            QLP_N_txtMoTa.Enabled = true;
            QLP_N_btnChonAnh.Enabled = true;
            QLP_N_cboLoaiTL.Text = QLP_N_dgvChiTietPN.CurrentRow.Cells["TenLoaiTaiLieu"].Value.ToString();
            QLP_N_cboTacGia.Text = QLP_N_dgvChiTietPN.CurrentRow.Cells["TenTacGia"].Value.ToString();
            QLP_N_cboNhaXB.Text = QLP_N_dgvChiTietPN.CurrentRow.Cells["TenNhaXuatBan"].Value.ToString();
            QLP_N_cboChuDe.Text = QLP_N_dgvChiTietPN.CurrentRow.Cells["TenChuDe"].Value.ToString();
            QLP_N_cboNgonNgu.Text = QLP_N_dgvChiTietPN.CurrentRow.Cells["TenNgonNgu"].Value.ToString();
            QLP_N_cboVitri.Text = QLP_N_dgvChiTietPN.CurrentRow.Cells["MaViTri"].Value.ToString();
            QLP_N_txtTLMoi.Text = QLP_N_dgvChiTietPN.CurrentRow.Cells["TenTaiLieu"].Value.ToString();
            QLP_N_txtNamXB.Text = QLP_N_dgvChiTietPN.CurrentRow.Cells["NamXuatBan"].Value.ToString();
            QLP_N_txtGiaMoi.Text = QLP_N_dgvChiTietPN.CurrentRow.Cells["Gia"].Value.ToString();
            QLP_N_txtSoTrang.Text = QLP_N_dgvChiTietPN.CurrentRow.Cells["SoTrang"].Value.ToString();
            QLP_N_txtMoTa.Text = QLP_N_dgvChiTietPN.CurrentRow.Cells["ThongTinTaiLieu"].Value.ToString();
            if (!string.IsNullOrEmpty(QLP_N_dgvChiTietPN.CurrentRow.Cells["HinhAnh"].Value.ToString()))
            {
                string path = System.IO.Path.GetFullPath("..\\..\\..\\");
                path += "Images\\TaiLieu\\";
                string urlImage = path + QLP_N_dgvChiTietPN.CurrentRow.Cells["HinhAnh"].Value.ToString();
                QLP_N_ptbHinhAnh.Image = new Bitmap(urlImage);
            }
            QLP_N_txtSL.Enabled = false;
            QLP_N_btnXoa.Enabled = true;
            QLP_N_btnSua.Enabled = true;
            QLP_N_btnLuu.Enabled = false;
        }
        #region nhapcu
        private void NTLC_TaoPhieuNhap_Click(object sender, EventArgs e)
        {
            QLP_N_btnTaoPN.Enabled = false;
            taoPhieuNhap();
            loadDgvPhieuNhaps();
            loadDgvPhieuNhapCus();
            if (!string.IsNullOrEmpty(qlpn.getLastMaPhieuNhap()))
            {
                QLN_lblMaPhieuNhap.Text = qlpn.getLastMaPhieuNhap();
            }
        }
        private void loadDgvPhieuNhapCus()
        {
            NTLC_dgvPhieuNhap.DataSource = qlpn.loadDgvPhieuNhap();
        }
        public void loadDgvChiTietPhieuNhapcu()
        {

            NTLC_dgvCTPhieuNhap.DataSource = qlpn.loadDgvChiTietPhieuNhap(NTLC_dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString());
        }
        private void NTLC_btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            string maphieunhap = NTLC_dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            bool flg = qlpn.xoaPhieuNhap(maphieunhap);
            if (flg)
            {
                MessageBox.Show("Xoá phiếu nhập thành công.");
            }
            else
            {
                MessageBox.Show("Xoá phiếu nhập không thành công.");
                return;
            }
            loadDgvPhieuNhaps();
            loadDgvPhieuNhapCus();
        }

        #endregion

        private void NTLC_dgvPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            loadDgvChiTietPhieuNhapcu();
        }

        private void NTLC_btnThem_Click(object sender, EventArgs e)
        {
            QLP_N_PC_dgvDSTL.Enabled = true;
            QLP_N_NC_txtSL.Enabled = true;
            QLP_N_NC_txtSL.Clear();
            QLP_N_NC_txtTimTL.Focus();
            QLP_N_NC_txtTimTL.Enabled = true;
            QLP_N_NC_txtTimTL.Clear();
            QLP_N_NC_btnTimTL.Enabled = true;
            NTLC_btnXoa.Enabled = false;
            NTLC_btnLuu.Enabled = true;
        }
        public void loadComboboxNCC()
        {
            NTLC_cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            NTLC_cboNhaCungCap.ValueMember = "MaNhaCungCap";
            NTLC_cboNhaCungCap.DataSource = qlpn.loadComboboxNhaCungCap();
        }
        private void NTLC_btnLuu_Click(object sender, EventArgs e)
        {
            
            
            if (QLP_N_PC_dgvDSTL.RowCount == 0)
            {
                MessageBox.Show("Không có tài liệu để thêm.");
                return;
            }
            string maphieunhap = NTLC_dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            string mavach = QLP_N_PC_dgvDSTL.CurrentRow.Cells["oldMaVach"].Value.ToString();
            bool flg = qlpn.themTaiLieuCu(mavach, QLP_N_NC_txtSL.Text, maphieunhap, NTLC_cboNhaCungCap.SelectedValue.ToString());
            if(flg)
            {
                MessageBox.Show("Nhập tài liệu thành công.");
                loadDgvChiTietPhieuNhapcu();
            }
            else
            {
                MessageBox.Show("Nhập tài liệu không thành công.");
                return;
            }    
        }
        public void loadDgvTaiLieuPhieuNhapCu()
        {
            QLP_N_PC_dgvDSTL.DataSource = qlpn.loadDgvTaiLieu();

        }

        private void QLP_N_NC_btnTimTL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(QLP_N_NC_txtTimTL.Text))
            {
                MessageBox.Show("Vui lòng nhập mã tài liệu cần tìm!");
            }
            else {
                QLP_N_PC_dgvDSTL.DataSource = qlpn.loadTLtheoMaTL(QLP_N_NC_txtTimTL.Text);
                if (QLP_N_PC_dgvDSTL.Rows.Count == 0)
                {
                    MessageBox.Show("Tài liệu vừa tìm không tồn tại!");
                }
            }
        }
    }
}
