using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL_DAL;

namespace Form_QuanLyThuVien
{
    public partial class UF_QLMuonTra : UserControl
    {
        
        QuanLyMuon qlm = new QuanLyMuon();
        ReportExcel ex = new ReportExcel();
        List<TAILIEU> dsTaiLieuChon = new List<TAILIEU>();
        int soluongtailieumuon = 0;
        double sotiencoc = 0;
        string mathetv = "";
        string mv = "";
        string mapm = "";
        public UF_QLMuonTra()
        {
            InitializeComponent();
        }

        private void UF_QLMuonTra_Load(object sender, EventArgs e)
        {
            M_loadDgvTaiLieu();
            // tao bang tam
            taoBangtam();
            QLMT_T_txtTimTLTra.Text = "";
            QLMT_T_txtTimTLTra.Focus();
            QLMT_T_lblMaThe.Text = "";
            QLMT_T_lblTienCoc.Text = "";
            QLMT_T_lblTinhTrang.Text = "";
            QLMT_T_lblHoTen.Text = "";
            QLMT_T_lblEmail.Text = "";
            QLMT_T_lblSDT.Text = "";
            QLMT_T_txtMV.Text = "";
            QLMT_T_txtTenNV.Text = "";
            QLMT_T_txtGiaTL.Text = "";
            QLMT_T_lblTongtien.Text = "";
            QLMT_T_lblTongTienBT.Text = "";

            QLMT_T_btnXacNhanVP.Enabled = false;
            QLMT_T_btnTinhTien.Enabled = false;
            QLMT_T_btnXoaCT.Enabled = false;
            QLMT_T_btnChon.Enabled = false;
            QLMT_T_btnHuyChon.Enabled = false;
            QLMT_T_btnXacNhanTra.Enabled = false;

            QLMT_T_chkNhanTienCoc.Checked = false;

            QLMT_TDG_txtTimMaDG.Text = "";
            QLMT_TDG_txtTimMaDG.Focus();
            QLMT_TDG_lblMaThe.Text = "";
            QLMT_TDG_lblTienCoc.Text = "";
            QLMT_TDG_lblTTThe.Text = "";
            QLMT_TDG_lblHoTen.Text = "";
            QLMT_TDG_lblEmail.Text = "";
            QLMT_TDG_lblSDT.Text = "";
            QLMT_TDG_txtMV.Text = "";
            QLMT_TDG_txtTenNV.Text = "";
            QLMT_TDG_txtGiaTL.Text = "";
            QLMT_TDG_lblTongtien.Text = "";
            QLMT_TDG_lblTongTienBT.Text = "";

            QLMT_TDG_btnXacNhanTra.Enabled = false;
            QLMT_TDG_btnTinhTien.Enabled = false;
            QLMT_TDG_btnXoa.Enabled = false;
            QLMT_TDG_btnChon.Enabled = false;
            QLMT_TDG_btnHuyChon.Enabled = false;
            QLMT_TDG_btnXacNhanVP.Enabled = false;
           
            loadCboLoaiVP();
        }

       

        private void QLMT_btnChonTraTL_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show( "Tài liệu này quá hạn trả", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                Frm_XuLuViPham xuly = new Frm_XuLuViPham();
                xuly.ShowDialog();
            }
          
         }

        private void QLMT_btnSearchDG_Click_1(object sender, EventArgs e)
        {
            DOCGIA item = qlm.timKiemDocGiaByMaThe(QLMT_txtSearchDG.Text);
            if(item == null)
            {
                MessageBox.Show("Không tìm thấy độc giả.");
                return;
            }    
            else
            {
                QLMT_lblMaThe.Text = item.MaTheThuVien;
                QLMT_lblHoTenDG.Text = item.TenDocGia;
                QLMT_lblNgaySinh.Text = DateTime.Parse(item.NgaySinh.ToString()).ToString("dd/MM/yyyy");
                QLMT_lblGioiTinh.Text = item.GioiTinh.ToString();
                QLMT_lblEmail.Text = item.Email;
                QLMT_lblSDT.Text = item.SoDienThoai;
                QLMT_lblNgayLamThe.Text = DateTime.Parse(item.NgayLamThe.ToString()).ToString("dd/MM/yyyy");
                QLMT_lblDiaChi.Text = item.DiaChi.ToString();
                QLMT_lblHSD.Text = DateTime.Parse(item.HanSuDungTheThuVien.ToString()).ToString("dd/MM/yyyy");
                QLMT_lblCMND.Text = item.CMND.ToString();
                if(item.TinhTrangTheThuVien == false)
                {
                    QLMT_lblTinhTrang.Text = "Đang hoạt động";
                }    
                else
                {
                    QLMT_lblTinhTrang.Text = "Ngưng hoạt động";
                }
                string path = System.IO.Path.GetFullPath("..\\..\\..\\");
                path += "Images\\DocGia\\";
                string urlImage = path + item.HinhAnh.ToString();
                if(System.IO.File.Exists(urlImage))
                {
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    QLMT_avatarDG.Image = new Bitmap(urlImage);
                }
                QLM_dgvDSTLDangMuon.DataSource = qlm.getDSTLDangMuon(QLMT_txtSearchDG.Text);
                //int soluongtailieumuon = 0;
                //double sotiencoc = 0;
                //qlm.returnThongtinmuon(item.MaTheThuVien.ToString(), ref soluongtailieumuon, ref sotiencoc);
                //QLMT_lblTongTienDC.Text = sotiencoc.ToString();
                //QLMT_lblTongTLMuon.Text = soluongtailieumuon.ToString(); 
            }    
        }
        public void M_loadDgvTaiLieu()
        {
            QLMT_M_dgvTaiLieu.DataSource = qlm.loadDgvTaiLieu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(qlm.loadDgvTaiLieuByMaVach(QLMT_M_txtTimSach.Text) != null)
            {
                QLMT_M_dgvTaiLieu.DataSource = qlm.loadDgvTaiLieuByMaVach(QLMT_M_txtTimSach.Text);
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài liệu.");
                return;
            }
        }

