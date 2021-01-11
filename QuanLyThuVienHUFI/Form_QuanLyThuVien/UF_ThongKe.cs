using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
namespace Form_QuanLyThuVien
{
    public partial class UF_ThongKe : UserControl
    {
        ThongKe tk = new ThongKe();
        int chk_value = 0;
        int tg_value = 1;
        int rdb_nv = 1;
        DataTable dt;
        DataTable dtMain;
        DataRow dr;
        DataColumn dc;
        public UF_ThongKe()
        {
            InitializeComponent();

        }
        private void QLTK_PM_btnXem_Click(object sender, EventArgs e)
        {
            if (QLTK_PM_rdoChuaTraQuaHan.Checked)
            {
                dtMain = new DataTable();
                List<PhieuMuonTreHanModel> lst = tk.loadPhieuMuonTreHan();
                dtMain.Columns.Add("MaPhieuMuon", typeof(int));
                dtMain.Columns.Add("MaTheThuVien", typeof(string));
                dtMain.Columns.Add("TenNhanVien", typeof(string));
                dtMain.Columns.Add("NgayLap", typeof(DateTime));
                dtMain.Columns.Add("ThoiHanMuon", typeof(DateTime));
                dtMain.Columns.Add("SoLuongTreHan", typeof(int));
                dtMain.Columns.Add("SoNgayTre", typeof(int));
                foreach (PhieuMuonTreHanModel item in lst)
                {
                    dr = dtMain.NewRow();
                    dr["MaPhieuMuon"] = item.MaPhieuMuon;
                    dr["MaTheThuVien"] = item.MaTheThuVien;
                    dr["TenNhanVien"] = item.TenNhanVien;
                    dr["NgayLap"] = item.NgayLap;
                    dr["ThoiHanMuon"] = item.ThoiHanMuon;
                    dr["SoLuongTreHan"] = item.SoLuongTreHan;
                    dr["SoNgayTre"] = tk.tinhSoNgayTre(DateTime.Parse(item.ThoiHanMuon));
                    dtMain.Rows.Add(dr);
                }
                QLTK_PM_dgvDS.DataSource = dtMain;
            }
            else if (QLTK_PM_rdoChuatra.Checked)
            {
                dtMain = new DataTable();
                List<PhieuMuonTreHanModel> lst = tk.loadPMChuaTra();
                dtMain.Columns.Add("MaPhieuMuon", typeof(int));
                dtMain.Columns.Add("MaTheThuVien", typeof(string));
                dtMain.Columns.Add("TenNhanVien", typeof(string));
                dtMain.Columns.Add("NgayLap", typeof(DateTime));
                dtMain.Columns.Add("ThoiHanMuon", typeof(DateTime));
                dtMain.Columns.Add("SoLuongTreHan", typeof(int));
                dtMain.Columns.Add("SoNgayTre", typeof(int));
                foreach (PhieuMuonTreHanModel item in lst)
                {
                    dr = dtMain.NewRow();
                    dr["MaPhieuMuon"] = item.MaPhieuMuon;
                    dr["MaTheThuVien"] = item.MaTheThuVien;
                    dr["TenNhanVien"] = item.TenNhanVien;
                    dr["NgayLap"] = item.NgayLap;
                    dr["ThoiHanMuon"] = item.ThoiHanMuon;
                    dr["SoLuongTreHan"] = item.SoLuongTreHan;
                    dr["SoNgayTre"] = tk.tinhSoNgayTre(DateTime.Parse(item.ThoiHanMuon));
                    dtMain.Rows.Add(dr);
                }
                QLTK_PM_dgvDS.DataSource = dtMain;
            }
            else if (QLTK_PM_rdoMuonDaTra.Checked)
            {
                dtMain = new DataTable();
                List<PhieuMuonTreHanModel> lst = tk.loadPMDaTra();
                dtMain.Columns.Add("MaPhieuMuon", typeof(int));
                dtMain.Columns.Add("MaTheThuVien", typeof(string));
                dtMain.Columns.Add("TenNhanVien", typeof(string));
                dtMain.Columns.Add("NgayLap", typeof(DateTime));
                dtMain.Columns.Add("ThoiHanMuon", typeof(DateTime));
                dtMain.Columns.Add("SoLuongTreHan", typeof(int));
                dtMain.Columns.Add("SoNgayTre", typeof(int));
                foreach (PhieuMuonTreHanModel item in lst)
                {
                    dr = dtMain.NewRow();
                    dr["MaPhieuMuon"] = item.MaPhieuMuon;
                    dr["MaTheThuVien"] = item.MaTheThuVien;
                    dr["TenNhanVien"] = item.TenNhanVien;
                    dr["NgayLap"] = item.NgayLap;
                    dr["ThoiHanMuon"] = item.ThoiHanMuon;
                    dr["SoLuongTreHan"] = item.SoLuongTreHan;
                    dr["SoNgayTre"] = tk.tinhSoNgayTre(DateTime.Parse(item.ThoiHanMuon));
                    dtMain.Rows.Add(dr);
                }
                QLTK_PM_dgvDS.DataSource = dtMain;
                QLTK_PM_dgvDS.Columns["SoLuongTreHan"].Visible = false;///bug
                QLTK_PM_dgvDS.Columns["SoNgayTre"].Visible = false;  ///bug
            }
            else if (QLTK_PM_rdoTatCa.Checked)
            {
                dtMain = new DataTable();
                List<PhieuMuonTreHanModel> lst = tk.loadDSPM();
                dtMain.Columns.Add("MaPhieuMuon", typeof(int));
                dtMain.Columns.Add("MaTheThuVien", typeof(string));
                dtMain.Columns.Add("TenNhanVien", typeof(string));
                dtMain.Columns.Add("NgayLap", typeof(DateTime));
                dtMain.Columns.Add("ThoiHanMuon", typeof(DateTime));
                dtMain.Columns.Add("SoLuongTreHan", typeof(int));
                dtMain.Columns.Add("SoNgayTre", typeof(int));
                foreach (PhieuMuonTreHanModel item in lst)
                {
                    dr = dtMain.NewRow();
                    dr["MaPhieuMuon"] = item.MaPhieuMuon;
                    dr["MaTheThuVien"] = item.MaTheThuVien;
                    dr["TenNhanVien"] = item.TenNhanVien;
                    dr["NgayLap"] = item.NgayLap;
                    dr["ThoiHanMuon"] = item.ThoiHanMuon;
                    dr["SoLuongTreHan"] = item.SoLuongTreHan;
                    dr["SoNgayTre"] = tk.tinhSoNgayTre(DateTime.Parse(item.ThoiHanMuon));
                    dtMain.Rows.Add(dr);
                }
                QLTK_PM_dgvDS.DataSource = dtMain;
            }
            else
            {
                dtMain = new DataTable();
                List<PhieuMuonTreHanModel> lst = tk.loadPMTheooNgay(QLTK_PM_dtp1.Value, QLTK_PM_dtp2.Value);
                dtMain.Columns.Add("MaPhieuMuon", typeof(int));
                dtMain.Columns.Add("MaTheThuVien", typeof(string));
                dtMain.Columns.Add("TenNhanVien", typeof(string));
                dtMain.Columns.Add("NgayLap", typeof(DateTime));
                dtMain.Columns.Add("ThoiHanMuon", typeof(DateTime));
                dtMain.Columns.Add("SoLuongTreHan", typeof(int));
                dtMain.Columns.Add("SoNgayTre", typeof(int));
                foreach (PhieuMuonTreHanModel item in lst)
                {
                    dr = dtMain.NewRow();
                    dr["MaPhieuMuon"] = item.MaPhieuMuon;
                    dr["MaTheThuVien"] = item.MaTheThuVien;
                    dr["TenNhanVien"] = item.TenNhanVien;
                    dr["NgayLap"] = item.NgayLap;
                    dr["ThoiHanMuon"] = item.ThoiHanMuon;
                    dr["SoLuongTreHan"] = item.SoLuongTreHan;
                    dr["SoNgayTre"] = tk.tinhSoNgayTre(DateTime.Parse(item.ThoiHanMuon));
                    dtMain.Rows.Add(dr);
                }
                QLTK_PM_dgvDS.DataSource = dtMain;
                if (QLTK_PM_dgvDS.Rows.Count == 0)
                {
                    MessageBox.Show("Không có phiếu mượn trong khoảng thời gian này !");
                }
            }




        }

        private void QLTK_PM_btnIn_Click(object sender, EventArgs e)
        {
            if (QLTK_PM_dgvDS.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để in.");
                return;
            }
            var ds = new DataSet();
            var phieumuon = new DataTable();
            var thongtinnhanvien = new DataTable();

            thongtinnhanvien.Columns.Add("hovaten");
            thongtinnhanvien.Columns.Add("manhanvien");
            thongtinnhanvien.TableName = "thongtinnhanvien";
            thongtinnhanvien.Rows.Add(Frm_Main.hoten, Frm_Main.username);

            phieumuon.Columns.Add("maphieumuon");
            phieumuon.Columns.Add("mathethuvien");
            phieumuon.Columns.Add("tennhanvien");
            phieumuon.Columns.Add("thoihanmuon");
            phieumuon.Columns.Add("phicoc");
            phieumuon.TableName = "phieumuon";
            foreach (DataGridViewRow row in QLTK_PM_dgvDS.Rows)
            {
                phieumuon.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[7].Value.ToString());
            }
            ds.Tables.Add(phieumuon);
            ds.Tables.Add(thongtinnhanvien);
            ReportExcel.FillReport("DanhSachPhieuMuonTreHanChuaTra.xlsx", "DSPMTHCT.xlsx", ds, new string[] { "{", "}" });
            Process.Start("DanhSachPhieuMuonTreHanChuaTra.xlsx");
        }





