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
    public partial class Frm_DangNhap : Form
    {
        public static string username = "";
        public static string hoten = "";
        DangNhap dn = new DangNhap();
        public Frm_DangNhap()
        {
            InitializeComponent();
            xoaText(DN_txtMK);
        }
        
        private void DN_btnDangNhap_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MaNhanVien = int.Parse(DN_txtTK.Text);
            nv.MatKhau = DN_txtMK.Text;
            if (dn.ktraDangNhapTK(nv, ref username, ref hoten) == 0)
            {
                MessageBox.Show("Tài khoản không tồn tại !");
                DN_txtMK.Clear();
                DN_txtMK.Focus();
                return;
            }
            else if(dn.ktraDangNhapTK(nv, ref username, ref hoten) == 2)
            {
                MessageBox.Show("Tài khoản này đã bị khoá.");
                DN_txtMK.Clear();
                DN_txtMK.Focus();
                return;
            }
            else if (dn.ktraDangNhapTK(nv, ref username, ref hoten) == -1)
            {
                MessageBox.Show("Mật khẩu không đúng !");
                DN_txtMK.Clear();
                DN_txtMK.Focus();
                return;
            }
            else {
                Frm_Main frmMain = new Frm_Main();
                frmMain.Show();
                
            }
        }
        public void xoaText(Control ctrl)
        {
            ctrl.Text = string.Empty;
        }
        private void DN_btnClose_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn chắc muốn đóng ?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DN_txtMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DN_btnDangNhap_Click(sender, e);
            }
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            DN_txtTK.Focus();
        }
    }
}
