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

            QLTK_NV_cboLoaiNV.Enabled = false;
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
            else {
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
            else {
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
            }else
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
            else {
                QLTK_PXL_dgvPXL.DataSource = tk.loadDSPXLTheoNgay(QLTK_PXL_dtpNgayBD.Value, QLTK_PXL_dtpNgayKT.Value);
                if(QLTK_PXL_dgvPXL.Rows.Count == 0)
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
    }
}