        private void QLMT_M_dgvTaiLieu_SelectionChanged(object sender, EventArgs e)
        {
            //QLMT_M_txtTimSach.Text = QLMT_M_dgvTaiLieu.CurrentRow.Cells[1].Value.ToString();
        }
        private void loadDgvChiTietTaiLieuMuon()
        {
            QLMT_M_dgvChiTietTaiLieuMuon.DataSource = qlm.dsTaiLieuChon(dsTaiLieuChon) ;
        }
        private void QLMT_btnChonMuon_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(QLMT_lblMaThe.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin độc giả.");
                return;
            }
            if(QLMT_M_dgvTaiLieu.CurrentRow.Cells[1].Value == null)
            {
                MessageBox.Show("Không có dữ liệu để chọn.");
                return;
            }    
            if(string.IsNullOrEmpty(QLMT_M_dgvTaiLieu.CurrentRow.Cells[1].Value.ToString()))
            {
                MessageBox.Show("Vui lòng chọn tài liệu.");
                return;
            }
            else
            {
                int slm = QLM_dgvDSTLDangMuon.RowCount + dsTaiLieuChon.Count();
                if (slm == 3)
                {
                    MessageBox.Show("Số lượng tài liệu mượn của độc giả đạt mức tối đa của quy định thư viện.");
                    return;
                }
                TAILIEU tlChon = qlm.chonTaiLieu(QLMT_M_dgvTaiLieu.CurrentRow.Cells[0].Value.ToString(), dsTaiLieuChon);
                if(tlChon != null)
                {
                    dsTaiLieuChon.Add(tlChon);
                }
                loadDgvChiTietTaiLieuMuon();
            }
            QLMT_M_lblNgayMuon.Text = DateTime.Now.ToString("dd/MM/yyyy");
            QLMT_M_lblNgayTraDuKien.Text = DateTime.Now.AddMonths(1).ToString("dd/MM/yyyy");

        }

        private void QLMT_btnXacNhanMuon_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(QLMT_lblMaThe.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin độc giả.");
                return;
            }    
            if(string.IsNullOrEmpty(QLMT_M_txtTienDatCoc.Text))
            {
                MessageBox.Show("Vui lòng nhập phí cọc.");
                return;
            }    
            if(dsTaiLieuChon.Count() != 0)
            {
                string manhanvien = "";
                if(!string.IsNullOrEmpty(Frm_Main.username))
                {
                    manhanvien = Frm_Main.username;
                }    
                bool flg = qlm.muonTaiLieu(dsTaiLieuChon, QLMT_lblMaThe.Text, QLMT_M_txtTienDatCoc.Text, manhanvien);
                if(!flg)
                {
                    MessageBox.Show("Quá trình mượn tài liệu thất bại.");
                    return;
                }    
                else
                {
                    MessageBox.Show("Quá trình mượn thành công.");
                    if(MessageBox.Show("Bạn có muốn xuất phiếu mượn không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        
                        var ds = new DataSet();
                        var tailieu = new DataTable();
                        var thongtindocgia = new DataTable();
                        var ngaythangnam = new DataTable();

                        ngaythangnam.Columns.Add("ngaythangnam");
                        ngaythangnam.TableName = "ngaythangnam";
                        string ngay = DateTime.Now.Day.ToString();
                        string thang = DateTime.Now.Month.ToString();
                        string nam = DateTime.Now.Year.ToString();
                        string phicoc = "";
                        if (!string.IsNullOrEmpty(QLMT_M_txtTienDatCoc.Text))
                        {
                            phicoc = QLMT_M_txtTienDatCoc.Text;
                        } else
                        {
                            phicoc = 0.ToString();
                        }
                        string ntn = "TP. Hồ Chí Minh, Ngày " +ngay+ " tháng " + thang + " năm " +nam +".";
                        ngaythangnam.Rows.Add(ntn);

                        thongtindocgia.Columns.Add("hovaten");
                        thongtindocgia.Columns.Add("thethuvien");
                        thongtindocgia.Columns.Add("hovatenkiten");
                        thongtindocgia.Columns.Add("phicoc");
                        thongtindocgia.TableName = "thongtindocgia";

                        //thongtindocgia.Columns.Add("PhiCoc");
                        //thongtindocgia.Rows.Add(QLMT_lblHoTenDG.Text, QLMT_lblMaThe.Text, QLMT_lblHoTenDG.Text,phicoc);
                        thongtindocgia.Rows.Add(QLMT_lblHoTenDG.Text, QLMT_lblMaThe.Text, QLMT_lblHoTenDG.Text, phicoc + " đồng");


                        tailieu.Columns.Add("tentailieu");
                        tailieu.Columns.Add("tentacgia");
                        tailieu.Columns.Add("kihieuxepgia");
                        tailieu.TableName = "thongtintailieu";


                        var dsTLChon = qlm.dsTaiLieuChon(dsTaiLieuChon);
                        // 1 6
                        foreach(DataGridViewRow row in QLMT_M_dgvChiTietTaiLieuMuon.Rows)
                        {
                            tailieu.Rows.Add(row.Cells[1].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString());
                        }
                        ds.Tables.Add(tailieu);
                        ds.Tables.Add(thongtindocgia);
                        ds.Tables.Add(ngaythangnam);
                        ReportExcel.FillReport("phieumuonrs.xlsx", "PhieuMuon.xlsx", ds, new string[] { "{", "}" });
                        Process.Start("phieumuonrs.xlsx");
                    }    
                    dsTaiLieuChon.Clear();
                    loadDgvChiTietTaiLieuMuon();
                    QLM_dgvDSTLDangMuon.DataSource = qlm.getDSTLDangMuon(QLMT_txtSearchDG.Text);
                    //QLMT_lblTongTienDC.Text = sotiencoc.ToString();
                    //QLMT_lblTongTLMuon.Text = soluongtailieumuon.ToString();
                    M_loadDgvTaiLieu();
                    QLMT_M_txtTienDatCoc.Clear();
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài liệu trước khi mượn.");
                return;
            }
        }

        private void QLMT_btnHuyMuon_Click(object sender, EventArgs e)
        {
            if(QLMT_M_dgvChiTietTaiLieuMuon.RowCount ==0 )
            {
                MessageBox.Show("Không có tài liệu để huỷ.");
                return;
            }
            if(QLMT_M_dgvChiTietTaiLieuMuon.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Không có dữ liệu để xoá.");
                return;
            }
            TAILIEU tlHuy = qlm.huyChonTaiLieu(QLMT_M_dgvChiTietTaiLieuMuon.CurrentRow.Cells[0].Value.ToString(),dsTaiLieuChon);
            if(tlHuy != null)
            {
                dsTaiLieuChon.Remove(tlHuy);
                loadDgvChiTietTaiLieuMuon();
            }
            else
            {
                MessageBox.Show("Thao tác huỷ không thành công.");
                return;
            }
        }

        private void QLMT_M_txtTimSach_TextChanged(object sender, EventArgs e)
        {
            QLMT_M_dgvTaiLieu.DataSource = qlm.timKiemMaVachTaiLieu(QLMT_M_txtTimSach.Text);
        }
    

    //phiếu trả /////////////////////////////////////////////////////////////////////////////
 
        QuanLyTra qlt = new QuanLyTra();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataRow dr;
        UF_NhanVien ufnv = new UF_NhanVien();
        public static string hoten = "";
        public static string manv = "";


        void loadCboLoaiVP()
        {
            QLMT_T_cboLoaiVP.DisplayMember = "TenLoaiViPham";
            QLMT_T_cboLoaiVP.ValueMember = "MaLoaiViPham";
            QLMT_T_cboLoaiVP.DataSource = qlt.loadLoaiVP();

            QLMT_TDG_cboLoaiVP.DisplayMember = "TenLoaiViPham";
            QLMT_TDG_cboLoaiVP.ValueMember = "MaLoaiViPham";
            QLMT_TDG_cboLoaiVP.DataSource = qlt.loadLoaiVP();
        }

        private void QLTL_T_btnTimTL_Click(object sender, EventArgs e)
        {
            QLMT_T_btnChon.Enabled = true;
            QLMT_T_btnXacNhanTra.Enabled = true;
            DOCGIA dg = new DOCGIA();
            string tiencoc = "";
            QLMT_T_dgvDSTL.DataSource = qlt.layMVtuCTPM(QLMT_T_txtTimTLTra.Text);
            if (QLMT_T_dgvDSTL.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy tài liệu");
            }
            dg = qlt.layMaDG(dg, QLMT_T_txtTimTLTra.Text, ref tiencoc);
            QLMT_T_lblMaThe.Text = dg.MaTheThuVien;
            QLMT_T_lblHoTen.Text = dg.TenDocGia;
            QLMT_T_lblSDT.Text = dg.SoDienThoai;
            QLMT_T_lblEmail.Text = dg.Email;
            if (dg.TinhTrangTheThuVien == false)
            {
                QLMT_T_lblTinhTrang.Text = "Đang hoạt động";
            }
            else { QLMT_T_lblTinhTrang.Text = "Ngưng hoạt động"; }
            QLMT_T_lblTienCoc.Text = tiencoc;
            string path;
            if (!string.IsNullOrEmpty(dg.HinhAnh))
            {
                path = System.IO.Path.GetFullPath("..\\..\\..\\");
                path += "Images\\DocGia\\";
                string urlImage = path + dg.HinhAnh;
                using (FileStream stream = new FileStream(urlImage, FileMode.Open, FileAccess.Read))
                {
                    QLMT_T_ptbAvatar.Image = new Bitmap(urlImage);
                    QLMT_T_ptbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                path = System.IO.Path.GetFullPath("..\\..\\..\\");
                path += "Images\\DocGia\\";
                using (FileStream stream = new FileStream(path + "defaul.png", FileMode.Open, FileAccess.Read))
                {

                    QLMT_T_ptbAvatar.Image = new Bitmap(path + "defaul.png");
                    QLMT_T_ptbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
        void taoBangtam()
        {
            dt.Columns.Add("MaPhieuMuon", typeof(int));
            dt.Columns.Add("MaVach", typeof(int));
            dt.Columns.Add("TenLoaiViPham", typeof(string));
            dt.Columns.Add("TienBoiThuong", typeof(float));
            dt.Columns.Add("MaLoaiViPham", typeof(int));

            dt2.Columns.Add("MaVach", typeof(int));
            dt2.Columns.Add("MaPhieuMuon", typeof(int));
            dt2.Columns.Add("TenTaiLieu", typeof(string));
            dt2.Columns.Add("NgayLap", typeof(DateTime));
            dt2.Columns.Add("Gia", typeof(float));

        }





        private void QLMT_T_btnChon_Click_1(object sender, EventArgs e)
        {

            int mv = int.Parse(QLMT_T_dgvDSTL.CurrentRow.Cells[0].Value.ToString());

            if (string.IsNullOrEmpty(mathetv))
            {
                dr = dt2.NewRow();
                dr["MaVach"] = int.Parse(QLMT_T_dgvDSTL.CurrentRow.Cells[0].Value.ToString());
                dr["MaPhieuMuon"] = int.Parse(QLMT_T_dgvDSTL.CurrentRow.Cells[1].Value.ToString());
                dr["TenTaiLieu"] = QLMT_T_dgvDSTL.CurrentRow.Cells[2].Value.ToString();
                dr["NgayLap"] = DateTime.Parse(QLMT_T_dgvDSTL.CurrentRow.Cells[8].Value.ToString());
                dr["Gia"] = QLMT_T_dgvDSTL.CurrentRow.Cells[9].Value.ToString();

                dt2.Rows.Add(dr);
                QLMT_T_dgvCTTra.DataSource = dt2;

                string flg = qlt.layMaTVTheoPM(QLMT_T_dgvDSTL.CurrentRow.Cells[1].Value.ToString());
                if (string.IsNullOrEmpty(flg))
                {
                    MessageBox.Show("Dữ liệu không hợp lệ!");
                    return;
                }
                else
                {
                    mathetv = flg;
                }
            }
            else
            {
                string flg = qlt.layMaTVTheoPM(QLMT_T_dgvDSTL.CurrentRow.Cells[1].Value.ToString());
                if (mathetv != flg)
                {
                    MessageBox.Show("Không cùng mã thẻ thư viện!");
                    return;
                }
                if (dt2.Rows.Count == 3)
                {
                    MessageBox.Show("Vượt quá số lượng giới hạn !");
                    return;
                }
                else
                {
                    foreach (DataRow row in dt2.Rows)
                    {
                        if (row["MaVach"].Equals(mv))
                        {
                            MessageBox.Show("Tài liệu đã tồn tại trong danh sách trả !");
                            return;
                        }
                    }
                    dr = dt2.NewRow();
                    dr["MaVach"] = int.Parse(QLMT_T_dgvDSTL.CurrentRow.Cells[0].Value.ToString());
                    dr["MaPhieuMuon"] = int.Parse(QLMT_T_dgvDSTL.CurrentRow.Cells[1].Value.ToString());
                    dr["TenTaiLieu"] = QLMT_T_dgvDSTL.CurrentRow.Cells[2].Value.ToString();
                    dr["NgayLap"] = DateTime.Parse(QLMT_T_dgvDSTL.CurrentRow.Cells[8].Value.ToString());
                    dr["Gia"] = QLMT_T_dgvDSTL.CurrentRow.Cells[9].Value.ToString();

                    dt2.Rows.Add(dr);
                    QLMT_T_dgvCTTra.DataSource = dt2;
                }
            }

        }

        private void QLMT_T_btnHuyChon_Click(object sender, EventArgs e)
        {
            QLMT_T_dgvCTTra.Rows.RemoveAt(QLMT_T_dgvCTTra.CurrentRow.Index);
            QLMT_T_dgvCTTra.DataSource = dt2;
        }

        private void QLMT_T_dgvCTTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hoten = Frm_Main.hoten;
            QLMT_T_txtMV.Text = QLMT_T_dgvCTTra.Rows[e.RowIndex].Cells[0].Value.ToString();
            QLMT_T_txtGiaTL.Text = QLMT_T_dgvCTTra.Rows[e.RowIndex].Cells[4].Value.ToString();
            QLMT_T_txtTenNV.Text = hoten;
         
            QLMT_T_txtSoNgayVP.Enabled = true;
            QLMT_T_txtSoNgayVP.Text = "";
            QLMT_T_cboLoaiVP.Enabled = true;

            QLMT_T_btnHuyChon.Enabled = true; 
        }

        private void QLMT_T_btnTinhTien_Click_1(object sender, EventArgs e)
        {
            QLMT_T_btnXacNhanVP.Enabled = true;
            float tongtien = 0;
            LOAIVIPHAM lvp = new LOAIVIPHAM();
            lvp.MaLoaiViPham = int.Parse(QLMT_T_cboLoaiVP.SelectedValue.ToString());
            float giatl = float.Parse(QLMT_T_txtGiaTL.Text);
            //float coc = float.Parse(QLMT_T_lblTienCoc.Text);

            if (QLMT_T_cboLoaiVP.Text == "Mất tài liệu")
            {
                QLMT_T_txtSoNgayVP.Text = "0";
            }
            int songay = int.Parse(QLMT_T_txtSoNgayVP.Text);

            tongtien = qlt.tinhPhiBT(lvp, songay, giatl);
            QLMT_T_lblTongtien.Text = tongtien.ToString() + " VNĐ";
        }

        private void QLMT_T_btnXacNhanVP_Click_1(object sender, EventArgs e)
        {
            QLMT_T_btnHuyChon.Enabled = true;
            string[] arrtien = QLMT_T_lblTongtien.Text.Split(' ');
            int mav= int.Parse(QLMT_T_txtMV.Text);
            foreach (DataRow row in dt.Rows)
            {
                if (row["MaVach"].Equals(mav))
                {
                    MessageBox.Show("Tài liệu đã tồn tại trong danh sách trả !");
                    return;
                }
            }
            dr = dt.NewRow();
            dr["MaPhieuMuon"] = int.Parse(QLMT_T_dgvDSTL.CurrentRow.Cells[1].Value.ToString());
            dr["MaVach"] = int.Parse(QLMT_T_txtMV.Text);
            dr["TenLoaiViPham"] = QLMT_T_cboLoaiVP.Text;
            dr["TienBoiThuong"] = arrtien.First();
            dr["MaLoaiViPham"] = QLMT_T_cboLoaiVP.SelectedValue;
            dt.Rows.Add(dr);
            QLMT_T_dgvChiTietXLVP.DataSource = dt;
            float tt = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tt += float.Parse(QLMT_T_dgvChiTietXLVP.Rows[i].Cells[3].Value.ToString());
            }
            QLMT_T_lblTongTienBT.Text = tt.ToString();

        }

        private void QLMT_T_btnXoaCT_Click_1(object sender, EventArgs e)
        {
            QLMT_T_dgvChiTietXLVP.Rows.RemoveAt(QLMT_T_dgvChiTietXLVP.CurrentRow.Index);
            QLMT_T_dgvChiTietXLVP.DataSource = dt;
            float tt = 0;
            if (QLMT_T_dgvChiTietXLVP.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tt += float.Parse(QLMT_T_dgvChiTietXLVP.Rows[i].Cells[3].Value.ToString());
                }
            }
            QLMT_T_lblTongTienBT.Text = tt.ToString();
        }

        private void QLMT_T_btnXacNhanTra_Click(object sender, EventArgs e)
        {

            //luu phieu tra
            //cap nha phieu muon ( neu tra du thi tinh trang = true, tinh trang chi tiet = true

            List<CT_PHIEUTRA> lstCTPT = new List<CT_PHIEUTRA>();
            List<LOAIVIPHAM> lstLoaivp = new List<LOAIVIPHAM>();
            List<CT_XULYVIPHAM> lstCTXL = new List<CT_XULYVIPHAM>();

            string[] tienbt = QLMT_T_lblTongtien.Text.Split(' ');
            manv = Frm_Main.username;
            int sltra = QLMT_T_dgvCTTra.Rows.Count - 1;
            DateTime ngaytra = DateTime.Now;
            int mapm = int.Parse(QLMT_T_dgvDSTL.CurrentRow.Cells[1].Value.ToString());
            //lvp.MaLoaiViPham = QLMT_T_cboLoaiVP.SelectedIndex;


            if (QLMT_T_dgvCTTra.Rows.Count - 1 > 0)
            {
                for (int i = 0; i < QLMT_T_dgvCTTra.Rows.Count - 1; i++)
                {
                    CT_PHIEUTRA _ct = new CT_PHIEUTRA();
                    _ct.MaVach = QLMT_T_dgvCTTra.Rows[i].Cells[0].Value.ToString();
                    _ct.MaPhieuMuon = int.Parse(QLMT_T_dgvCTTra.Rows[i].Cells[1].Value.ToString());
                    lstCTPT.Add(_ct);
                }
            }


            if (QLMT_T_dgvChiTietXLVP.Rows.Count - 1 > 0)
            {
                for (int i = 0; i < QLMT_T_dgvChiTietXLVP.Rows.Count - 1; i++)
                {
                    CT_XULYVIPHAM ctxl = new CT_XULYVIPHAM();
                    ctxl.MaVach = QLMT_T_dgvChiTietXLVP.Rows[i].Cells[1].Value.ToString();
                    ctxl.MaLoaiViPham = int.Parse(QLMT_T_dgvChiTietXLVP.Rows[i].Cells[4].Value.ToString());
                    ctxl.TienBoiThuong = float.Parse(QLMT_T_dgvChiTietXLVP.Rows[i].Cells[3].Value.ToString());
                    lstCTXL.Add(ctxl);
                }
            }

            // lấy ds loại vi phạm và ds tiền bồi thường

            bool phicoc;
            if (QLMT_T_chkNhanTienCoc.Checked)
            {
                phicoc = true;
            }
            else
            {
                phicoc = false;
            }

            if (QLMT_T_dgvCTTra.RowCount - 1 > 0)
            {
                if (qlt.luuPhieuTra(mapm, int.Parse(manv.ToString()), ngaytra, sltra, phicoc, QLMT_T_lblTienCoc.Text, lstCTPT))
                {
                    // luu phieu xu ly neu co
                    if (QLMT_T_dgvChiTietXLVP.Rows.Count - 1 > 0)
                    {
                        qlt.luuPhieuXLVP(ngaytra, float.Parse(QLMT_T_lblTongTienBT.Text), lstCTXL, int.Parse(manv));
                        mathetv = "";
              
                    }
                    MessageBox.Show("Quá trình trả thành công ! ");

                }
            }
            else
            {
                MessageBox.Show("Quá trình trả thất bại !");
            }




            //luu chi tiet phieu nhap
            //reset dgv
            QLMT_T_dgvDSTL.DataSource = null;
            QLMT_T_dgvDSTL.Refresh();
            QLMT_T_dgvChiTietXLVP.DataSource = null;
            QLMT_T_dgvChiTietXLVP.Refresh();
            QLMT_T_dgvCTTra.DataSource = null;
            QLMT_T_dgvCTTra.Refresh();
            QLMT_T_txtTimTLTra.Text = "";
            QLMT_T_txtTimTLTra.Focus();
            QLMT_T_lblMaThe.Text = "";
            QLMT_T_lblTienCoc.Text = "";
            QLMT_T_lblTinhTrang.Text = "";
            QLMT_T_lblHoTen.Text = "";
            QLMT_T_lblEmail.Text = "";
            QLMT_T_lblSDT.Text = "";
            QLMT_T_txtMV.Text = "";
            QLMT_T_txtTenNV.Text = "";
            QLMT_T_txtGiaTL.Text = "";
            QLMT_T_lblTongtien.Text = "";
            QLMT_T_lblTongTienBT.Text = "";

            QLMT_T_btnXacNhanVP.Enabled = false;
            QLMT_T_btnTinhTien.Enabled = false;
            QLMT_T_btnXoaCT.Enabled = false;
            QLMT_T_btnChon.Enabled = false;
            QLMT_T_btnHuyChon.Enabled = false;
            QLMT_T_btnXacNhanTra.Enabled = false;
            QLMT_T_txtSoNgayVP.Enabled = false;

            QLMT_T_chkNhanTienCoc.Checked = false;

        }

        private void QLTL_T_btnTimTL_Click_1(object sender, EventArgs e)
        {
            
            QLMT_T_btnXacNhanTra.Enabled = true;
            QLMT_T_btnChon.Enabled = true;
            DOCGIA dg = new DOCGIA();
            string tiencoc = "";
            QLMT_T_dgvDSTL.DataSource = qlt.layMVtuCTPM(QLMT_T_txtTimTLTra.Text);
            if (QLMT_T_dgvDSTL.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy tài liệu");
            }
            else
            {
                dg = qlt.layMaDG(dg, QLMT_T_txtTimTLTra.Text, ref tiencoc);
                QLMT_T_lblMaThe.Text = dg.MaTheThuVien;
                QLMT_T_lblHoTen.Text = dg.TenDocGia;
                QLMT_T_lblSDT.Text = dg.SoDienThoai;
                QLMT_T_lblEmail.Text = dg.Email;
                if (dg.TinhTrangTheThuVien == false)
                {
                    QLMT_T_lblTinhTrang.Text = "Đang hoạt động";
                }
                else { QLMT_T_lblTinhTrang.Text = "Ngưng hoạt động"; }
                QLMT_T_lblTienCoc.Text = tiencoc;
                string path;
                if (!string.IsNullOrEmpty(dg.HinhAnh))
                {
                    try
                    {
                        path = System.IO.Path.GetFullPath("..\\..\\..\\");
                        path += "Images\\DocGia\\";
                        string urlImage = path + dg.HinhAnh;
                        using (FileStream stream = new FileStream(urlImage, FileMode.Open, FileAccess.Read))
                        {
                            QLMT_T_ptbAvatar.Image = new Bitmap(urlImage);
                            QLMT_T_ptbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }


        }

        private void QLMT_T_dgvCTTra_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            hoten = Frm_Main.hoten;
            QLMT_T_txtMV.Text = QLMT_T_dgvCTTra.Rows[e.RowIndex].Cells[0].Value.ToString();
            QLMT_T_txtGiaTL.Text = QLMT_T_dgvCTTra.Rows[e.RowIndex].Cells[4].Value.ToString();
            QLMT_T_txtTenNV.Text = hoten;
            //QLMT_T_btnXacNhanVP.Enabled = true;
            QLMT_T_txtSoNgayVP.Enabled = true;
            QLMT_T_cboLoaiVP.Enabled = true;
            QLMT_T_btnTinhTien.Enabled = true;
            QLMT_T_btnHuyChon.Enabled = true;
        }

        private void QLMT_T_btnInPhieu_Click(object sender, EventArgs e)
        {

        }

        private void QLMT_T_cboLoaiVP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (QLMT_T_cboLoaiVP.SelectedIndex == 1)
            {

                QLMT_T_txtSoNgayVP.Enabled = false;
            }
            else
            {
                QLMT_T_txtSoNgayVP.Enabled = true;
            }
        }

        private void QLMT_T_dgvChiTietXLVP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QLMT_T_btnXoaCT.Enabled = true;
        }





        //Tra theo độc giả
        
        private void QLMT_TDG_btnTimDG_Click(object sender, EventArgs e)
        {
            string tiencoc = "";
            DOCGIA dg = new DOCGIA();
            List<CT_PHIEUMUON> lstCTPM = new List<CT_PHIEUMUON>();
            dg.MaTheThuVien = QLMT_TDG_txtTimMaDG.Text;
            if (qlt.ktraTonTaiDG(dg) == -1)
            {
                MessageBox.Show("Mã thẻ thư viện không tồn tại !");
                return;
            }
            else
            {
                if (qlt.ktraDGTrongPM(dg) == -1)
                {
                    MessageBox.Show("Độc giả không có trong phiếu mượn !");
                }
                else
                {
                    QLMT_TDG_dgvDSTLTra.DataSource = qlt.layDGTuPMChuaTra(QLMT_TDG_txtTimMaDG.Text);

                    for (int i = 0; i < QLMT_TDG_dgvDSTLTra.Rows.Count; i++)
                    {

                        if (qlt.layTTtra(int.Parse(QLMT_TDG_dgvDSTLTra.Rows[i].Cells[10].Value.ToString())))
                        {
                            QLMT_TDG_dgvDSTLTra.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                            QLMT_TDG_dgvDSTLTra.Rows[i].ReadOnly = true;
                        }
                      
                    }

                    dg = qlt.layDGtuPM(dg, ref tiencoc);
                    QLMT_TDG_lblEmail.Text = dg.Email;
                    QLMT_TDG_lblHoTen.Text = dg.TenDocGia;
                    QLMT_TDG_lblMaThe.Text = dg.MaTheThuVien;
                    QLMT_TDG_lblSDT.Text = dg.SoDienThoai;
                    QLMT_TDG_lblTienCoc.Text = tiencoc;
                    if (dg.TinhTrangTheThuVien == true)
                    {
                        QLMT_TDG_lblTTThe.Text = "Đang hoạt động";
                    }
                    else { QLMT_TDG_lblTTThe.Text = "Ngưng hoạt động"; }
                    string path;
                    if (!string.IsNullOrEmpty(dg.HinhAnh))
                    {
                        path = System.IO.Path.GetFullPath("..\\..\\..\\");
                        path += "Images\\DocGia\\";
                        string urlImage = path + dg.HinhAnh;
                        using (FileStream stream = new FileStream(urlImage, FileMode.Open, FileAccess.Read))
                        {
                            QLMT_TDG_ptbAvatar.Image = new Bitmap(urlImage);
                            QLMT_TDG_ptbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                    else
                    {
                        path = System.IO.Path.GetFullPath("..\\..\\..\\");
                        path += "Images\\DocGia\\";
                        using (FileStream stream = new FileStream(path + "defaul.png", FileMode.Open, FileAccess.Read))
                        {

                            QLMT_TDG_ptbAvatar.Image = new Bitmap(path + "defaul.png");
                            QLMT_TDG_ptbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }
            }
        }

        private void QLMT_TDG_btnChon_Click(object sender, EventArgs e)
        {
            int mv = int.Parse(QLMT_TDG_dgvDSTLTra.CurrentRow.Cells[1].Value.ToString());

            foreach (DataRow row in dt2.Rows)
            {
                if (row["MaVach"].Equals(mv))
                {
                    MessageBox.Show("Tài liệu đã tồn tại trong danh sách trả !");
                    return;
                }
            }
            if (QLMT_TDG_dgvDSTLTra.CurrentRow.DefaultCellStyle.BackColor == Color.LightSkyBlue)
            {
                MessageBox.Show("Tài liệu đã được trả !");
            }
            else {
                dr = dt2.NewRow();
                dr["MaVach"] = int.Parse(QLMT_TDG_dgvDSTLTra.CurrentRow.Cells[1].Value.ToString());
                dr["MaPhieuMuon"] = int.Parse(QLMT_TDG_dgvDSTLTra.CurrentRow.Cells[0].Value.ToString());
                dr["TenTaiLieu"] = QLMT_TDG_dgvDSTLTra.CurrentRow.Cells[2].Value.ToString();
                dr["NgayLap"] = DateTime.Parse(QLMT_TDG_dgvDSTLTra.CurrentRow.Cells[8].Value.ToString());
                dr["Gia"] = QLMT_TDG_dgvDSTLTra.CurrentRow.Cells[9].Value.ToString();

                dt2.Rows.Add(dr);
                QLMT_TDG_dgvCT_TLTra.DataSource = dt2;
            }
        
            QLMT_TDG_btnXacNhanTra.Enabled = true;
        }

        private void QLMT_TDG_btnHuyChon_Click(object sender, EventArgs e)
        {
           QLMT_TDG_dgvCT_TLTra.Rows.RemoveAt(QLMT_TDG_dgvCT_TLTra.CurrentRow.Index);
           QLMT_TDG_dgvCT_TLTra.DataSource = dt2;
        }

        private void QLMT_TDG_dgvCT_TLTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hoten = Frm_Main.hoten;
            QLMT_TDG_txtMV.Text = QLMT_TDG_dgvCT_TLTra.Rows[e.RowIndex].Cells[0].Value.ToString();
           QLMT_TDG_txtGiaTL.Text = QLMT_TDG_dgvCT_TLTra.Rows[e.RowIndex].Cells[4].Value.ToString();
            QLMT_TDG_txtTenNV.Text = hoten;
            //QLMT_T_btnXacNhanVP.Enabled = true;
            QLMT_TDG_txtSoNgayVP.Enabled = true;
            QLMT_TDG_cboLoaiVP.Enabled = true;
            QLMT_TDG_btnTinhTien.Enabled = true;
            //QLMT_TDG_btnXoa.Enabled = true;
            QLMT_TDG_btnHuyChon.Enabled = true;
       


        }

        private void QLMT_TDG_btnXacNhanVP_Click(object sender, EventArgs e)
        {
            QLMT_TDG_btnHuyChon.Enabled = true;
            string[] arrtien = QLMT_TDG_lblTongtien.Text.Split(' ');
            int mav = int.Parse(QLMT_TDG_txtMV.Text);
            foreach (DataRow row in dt.Rows)
            {
                if (row["MaVach"].Equals(mav))
                {
                    MessageBox.Show("Tài liệu đã tồn tại trong danh sách trả !");
                    return;
                }
            }
            dr = dt.NewRow();
            dr["MaPhieuMuon"] = int.Parse(QLMT_TDG_dgvDSTLTra.CurrentRow.Cells[1].Value.ToString());
            dr["MaVach"] = int.Parse(QLMT_TDG_txtMV.Text);
            dr["TenLoaiViPham"] = QLMT_TDG_cboLoaiVP.Text;
            dr["TienBoiThuong"] = arrtien.First();
            dr["MaLoaiViPham"] = QLMT_TDG_cboLoaiVP.SelectedValue;
            dt.Rows.Add(dr);
            QLMT_TDG_dgvCT_Vipham.DataSource = dt;
            float tt = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tt += float.Parse(QLMT_TDG_dgvCT_Vipham.Rows[i].Cells[3].Value.ToString());
            }
            QLMT_TDG_lblTongTienBT.Text = tt.ToString();
        }

        private void QLMT_TDG_btnTinhTien_Click(object sender, EventArgs e)
        {
            QLMT_TDG_btnXacNhanVP.Enabled = true;
            float tongtien = 0;
            LOAIVIPHAM lvp = new LOAIVIPHAM();
            lvp.MaLoaiViPham = int.Parse(QLMT_TDG_cboLoaiVP.SelectedValue.ToString());
            float giatl = float.Parse(QLMT_TDG_txtGiaTL.Text);
            //float coc = float.Parse(QLMT_TDG_lblTienCoc.Text);

            if (QLMT_TDG_cboLoaiVP.Text == "Mất tài liệu")
            {
                QLMT_TDG_txtSoNgayVP.Text = "0";
            }
            int songay = int.Parse(QLMT_TDG_txtSoNgayVP.Text);

            tongtien = qlt.tinhPhiBT(lvp, songay, giatl);
            QLMT_TDG_lblTongtien.Text = tongtien.ToString() + " VNĐ";
        }

        private void QLMT_TDG_btnXoa_Click(object sender, EventArgs e)
        {
            QLMT_TDG_dgvCT_Vipham.Rows.RemoveAt(QLMT_TDG_dgvCT_Vipham.CurrentRow.Index);
            QLMT_TDG_dgvCT_Vipham.DataSource = dt;
            float tt = 0;
            if (QLMT_TDG_dgvCT_Vipham.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tt += float.Parse(QLMT_TDG_dgvCT_Vipham.Rows[i].Cells[3].Value.ToString());
                }
            }
            QLMT_TDG_lblTongTienBT.Text = tt.ToString();
        }

        private void QLMT_TDG_dgvCT_Vipham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QLMT_TDG_btnXoa.Enabled = true;
        }

        private void QLMT_TDG_btnXacNhanTra_Click(object sender, EventArgs e)
        {
            //luu phieu tra
            //cap nha phieu muon ( neu tra du thi tinh trang = true, tinh trang chi tiet = true

            List<CT_PHIEUTRA> lstCTPT = new List<CT_PHIEUTRA>();
            List<LOAIVIPHAM> lstLoaivp = new List<LOAIVIPHAM>();
            List<CT_XULYVIPHAM> lstCTXL = new List<CT_XULYVIPHAM>();

            string[] tienbt = QLMT_TDG_lblTongtien.Text.Split(' ');
            manv = Frm_Main.username;
            int sltra = QLMT_TDG_dgvCT_TLTra.Rows.Count - 1;
            DateTime ngaytra = DateTime.Now;
            int mapm = int.Parse(QLMT_TDG_dgvDSTLTra.CurrentRow.Cells[1].Value.ToString());
            //lvp.MaLoaiViPham = QLMT_T_cboLoaiVP.SelectedIndex;


            if (QLMT_TDG_dgvCT_TLTra.Rows.Count - 1 > 0)
            {
                for (int i = 0; i < QLMT_TDG_dgvCT_TLTra.Rows.Count - 1; i++)
                {
                    CT_PHIEUTRA _ct = new CT_PHIEUTRA();
                    _ct.MaVach = QLMT_TDG_dgvCT_TLTra.Rows[i].Cells[0].Value.ToString();
                    _ct.MaPhieuMuon = int.Parse(QLMT_TDG_dgvCT_TLTra.Rows[i].Cells[1].Value.ToString());
                    lstCTPT.Add(_ct);
                }
            }


            if (QLMT_TDG_dgvCT_Vipham.Rows.Count - 1 > 0)
            {
                for (int i = 0; i < QLMT_TDG_dgvCT_Vipham.Rows.Count - 1; i++)
                {
                    CT_XULYVIPHAM ctxl = new CT_XULYVIPHAM();
                    ctxl.MaVach = QLMT_TDG_dgvCT_Vipham.Rows[i].Cells[1].Value.ToString();
                    ctxl.MaLoaiViPham = int.Parse(QLMT_TDG_dgvCT_Vipham.Rows[i].Cells[4].Value.ToString());
                    ctxl.TienBoiThuong = float.Parse(QLMT_TDG_dgvCT_Vipham.Rows[i].Cells[3].Value.ToString());
                    lstCTXL.Add(ctxl);
                }
            }

            // lấy ds loại vi phạm và ds tiền bồi thường

            bool phicoc;
            if (QLMT_TDG_chkTraTienCoc.Checked)
            {
                phicoc = true;
            }
            else
            {
                phicoc = false;
            }

            if (QLMT_TDG_dgvCT_TLTra.RowCount - 1 > 0)
            {
                if (qlt.luuPhieuTra(mapm, int.Parse(manv.ToString()), ngaytra, sltra, phicoc, QLMT_TDG_lblTienCoc.Text, lstCTPT))
                {
                    // luu phieu xu ly neu co
                    if (QLMT_TDG_dgvCT_Vipham.Rows.Count - 1 > 0)
                    {
                        qlt.luuPhieuXLVP(ngaytra, float.Parse(QLMT_TDG_lblTongTienBT.Text), lstCTXL, int.Parse(manv));
                        mathetv = "";

                    }
                    MessageBox.Show("Quá trình trả thành công ! ");

                }
            }
            else
            {
                MessageBox.Show("Quá trình trả thất bại !");
            }




            //luu chi tiet phieu nhap



            //reset dgv
            QLMT_TDG_dgvDSTLTra.DataSource = null;
            QLMT_TDG_dgvDSTLTra.Refresh();
            QLMT_TDG_dgvCT_Vipham.DataSource = null;
            QLMT_TDG_dgvCT_Vipham.Refresh();
            QLMT_TDG_dgvCT_TLTra.DataSource = null;
            QLMT_TDG_dgvCT_TLTra.Refresh();
            QLMT_TDG_txtTimMaDG.Text = "";
            QLMT_TDG_txtTimMaDG.Focus();
            QLMT_TDG_lblMaThe.Text = "";
            QLMT_TDG_lblTienCoc.Text = "";
            QLMT_TDG_lblTTThe.Text = "";
            QLMT_TDG_lblHoTen.Text = "";
            QLMT_TDG_lblEmail.Text = "";
            QLMT_TDG_lblSDT.Text = "";
            QLMT_TDG_txtMV.Text = "";
            QLMT_TDG_txtMV.Enabled = false;
            QLMT_TDG_txtTenNV.Text = "";
            QLMT_TDG_txtTenNV.Enabled = false;
            QLMT_TDG_txtGiaTL.Text = "";
            QLMT_TDG_txtGiaTL.Enabled = false;
            QLMT_TDG_lblTongtien.Text = "";
            QLMT_TDG_lblTongTienBT.Text = "";

            QLMT_TDG_btnXacNhanTra.Enabled = false;
            QLMT_TDG_btnTinhTien.Enabled = false;
            QLMT_TDG_btnXoa.Enabled = false;
            QLMT_TDG_btnChon.Enabled = false;
            QLMT_TDG_btnHuyChon.Enabled = false;
            QLMT_TDG_btnXacNhanVP.Enabled = false;
            QLMT_TDG_txtSoNgayVP.ResetText();

            ////QLMT_TDG_chkTraTienCoc.Checked = false;
        }

        private void QLMT_TDG_dgvDSTLTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QLMT_TDG_btnChon.Enabled = true;
        }

        private void QLMT_TDG_cboLoaiVP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QLMT_TDG_cboLoaiVP.SelectedIndex == 1)
            {

                QLMT_TDG_txtSoNgayVP.Enabled = false;
            }
            else
            {
                QLMT_TDG_txtSoNgayVP.Enabled = true;
            }
        }
    }
}