        private void UF_ThongKe_Load(object sender, EventArgs e)
        {
            load_dgvTaiLieu();
            load_cboLNV();
            load_dgvPT();
            load_dgvDG();
            load_dgvDSPN();
            load_dgvPXLVP();
            //reloadDGv();
            QLTK_NV_cboLoaiNV.Enabled = false;

            QLTK_dtpTheoNgay.Enabled = false;
            QLTK_dtpNgayBD.Enabled = false;
            QLTK_dtpNgayKT.Enabled = false;
            QLTK_dtpTheoThang.Enabled = false;
            QLTK_dtpThangBD.Enabled = false;
            QLTK_dtpThangKT.Enabled = false;
            QLTK_dtpTheoNam.Enabled = false;
            QLTK_dtpNamBD.Enabled = false;
            QLTK_dtpNamKT.Enabled = false;

            QLTK_rdbChuDe.Enabled = false;
            QLTK_rdbKhoa.Enabled = false;
            QLTK_rdbLoaiTL.Enabled = false;
            QLTK_rdbPhiCoc.Enabled = false;
            QLTK_rdbTaiLieu.Enabled = false;


            if (QLTK_DG_dgvDS.Rows.Count > 0)
            {
                QLTK_DG_dgvDS.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                QLTK_DG_dgvDS.Columns[10].DefaultCellStyle.Format = "dd/MM/yyyy";
                QLTK_DG_dgvDS.Columns[11].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (QLTK_NV_dgvDSNV.Rows.Count > 0)
            {
                QLTK_NV_dgvDSNV.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                QLTK_NV_dgvDSNV.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
               
            }
            if (QLTK_PM_dgvDS.Rows.Count > 0)
            {
                QLTK_PM_dgvDS.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                QLTK_PM_dgvDS.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
               
            }
            if (QLTK_PT_dgvDSPT.Rows.Count > 0)
            {
                QLTK_PT_dgvDSPT.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
              
            }
            if (QLTK_PN_dgvDSPN.Rows.Count > 0)
            {
                QLTK_PN_dgvDSPN.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";

            }
            if (QLTK_PXL_dgvPXL.Rows.Count > 0)
            {
                QLTK_PXL_dgvPXL.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";

            }

        }

        // thống kê độc giả


        void load_dgvDG()
        {
            QLTK_DG_dgvDS.DataSource = tk.loadDG();
            QLTK_DG_rdbTatCa.Checked = true;
        }
        void loadDGNHD()
        {
            if (QLTK_DG_dgvDS.Rows.Count > 1)
            {
                for (int i = 0; i < QLTK_DG_dgvDS.Rows.Count; i++)
                {
                    DOCGIA dg = new DOCGIA();
                    dg.MaTheThuVien = QLTK_DG_dgvDS.Rows[i].Cells[0].Value.ToString();
                    if (tk.ktraTheNHD(dg))
                    {
                        QLTK_DG_dgvDS.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }

                }

            }
        }

        private void QLTK_DG_rdbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            //QLTK_DG_rdbDGNHD.Checked = false;
            //QLTK_DG_rdoDGDHD.Checked = false;
        }

        private void QLTK_DG_rdoDGDHD_CheckedChanged(object sender, EventArgs e)
        {
            //QLTK_DG_rdbDGNHD.Checked = false;
            //QLTK_DG_rdbTatCa.Checked = false;
        }

        private void QLTK_DG_rdbDGNHD_CheckedChanged(object sender, EventArgs e)
        {
            //QLTK_DG_rdbTatCa.Checked = false;
            //QLTK_DG_rdoDGDHD.Checked = false;
        }



        // tài liệu
        void load_dgvTaiLieu()
        {
            QLTK_TL_dgvDSTL.DataSource = tk.loadTL();
        }

        private void QLTK_TL_btnXem_Click(object sender, EventArgs e)
        {
            if (QLTK_TL_rdbTangDan.Checked)
            {
                tg_value = 1;
                QLTK_TL_dgvDSTL.DataSource = tk.loadTangGiamTheoTL(tg_value);
            }
            else if (QLTK_TL_rdbGiamDan.Checked)
            {
                tg_value = 2;
                QLTK_TL_dgvDSTL.DataSource = tk.loadTangGiamTheoTL(tg_value);
            }
            else if (QLTK_TL_rdbTLChuaMuon.Checked)
            {
                QLTK_TL_dgvDSTL.DataSource = tk.tlChuaDuocMuon();
            }
            else if (QLTK_TL_rdbLTLChuaMuon.Checked)
            {
                QLTK_TL_dgvDSTL.DataSource = tk.loaitlChuaDuocMuon();
            }
            else if (QLTK_TL_rdbCDChuaMuon.Checked)
            {
                QLTK_TL_dgvDSTL.DataSource = tk.cdChuaDuocMuon();
            }
            else if (QLTK_DG_rdbTatCa.Checked)
            {
                QLTK_TL_dgvDSTL.DataSource = tk.loadTL();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bộ chọn để xem");
            }
        }

        // Nhân viên
        void load_cboLNV()
        {
            QLTK_NV_cboLoaiNV.ValueMember = "MaLoaiNhanVien";
            QLTK_NV_cboLoaiNV.DisplayMember = "TenLoaiNhanVien";
            QLTK_NV_cboLoaiNV.DataSource = tk.loadLoaiNV();
        }

        private void QLTK_NV_btnXem_Click_1(object sender, EventArgs e)
        {
            if (QLTK_NV_rdbLoaiNV.Checked == false)
            {
                if (QLTK_NV_rdbTatCa.Checked)
                {
                    rdb_nv = 0;

                }
                else if (QLTK_NV_rdbNVDHD.Checked)
                {
                    rdb_nv = 1;
                }
                else
                {
                    rdb_nv = 2;
                }
                QLTK_NV_dgvDSNV.DataSource = tk.loadNV(rdb_nv);
            }
            else
            {
                QLTK_NV_dgvDSNV.DataSource = tk.loadNVTheoLoai(int.Parse(QLTK_NV_cboLoaiNV.SelectedValue.ToString()));
            }
        }

