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
        public UF_ThongKe()
        {
            InitializeComponent();

        }

        private void QLTK_PM_btnXem_Click(object sender, EventArgs e)
        {
            if(QLTK_PM_rdoChuaTraQuaHan.Checked)
            {
                QLTK_PM_dgvDS.DataSource = tk.loadPhieuMuonTreHan();
            }
        }

        private void QLTK_PM_btnIn_Click(object sender, EventArgs e)
        {
            if(QLTK_PM_dgvDS.RowCount == 0)
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
            thongtinnhanvien.Rows.Add(Frm_Main.hoten,Frm_Main.username);

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
    }
}
