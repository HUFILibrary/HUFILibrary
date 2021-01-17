using BLL_DAL;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Form_QuanLyThuVien
{
    public partial class UF_TaiLieu : UserControl
    {
        QuanLyTaiLieu qltl = new QuanLyTaiLieu();
        string matg;
        string manxb;
        string macd;
        string mann;
        string maltl;
        string TL_urlImage = "";
        string matailieu;
        public UF_TaiLieu()
        {
            InitializeComponent();
        }

        private void UF_TaiLieu_Load(object sender, EventArgs e)
        {
            loadDgvTacGia();
            loadDgvNXB();
            loadDgvChuDe();
            loadDgvNgonNgu();
            loadDgvLoaiTaiLieu();
            loadComboboxLoaiTaiLieu();
            loadComboboxTacGia();
            loadComboboxNXB();
            loadComboboxNgonNgu();
            loadDgvTaiLieu();
            loadComboboxViTri();
            loadDgvViTri();
            loadCboChuDe();
            loadComboboxMaViTri();
        }
        public void loadComboboxTang()
        {

        }
        private void loadComboboxViTri()
        {
            cboViTri.Items.Add("Tầng 1");
            cboViTri.Items.Add("Tầng 2");
            cboViTri.Items.Add("Tầng 3");
            cboViTri.Items.Add("Tầng 4");
        }
        private void loadDgvViTri()
        {
            VT_dgvDSVT.DataSource = qltl.loadDgvViTri();

        }
        private void loadDgvTaiLieu()
        {
            dgvTaiLieu.DataSource = qltl.loadDgvTaiLieu();
        }
        private void loadComboboxNgonNgu()
        {
            TL_cboNgonNgu.DataSource = qltl.loadNgonNgus();
            TL_cboNgonNgu.DisplayMember = "TenNgonNgu";
            TL_cboNgonNgu.ValueMember = "MaNgonNgu";
        }
        private void loadComboboxNXB()
        {
            TL_cboNhaXB.DataSource = qltl.loadNXBs();
            TL_cboNhaXB.DisplayMember = "TenNhaXuatBan";
            TL_cboNhaXB.ValueMember = "MaNhaXuatBan";
        }
        private void loadComboboxTacGia()
        {
            TL_cboTG.DataSource = qltl.loadTacGias();
            TL_cboTG.DisplayMember = "TenTacGia";
            TL_cboTG.ValueMember = "MaTacGia";
        }
        private void loadComboboxLoaiTaiLieu()
        {
            TL_cboLoaiTL.DataSource = qltl.loadLoaiTaiLieus();
            TL_cboLoaiTL.DisplayMember = "TenLoaiTaiLieu";
            TL_cboLoaiTL.ValueMember = "MaLoaiTaiLieu";
        }
        private void loadDgvNgonNgu()
        {
            dgvNgonNgu.DataSource = qltl.loadNgonNgus();
        }
        private void loadDgvTacGia()
        {
            dgvTacGia.DataSource = qltl.loadTacGias();
        }

        private void dgvTacGia_SelectionChanged(object sender, EventArgs e)
        {
            TG_btnXoa.Enabled = true;
            TG_btnSua.Enabled = true;
            TG_btnLuu.Enabled = false;
            TG_txtTenTG.Text = dgvTacGia.CurrentRow.Cells[1].Value.ToString();
            matg = dgvTacGia.CurrentRow.Cells[0].Value.ToString();
        }

        private void TG_btnThem_Click(object sender, EventArgs e)
        {
            TG_txtTenTG.Text = "";
            TG_txtTenTG.Focus();
            TG_btnSua.Enabled = false;
            TG_btnXoa.Enabled = false;
        }

        private void TG_btnLuu_Click(object sender, EventArgs e)
        {
            qltl.themTacGia(TG_txtTenTG.Text);
            loadDgvTacGia();
            loadComboboxTacGia();
            TG_btnSua.Enabled = true;
            TG_btnXoa.Enabled = true;
            TG_btnLuu.Enabled = false;
        }

        private void TG_btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTacGia.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để xoá.");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                qltl.xoaTacGia(matg);
                loadDgvTacGia();
            }
            else
            {
                return;
            }
        }

        private void TG_btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTacGia.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để sửa.");
                return;
            }
            qltl.suaTacGia(matg, TG_txtTenTG.Text);
            loadDgvTacGia();
        }

        private void NXB_btnThem_Click(object sender, EventArgs e)
        {
            NXB_txtTen.Text = "";
            NXB_txtTen.Focus();
            NXB_btnSua.Enabled = false;
            NXB_btnXoa.Enabled = false;
            NXB_btnLuu.Enabled = true;

        }
        private void loadDgvNXB()
        {
            dgvNhaXuatBan.DataSource = qltl.loadNXBs();
        }
        private void NXB_btnLuu_Click(object sender, EventArgs e)
        {

            qltl.themNXB(NXB_txtTen.Text);
            loadDgvNXB();
            loadComboboxNXB();
            NXB_btnXoa.Enabled = true;
            NXB_btnSua.Enabled = true;
            NXB_btnLuu.Enabled = false;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void NXB_btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNgonNgu.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để xoá.");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                qltl.xoaNXB(manxb);
                loadDgvNXB();
            }
            else
            {
                return;
            }
        }

        private void dgvNhaXuatBan_SelectionChanged(object sender, EventArgs e)
        {
            NXB_btnXoa.Enabled = true;
            NXB_btnSua.Enabled = true;
            NXB_btnLuu.Enabled = false;
            manxb = dgvNhaXuatBan.CurrentRow.Cells[0].Value.ToString();
            NXB_txtTen.Text = dgvNhaXuatBan.CurrentRow.Cells[1].Value.ToString();
        }

        private void NXB_btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhaXuatBan.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để sửa.");
                return;
            }
            qltl.suaNXB(manxb, NXB_txtTen.Text);
            loadDgvNXB();
        }

        private void NN_btnThem_Click(object sender, EventArgs e)
        {
            NN_txtTenNN.Text = "";
            NN_txtTenNN.Focus();
            NN_btnSua.Enabled = false;
            NN_btnXoa.Enabled = false;
            NN_btnLuu.Enabled = true;
        }

        private void CD_btnThem_Click(object sender, EventArgs e)
        {
            CD_txtTen.Text = "";
            CD_txtTen.Focus();
            CD_btnSua.Enabled = false;
            CD_btnXoa.Enabled = false;
            CD_btnLuu.Enabled = true;
        }
        private void loadDgvChuDe()
        {
            CD_dgvCD.DataSource = qltl.loadCHUDEs();
        }
        private void CD_btnLuu_Click(object sender, EventArgs e)
        {
            qltl.themChuDe(CD_txtTen.Text);
            loadDgvChuDe();
            loadCboChuDe();
            CD_btnLuu.Enabled = false;
            CD_btnXoa.Enabled = true;
            CD_btnSua.Enabled = true;
        }

        private void CD_btnXoa_Click(object sender, EventArgs e)
        {
            if (CD_dgvCD.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để xoá.");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                qltl.xoaChuDe(macd);
                loadDgvChuDe();
            }
            else
            {
                return;
            }
        }

        private void CD_dgvCD_SelectionChanged(object sender, EventArgs e)
        {
            macd = CD_dgvCD.CurrentRow.Cells[0].Value.ToString();
            CD_txtTen.Text = CD_dgvCD.CurrentRow.Cells[1].Value.ToString();
            CD_btnXoa.Enabled = true;
            CD_btnSua.Enabled = true;
            CD_btnLuu.Enabled = false;
        }

        private void CD_btnSua_Click(object sender, EventArgs e)
        {
            if (CD_dgvCD.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để sửa.");
                return;
            }
            qltl.suaChuDe(macd, CD_txtTen.Text);
            loadDgvChuDe();
        }

        private void NN_btnLuu_Click(object sender, EventArgs e)
        {
            qltl.themNgonNgu(NN_txtTenNN.Text);
            loadDgvNgonNgu();
            loadComboboxNgonNgu();
            NN_btnXoa.Enabled = true;
            NN_btnSua.Enabled = true;
            NN_btnLuu.Enabled = false;
        }

        private void NN_btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNgonNgu.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để xoá.");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                qltl.xoaNgonNgu(mann);
                loadDgvNgonNgu();
            }
            else
            {
                return;
            }
        }

        private void dgvNgonNgu_SelectionChanged(object sender, EventArgs e)
        {
            mann = dgvNgonNgu.CurrentRow.Cells[0].Value.ToString();
            NN_txtTenNN.Text = dgvNgonNgu.CurrentRow.Cells[1].Value.ToString();

            NN_btnXoa.Enabled = true;
            NN_btnSua.Enabled = true;
            NN_btnLuu.Enabled = false;
        }

        private void NN_btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNgonNgu.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để sửa.");
                return;
            }
            qltl.suaNgonNgu(mann, NN_txtTenNN.Text);
            loadDgvNgonNgu();
        }

        private void LTL_dgvDSLTL_SelectionChanged(object sender, EventArgs e)
        {
            maltl = LTL_dgvDSLTL.CurrentRow.Cells[0].Value.ToString();
            LTL_txtTen.Text = LTL_dgvDSLTL.CurrentRow.Cells[1].Value.ToString();
            LTL_btnXoa.Enabled = true;
            LTL_btnSua.Enabled = true;
            LTL_btnLuu.Enabled = false;
        }

        private void LTL_btnThem_Click(object sender, EventArgs e)
        {
            LTL_btnLuu.Enabled = true;
            LTL_btnSua.Enabled = false;
            LTL_btnXoa.Enabled = false;
            LTL_txtTen.Text = "";
            LTL_txtTen.Focus();
        }
        private void loadDgvLoaiTaiLieu()
        {
            LTL_dgvDSLTL.DataSource = qltl.loadLoaiTaiLieus();

        }
        private void LTL_btnXoa_Click(object sender, EventArgs e)
        {
            if (LTL_dgvDSLTL.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để xoá.");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                qltl.xoaLoaiTaiLieu(maltl);
                loadDgvLoaiTaiLieu();
            }
            else
            {
                return;
            }
        }

        private void LTL_btnSua_Click(object sender, EventArgs e)
        {
            if (LTL_dgvDSLTL.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để sửa.");
                return;
            }
            qltl.suaLoaiTaiLieu(maltl, LTL_txtTen.Text);
            loadDgvLoaiTaiLieu();
        }

        private void LTL_btnLuu_Click(object sender, EventArgs e)
        {
            qltl.themLoaiTaiLieu(LTL_txtTen.Text);
            loadDgvLoaiTaiLieu();
            loadComboboxLoaiTaiLieu();
            LTL_btnXoa.Enabled = true;
            LTL_btnSua.Enabled = true;
            LTL_btnLuu.Enabled = false;
        }

        private void VT_btnXoa_Click(object sender, EventArgs e)
        {
            if (VT_dgvDSVT.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để xoá.");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            bool flg = qltl.xoaVT(VT_dgvDSVT.CurrentRow.Cells[0].Value.ToString());
            if(flg)
            {
                MessageBox.Show("Xoá thành công.");
                loadDgvViTri();
            }
            else
            {
                MessageBox.Show("Xoá không thành công.");
                return;
            }    
        }
        private void loadCboChuDe()
        {
            TL_CboChuDe.DisplayMember = "TenChuDe";
            TL_CboChuDe.ValueMember = "MaChuDe";
            TL_CboChuDe.DataSource = qltl.loadChudes();

        }
        private void TL_txtThem_Click(object sender, EventArgs e)
        {
            TL_lblSoLuong.Visible = true;
            TL_txtSoLuong.Visible = true;
            TL_pbImage.Image = null;
            TL_btnXoa.Enabled = false;
            TL_btnSua.Enabled = false;
            TL_btnLuu.Enabled = true;
            clearTextTaiLieu();
            TL_txtTen.Focus();

        }
        private void clearTextTaiLieu()
        {
            TL_txtTen.Text = "";
            TL_txtSoTrang.Text = "";
            TL_txtGia.Text = "";
            TL_txtNamXuatBan.Text = "";
            TL_txtMoTa.Text = "";

            TL_txtSoLuong.Text = "";
        }
        private void dgvTaiLieu_SelectionChanged(object sender, EventArgs e)
        {

            //TL_btnXoa.Enabled = true;
            //TL_btnSua.Enabled = true;
            //if (!string.IsNullOrEmpty(dgvTaiLieu.CurrentRow.Cells[13].Value.ToString()))
            //{
            //    string path = System.IO.Path.GetFullPath("..\\..\\..\\");
            //    path += "Images\\TaiLieu\\";
            //    string urlImage = path + dgvTaiLieu.CurrentRow.Cells[13].Value.ToString();
            //    TL_pbImage.Image = new Bitmap(urlImage);
            //}
            //matailieu = dgvTaiLieu.CurrentRow.Cells[14].Value.ToString();
            //TL_txtMaVach.Text = dgvTaiLieu.CurrentRow.Cells[0].Value.ToString();
            //TL_txtTen.Text = dgvTaiLieu.CurrentRow.Cells[2].Value.ToString();
            //TL_cboLoaiTL.Text = dgvTaiLieu.CurrentRow.Cells[1].Value.ToString();
            //TL_cboTG.Text = dgvTaiLieu.CurrentRow.Cells[7].Value.ToString();
            //TL_cboNgonNgu.Text = dgvTaiLieu.CurrentRow.Cells[5].Value.ToString();
            //TL_cboNhaXB.Text = dgvTaiLieu.CurrentRow.Cells[6].Value.ToString();
            //TL_txtSoTrang.Text = dgvTaiLieu.CurrentRow.Cells[8].Value.ToString();
            //TL_txtGia.Text = dgvTaiLieu.CurrentRow.Cells[9].Value.ToString();
            //TL_txtNamXuatBan.Text = dgvTaiLieu.CurrentRow.Cells[10].Value.ToString();
            //TL_txtMoTa.Text = dgvTaiLieu.CurrentRow.Cells[11].Value.ToString();
            //TL_CboChuDe.Text = dgvTaiLieu.CurrentRow.Cells[3].Value.ToString();
            //TL_cboMaViTri.Text = dgvTaiLieu.CurrentRow.Cells[12].Value.ToString();



        }
        public string[] getTangKebyMaViTri(string mavitri)
        {
            string[] emp = mavitri.Split('-');
            return emp;
        }
        private void VT_btnThem_Click(object sender, EventArgs e)
        {
            VT_txtKe.Text = "";
            VT_btnLuu.Enabled = true;
            VT_btnSua.Enabled = false;
            VT_btnXoa.Enabled = false;
            VT_txtKe.Focus();
        }

        private void VT_dgvDSVT_SelectionChanged(object sender, EventArgs e)
        {
            if (VT_dgvDSVT.CurrentRow.Cells[1].Value.ToString() == "1")
            {
                cboViTri.Text = "Tầng 1";
            }
            else if (VT_dgvDSVT.CurrentRow.Cells[1].Value.ToString() == "2")
            {
                cboViTri.Text = "Tầng 2";
            }
            else if (VT_dgvDSVT.CurrentRow.Cells[1].Value.ToString() == "3")
            {
                cboViTri.Text = "Tầng 3";
            }
            else
            {
                cboViTri.Text = "Tầng 4";
            }

            VT_txtKe.Text = VT_dgvDSVT.CurrentRow.Cells[3].Value.ToString();

            VT_btnXoa.Enabled = true;
            VT_btnSua.Enabled = true;
            VT_btnLuu.Enabled = false;

        }
        private void loadComboboxMaViTri()
        {
            TL_cboMaViTri.ValueMember = "MaViTri";
            TL_cboMaViTri.DisplayMember = "MaViTri";
            TL_cboMaViTri.DataSource = qltl.loadMaViTri();
        }

        private void VT_btnLuu_Click(object sender, EventArgs e)
        {
            qltl.themViTri(cboViTri.Text, VT_txtKe.Text);
            TL_btnLuu.Enabled = false;
            TL_btnSua.Enabled = true;
            LTL_btnXoa.Enabled = true;
            loadDgvViTri();

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
        private void TL_btnLuu_Click(object sender, EventArgs e)
        {
            if(!ktraTxtChuaSo(TL_txtMaVach))
            {
                MessageBox.Show("Mã vạch chỉ chứa ký tự số.");
                TL_txtMaVach.Focus();
                return; 
            }
            if (!ktraTxtChuaSo(TL_txtSoTrang))
            {
                MessageBox.Show("Số trang vui lòng chỉ nhập số");
                TL_txtSoTrang.Focus();
                return;
            }
            
            if (!ktraTxtChuaSo(TL_txtGia))
            {
                MessageBox.Show("Giá vui lòng chỉ nhập số");
                TL_txtGia.Focus();
                return;
            }
            
            if (!ktraTxtChuaSo(TL_txtSoLuong))
            {
                MessageBox.Show("Số lượng vui lòng chỉ nhập số");
                TL_txtSoLuong.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TL_urlImage))
            {
                MessageBox.Show("Vui lòng chọn hình.");
                return;
            }
            if (string.IsNullOrEmpty(TL_txtSoTrang.Text) || string.IsNullOrEmpty(TL_txtGia.Text) || string.IsNullOrEmpty(TL_txtNamXuatBan.Text) || string.IsNullOrEmpty(TL_txtMoTa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.");
                return;
            }
            TAILIEU item = new TAILIEU();
            item.TenTaiLieu = TL_txtTen.Text;
            item.MaLoaiTaiLieu = int.Parse(TL_cboLoaiTL.SelectedValue.ToString());
            item.SoTrang = int.Parse(TL_txtSoTrang.Text);
            item.Gia = double.Parse(TL_txtGia.Text);
            item.NamXuatBan = int.Parse(TL_txtNamXuatBan.Text);
            item.MaTacGia = int.Parse(TL_cboTG.SelectedValue.ToString());
            item.MaNhaXuatBan = int.Parse(TL_cboNhaXB.SelectedValue.ToString());
            item.ThongTinTaiLieu = TL_txtMoTa.Text;
            item.MaNgonNgu = int.Parse(TL_cboNgonNgu.SelectedValue.ToString());
            item.MaChuDe = int.Parse(TL_CboChuDe.SelectedValue.ToString());
            item.MaTap = "0";
            item.MaViTri = TL_cboMaViTri.SelectedValue.ToString();
            item.TinhTrangXoa = false;
            if (string.IsNullOrEmpty(TL_txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng.");
                return;
            }
            if (!string.IsNullOrEmpty(TL_urlImage.ToString()))
            {
                item.HinhAnh = TL_urlImage.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hình ảnh.");
                return;
            }    
            qltl.themTaiLieu(item, int.Parse(TL_txtSoLuong.Text));
            loadDgvTaiLieu();
            TL_lblSoLuong.Visible = false;
            TL_txtSoLuong.Visible = false;
        }

        private void TL_btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            fd.Multiselect = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                var fileName = fd.FileName;
                TL_pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                TL_pbImage.Image = new Bitmap(fd.FileName);
                TL_urlImage = fd.FileName;
            }
        }

        private void TL_btnSua_Click(object sender, EventArgs e)
        {
            //TAILIEU tl = new TAILIEU();
            //tl.MaVach = TL_txtMaVach.Text;
            //tl.TenTaiLieu = TL_txtTen.Text;
            //if(!string.IsNullOrEmpty(TL_urlImage))
            //{
            //    tl.HinhAnh = TL_urlImage;
            //}
            //tl.MaNhaXuatBan = int.Parse(TL_cboNhaXB.SelectedValue.ToString());
            //tl.MaLoaiTaiLieu = int.Parse(TL_cboLoaiTL.SelectedValue.ToString());
            //tl.MaTacGia = int.Parse(TL_cboTG.SelectedValue.ToString());
            //tl.SoTrang = int.Parse(TL_txtSoTrang.Text);
            //tl.Gia = double.Parse(TL_txtGia.Text);
            //tl.MaNgonNgu = int.Parse(TL_cboNgonNgu.SelectedValue.ToString());
            //tl.MaChuDe = int.Parse(TL_CboChuDe.SelectedValue.ToString());
            //tl.NamXuatBan = int.Parse(TL_txtNamXuatBan.Text);
            //tl.ThongTinTaiLieu = TL_txtMoTa.Text;
            if (!ktraTxtChuaSo(TL_txtMaVach))
            {
                MessageBox.Show("Mã vạch chỉ chứa ký tự số.");
                TL_txtMaVach.Focus();
                return;
            }
            if (!ktraTxtChuaSo(TL_txtSoTrang))
            {
                MessageBox.Show("Số trang vui lòng chỉ nhập số");
                TL_txtSoTrang.Focus();
                return;
            }

            if (!ktraTxtChuaSo(TL_txtGia))
            {
                MessageBox.Show("Giá vui lòng chỉ nhập số");
                TL_txtGia.Focus();
                return;
            }

            if (!ktraTxtChuaSo(TL_txtSoLuong))
            {
                MessageBox.Show("Số lượng vui lòng chỉ nhập số");
                TL_txtSoLuong.Focus();
                return;
            }
            if (dgvTaiLieu.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để sửa.");
                return;
            }
            qltl.suaTaiLieu(TL_txtMaVach.Text,TL_cboLoaiTL.SelectedValue.ToString(), TL_CboChuDe.SelectedValue.ToString(),TL_cboTG.SelectedValue.ToString(), TL_cboNhaXB.SelectedValue.ToString(), TL_txtTen.Text, TL_txtSoTrang.Text, TL_txtGia.Text, TL_txtNamXuatBan.Text, TL_txtMoTa.Text, TL_cboNgonNgu.SelectedValue.ToString(), TL_urlImage,TL_cboMaViTri.SelectedValue.ToString(),matailieu);
            loadDgvTaiLieu();
        }

        private void TL_btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvTaiLieu.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để xoá.");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                qltl.xoaTaiLieu(dgvTaiLieu.CurrentRow.Cells[0].Value.ToString());
                loadDgvTaiLieu();
            }
            else
            {
                return;
            }
            
        }

        private void dgvTaiLieu_Click(object sender, EventArgs e)
        {

            


        }

        private void QLTL_txtSearchMaVach_TextChanged(object sender, EventArgs e)
        {
            dgvTaiLieu.DataSource = qltl.timKiemMaVachTaiLieu(QLTL_txtSearchMaVach.Text);
        }

        private void dgvTaiLieu_SelectionChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvTaiLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TL_lblSoLuong.Visible = false;
            TL_txtSoLuong.Visible = false;
            TL_btnXoa.Enabled = true;
            TL_btnLuu.Enabled = false;
            TL_btnSua.Enabled = true;
            if (!string.IsNullOrEmpty(dgvTaiLieu.CurrentRow.Cells[13].Value.ToString()))
            {
                string path = System.IO.Path.GetFullPath("..\\..\\..\\");
                path += "Images\\TaiLieu\\";
                string urlImage = path + dgvTaiLieu.CurrentRow.Cells[13].Value.ToString();
                TL_pbImage.Image = new Bitmap(urlImage);
            }
            matailieu = dgvTaiLieu.CurrentRow.Cells[14].Value.ToString();
            TL_txtMaVach.Text = dgvTaiLieu.CurrentRow.Cells[0].Value.ToString();
            TL_txtTen.Text = dgvTaiLieu.CurrentRow.Cells[2].Value.ToString();
            TL_cboLoaiTL.Text = dgvTaiLieu.CurrentRow.Cells[1].Value.ToString();
            TL_cboTG.Text = dgvTaiLieu.CurrentRow.Cells[7].Value.ToString();
            TL_cboNgonNgu.Text = dgvTaiLieu.CurrentRow.Cells[5].Value.ToString();
            TL_cboNhaXB.Text = dgvTaiLieu.CurrentRow.Cells[6].Value.ToString();
            TL_txtSoTrang.Text = dgvTaiLieu.CurrentRow.Cells[8].Value.ToString();
            TL_txtGia.Text = dgvTaiLieu.CurrentRow.Cells[9].Value.ToString();
            TL_txtNamXuatBan.Text = dgvTaiLieu.CurrentRow.Cells[10].Value.ToString();
            TL_txtMoTa.Text = dgvTaiLieu.CurrentRow.Cells[11].Value.ToString();
            TL_CboChuDe.Text = dgvTaiLieu.CurrentRow.Cells[3].Value.ToString();
            TL_cboMaViTri.Text = dgvTaiLieu.CurrentRow.Cells[12].Value.ToString();
        }

        private void QLTL_btnSearchMaVach_Click(object sender, EventArgs e)
        {
            dgvTaiLieu.DataSource = qltl.timKiemMaVachTaiLieu(QLTL_txtSearchMaVach.Text);
        }

        private void VT_btnSua_Click(object sender, EventArgs e)
        {
            bool flg = qltl.suaVT(VT_dgvDSVT.CurrentRow.Cells[0].Value.ToString(), cboViTri.SelectedText.ToString(), VT_txtKe.Text);
            if(flg)
            {
                MessageBox.Show("Sửa vị trí thành công.");
            }
            else
            {
                MessageBox.Show("Sửa vị trí không thành công.");
                return;
            }
            loadDgvViTri();
        }
    }
}