        private void QLTK_NV_rdbLoaiNV_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_NV_rdbLoaiNV.Checked)
            {
                QLTK_NV_rdbTatCa.Checked = false;
                QLTK_NV_rdbNVDHD.Checked = false;
                QLTK_NV_rdbNVNHD.Checked = false;
                QLTK_NV_rdbNVDHD.Enabled = false;
                QLTK_NV_rdbNVNHD.Enabled = false;
                QLTK_NV_rdbTatCa.Enabled = false;
                QLTK_NV_cboLoaiNV.Enabled = true;
            }
            else
            {
                QLTK_NV_rdbNVDHD.Enabled = true;
                QLTK_NV_rdbNVNHD.Enabled = true;
                QLTK_NV_rdbTatCa.Enabled = true;

                QLTK_NV_cboLoaiNV.Enabled = false;
            }
        }



        //Phieu tra
        void load_dgvPT()
        {
            QLTK_PT_rdbTatCa.Checked = true;
            QLTK_PT_dgvDSPT.DataSource = tk.loadPT();
        }

        private void QLTK_PT_rdbPhieuTraTu_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_PT_rdbPhieuTraTu.Checked)
            {
                QLTK_PT_rdbTatCa.Checked = false;

                QLTK_PT_dtpNgayBD.Enabled = true;
                QLTK_PT_dtpNgayKT.Enabled = true;
            }
        }

        private void QLTK_PT_rdbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_PT_rdbTatCa.Checked)
            {
                QLTK_PT_rdbPhieuTraTu.Checked = false;

                QLTK_PT_dtpNgayBD.Enabled = false;
                QLTK_PT_dtpNgayKT.Enabled = false;
            }
        }

        private void QLTK_PT_btnXem_Click(object sender, EventArgs e)
        {
            if (QLTK_PT_rdbTatCa.Checked)
            {
                QLTK_PT_dgvDSPT.DataSource = tk.loadPT();
            }
            else if (QLTK_PT_rdbPhieuTraTu.Checked)
            {
                QLTK_PT_dgvDSPT.DataSource = tk.loadPTTheoNgay(QLTK_PT_dtpNgayBD.Value, QLTK_PT_dtpNgayKT.Value);
                if (QLTK_PT_dgvDSPT.Rows.Count == 0)
                {
                    MessageBox.Show("Không có phiếu trả trong khoảng thời gian này !");
                }
            }
            //else {
            //    MessageBox.Show("Vui lòng chọn bộ chọn muốn xem !");
            //}
        }

        private void QLTK_DG_btnXem_Click(object sender, EventArgs e)
        {
            if (QLTK_DG_rdbTatCa.Checked)
            {
                QLTK_DG_dgvDS.DataSource = tk.loadDG();
            }
            else if (QLTK_DG_rdbDGNHD.Checked)
            {
                QLTK_DG_dgvDS.DataSource = tk.loadDGNHD();
            }
            else
            {
                QLTK_DG_dgvDS.DataSource = tk.loadDGDHD();
            }
        }


        void load_dgvDSPN()
        {
            QLTK_PN_dgvDSPN.DataSource = tk.loadDSPN();
            QLTK_PN_rdbTatCa.Checked = true;
        }

        private void QLTK_PN_btnXem_Click(object sender, EventArgs e)
        {
            if (QLTK_PN_rdbTatCa.Checked)
            {
                load_dgvDSPN();
            }
            else
            {
                QLTK_PN_dgvDSPN.DataSource = tk.loadDSPNTheoNgay(QLTK_PN_dtpNgayBd.Value, QLTK_PN_dtpNgayKT.Value);
                if (QLTK_PN_dgvDSPN.Rows.Count == 0)
                {
                    MessageBox.Show("Không có phiếu nhập trong khoảng thời gian này");
                }
            }
        }

        private void QLTK_PN_rdbPhieuNhapTu_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_PN_rdbPhieuNhapTu.Checked)
            {
                QLTK_PN_dtpNgayBd.Enabled = true;
                QLTK_PN_rdbTatCa.Checked = false;
                QLTK_PN_dtpNgayKT.Enabled = true;
            }
        }

        private void QLTK_PN_rdbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_PN_rdbTatCa.Checked)
            {
                QLTK_PN_dtpNgayBd.Enabled = false;
                QLTK_PN_rdbPhieuNhapTu.Checked = false;
                QLTK_PN_dtpNgayKT.Enabled = false;
            }
        }


        //Phiếu xử lý vi phạm

        void load_dgvPXLVP()
        {
            QLTK_PXL_dgvPXL.DataSource = tk.loadDSPXL();
            QLTK_PXL_rdbTatCa.Checked = true;
        }
        private void QLTK_PXL_btnXem_Click(object sender, EventArgs e)
        {
            if (QLTK_PXL_rdbTatCa.Checked)
            {
                QLTK_PXL_dgvPXL.DataSource = tk.loadDSPXL();
            }
            else
            {
                QLTK_PXL_dgvPXL.DataSource = tk.loadDSPXLTheoNgay(QLTK_PXL_dtpNgayBD.Value, QLTK_PXL_dtpNgayKT.Value);
                if (QLTK_PXL_dgvPXL.Rows.Count == 0)
                {
                    MessageBox.Show("Không có phiếu xử lý vi phạm trong khoảng thời gian này ");
                }
            }
        }

        private void QLTK_PXL_rdbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_PXL_rdbTatCa.Checked)
            {
                QLTK_PXL_dtpNgayBD.Enabled = false;
                QLTK_PXL_dtpNgayKT.Enabled = false;
            }
        }

        private void QLTK_PXL_rdbPhieuXLTu_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_PXL_rdbPhieuXLTu.Checked)
            {
                QLTK_PXL_dtpNgayBD.Enabled = true;
                QLTK_PXL_dtpNgayKT.Enabled = true;
            }
        }

        private void QLTK_TL_rdbTLChuaMuon_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_TL_rdbTLChuaMuon.Checked)
            {
                QLTK_TL_rdbGiamDan.Checked = false;
                QLTK_TL_rdbTangDan.Checked = false;
            }
        }

        private void QLTK_TL_rdbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_TL_rdbTatCa.Checked)
            {
                QLTK_TL_rdbGiamDan.Checked = false;
                QLTK_TL_rdbTangDan.Checked = false;
            }
        }

        private void QLTK_TL_rdbLTLChuaMuon_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_TL_rdbLTLChuaMuon.Checked)
            {
                QLTK_TL_rdbGiamDan.Checked = false;
                QLTK_TL_rdbTangDan.Checked = false;
            }
        }

        private void QLTK_TL_rdbCDChuaMuon_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_TL_rdbCDChuaMuon.Checked)
            {
                QLTK_TL_rdbGiamDan.Checked = false;
                QLTK_TL_rdbTangDan.Checked = false;
            }

        }

        private void QLTK_TL_rdbTangDan_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_TL_rdbTangDan.Checked)
            {
                QLTK_TL_rdbLTLChuaMuon.Checked = false;
                QLTK_TL_rdbTLChuaMuon.Checked = false;
                QLTK_TL_rdbTatCa.Checked = false;
                QLTK_TL_rdbCDChuaMuon.Checked = false;
            }
        }

        private void QLTK_TL_rdbGiamDan_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_TL_rdbGiamDan.Checked)
            {
                QLTK_TL_rdbLTLChuaMuon.Checked = false;
                QLTK_TL_rdbTLChuaMuon.Checked = false;
                QLTK_TL_rdbTatCa.Checked = false;
                QLTK_TL_rdbCDChuaMuon.Checked = false;
            }
        }

        //Thống kê mới
        private void QLTK_rdbTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_rdbTheoNgay.Checked)
            {
                QLTK_dtpTheoNgay.Enabled = true;
                QLTK_rdbChuDe.Enabled = true;
                QLTK_rdbKhoa.Enabled = true;
                QLTK_rdbLoaiTL.Enabled = true;
                QLTK_rdbPhiCoc.Enabled = true;
                QLTK_rdbTaiLieu.Enabled = true;
                chart_Kq.DataSource = null;
                chart_Kq.Series.Clear();
                chart_Kq.Titles.Clear();
            }
            else
            {
                QLTK_dtpTheoNgay.Enabled = false;
            }
        }

        private void QLTK_rdbTuNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_rdbTuNgay.Checked)
            {
                QLTK_dtpNgayBD.Enabled = true;
                QLTK_dtpNgayKT.Enabled = true;
                QLTK_rdbChuDe.Enabled = true;
                QLTK_rdbKhoa.Enabled = true;
                QLTK_rdbLoaiTL.Enabled = true;
                QLTK_rdbPhiCoc.Enabled = true;
                QLTK_rdbTaiLieu.Enabled = true;
                chart_Kq.DataSource = null;
                chart_Kq.Series.Clear();
                chart_Kq.Titles.Clear();
            }
            else
            {
                QLTK_dtpNgayBD.Enabled = false;
                QLTK_dtpNgayKT.Enabled = false;

            }
        }

        private void QLTK_rdbTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_rdbTheoThang.Checked)
            {
                QLTK_dtpTheoThang.Enabled = true;
                QLTK_rdbChuDe.Enabled = true;
                QLTK_rdbKhoa.Enabled = true;
                QLTK_rdbLoaiTL.Enabled = true;
                QLTK_rdbPhiCoc.Enabled = true;
                QLTK_rdbTaiLieu.Enabled = true;
                chart_Kq.DataSource = null;
                chart_Kq.Series.Clear();
                chart_Kq.Titles.Clear();
            }
            else
            {
                QLTK_dtpTheoThang.Enabled = false;

            }
        }

        private void QLTK_rdbTuThang_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_rdbTuThang.Checked)
            {
                QLTK_dtpThangBD.Enabled = true;
                QLTK_dtpThangKT.Enabled = true;
                QLTK_rdbChuDe.Enabled = true;
                QLTK_rdbKhoa.Enabled = true;
                QLTK_rdbLoaiTL.Enabled = true;
                QLTK_rdbPhiCoc.Enabled = true;
                QLTK_rdbTaiLieu.Enabled = true;
                chart_Kq.DataSource = null;
                chart_Kq.Series.Clear();
                chart_Kq.Titles.Clear();
            }
            else
            {
                QLTK_dtpThangBD.Enabled = false;
                QLTK_dtpThangKT.Enabled = false;

            }
        }

        private void QLTK_rdbTheoNam_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_rdbTheoNam.Checked)
            {
                QLTK_dtpTheoNam.Enabled = true;
                QLTK_rdbChuDe.Enabled = true;
                QLTK_rdbKhoa.Enabled = true;
                QLTK_rdbLoaiTL.Enabled = true;
                QLTK_rdbPhiCoc.Enabled = true;
                QLTK_rdbTaiLieu.Enabled = true;
                chart_Kq.DataSource = null;
                chart_Kq.Series.Clear();
                chart_Kq.Titles.Clear();
            }
            else
            {
                QLTK_dtpTheoNam.Enabled = false;

            }
        }

        private void QLTK_rdbTuNam_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_rdbTuNam.Checked)
            {
                QLTK_dtpNamBD.Enabled = true;
                QLTK_dtpNamKT.Enabled = true;
                QLTK_rdbChuDe.Enabled = true;
                QLTK_rdbKhoa.Enabled = true;
                QLTK_rdbLoaiTL.Enabled = true;
                QLTK_rdbPhiCoc.Enabled = true;
                QLTK_rdbTaiLieu.Enabled = true;
                chart_Kq.DataSource = null;
                chart_Kq.Series.Clear();
                chart_Kq.Titles.Clear();
            }
            else
            {
                QLTK_dtpNamBD.Enabled = false;
                QLTK_dtpNamKT.Enabled = false;
            }
        }

        private void QLTK_btnXemKetQua_Click(object sender, EventArgs e)
        {
            //tao bang TL
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataRow dr;
            DataColumn dc;
            int rdbTimes = 0;
            int rdbOption = 0;
            DateTime dtp_ngay = QLTK_dtpTheoNgay.Value;
            int tongcong = 0;
            double tongtien=0;
            List<DSTK_TLPM> lstPMTL;
            List<DSTK_LTL> lstLTL;
            List<DSTK_CD> lstCD;
            List<DSTK_Khoa> lstKhoa;
            List<DSTK_PhiCoc> lstPhiCoc;
            List<DSTK_TLTheoKhoang> lstTenTheoKhoang;
            List<DSTK_TLTheoKhoang> lstTimeTheoKhoang;
            List<DSTK_TLTheoKhoang> lstSLTheoKhoang;
            List<DSTK_TLTheoKhoang> lstPhiCocTheoKhoang;
            if (QLTK_rdbTheoNgay.Checked)
            {

                if (QLTK_rdbTaiLieu.Checked)
                {
                    // code tài liệu trong 1 ngày
                    chart_Kq.DataSource = null;
                    chart_Kq.Series.Clear();
                    chart_Kq.Titles.Clear();
                    lstPMTL = tk.dsTlTrongNgay(dtp_ngay.ToShortDateString());
                    dt.Columns.Add("TenTaiLieu", typeof(string));
                    dt.Columns.Add("NgayLap", typeof(DateTime));
                    dt.Columns.Add("SoLuongTL", typeof(int));
                    foreach (DSTK_TLPM item in lstPMTL)
                    {
                        dr = dt.NewRow();
                        dr["TenTaiLieu"] = item.TenTaiLieu;
                        dr["NgayLap"] = item.NgayLap;
                        dr["SoLuongTL"] = item.SoLuongTL;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {
                        QLTK_dgvKQTK.Columns["TenTaiLieu"].HeaderText = "Tên tài liệu";
                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        QLTK_dgvKQTK.Columns["SoLuongTL"].HeaderText = "Số lượng";
                        QLTK_dgvKQTK.Columns["TenTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongcong.ToString();

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }


                    //// chatt
                    //chart_Kq.DataSource = dt;
                    //string name = QLTK_rdbTaiLieu.Text;
                    //chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    //for (int c = 1; c < QLTK_dgvKQTK.Columns.Count - 1; c++)
                    //{
                    //    int tong = 0;
                    //    for (int r = 0; r < QLTK_dgvKQTK.Rows.Count - 1; r++)
                    //    {
                    //        tong += int.Parse(QLTK_dgvKQTK.Rows[r].Cells[c].Value.ToString());
                    //    }
                    //    chart_Kq.Series[name].Points.AddXY(dt.Columns[c].ToString(), Double.Parse(tong.ToString()));
                    //}
                    //chart_Kq.Titles.Add("Thống kê theo ngày");


                }
                else if (QLTK_rdbLoaiTL.Checked)
                {
                    rdbOption = 1;
                    // code loại tài liệu trong 1 ngày

                    lstLTL = tk.dsLoaiTLTrongNgay(dtp_ngay.ToShortDateString());
                    dt.Columns.Add("TenLoaiTaiLieu", typeof(string));
                    dt.Columns.Add("NgayLap", typeof(DateTime));
                    dt.Columns.Add("SoLuongLTL", typeof(int));
                    foreach (DSTK_LTL item in lstLTL)
                    {
                        dr = dt.NewRow();
                        dr["TenLoaiTaiLieu"] = item.TenLoaiTaiLieu;
                        dr["NgayLap"] = item.NgayLap;
                        dr["SoLuongLTL"] = item.SoLuongLTL;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {
                        QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].HeaderText = "Tên loại tài liệu";
                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        QLTK_dgvKQTK.Columns["SoLuongLTL"].HeaderText = "Số lượng";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongcong.ToString();

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbLoaiTL.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        string ten = QLTK_dgvKQTK.Rows[i].Cells[0].Value.ToString();
                        chart_Kq.Series[name].Points.AddXY(ten,
                            Double.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString()));
                    }

                    chart_Kq.Titles.Add("Thống kê trong ngày");

                }
                else if (QLTK_rdbChuDe.Checked)
                {
                    rdbOption = 2;
                    // code chu de trong 1 ngày
                    lstCD = tk.dsChuDeTrongNgay(dtp_ngay.ToShortDateString());
                    dt.Columns.Add("TenChuDe", typeof(string));
                    dt.Columns.Add("NgayLap", typeof(DateTime));
                    dt.Columns.Add("SoLuongCD", typeof(int));
                    foreach (DSTK_CD item in lstCD)
                    {
                        dr = dt.NewRow();
                        dr["TenChuDe"] = item.TenChuDe;
                        dr["NgayLap"] = item.NgayLap;
                        dr["SoLuongCD"] = item.SoLuongCD;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {
                        QLTK_dgvKQTK.Columns["TenChuDe"].HeaderText = "Tên chủ đề";
                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        QLTK_dgvKQTK.Columns["SoLuongCD"].HeaderText = "Số lượng";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongcong.ToString();

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbChuDe.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count-1; i++)
                    {
                        string ten = QLTK_dgvKQTK.Rows[i].Cells[0].Value.ToString();
                        chart_Kq.Series[name].Points.AddXY(ten,
                            Double.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString()));
                    }
                    
                    chart_Kq.Titles.Add("Thống kê trong ngày");
                }
                else if (QLTK_rdbKhoa.Checked)
                {
                    chart_Kq.DataSource = null;
                    chart_Kq.Series.Clear();
                    chart_Kq.Titles.Clear();
                    // code Khoa trong 1 ngày
                    lstKhoa = tk.dsKhoaTrongNgay(dtp_ngay.ToShortDateString());
                    dt.Columns.Add("TenKhoa", typeof(string));
                    dt.Columns.Add("NgayLap", typeof(DateTime));
                    dt.Columns.Add("SoLuongKhoa", typeof(int));
                    foreach (DSTK_Khoa item in lstKhoa)
                    {
                        dr = dt.NewRow();
                        dr["TenKhoa"] = item.TenKhoa;
                        dr["NgayLap"] = item.NgayLap;
                        dr["SoLuongKhoa"] = item.SoLuongKhoa;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {
                        QLTK_dgvKQTK.Columns["TenKhoa"].HeaderText = "Tên Khoa";
                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        QLTK_dgvKQTK.Columns["SoLuongKhoa"].HeaderText = "Số lượng";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongcong.ToString();

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                }
                else if (QLTK_rdbPhiCoc.Checked)
                {
                    chart_Kq.DataSource = null;
                    chart_Kq.Series.Clear();
                    chart_Kq.Titles.Clear();
                    // code phi coc trong 1 ngày
                    lstPhiCoc = tk.dsPhiCocTrongNgay(dtp_ngay.ToShortDateString());
                    dt2.Columns.Add("NgayLap", typeof(DateTime));
                    dt2.Columns.Add("TongTien", typeof(string));
                    foreach (DSTK_PhiCoc item in lstPhiCoc)
                    {
                        dr = dt2.NewRow();
                       
                        dr["NgayLap"] = item.NgayLap;
                        dr["TongTien"] = item.TongTien;
                        dt2.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt2;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {
                       
                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        QLTK_dgvKQTK.Columns["TongTien"].HeaderText = "Tổng tiền";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongtien += double.Parse(QLTK_dgvKQTK.Rows[i].Cells[1].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongtien.ToString() + " VNĐ";

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                }
            }
            else if (QLTK_rdbTuNgay.Checked)
            {
                rdbTimes = 1;
                string bd = QLTK_dtpNgayBD.Value.ToShortDateString();
                string kt = QLTK_dtpNgayKT.Value.ToShortDateString();
                if (QLTK_rdbTaiLieu.Checked)
                {

                    rdbOption = 0;
                    // code tài liệu trong khoang ngày

                    lstTenTheoKhoang = tk.dsTenTheoKhoang(bd, kt);
                    lstTimeTheoKhoang = tk.dsTimeTheoKhoang(bd, kt);
                    dt.Columns.Add("Ten", typeof(string));
                    for (int i = 0; i < lstTimeTheoKhoang.Count; i++)
                    {
                        dc = new DataColumn();
                        dc.ColumnName = lstTimeTheoKhoang[i].NgayLap;
                        dt.Columns.Add(dc);
                    }

                    dt.Columns.Add("TongSL", typeof(int));

                    for (int j = 0; j < lstTenTheoKhoang.Count; j++) //ten
                    {
                        int tsl = 0;
                        dr = dt.NewRow();
                        dr["Ten"] = lstTenTheoKhoang[j].Ten;
                        for (int c = 1; c < dt.Columns.Count - 1; c++) //col ngay
                        {
                            DSTK_TLTheoKhoang sl = tk.dsSLTheoKhoang(lstTenTheoKhoang[j].Ten.ToString(), dt.Columns[c].ColumnName);
                            if (sl != null)
                            {
                                dr[dt.Columns[c].ColumnName] = sl.SoLuong;
                            }
                            else
                            {
                                dr[dt.Columns[c].ColumnName] = 0;
                            }
                            tsl += int.Parse(dr[dt.Columns[c].ColumnName].ToString());
                        }
                        dr["TongSL"] = tsl;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;
                 
                    QLTK_dgvKQTK.Columns["Ten"].HeaderText = "Tên tài liệu";
                    QLTK_dgvKQTK.Columns["Ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    QLTK_dgvKQTK.Columns["TongSL"].HeaderText = "Tổng số lượng";
                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[QLTK_dgvKQTK.Columns.Count - 1].Value.ToString());
                    }
                    QLTK_lblTongCong.Text = tongcong.ToString();

                    for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                    {

                        DataGridViewColumn dgvCl = QLTK_dgvKQTK.Columns[i];
                        dgvCl.MinimumWidth = 100;
                        dgvCl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    for (int j = 0; j < lstTimeTheoKhoang.Count; j++)
                    {
                        QLTK_dgvKQTK.Columns[lstTimeTheoKhoang[j].NgayLap].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }




                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbTaiLieu.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 1; c < QLTK_dgvKQTK.Columns.Count - 1; c++)
                    {
                        int tong = 0;
                        for (int r = 0; r < QLTK_dgvKQTK.Rows.Count - 1; r++)
                        {
                            tong += int.Parse(QLTK_dgvKQTK.Rows[r].Cells[c].Value.ToString());
                        }
                        chart_Kq.Series[name].Points.AddXY(dt.Columns[c].ToString(), Double.Parse(tong.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo ngày");

                }
                else if (QLTK_rdbLoaiTL.Checked)
                {
                    rdbOption = 1;
                    // code loại tài liệu trong khoang ngày
                    lstTenTheoKhoang = tk.dsLTLTenTheoKhoang(bd, kt);
                    lstTimeTheoKhoang = tk.dsLTLTimeTheoKhoang(bd, kt);
                    dt.Columns.Add("Ten", typeof(string));
                    for (int i = 0; i < lstTimeTheoKhoang.Count; i++)
                    {
                        dc = new DataColumn();
                        dc.ColumnName = lstTimeTheoKhoang[i].NgayLap;
                        dt.Columns.Add(dc);
                    }
                    dt.Columns.Add("TongSL", typeof(int));

                    for (int j = 0; j < lstTenTheoKhoang.Count; j++) //ten
                    {
                        int tsl = 0;
                        dr = dt.NewRow();
                        dr["Ten"] = lstTenTheoKhoang[j].Ten;
                        for (int c = 1; c < dt.Columns.Count - 1; c++) //col ngay
                        {
                            DSTK_TLTheoKhoang sl = tk.dsLTLSLTheoKhoang(lstTenTheoKhoang[j].Ten.ToString(), dt.Columns[c].ColumnName);
                            if (sl != null)
                            {
                                dr[dt.Columns[c].ColumnName] = sl.SoLuong;
                            }
                            else
                            {
                                dr[dt.Columns[c].ColumnName] = 0;
                            }
                            tsl += int.Parse(dr[dt.Columns[c].ColumnName].ToString());
                        }
                        dr["TongSL"] = tsl;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;

                    QLTK_dgvKQTK.Columns["Ten"].HeaderText = "Tên loại tài liệu";
                    QLTK_dgvKQTK.Columns["Ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    QLTK_dgvKQTK.Columns["TongSL"].HeaderText = "Tổng số lượng";
                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[QLTK_dgvKQTK.Columns.Count - 1].Value.ToString());
                    }
                    QLTK_lblTongCong.Text = tongcong.ToString();

                    for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                    {

                        DataGridViewColumn dgvCl = QLTK_dgvKQTK.Columns[i];
                        dgvCl.MinimumWidth = 100;
                        dgvCl.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }

                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbLoaiTL.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 1; c < QLTK_dgvKQTK.Columns.Count - 1; c++)
                    {
                        int tong = 0;
                        for (int r = 0; r < QLTK_dgvKQTK.Rows.Count - 1; r++)
                        {
                            tong += int.Parse(QLTK_dgvKQTK.Rows[r].Cells[c].Value.ToString());
                        }
                        chart_Kq.Series[name].Points.AddXY(dt.Columns[c].ToString(), Double.Parse(tong.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo ngày");
                }
                else if (QLTK_rdbChuDe.Checked)
                {
                    rdbOption = 2;
                    // code chu de trong khoang ngày
                    lstTenTheoKhoang = tk.dsCDTenTheoKhoang(bd, kt);
                    lstTimeTheoKhoang = tk.dsCDTimeTheoKhoang(bd, kt);
                    dt.Columns.Add("Ten", typeof(string));
                    for (int i = 0; i < lstTimeTheoKhoang.Count; i++)
                    {
                        dc = new DataColumn();
                        dc.ColumnName = lstTimeTheoKhoang[i].NgayLap;
                        dt.Columns.Add(dc);
                    }
                    dt.Columns.Add("TongSL", typeof(int));

                    for (int j = 0; j < lstTenTheoKhoang.Count; j++) //ten
                    {
                        int tsl = 0;
                        dr = dt.NewRow();
                        dr["Ten"] = lstTenTheoKhoang[j].Ten;
                        for (int c = 1; c < dt.Columns.Count - 1; c++) //col ngay
                        {
                            DSTK_TLTheoKhoang sl = tk.dsCDSLTheoKhoang(lstTenTheoKhoang[j].Ten.ToString(), dt.Columns[c].ColumnName);
                            if (sl != null)
                            {
                                dr[dt.Columns[c].ColumnName] = sl.SoLuong;
                            }
                            else
                            {
                                dr[dt.Columns[c].ColumnName] = 0;
                            }
                            tsl += int.Parse(dr[dt.Columns[c].ColumnName].ToString());
                        }
                        dr["TongSL"] = tsl;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;

                    QLTK_dgvKQTK.Columns["Ten"].HeaderText = "Tên chủ đề";
                    QLTK_dgvKQTK.Columns["Ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    QLTK_dgvKQTK.Columns["Ten"].MinimumWidth = 200;
                    QLTK_dgvKQTK.Columns["TongSL"].HeaderText = "Tổng số lượng";
                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[QLTK_dgvKQTK.Columns.Count - 1].Value.ToString());
                    }
                    QLTK_lblTongCong.Text = tongcong.ToString();

                    for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                    {

                        DataGridViewColumn dgvCl = QLTK_dgvKQTK.Columns[i];
                        dgvCl.MinimumWidth = 100;
                        dgvCl.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbChuDe.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 1; c < QLTK_dgvKQTK.Columns.Count - 1; c++)
                    {
                        int tong = 0;
                        for (int r = 0; r < QLTK_dgvKQTK.Rows.Count - 1; r++)
                        {
                            tong += int.Parse(QLTK_dgvKQTK.Rows[r].Cells[c].Value.ToString());
                        }
                        chart_Kq.Series[name].Points.AddXY(dt.Columns[c].ToString(), Double.Parse(tong.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo ngày");
                }
                else if (QLTK_rdbKhoa.Checked)
                {
                    rdbOption = 3;
                    // code Khoa trong khoang ngày
                    lstTenTheoKhoang = tk.dsKhoaTenTheoKhoang(bd, kt);
                    lstTimeTheoKhoang = tk.dsKhoaTimeTheoKhoang(bd, kt);
                    dt.Columns.Add("Ten", typeof(string));
                    for (int i = 0; i < lstTimeTheoKhoang.Count; i++)
                    {
                        dc = new DataColumn();
                        dc.ColumnName = lstTimeTheoKhoang[i].NgayLap;
                        dt.Columns.Add(dc);
                    }
                    dt.Columns.Add("TongSL", typeof(int));

                    for (int j = 0; j < lstTenTheoKhoang.Count; j++) //ten
                    {
                        int tsl = 0;
                        dr = dt.NewRow();
                        dr["Ten"] = lstTenTheoKhoang[j].Ten;
                        for (int c = 1; c < dt.Columns.Count - 1; c++) //col ngay
                        {
                            DSTK_TLTheoKhoang sl = tk.dsKhoaSLTheoKhoang(lstTenTheoKhoang[j].Ten.ToString(), dt.Columns[c].ColumnName);
                            if (sl != null)
                            {
                                dr[dt.Columns[c].ColumnName] = sl.SoLuong;
                            }
                            else
                            {
                                dr[dt.Columns[c].ColumnName] = 0;
                            }
                            tsl += int.Parse(dr[dt.Columns[c].ColumnName].ToString());
                        }
                        dr["TongSL"] = tsl;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;

                    QLTK_dgvKQTK.Columns["Ten"].HeaderText = "Tên khoa";
                    QLTK_dgvKQTK.Columns["Ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    QLTK_dgvKQTK.Columns["Ten"].MinimumWidth = 200;
                    QLTK_dgvKQTK.Columns["TongSL"].HeaderText = "Tổng số lượng";
                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[QLTK_dgvKQTK.Columns.Count - 1].Value.ToString());
                    }
                    QLTK_lblTongCong.Text = tongcong.ToString();

                    for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                    {

                        DataGridViewColumn dgvCl = QLTK_dgvKQTK.Columns[i];
                        dgvCl.MinimumWidth = 100;
                        dgvCl.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }

                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbKhoa.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 1; c < QLTK_dgvKQTK.Columns.Count - 1; c++)
                    {
                        int tong = 0;
                        for (int r = 0; r < QLTK_dgvKQTK.Rows.Count - 1; r++)
                        {
                            tong += int.Parse(QLTK_dgvKQTK.Rows[r].Cells[c].Value.ToString());
                        }
                        chart_Kq.Series[name].Points.AddXY(dt.Columns[c].ToString(), Double.Parse(tong.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo ngày");
                }
                else if (QLTK_rdbPhiCoc.Checked)
                {
                    rdbOption = 4;
                    // code phi coc trong khoang ngày
                    lstPhiCocTheoKhoang = tk.dsPhiCocKhoangNgay(bd, kt);
                    dt2.Columns.Add("NgayLap", typeof(DateTime));
                    dt2.Columns.Add("TongTien", typeof(string));
                    foreach (DSTK_TLTheoKhoang item in lstPhiCocTheoKhoang)
                    {
                        dr = dt2.NewRow();

                        dr["NgayLap"] = item.NgayLap;
                        dr["TongTien"] = item.PhiCoc;
                        dt2.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt2;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {

                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        QLTK_dgvKQTK.Columns["TongTien"].HeaderText = "Tổng tiền";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongtien += double.Parse(QLTK_dgvKQTK.Rows[i].Cells[1].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongtien.ToString() + " VNĐ";

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbPhiCoc.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 0; c < QLTK_dgvKQTK.Rows.Count-1; c++)
                    {
                          chart_Kq.Series[name].Points.AddXY(DateTime.Parse(QLTK_dgvKQTK.Rows[c].Cells[0].Value.ToString()).ToString("dd/MM/yyyy"), double.Parse(QLTK_dgvKQTK.Rows[c].Cells[1].Value.ToString())); 
                    }
                    chart_Kq.Titles.Add("Thống kê theo ngày");
                }
            }
            else if (QLTK_rdbTheoThang.Checked)
            {

                int thang = int.Parse(QLTK_dtpTheoThang.Value.Month.ToString());
                int nam = int.Parse(QLTK_dtpTheoThang.Value.Year.ToString());
                if (QLTK_rdbTaiLieu.Checked)
                {
                    chart_Kq.DataSource = null;
                    chart_Kq.Series.Clear();
                    chart_Kq.Titles.Clear();
                    // code tài liệu trong 1 thang
                    lstPMTL = tk.dsTlTrongThang(thang, nam);
                    dt.Columns.Add("TenTaiLieu", typeof(string));
                    dt.Columns.Add("NgayLap", typeof(DateTime));
                    dt.Columns.Add("SoLuongTL", typeof(int));
                    foreach (DSTK_TLPM item in lstPMTL)
                    {
                        dr = dt.NewRow();
                        dr["TenTaiLieu"] = item.TenTaiLieu;
                        dr["NgayLap"] = item.NgayLap;
                        dr["SoLuongTL"] = item.SoLuongTL;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {
                        QLTK_dgvKQTK.Columns["TenTaiLieu"].HeaderText = "Tên tài liệu";
                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        QLTK_dgvKQTK.Columns["SoLuongTL"].HeaderText = "Số lượng";
                        QLTK_dgvKQTK.Columns["TenTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongcong.ToString();

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                }
                else if (QLTK_rdbLoaiTL.Checked)
                {

                    // code loại tài liệu trong 1 thang
                    lstLTL = tk.dsLoaiTLTrongThang(thang,nam);
                    dt.Columns.Add("TenLoaiTaiLieu", typeof(string));
                    dt.Columns.Add("NgayLap", typeof(DateTime));
                    dt.Columns.Add("SoLuongLTL", typeof(int));
                    foreach (DSTK_LTL item in lstLTL)
                    {
                        dr = dt.NewRow();
                        dr["TenLoaiTaiLieu"] = item.TenLoaiTaiLieu;
                        dr["NgayLap"] = item.NgayLap;
                        dr["SoLuongLTL"] = item.SoLuongLTL;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {
                        QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].HeaderText = "Tên loại tài liệu";
                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        QLTK_dgvKQTK.Columns["SoLuongLTL"].HeaderText = "Số lượng";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongcong.ToString();

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbLoaiTL.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        string ten = QLTK_dgvKQTK.Rows[i].Cells[0].Value.ToString();
                        chart_Kq.Series[name].Points.AddXY(ten,
                            Double.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString()));
                    }

                    chart_Kq.Titles.Add("Thống kê trong tháng");
                }
                else if (QLTK_rdbChuDe.Checked)
                {
       
                    // code chu de trong 1 thang
                    lstCD = tk.dsChuDeTrongThang(thang,nam);
                    dt.Columns.Add("TenChuDe", typeof(string));
                    dt.Columns.Add("NgayLap", typeof(DateTime));
                    dt.Columns.Add("SoLuongCD", typeof(int));
                    foreach (DSTK_CD item in lstCD)
                    {
                        dr = dt.NewRow();
                        dr["TenChuDe"] = item.TenChuDe;
                        dr["NgayLap"] = item.NgayLap;
                        dr["SoLuongCD"] = item.SoLuongCD;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {
                        QLTK_dgvKQTK.Columns["TenChuDe"].HeaderText = "Tên chủ đề";
                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        QLTK_dgvKQTK.Columns["SoLuongCD"].HeaderText = "Số lượng";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongcong.ToString();

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbChuDe.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        string ten = QLTK_dgvKQTK.Rows[i].Cells[0].Value.ToString();
                        chart_Kq.Series[name].Points.AddXY(ten,
                            Double.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString()));
                    }

                    chart_Kq.Titles.Add("Thống kê trong tháng");
                }
                else if (QLTK_rdbKhoa.Checked)
                {
                    chart_Kq.DataSource = null;
                    chart_Kq.Series.Clear();
                    chart_Kq.Titles.Clear();
                    // code Khoa trong 1 thang
                    lstKhoa = tk.dsKhoaTrongThang(thang, nam);
                    dt.Columns.Add("TenKhoa", typeof(string));
                    dt.Columns.Add("NgayLap", typeof(DateTime));
                    dt.Columns.Add("SoLuongKhoa", typeof(int));
                    foreach (DSTK_Khoa item in lstKhoa)
                    {
                        dr = dt.NewRow();
                        dr["TenKhoa"] = item.TenKhoa;
                        dr["NgayLap"] = item.NgayLap;
                        dr["SoLuongKhoa"] = item.SoLuongKhoa;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {
                        QLTK_dgvKQTK.Columns["TenKhoa"].HeaderText = "Tên Khoa";
                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        QLTK_dgvKQTK.Columns["SoLuongKhoa"].HeaderText = "Số lượng";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongcong.ToString();

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                }
                else if (QLTK_rdbPhiCoc.Checked)
                {
                    chart_Kq.DataSource = null;
                    chart_Kq.Series.Clear();
                    chart_Kq.Titles.Clear();
                    // code phi coc trong 1 thang
                    lstPhiCoc = tk.dsPhiCocTrongThang(thang,nam);
                    dt2.Columns.Add("NgayLap", typeof(DateTime));
                    dt2.Columns.Add("TongTien", typeof(string));
                    foreach (DSTK_PhiCoc item in lstPhiCoc)
                    {
                        dr = dt2.NewRow();

                        dr["NgayLap"] = item.NgayLap;
                        dr["TongTien"] = item.TongTien;
                        dt2.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt2;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {

                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        QLTK_dgvKQTK.Columns["TongTien"].HeaderText = "Tổng tiền";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongtien += double.Parse(QLTK_dgvKQTK.Rows[i].Cells[1].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongtien.ToString() + " VNĐ";

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbPhiCoc.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 0; c < QLTK_dgvKQTK.Rows.Count - 1; c++)
                    {
                        chart_Kq.Series[name].Points.AddXY(DateTime.Parse(QLTK_dgvKQTK.Rows[c].Cells[0].Value.ToString()).ToString("dd/MM/yyyy"), double.Parse(QLTK_dgvKQTK.Rows[c].Cells[1].Value.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo ngày");
                }
            }
            else if (QLTK_rdbTuThang.Checked)
            {
                
                int thangbd = int.Parse(QLTK_dtpTheoThang.Value.Month.ToString());
                int nambd = int.Parse(QLTK_dtpTheoThang.Value.Year.ToString());
                int thangkt = int.Parse(QLTK_dtpThangBD.Value.Month.ToString());
                int namkt = int.Parse(QLTK_dtpThangKT.Value.Year.ToString());
                string bd = QLTK_dtpThangBD.Value.ToShortDateString();
                string kt = QLTK_dtpThangKT.Value.ToShortDateString();
                if (QLTK_rdbTaiLieu.Checked)
                {
                   
                    // code tài liệu trong khoang thang
                    lstTenTheoKhoang = tk.dsTLTenkhoangThang(bd, kt);
                    lstTimeTheoKhoang = tk.dsNgayLapTheoKhoangThang(bd, kt);
                    dt.Columns.Add("Ten", typeof(string));
                    for (int i = 0; i < lstTimeTheoKhoang.Count; i++)
                    {
                        dc = new DataColumn();
                        dc.ColumnName = lstTimeTheoKhoang[i].NgayLap +"/"+ lstTimeTheoKhoang[i].NamLap;
                        dt.Columns.Add(dc);
                    }
                    dt.Columns.Add("TongSL", typeof(int));


                    for (int j = 0; j < lstTenTheoKhoang.Count; j++) //ten
                    {
                        int tsl = 0;
                        dr = dt.NewRow();
                        dr["Ten"] = lstTenTheoKhoang[j].Ten;
                        for (int c = 1; c < dt.Columns.Count - 1; c++) //col ngay
                        {
                           
                            string[] arr = dt.Columns[c].ColumnName.Split('/');
                            
                            DSTK_TLTheoKhoang sl = tk.dsTLSLTheoKhoangThang(lstTenTheoKhoang[j].Ten.ToString(),
                               int.Parse(arr[0]),
                               int.Parse(arr[1]));
                            if (sl != null)
                            {
                                dr[dt.Columns[c].ColumnName] = sl.SoLuong;
                            }
                            else
                            {
                                dr[dt.Columns[c].ColumnName] = 0;
                            }
                            tsl += int.Parse(dr[dt.Columns[c].ColumnName].ToString());
                        }
                        dr["TongSL"] = tsl;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;

                    QLTK_dgvKQTK.Columns["Ten"].HeaderText = "Tên tài liệu";
                    QLTK_dgvKQTK.Columns["Ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    QLTK_dgvKQTK.Columns["TongSL"].HeaderText = "Tổng số lượng";
                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[QLTK_dgvKQTK.Columns.Count - 1].Value.ToString());
                    }
                    QLTK_lblTongCong.Text = tongcong.ToString();

                    for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                    {

                        DataGridViewColumn dgvCl = QLTK_dgvKQTK.Columns[i];
                        dgvCl.MinimumWidth = 100;
                        dgvCl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbTaiLieu.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 1; c < QLTK_dgvKQTK.Columns.Count - 1; c++)
                    {
                        int tong = 0;
                        for (int r = 0; r < QLTK_dgvKQTK.Rows.Count - 1; r++)
                        {
                            tong += int.Parse(QLTK_dgvKQTK.Rows[r].Cells[c].Value.ToString());
                        }
                        chart_Kq.Series[name].Points.AddXY(dt.Columns[c].ToString(), Double.Parse(tong.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo tháng");

                }
                else if (QLTK_rdbLoaiTL.Checked)
                {
                    rdbOption = 1;
                    // code loại tài liệu trong khoang thang
                    lstTenTheoKhoang = tk.dsLTLTenkhoangThang(bd, kt);
                    lstTimeTheoKhoang = tk.dsNgayLapTheoKhoangThang(bd, kt);
                    dt.Columns.Add("Ten", typeof(string));
                    for (int i = 0; i < lstTimeTheoKhoang.Count; i++)
                    {
                        dc = new DataColumn();
                        dc.ColumnName = lstTimeTheoKhoang[i].NgayLap + "/" + lstTimeTheoKhoang[i].NamLap;
                        dt.Columns.Add(dc);
                    }
                    dt.Columns.Add("TongSL", typeof(int));


                    for (int j = 0; j < lstTenTheoKhoang.Count; j++) //ten
                    {
                        int tsl = 0;
                        dr = dt.NewRow();
                        dr["Ten"] = lstTenTheoKhoang[j].Ten;
                        for (int c = 1; c < dt.Columns.Count - 1; c++) //col ngay
                        {

                            string[] arr = dt.Columns[c].ColumnName.Split('/');

                            DSTK_TLTheoKhoang sl = tk.dsLTLSLTheoKhoangThang(lstTenTheoKhoang[j].Ten.ToString(),
                               int.Parse(arr[0]),
                               int.Parse(arr[1]));
                            if (sl != null)
                            {
                                dr[dt.Columns[c].ColumnName] = sl.SoLuong;
                            }
                            else
                            {
                                dr[dt.Columns[c].ColumnName] = 0;
                            }
                            tsl += int.Parse(dr[dt.Columns[c].ColumnName].ToString());
                        }
                        dr["TongSL"] = tsl;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;

                    QLTK_dgvKQTK.Columns["Ten"].HeaderText = "Tên loại tài liệu";
                    QLTK_dgvKQTK.Columns["Ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    QLTK_dgvKQTK.Columns["Ten"].MinimumWidth = 300;
                    QLTK_dgvKQTK.Columns["TongSL"].HeaderText = "Tổng số lượng";
                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[QLTK_dgvKQTK.Columns.Count - 1].Value.ToString());
                    }
                    QLTK_lblTongCong.Text = tongcong.ToString();

                    for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                    {

                        DataGridViewColumn dgvCl = QLTK_dgvKQTK.Columns[i];
                        dgvCl.MinimumWidth = 100;
                        dgvCl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbLoaiTL.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 1; c < QLTK_dgvKQTK.Columns.Count - 1; c++)
                    {
                        int tong = 0;
                        for (int r = 0; r < QLTK_dgvKQTK.Rows.Count - 1; r++)
                        {
                            tong += int.Parse(QLTK_dgvKQTK.Rows[r].Cells[c].Value.ToString());
                        }
                        chart_Kq.Series[name].Points.AddXY(dt.Columns[c].ToString(), Double.Parse(tong.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo tháng");
                }
                else if (QLTK_rdbChuDe.Checked)
                {
                    rdbOption = 2;
                    // code chu de trong khoang thang
                    lstTenTheoKhoang = tk.dsCDTenkhoangThang(bd, kt);
                    lstTimeTheoKhoang = tk.dsNgayLapTheoKhoangThang(bd, kt);
                    dt.Columns.Add("Ten", typeof(string));
                    for (int i = 0; i < lstTimeTheoKhoang.Count; i++)
                    {
                        dc = new DataColumn();
                        dc.ColumnName = lstTimeTheoKhoang[i].NgayLap + "/" + lstTimeTheoKhoang[i].NamLap;
                        dt.Columns.Add(dc);
                    }
                    dt.Columns.Add("TongSL", typeof(int));


                    for (int j = 0; j < lstTenTheoKhoang.Count; j++) //ten
                    {
                        int tsl = 0;
                        dr = dt.NewRow();
                        dr["Ten"] = lstTenTheoKhoang[j].Ten;
                        for (int c = 1; c < dt.Columns.Count - 1; c++) //col ngay
                        {

                            string[] arr = dt.Columns[c].ColumnName.Split('/');

                            DSTK_TLTheoKhoang sl = tk.dsCDSLTheoKhoangThang(lstTenTheoKhoang[j].Ten.ToString(),
                               int.Parse(arr[0]),
                               int.Parse(arr[1]));
                            if (sl != null)
                            {
                                dr[dt.Columns[c].ColumnName] = sl.SoLuong;
                            }
                            else
                            {
                                dr[dt.Columns[c].ColumnName] = 0;
                            }
                            tsl += int.Parse(dr[dt.Columns[c].ColumnName].ToString());
                        }
                        dr["TongSL"] = tsl;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;

                    QLTK_dgvKQTK.Columns["Ten"].HeaderText = "Tên chủ đề";
                    QLTK_dgvKQTK.Columns["Ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    QLTK_dgvKQTK.Columns["TongSL"].HeaderText = "Tổng số lượng";
                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[QLTK_dgvKQTK.Columns.Count - 1].Value.ToString());
                    }
                    QLTK_lblTongCong.Text = tongcong.ToString();

                    for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                    {

                        DataGridViewColumn dgvCl = QLTK_dgvKQTK.Columns[i];
                        dgvCl.MinimumWidth = 100;
                        dgvCl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbChuDe.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 1; c < QLTK_dgvKQTK.Columns.Count - 1; c++)
                    {
                        int tong = 0;
                        for (int r = 0; r < QLTK_dgvKQTK.Rows.Count - 1; r++)
                        {
                            tong += int.Parse(QLTK_dgvKQTK.Rows[r].Cells[c].Value.ToString());
                        }
                        chart_Kq.Series[name].Points.AddXY(dt.Columns[c].ToString(), Double.Parse(tong.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo tháng");
                }
                else if (QLTK_rdbKhoa.Checked)
                {
                    rdbOption = 3;
                    // code Khoa trong khoang thang
                    lstTenTheoKhoang = tk.dsKhoaTenkhoangThang(bd, kt);
                    lstTimeTheoKhoang = tk.dsNgayLapTheoKhoangThang(bd, kt);
                    dt.Columns.Add("Ten", typeof(string));
                    for (int i = 0; i < lstTimeTheoKhoang.Count; i++)
                    {
                        dc = new DataColumn();
                        dc.ColumnName = lstTimeTheoKhoang[i].NgayLap + "/" + lstTimeTheoKhoang[i].NamLap;
                        dt.Columns.Add(dc);
                    }
                    dt.Columns.Add("TongSL", typeof(int));


                    for (int j = 0; j < lstTenTheoKhoang.Count; j++) //ten
                    {
                        int tsl = 0;
                        dr = dt.NewRow();
                        dr["Ten"] = lstTenTheoKhoang[j].Ten;
                        for (int c = 1; c < dt.Columns.Count - 1; c++) //col ngay
                        {

                            string[] arr = dt.Columns[c].ColumnName.Split('/');

                            DSTK_TLTheoKhoang sl = tk.dsKhoaSLTheoKhoangThang(lstTenTheoKhoang[j].Ten.ToString(),
                               int.Parse(arr[0]),
                               int.Parse(arr[1]));
                            if (sl != null)
                            {
                                dr[dt.Columns[c].ColumnName] = sl.SoLuong;
                            }
                            else
                            {
                                dr[dt.Columns[c].ColumnName] = 0;
                            }
                            tsl += int.Parse(dr[dt.Columns[c].ColumnName].ToString());
                        }
                        dr["TongSL"] = tsl;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;

                    QLTK_dgvKQTK.Columns["Ten"].HeaderText = "Tên khoa";
                    QLTK_dgvKQTK.Columns["Ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    QLTK_dgvKQTK.Columns["TongSL"].HeaderText = "Tổng số lượng";
                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[QLTK_dgvKQTK.Columns.Count - 1].Value.ToString());
                    }
                    QLTK_lblTongCong.Text = tongcong.ToString();

                    for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                    {

                        DataGridViewColumn dgvCl = QLTK_dgvKQTK.Columns[i];
                        dgvCl.MinimumWidth = 100;
                        dgvCl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbKhoa.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 1; c < QLTK_dgvKQTK.Columns.Count - 1; c++)
                    {
                        int tong = 0;
                        for (int r = 0; r < QLTK_dgvKQTK.Rows.Count - 1; r++)
                        {
                            tong += int.Parse(QLTK_dgvKQTK.Rows[r].Cells[c].Value.ToString());
                        }
                        chart_Kq.Series[name].Points.AddXY(dt.Columns[c].ToString(), Double.Parse(tong.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo tháng");
                }
                else if (QLTK_rdbPhiCoc.Checked)
                {
                    rdbOption = 4;
                    // code phi coc trong khoang thang
                    lstPhiCocTheoKhoang = tk.dsPhiCocSLTheoKhoangThang(bd, kt);
                    dt2.Columns.Add("NgayLap", typeof(DateTime));
                    dt2.Columns.Add("TongTien", typeof(string));
                    foreach (DSTK_TLTheoKhoang item in lstPhiCocTheoKhoang)
                    {
                        dr = dt2.NewRow();

                        dr["NgayLap"] = item.NgayLap + "/" + item.NamLap;
                        dr["TongTien"] = item.PhiCoc;
                        dt2.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt2;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {

                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "MM/yyyy";
                        QLTK_dgvKQTK.Columns["TongTien"].HeaderText = "Tổng tiền";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongtien += double.Parse(QLTK_dgvKQTK.Rows[i].Cells[1].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongtien.ToString() + " VNĐ";

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbPhiCoc.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 0; c < QLTK_dgvKQTK.Rows.Count - 1; c++)
                    {
                        chart_Kq.Series[name].Points.AddXY(DateTime.Parse(QLTK_dgvKQTK.Rows[c].Cells[0].Value.ToString()).ToString("dd/MM/yyyy"), double.Parse(QLTK_dgvKQTK.Rows[c].Cells[1].Value.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo tháng");
                }
            }
            else if (QLTK_rdbTheoNam.Checked)
            {
                
                int nam = int.Parse(QLTK_dtpTheoNam.Value.Year.ToString());
                if (QLTK_rdbTaiLieu.Checked)
                {
                    chart_Kq.DataSource = null;
                    chart_Kq.Series.Clear();
                    chart_Kq.Titles.Clear();
                    // code tài liệu trong 1 nam
                    lstPMTL = tk.dsTlTrongNam(nam);
                    dt.Columns.Add("TenTaiLieu", typeof(string));
                    dt.Columns.Add("NgayLap", typeof(DateTime));
                    dt.Columns.Add("SoLuongTL", typeof(int));
                    foreach (DSTK_TLPM item in lstPMTL)
                    {
                        dr = dt.NewRow();
                        dr["TenTaiLieu"] = item.TenTaiLieu;
                        dr["NgayLap"] = item.NgayLap;
                        dr["SoLuongTL"] = item.SoLuongTL;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {
                        QLTK_dgvKQTK.Columns["TenTaiLieu"].HeaderText = "Tên tài liệu";
                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "MM/yyyy";
                        QLTK_dgvKQTK.Columns["SoLuongTL"].HeaderText = "Số lượng";
                        QLTK_dgvKQTK.Columns["TenTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongcong.ToString();

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }

                }
                else if (QLTK_rdbLoaiTL.Checked)
                {
                    rdbOption = 1;
                    // code loại tài liệu trong 1 nam
                    lstLTL = tk.dsLoaiTLTrongNam(nam);
                    dt.Columns.Add("TenLoaiTaiLieu", typeof(string));
                    dt.Columns.Add("NgayLap", typeof(DateTime));
                    dt.Columns.Add("SoLuongLTL", typeof(int));
                    foreach (DSTK_LTL item in lstLTL)
                    {
                        dr = dt.NewRow();
                        dr["TenLoaiTaiLieu"] = item.TenLoaiTaiLieu;
                        dr["NgayLap"] = item.NgayLap;
                        dr["SoLuongLTL"] = item.SoLuongLTL;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {
                        QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].HeaderText = "Tên loại tài liệu";
                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "MM/yyyy";
                        QLTK_dgvKQTK.Columns["SoLuongLTL"].HeaderText = "Số lượng";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongcong.ToString();

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbLoaiTL.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        string ten = QLTK_dgvKQTK.Rows[i].Cells[0].Value.ToString();
                        chart_Kq.Series[name].Points.AddXY(ten,
                            Double.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString()));
                    }

                    chart_Kq.Titles.Add("Thống kê trong năm");

                }
                else if (QLTK_rdbChuDe.Checked)
                {
                    rdbOption = 2;
                    // code chu de trong 1 nam
                    lstCD = tk.dsChuDeTrongNam( nam);
                    dt.Columns.Add("TenChuDe", typeof(string));
                    dt.Columns.Add("NgayLap", typeof(DateTime));
                    dt.Columns.Add("SoLuongCD", typeof(int));
                    foreach (DSTK_CD item in lstCD)
                    {
                        dr = dt.NewRow();
                        dr["TenChuDe"] = item.TenChuDe;
                        dr["NgayLap"] = item.NgayLap;
                        dr["SoLuongCD"] = item.SoLuongCD;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {
                        QLTK_dgvKQTK.Columns["TenChuDe"].HeaderText = "Tên chủ đề";
                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "MM/yyyy";
                        QLTK_dgvKQTK.Columns["SoLuongCD"].HeaderText = "Số lượng";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongcong.ToString();

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbChuDe.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        string ten = QLTK_dgvKQTK.Rows[i].Cells[0].Value.ToString();
                        chart_Kq.Series[name].Points.AddXY(ten,
                            Double.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString()));
                    }

                    chart_Kq.Titles.Add("Thống kê trong năm");
                }
                else if (QLTK_rdbKhoa.Checked)
                {
                    chart_Kq.DataSource = null;
                    chart_Kq.Series.Clear();
                    chart_Kq.Titles.Clear();
                    // code Khoa trong 1 nam
                    lstKhoa = tk.dsKhoaTrongNam( nam);
                    dt.Columns.Add("TenKhoa", typeof(string));
                    dt.Columns.Add("NgayLap", typeof(DateTime));
                    dt.Columns.Add("SoLuongKhoa", typeof(int));
                    foreach (DSTK_Khoa item in lstKhoa)
                    {
                        dr = dt.NewRow();
                        dr["TenKhoa"] = item.TenKhoa;
                        dr["NgayLap"] = item.NgayLap;
                        dr["SoLuongKhoa"] = item.SoLuongKhoa;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {
                        QLTK_dgvKQTK.Columns["TenKhoa"].HeaderText = "Tên Khoa";
                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        QLTK_dgvKQTK.Columns["SoLuongKhoa"].HeaderText = "Số lượng";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[2].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongcong.ToString();

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                }
                else if (QLTK_rdbPhiCoc.Checked)
                {
                    chart_Kq.DataSource = null;
                    chart_Kq.Series.Clear();
                    chart_Kq.Titles.Clear();
                    // code phi coc trong 1 nam
                    lstPhiCoc = tk.dsPhiCocTrongNam(nam);
                    dt2.Columns.Add("NgayLap", typeof(DateTime));
                    dt2.Columns.Add("TongTien", typeof(string));
                    foreach (DSTK_PhiCoc item in lstPhiCoc)
                    {
                        dr = dt2.NewRow();

                        dr["NgayLap"] = item.NgayLap;
                        dr["TongTien"] = item.TongTien;
                        dt2.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt2;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {

                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "MM/yyyy";
                        QLTK_dgvKQTK.Columns["TongTien"].HeaderText = "Tổng tiền";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongtien += double.Parse(QLTK_dgvKQTK.Rows[i].Cells[1].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongtien.ToString() + " VNĐ";

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbPhiCoc.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 0; c < QLTK_dgvKQTK.Rows.Count - 1; c++)
                    {
                        chart_Kq.Series[name].Points.AddXY(DateTime.Parse(QLTK_dgvKQTK.Rows[c].Cells[0].Value.ToString()).ToString("dd/MM/yyyy"), double.Parse(QLTK_dgvKQTK.Rows[c].Cells[1].Value.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo ngày");
                }

            }
            else
            {
                rdbTimes = 5;
                int nambd = QLTK_dtpNamBD.Value.Year;
                int namkt = QLTK_dtpNamKT.Value.Year;
                if (QLTK_rdbTaiLieu.Checked)
                {
                    rdbOption = 0;
                    // code tài liệu trong khoang nam

                    lstTenTheoKhoang = tk.dsTLTenkhoangNam(nambd, namkt);
                    lstTimeTheoKhoang = tk.dsNgayLapTheoKhoangNam(nambd, namkt);
                    dt.Columns.Add("Ten", typeof(string));
                    for (int i = 0; i < lstTimeTheoKhoang.Count; i++)
                    {
                        dc = new DataColumn();
                        dc.ColumnName = lstTimeTheoKhoang[i].NgayLap;
                        dt.Columns.Add(dc);
                    }
                    dt.Columns.Add("TongSL", typeof(int));


                    for (int j = 0; j < lstTenTheoKhoang.Count; j++) //ten
                    {
                        int tsl = 0;
                        dr = dt.NewRow();
                        dr["Ten"] = lstTenTheoKhoang[j].Ten;
                        for (int c = 1; c < dt.Columns.Count - 1; c++) //col ngay
                        {


                            DSTK_TLTheoKhoang sl = tk.dsTLSLTheoKhoangNam(lstTenTheoKhoang[j].Ten.ToString(), int.Parse(dt.Columns[c].ColumnName));
                            if (sl != null)
                            {
                                dr[dt.Columns[c].ColumnName] = sl.SoLuong;
                            }
                            else
                            {
                                dr[dt.Columns[c].ColumnName] = 0;
                            }
                            tsl += int.Parse(dr[dt.Columns[c].ColumnName].ToString());
                        }
                        dr["TongSL"] = tsl;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;

                    QLTK_dgvKQTK.Columns["Ten"].HeaderText = "Tên tài liệu";
                    QLTK_dgvKQTK.Columns["Ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    QLTK_dgvKQTK.Columns["Ten"].MinimumWidth = 300;
                    QLTK_dgvKQTK.Columns["TongSL"].HeaderText = "Tổng số lượng";
                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[QLTK_dgvKQTK.Columns.Count - 1].Value.ToString());
                    }
                    QLTK_lblTongCong.Text = tongcong.ToString();

                    for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                    {

                        DataGridViewColumn dgvCl = QLTK_dgvKQTK.Columns[i];
                        dgvCl.MinimumWidth = 100;
                        dgvCl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbTaiLieu.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 1; c < QLTK_dgvKQTK.Columns.Count - 1; c++)
                    {
                        int tong = 0;
                        for (int r = 0; r < QLTK_dgvKQTK.Rows.Count - 1; r++)
                        {
                            tong += int.Parse(QLTK_dgvKQTK.Rows[r].Cells[c].Value.ToString());
                        }
                        chart_Kq.Series[name].Points.AddXY(dt.Columns[c].ToString(), Double.Parse(tong.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo năm");

                }
                else if (QLTK_rdbLoaiTL.Checked)
                {
                    rdbOption = 1;
                    // code loại tài liệu trong  khoang nam
                    lstTenTheoKhoang = tk.dsLTLTenkhoangNam(nambd, namkt);
                    lstTimeTheoKhoang = tk.dsNgayLapTheoKhoangNam(nambd, namkt);
                    dt.Columns.Add("Ten", typeof(string));
                    for (int i = 0; i < lstTimeTheoKhoang.Count; i++)
                    {
                        dc = new DataColumn();
                        dc.ColumnName = lstTimeTheoKhoang[i].NgayLap;
                        dt.Columns.Add(dc);
                    }
                    dt.Columns.Add("TongSL", typeof(int));


                    for (int j = 0; j < lstTenTheoKhoang.Count; j++) //ten
                    {
                        int tsl = 0;
                        dr = dt.NewRow();
                        dr["Ten"] = lstTenTheoKhoang[j].Ten;
                        for (int c = 1; c < dt.Columns.Count - 1; c++) //col ngay
                        {


                            DSTK_TLTheoKhoang sl = tk.dsLTLSLTheoKhoangNam(lstTenTheoKhoang[j].Ten.ToString(), int.Parse(dt.Columns[c].ColumnName));
                            if (sl != null)
                            {
                                dr[dt.Columns[c].ColumnName] = sl.SoLuong;
                            }
                            else
                            {
                                dr[dt.Columns[c].ColumnName] = 0;
                            }
                            tsl += int.Parse(dr[dt.Columns[c].ColumnName].ToString());
                        }
                        dr["TongSL"] = tsl;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;

                    QLTK_dgvKQTK.Columns["Ten"].HeaderText = "Tên loại tài liệu";
                    QLTK_dgvKQTK.Columns["Ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    QLTK_dgvKQTK.Columns["Ten"].MinimumWidth = 300;
                    QLTK_dgvKQTK.Columns["TongSL"].HeaderText = "Tổng số lượng";
                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[QLTK_dgvKQTK.Columns.Count - 1].Value.ToString());
                    }
                    QLTK_lblTongCong.Text = tongcong.ToString();

                    for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                    {

                        DataGridViewColumn dgvCl = QLTK_dgvKQTK.Columns[i];
                        dgvCl.MinimumWidth = 100;
                        dgvCl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbLoaiTL.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 1; c < QLTK_dgvKQTK.Columns.Count - 1; c++)
                    {
                        int tong = 0;
                        for (int r = 0; r < QLTK_dgvKQTK.Rows.Count - 1; r++)
                        {
                            tong += int.Parse(QLTK_dgvKQTK.Rows[r].Cells[c].Value.ToString());
                        }
                        chart_Kq.Series[name].Points.AddXY(dt.Columns[c].ToString(), Double.Parse(tong.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo năm");
                }
                else if (QLTK_rdbChuDe.Checked)
                {
                    rdbOption = 2;
                    // code chu de trong  khoang nam
                    lstTenTheoKhoang = tk.dsCDTenkhoangNam(nambd, namkt);
                    lstTimeTheoKhoang = tk.dsNgayLapTheoKhoangNam(nambd, namkt);
                    dt.Columns.Add("Ten", typeof(string));
                    for (int i = 0; i < lstTimeTheoKhoang.Count; i++)
                    {
                        dc = new DataColumn();
                        dc.ColumnName = lstTimeTheoKhoang[i].NgayLap;
                        dt.Columns.Add(dc);
                    }
                    dt.Columns.Add("TongSL", typeof(int));


                    for (int j = 0; j < lstTenTheoKhoang.Count; j++) //ten
                    {
                        int tsl = 0;
                        dr = dt.NewRow();
                        dr["Ten"] = lstTenTheoKhoang[j].Ten;
                        for (int c = 1; c < dt.Columns.Count - 1; c++) //col ngay
                        {


                            DSTK_TLTheoKhoang sl = tk.dsCDSLTheoKhoangNam(lstTenTheoKhoang[j].Ten.ToString(), int.Parse(dt.Columns[c].ColumnName));
                            if (sl != null)
                            {
                                dr[dt.Columns[c].ColumnName] = sl.SoLuong;
                            }
                            else
                            {
                                dr[dt.Columns[c].ColumnName] = 0;
                            }
                            tsl += int.Parse(dr[dt.Columns[c].ColumnName].ToString());
                        }
                        dr["TongSL"] = tsl;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;

                    QLTK_dgvKQTK.Columns["Ten"].HeaderText = "Tên chủ đề";
                    QLTK_dgvKQTK.Columns["Ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    QLTK_dgvKQTK.Columns["Ten"].MinimumWidth = 300;
                    QLTK_dgvKQTK.Columns["TongSL"].HeaderText = "Tổng số lượng";
                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[QLTK_dgvKQTK.Columns.Count - 1].Value.ToString());
                    }
                    QLTK_lblTongCong.Text = tongcong.ToString();

                    for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                    {

                        DataGridViewColumn dgvCl = QLTK_dgvKQTK.Columns[i];
                        dgvCl.MinimumWidth = 100;
                        dgvCl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbChuDe.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 1; c < QLTK_dgvKQTK.Columns.Count - 1; c++)
                    {
                        int tong = 0;
                        for (int r = 0; r < QLTK_dgvKQTK.Rows.Count - 1; r++)
                        {
                            tong += int.Parse(QLTK_dgvKQTK.Rows[r].Cells[c].Value.ToString());
                        }
                        chart_Kq.Series[name].Points.AddXY(dt.Columns[c].ToString(), Double.Parse(tong.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo năm");
                }
                else if (QLTK_rdbKhoa.Checked)
                {
                    rdbOption = 3;
                    // code Khoa trong  khoang nam
                    lstTenTheoKhoang = tk.dsKhoaTenkhoangNam(nambd, namkt);
                    lstTimeTheoKhoang = tk.dsNgayLapTheoKhoangNam(nambd, namkt);
                    dt.Columns.Add("Ten", typeof(string));
                    for (int i = 0; i < lstTimeTheoKhoang.Count; i++)
                    {
                        dc = new DataColumn();
                        dc.ColumnName = lstTimeTheoKhoang[i].NgayLap;
                        dt.Columns.Add(dc);
                    }
                    dt.Columns.Add("TongSL", typeof(int));


                    for (int j = 0; j < lstTenTheoKhoang.Count; j++) //ten
                    {
                        int tsl = 0;
                        dr = dt.NewRow();
                        dr["Ten"] = lstTenTheoKhoang[j].Ten;
                        for (int c = 1; c < dt.Columns.Count - 1; c++) //col ngay
                        {


                            DSTK_TLTheoKhoang sl = tk.dsKhoaSLTheoKhoangNam(lstTenTheoKhoang[j].Ten.ToString(), int.Parse(dt.Columns[c].ColumnName));
                            if (sl != null)
                            {
                                dr[dt.Columns[c].ColumnName] = sl.SoLuong;
                            }
                            else
                            {
                                dr[dt.Columns[c].ColumnName] = 0;
                            }
                            tsl += int.Parse(dr[dt.Columns[c].ColumnName].ToString());
                        }
                        dr["TongSL"] = tsl;
                        dt.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt;

                    QLTK_dgvKQTK.Columns["Ten"].HeaderText = "Tên Khoa";
                    QLTK_dgvKQTK.Columns["Ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    QLTK_dgvKQTK.Columns["Ten"].MinimumWidth = 300;
                    QLTK_dgvKQTK.Columns["TongSL"].HeaderText = "Tổng số lượng";
                    for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                    {
                        tongcong += int.Parse(QLTK_dgvKQTK.Rows[i].Cells[QLTK_dgvKQTK.Columns.Count - 1].Value.ToString());
                    }
                    QLTK_lblTongCong.Text = tongcong.ToString();

                    for (int i = 1; i < QLTK_dgvKQTK.Columns.Count; i++)
                    {

                        DataGridViewColumn dgvCl = QLTK_dgvKQTK.Columns[i];
                        dgvCl.MinimumWidth = 100;
                        dgvCl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbKhoa.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 1; c < QLTK_dgvKQTK.Columns.Count - 1; c++)
                    {
                        int tong = 0;
                        for (int r = 0; r < QLTK_dgvKQTK.Rows.Count - 1; r++)
                        {
                            tong += int.Parse(QLTK_dgvKQTK.Rows[r].Cells[c].Value.ToString());
                        }
                        chart_Kq.Series[name].Points.AddXY(dt.Columns[c].ToString(), Double.Parse(tong.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo năm");
                }
                else if (QLTK_rdbPhiCoc.Checked)
                {
                    rdbOption = 4;
                    // code phi coc trong  khoang nam
                    lstPhiCocTheoKhoang = tk.dsPhiCocSLTheoKhoangNam(nambd, namkt);
                    dt2.Columns.Add("NgayLap", typeof(string));
                    dt2.Columns.Add("TongTien", typeof(string));
                    foreach (DSTK_TLTheoKhoang item in lstPhiCocTheoKhoang)
                    {
                        dr = dt2.NewRow();

                        dr["NgayLap"] = item.NgayLap;
                        dr["TongTien"] = item.PhiCoc;
                        dt2.Rows.Add(dr);
                    }
                    QLTK_dgvKQTK.DataSource = dt2;
                    if (QLTK_dgvKQTK.Rows.Count - 1 > 0)
                    {

                        QLTK_dgvKQTK.Columns["NgayLap"].HeaderText = "Ngày lập";
                        //QLTK_dgvKQTK.Columns["NgayLap"].DefaultCellStyle.Format = "MM/yyyy";
                        QLTK_dgvKQTK.Columns["TongTien"].HeaderText = "Tổng tiền";
                        //QLTK_dgvKQTK.Columns["TenLoaiTaiLieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        for (int i = 0; i < QLTK_dgvKQTK.Columns.Count; i++)
                        {
                            QLTK_dgvKQTK.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        }
                        for (int i = 0; i < QLTK_dgvKQTK.Rows.Count - 1; i++)
                        {
                            tongtien += double.Parse(QLTK_dgvKQTK.Rows[i].Cells[1].Value.ToString());
                        }
                        QLTK_lblTongCong.Text = tongtien.ToString() + " VNĐ";

                    }
                    else
                    {
                        tongcong = 0;
                        QLTK_lblTongCong.Text = tongcong.ToString();
                        MessageBox.Show("Không có tài liệu được mượn trong ngày được chọn !");
                        return;
                    }
                    // chatt
                    chart_Kq.DataSource = dt;
                    string name = QLTK_rdbPhiCoc.Text;
                    chart_Kq.Series.Add(name).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                    for (int c = 0; c < QLTK_dgvKQTK.Rows.Count - 1; c++)
                    {
                        chart_Kq.Series[name].Points.AddXY(DateTime.Parse(QLTK_dgvKQTK.Rows[c].Cells[0].Value.ToString()).ToString("dd/MM/yyyy"), double.Parse(QLTK_dgvKQTK.Rows[c].Cells[1].Value.ToString()));
                    }
                    chart_Kq.Titles.Add("Thống kê theo ngày");
                }
            }
        }

        private void QLTK_rdbPhiCoc_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_rdbPhiCoc.Checked == false)
            {
                QLTK_dgvKQTK.DataSource = null;
                chart_Kq.DataSource = null;
                chart_Kq.Series.Clear();
                chart_Kq.Titles.Clear();

            }
        }

        private void QLTK_rdbKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_rdbKhoa.Checked == false)
            {
                QLTK_dgvKQTK.DataSource = null;
                chart_Kq.DataSource = null;
                chart_Kq.Series.Clear();
                chart_Kq.Titles.Clear();
            }
        }

        private void QLTK_rdbLoaiTL_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_rdbLoaiTL.Checked == false)
            {
                QLTK_dgvKQTK.DataSource = null;
                chart_Kq.DataSource = null;
                chart_Kq.Series.Clear();
                chart_Kq.Titles.Clear();

            }
        }

        private void QLTK_rdbTaiLieu_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_rdbTaiLieu.Checked == false)
            {
                QLTK_dgvKQTK.DataSource = null;
                chart_Kq.DataSource = null;
                chart_Kq.Series.Clear();
                chart_Kq.Titles.Clear();
            }
        }

        private void QLTK_rdbChuDe_CheckedChanged(object sender, EventArgs e)
        {
            if (QLTK_rdbChuDe.Checked == false)
            {
                QLTK_dgvKQTK.DataSource = null;
                chart_Kq.DataSource = null;
                chart_Kq.Series.Clear();
                chart_Kq.Titles.Clear();

            }
        }
    }
}
