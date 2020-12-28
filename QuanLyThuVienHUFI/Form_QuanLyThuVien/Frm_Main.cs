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
    public partial class Frm_Main : Form
    {
        public static string hoten = "";
        public static string username = "";
        PhanQuyen pq = new PhanQuyen();
        public Frm_Main()
        {
            InitializeComponent();
            setTooltips();
        }
        bool mk = true;
        private void Main_btnMuonTra_Click(object sender, EventArgs e)
        {
            pnl_container.Controls.Clear();
            UF_QLMuonTra ufMT = new UF_QLMuonTra();
            pnl_container.Controls.Add(ufMT);
           
        }

        private void Main_btnQLNV_Click(object sender, EventArgs e)
        {
            pnl_container.Controls.Clear();
            UF_NhanVien ufnv = new UF_NhanVien();
            pnl_container.Controls.Add(ufnv);
            
        }

        private void Main_btnQLTL_Click(object sender, EventArgs e)
        {
            pnl_container.Controls.Clear();
            UF_TaiLieu  uftl = new UF_TaiLieu();
            pnl_container.Controls.Add(uftl);
           
        }

        private void Main_btnDG_Click(object sender, EventArgs e)
        {
            pnl_container.Controls.Clear();
            UF_DocGia ufdg = new UF_DocGia();
            pnl_container.Controls.Add(ufdg);
            
        }

        private void Main_btnDangXuat_Click(object sender, EventArgs e)
        {
            Frm_DangNhap frmDN = new Frm_DangNhap();
            DialogResult rs = MessageBox.Show("Bạn muốn đăng xuất?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Frm_Main.ActiveForm.Close();
                
               
            }
        }

        private void Main_btnThongKe_Click(object sender, EventArgs e)
        {
            pnl_container.Controls.Clear();
            UF_ThongKe uftk = new UF_ThongKe();
            pnl_container.Controls.Add(uftk);
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

            hoten = Frm_DangNhap.hoten;
            username = Frm_DangNhap.username;
            Main_TenNV.Text = hoten;
            phanQuyen();
        }
        public void setTooltips()
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(Main_btnDG, "Alt + 4");
            tt.SetToolTip(Main_btnMuonTra, "Alt + 1");
            tt.SetToolTip(Main_btnPhanQuyen, "Alt + 7");
            tt.SetToolTip(Main_btnPhieu, "Alt + 5");
            tt.SetToolTip(Main_btnQLNV, "Alt + 2");
            tt.SetToolTip(Main_btnThongKe, "Alt + 6");
            tt.SetToolTip(Main_btnQLTL, "Alt + 3");
            tt.SetToolTip(Main_btnDG, "Alt + 4");
        }
        public void phanQuyen()
        {
            foreach(Control control in flowLayoutPanel2.Controls)
            {
                //if(control is Button)
                //{
                    foreach (PHANQUYEN pq in pq.getPhanQuyens(username))
                    {
                        if(control.Tag.ToString() == pq.MaManHinh)
                        {
                            if(pq.CoQuyen == false)
                            {
                                control.Enabled = false;
                            }    
                        }    
                    }    
                //}    
            }    
        }

        private void Main_btnPhieu_Click(object sender, EventArgs e)
        {
            pnl_container.Controls.Clear();
            UF_PHIEU ufphieu = new UF_PHIEU();
            pnl_container.Controls.Add(ufphieu);
        }

        private void Main_btnPhanQuyen_Click(object sender, EventArgs e)
        {
            pnl_container.Controls.Clear();
            UF_PhanQuyen ufpq = new UF_PhanQuyen();
            pnl_container.Controls.Add(ufpq);
        }

        private void Frm_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.NumPad1 || e.Alt == true && e.KeyCode == Keys.D1 )
            {
                pnl_container.Controls.Clear();
                UF_QLMuonTra ufMT = new UF_QLMuonTra();
                pnl_container.Controls.Add(ufMT);
            }else if (e.Alt == true && e.KeyCode == Keys.NumPad2 || e.Alt == true && e.KeyCode == Keys.D2)
            {
                pnl_container.Controls.Clear();
                UF_NhanVien ufnv = new UF_NhanVien();
                pnl_container.Controls.Add(ufnv);
            }
            else if (e.Alt == true && e.KeyCode == Keys.NumPad3 || e.Alt == true && e.KeyCode == Keys.D3)
            {
                pnl_container.Controls.Clear();
                UF_TaiLieu uftl = new UF_TaiLieu();
                pnl_container.Controls.Add(uftl);
            }
            else if (e.Alt == true && e.KeyCode == Keys.NumPad4 || e.Alt == true && e.KeyCode == Keys.D4)
            {
                pnl_container.Controls.Clear();
                UF_DocGia ufdg = new UF_DocGia();
                pnl_container.Controls.Add(ufdg);

            }
            else if (e.Alt == true && e.KeyCode == Keys.NumPad5 || e.Alt == true && e.KeyCode == Keys.D5)
            {
                pnl_container.Controls.Clear();
                UF_PHIEU ufphieu = new UF_PHIEU();
                pnl_container.Controls.Add(ufphieu);
            }
            else if (e.Alt == true && e.KeyCode == Keys.NumPad6 || e.Alt == true && e.KeyCode == Keys.D7)
            {
                pnl_container.Controls.Clear();
                UF_ThongKe uftk = new UF_ThongKe();
                pnl_container.Controls.Add(uftk);
            }
            else if (e.Alt == true && e.KeyCode == Keys.NumPad7 || e.Alt == true && e.KeyCode == Keys.D7)
            {
                pnl_container.Controls.Clear();
                UF_PhanQuyen ufpq = new UF_PhanQuyen();
                pnl_container.Controls.Add(ufpq);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult rs = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    Frm_Main.ActiveForm.Close();
                }
            }
        }
    }
}
