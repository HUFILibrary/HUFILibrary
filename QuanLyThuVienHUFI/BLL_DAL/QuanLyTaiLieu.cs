using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace BLL_DAL
{
    public class QuanLyTaiLieu
    {
        DB_QLTVDataContext db = new DB_QLTVDataContext();

        public List<VW_TAILIEU> getList(string typesearch, string txtsearch,string selection__toantu1, string txtSearchNangCao1, string selection__noidung1, string selection__toantu2, string txtSearchNangCao2, string selection__noidung2, string selection__toantu3, string txtSearchNangCao3, string selection__noidung3)
        {
            List<VW_TAILIEU> lstTL = new List<VW_TAILIEU>();
            List<SqlParameter> param_list = new List<SqlParameter>();

            string select = "";
            select += " SELECT * ";
            select += " FROM VW_TAILIEU ";
            select += " WHERE VW_TAILIEU.TinhTrangXoa = 0 ";
            if (typesearch == "1")
            {
                select += " AND VW_TAILIEU.MaVach LIKE {0} ";
                param_list.Add(new SqlParameter("MaVach1", "%"+txtsearch+"%"));
            }
            else if (typesearch == "2")
            {

                select += " AND VW_TAILIEU.TenTaiLieu LIKE {0} ";
                param_list.Add(new SqlParameter("TenTaiLieu1", "%" + txtsearch + "%"));
            }
            else if (typesearch == "3")
            {

                select += " AND VW_TAILIEU.TenTacGia LIKE {0} ";
                param_list.Add(new SqlParameter("TenTacGia1", "%" + txtsearch + "%"));
            }
            else if (typesearch == "4")
            {

                select += " AND VW_TAILIEU.TenNhaXuatBan LIKE {0} ";
                param_list.Add(new SqlParameter("TenNhaXuatBan1", "%" + txtsearch + "%"));
            }
            else if (typesearch == "5")
            {

                select += " AND VW_TAILIEU.TenChuDe LIKE {0} ";
                param_list.Add(new SqlParameter("TenChuDe1", "%" + txtsearch + "%"));
            }
            if(!string.IsNullOrEmpty(txtSearchNangCao1))
            {
                select += " "+ selection__toantu1 + " VW_TAILIEU."+ selection__noidung1+" LIKE {1} ";
                param_list.Add(new SqlParameter(selection__noidung1 + "2", "%" + txtSearchNangCao1 + "%"));
            }
            if (!string.IsNullOrEmpty(txtSearchNangCao2))
            {
                select += " " + selection__toantu2 + " VW_TAILIEU." + selection__noidung2 + " LIKE {2} ";
                param_list.Add(new SqlParameter(selection__noidung2 + "3", "%" + txtSearchNangCao2 + "%"));
            }
            if (!string.IsNullOrEmpty(txtSearchNangCao3))
            {
                select += " " + selection__toantu3 + " VW_TAILIEU." + selection__noidung3 + " LIKE {3} ";
                param_list.Add(new SqlParameter(selection__noidung3 + "3", "%" + txtSearchNangCao3 + "%"));
            }


            #region ORDER BY
            select += " ORDER BY VW_TAILIEU.MaVach ";
            #endregion
            try
            {
                txtsearch = "%" + txtsearch + "%";
                lstTL = db.ExecuteQuery<VW_TAILIEU>(select,getSqlParameters(param_list)).ToList();
            }
            catch(Exception ex)
            {
                string temp = ex.ToString();
            }
            

            return lstTL;
        }
        public Object[] getSqlParameters(List<SqlParameter> param_list)
        {

            var param_count = param_list.Count;
            var sql_parameters = new Object[param_count];

            for (var i = 0; i < param_count; i++)
            {
                sql_parameters[i] = param_list[i].Value;
            }

            return sql_parameters;
        }
        public List<VW_TAILIEU> getListTaiLieuByMaTaiLieu(string matailieu, ref List<string> lstDangMuon, ref List<VW_TAILIEU> lstKhongLuuThong)
        {
            List<VW_TAILIEU> lst = db.VW_TAILIEUs.Where(a => a.MaTaiLieu == matailieu).ToList();
            lstKhongLuuThong = db.VW_TAILIEUs.Where(a => a.TinhTrangXoa == true && a.MaTaiLieu == matailieu).ToList();
            List<string> lstCT = db.CT_PHIEUMUONs.Where(a => a.TinhTrangTraCT.ToString() == "False").Select(a => a.MaVach).ToList();
            //List<VW_TAILIEU> lstDangMuon = from lst in db.VW_TAILIEUs
            //                               join ct in db.CT_PHIEUMUONs on lst.MaVach equals ct.MaVach
            //                               where (!ct.MaVach.Contains(lst.MaVach)) && (ct.TinhTrangTraCT = false)
            //                               select lst;
            var listDM = from lstDM in db.VW_TAILIEUs
                         join ct in db.CT_PHIEUMUONs on lstDM.MaVach equals ct.MaVach
                         where (lstCT.Contains(lstDM.MaVach)) && (lstDM.MaTaiLieu == matailieu) && (ct.TinhTrangTraCT == false)
                         select lstDM;

            foreach(VW_TAILIEU item in listDM)
            {
                lstDangMuon.Add(item.MaVach);
            }
            return lst;
        }
        public List<VW_TAILIEUCUNGTACGIA> lstTLCungTacGia(string mavach)
        {
            VW_TAILIEU tl = db.VW_TAILIEUs.Where(a => a.MaVach == mavach).FirstOrDefault();
            List<VW_TAILIEUCUNGTACGIA> lst = new List<VW_TAILIEUCUNGTACGIA>();
            if (tl != null)
            {
                lst = db.VW_TAILIEUCUNGTACGIAs.Where(a => a.TenTacGia == tl.TenTacGia && a.MaTaiLieu != tl.MaTaiLieu).Distinct().ToList();
            }
            return lst;
        }
        public List<VW_TAILIEUCUNGCHUDE> lstTLCungChuDe(string mavach)
        {
            VW_TAILIEU tl = db.VW_TAILIEUs.Where(a => a.MaVach == mavach).FirstOrDefault();
            List<VW_TAILIEUCUNGCHUDE> lst = new List<VW_TAILIEUCUNGCHUDE>();
            if (tl != null)
            {
                lst = db.VW_TAILIEUCUNGCHUDEs.Where(a => a.TenChuDe == tl.TenChuDe && a.MaTaiLieu != tl.MaTaiLieu).Distinct().ToList();
            }
            return lst;
        }
        public List<VW_TAILIEU> lstTLCungTacGiaCoMaVach(string mavach)
        {
            VW_TAILIEU tl = db.VW_TAILIEUs.Where(a => a.MaVach == mavach).FirstOrDefault();
            List<VW_TAILIEU> lst = new List<VW_TAILIEU>();
            if (tl != null)
            {
                lst = db.VW_TAILIEUs.Where(a => a.TenTacGia == tl.TenTacGia && a.MaTaiLieu != tl.MaTaiLieu).Distinct().ToList();
            }

            List<VW_TAILIEUCUNGTACGIA> lstTLCungTacGiaDistinct = lstTLCungTacGia(mavach);
            List<VW_TAILIEU> rs = new List<VW_TAILIEU>();
            if (lstTLCungTacGiaDistinct.Count() > 6)
            {
                while (rs.Count() <= 5)
                {
                    VW_TAILIEU flg = lst.OrderBy(a => Guid.NewGuid()).Take(1).FirstOrDefault();
                    if (rs.Count() == 0)
                    {
                        rs.Add(flg);
                    }
                    else
                    {
                        int flgInt = 0;
                        foreach (VW_TAILIEU itemFlg in rs)
                        {
                            if (itemFlg.MaTaiLieu == flg.MaTaiLieu)
                            {
                                flgInt = 1;
                            }
                        }
                        if (flgInt == 0)
                        {
                            rs.Add(flg);
                        }
                    }
                }
            }
            else
            {
                foreach (VW_TAILIEU itemFlg in lst)
                {
                    if (rs.Count() == 0)
                    {
                        rs.Add(itemFlg);
                    }
                    else
                    {
                        int temp = 0;
                        foreach (VW_TAILIEU itemFlgA in rs.ToList())
                        {
                            if (itemFlgA.MaTaiLieu == itemFlg.MaTaiLieu)
                            {
                                temp = 1;

                            }
                        }
                        if (temp == 0)
                        {
                            rs.Add(itemFlg);
                        }
                    }
                }
            }

            return rs;

            //return lst;
            ////return rs;
        }
        public List<VW_TAILIEU> lstTLCungChuDeCoMaVach(string mavach)
        {
            VW_TAILIEU tl = db.VW_TAILIEUs.Where(a => a.MaVach == mavach).FirstOrDefault();
            List<VW_TAILIEU> lst = new List<VW_TAILIEU>();
            if (tl != null)
            {
                lst = db.VW_TAILIEUs.Where(a => a.TenChuDe == tl.TenChuDe && a.MaTaiLieu != tl.MaTaiLieu).Distinct().ToList();
            }
            List<VW_TAILIEUCUNGCHUDE> lstTLCungChuDeDistinct = lstTLCungChuDe(mavach);
            List<VW_TAILIEU> rs = new List<VW_TAILIEU>();
            if (lstTLCungChuDeDistinct.Count() > 6)
            {
                while (rs.Count() <= 5)
                {
                    VW_TAILIEU flg = lst.OrderBy(a => Guid.NewGuid()).Take(1).FirstOrDefault();
                    if (rs.Count() == 0)
                    {
                        rs.Add(flg);
                    }
                    else
                    {
                        int flgInt = 0;
                        foreach (VW_TAILIEU itemFlg in rs)
                        {
                            if (itemFlg.MaTaiLieu == flg.MaTaiLieu)
                            {
                                flgInt = 1;
                            }
                        }
                        if (flgInt == 0)
                        {
                            rs.Add(flg);
                        }
                    }
                }
            }
            else
            {
                foreach (VW_TAILIEU itemFlg in lst)
                {
                    if (rs.Count() == 0)
                    {
                        rs.Add(itemFlg);
                    }
                    else
                    {
                        int temp = 0;
                        foreach (VW_TAILIEU itemFlgA in rs.ToList())
                        {
                            if (itemFlgA.MaTaiLieu == itemFlg.MaTaiLieu)
                            {
                                temp = 1;
                                
                            }
                        }
                        if (temp == 0)
                        {
                            rs.Add(itemFlg);
                        }
                    }
                }
            }

            return rs;
            //return lst;
        }
        public VW_TAILIEU getTaiLieuByMaVach(string mavach)
        {
            VW_TAILIEU tl = db.VW_TAILIEUs.Where(a => a.MaVach == mavach).FirstOrDefault();
            return tl;
        }
        public List<VW_TAILIEU> timKiemTheoMaVach(string mavach)
        {
            List<VW_TAILIEU> lstTL = db.VW_TAILIEUs.Where(a=>a.MaVach.Contains(mavach)).ToList();
            return lstTL;
        }
        public List<VW_TAILIEU> timKiemTheoTieuDe(string tieude)
        {
            List<VW_TAILIEU> lstTL = db.VW_TAILIEUs.Where(a => a.TenTaiLieu.Contains(tieude)).ToList();
            return lstTL;
        }
        public List<VW_TAILIEU> timKiemTheoTacGia(string tacgia)
        {
            List<VW_TAILIEU> lstTL = db.VW_TAILIEUs.Where(a => a.TenTacGia.Contains(tacgia)).ToList();
            return lstTL;
        }
        public List<VW_TAILIEU> timKiemTheoNhaXuatBan(string nxb)
        {
            List<VW_TAILIEU> lstTL = db.VW_TAILIEUs.Where(a => a.TenNhaXuatBan.Contains(nxb)).ToList();
            return lstTL;
        }
        public List<VW_TAILIEU> timKiemTheoChuDe(string chude)
        {
            List<VW_TAILIEU> lstTL = db.VW_TAILIEUs.Where(a => a.TenChuDe.Contains(chude)).ToList();
            
            return lstTL;
        }
        public IQueryable loadDgvViTri()
        {
            var vts = from vt in db.VITRIs
                      where vt.TinhTrangXoa == false
                      select vt;
            return vts;
        }
        public IQueryable loadChudes() 
        {
            var cds = from cd in db.CHUDEs
                      where cd.TinhTrangXoa == false
                      select new { cd.MaChuDe, cd.TenChuDe };
            return cds;
        }
        public bool kiemtraViTri(string mavitri)
        {
            VITRI vt = db.VITRIs.Where(a => a.MaViTri == mavitri).FirstOrDefault();
            if (vt != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void themViTri(string tang, string ke)
        {
            if(string.IsNullOrEmpty(tang) || string.IsNullOrEmpty(ke))
            {
                MessageBox.Show("Vui lòng nhập đày đủ dữ liệu.");
                return;
            }
            string mavitri = getMaViTri(tang,ke);
            if (kiemtraViTri(mavitri))
            {
                MessageBox.Show("Vị trí này đã tồn tại");
                return;
            }
            VITRI item = new VITRI();
            item.MaViTri = mavitri;
            if (tang == "Tầng 1")
            {
                item.Tang = 1;
            }
            else if (tang == "Tầng 2")
            {
                item.Tang = 2;
            }
            else if (tang == "Tầng 3")
            {
                item.Tang = 3;
            }
            else
            {
                item.Tang = 4;
            }
            item.Ke = ke;
            try
            {

                db.VITRIs.InsertOnSubmit(item);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm không thành công.");
                return;
            }
        }
        public string getMaViTri(string tang, string ke)
        {
            string rs = "";
            if(tang == "Tầng 1")
            {
                rs += "A-";
            }    
            else if(tang == "Tầng 2")
            {
                rs += "B-";
            }
            else if(tang == "Tầng 3")
            {
                rs += "C-";
            }
            else
            {
                rs += "D-";
            }

            rs += "" + ke.ToString();

            return rs;
        }
        public IQueryable loadDgvTaiLieu()
        {
            var dsTL = from tls in db.TAILIEUs
                       join cd in db.CHUDEs on tls.MaChuDe equals cd.MaChuDe
                       join nn in db.NGONNGUs on tls.MaNgonNgu equals nn.MaNgonNgu
                       join loaitl in db.LOAITAILIEUs on tls.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                       join tg in db.TACGIAs on tls.MaTacGia equals tg.MaTacGia
                       join nxb in db.NHAXUATBANs on tls.MaNhaXuatBan equals nxb.MaNhaXuatBan
                       join vt in db.VITRIs on tls.MaViTri equals vt.MaViTri
                       where tls.TinhTrangXoa == false
                       select new { tls.MaVach,loaitl.TenLoaiTaiLieu, tls.TenTaiLieu, cd.TenChuDe, tls.MaTap, nn.TenNgonNgu, nxb.TenNhaXuatBan, tg.TenTacGia,tls.SoTrang,tls.Gia,tls.NamXuatBan, tls.ThongTinTaiLieu,tls.MaViTri, tls.HinhAnh, tls.MaTaiLieu };
            return dsTL;
        }
        public IQueryable loadMaViTri()
        {
            var vts = from vt in db.VITRIs
                      select new { vt.MaViTri };
            return vts;
        }
        public void xoaTaiLieu(string mavach)
        {
            TAILIEU tl = db.TAILIEUs.Where(a => a.MaVach == mavach).FirstOrDefault();
            if(tl != null)
            {
                tl.TinhTrangXoa = true;
                updateMaDauTaiLieu(tl.MaTaiLieu);
                db.SubmitChanges();
                MessageBox.Show("Xoá thành công.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu xoá.");
                return;
            }    
        }
        public void suaTaiLieu(string mavach,string maloaitailieu, string machude, string matacgia, string manxb, string tentailieu, string sotrang, string gia, string namxuatban,string thongtintailieu, string mangonngu, string hinhanh, string mavitri, string matailieu)
        {
            //TAILIEU item = db.TAILIEUs.Where(a => a.MaVach == mavach).FirstOrDefault();
            var lstTaiLieu = db.TAILIEUs.Where(a => a.MaTaiLieu == matailieu).ToList();
            if (lstTaiLieu != null)
            {
                foreach(TAILIEU item in lstTaiLieu)
                {
                    item.MaLoaiTaiLieu = int.Parse(maloaitailieu);
                item.MaChuDe = int.Parse(machude);
                item.MaTacGia = int.Parse(matacgia);
                item.MaNhaXuatBan = int.Parse(manxb);
                item.TenTaiLieu = tentailieu;
                item.SoTrang = int.Parse(sotrang);
                item.Gia = double.Parse(gia);
                item.NamXuatBan = int.Parse(namxuatban);
                item.ThongTinTaiLieu = thongtintailieu;
                item.MaNgonNgu = int.Parse(mangonngu);
                item.MaViTri = mavitri;
                    if(!string.IsNullOrEmpty(hinhanh))
                    {
                        string uploadsPath = System.IO.Path.GetFullPath("..\\..\\..\\");
                        string ext = Path.GetExtension(hinhanh);
                        string delPath = System.IO.Path.GetFullPath("..\\..\\..\\") + "Images\\TaiLieu\\" + item.HinhAnh;
                        uploadsPath += "Images\\TaiLieu\\" + item.MaVach.ToString() + ext;
                        if (System.IO.File.Exists(delPath))
                        {
                            System.GC.Collect();
                            System.GC.WaitForPendingFinalizers();
                            try
                            {
                                System.IO.File.Delete(delPath);
                            }
                            catch (Exception ex)
                            {

                            }

                        }
                        try
                        {
                            System.IO.File.Copy(hinhanh, uploadsPath.ToString());
                            item.HinhAnh = item.MaVach + "" + ext;
                        }
                        catch (Exception ex)
                        {

                        }
                    }    
                }

                try
                {
                    db.SubmitChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Sửa không thành công.");
                    return;
                }
                MessageBox.Show("Sửa thành công.");
            }
            else
            {
                return;
            }    
        }
        public void themTaiLieu(TAILIEU tl, int soluong = 0, bool themmoi = true)
        {
            if(themmoi == true)
            {
                if (string.IsNullOrEmpty(tl.TenTaiLieu.ToString()) || string.IsNullOrEmpty(tl.SoTrang.ToString()) || string.IsNullOrEmpty(tl.Gia.ToString()) || string.IsNullOrEmpty(tl.NamXuatBan.ToString()) || string.IsNullOrEmpty(tl.MaTacGia.ToString()) || string.IsNullOrEmpty(tl.MaNhaXuatBan.ToString()) || string.IsNullOrEmpty(tl.ThongTinTaiLieu.ToString()) || string.IsNullOrEmpty(tl.MaNgonNgu.ToString()) || string.IsNullOrEmpty(tl.MaViTri.ToString()))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.");
                    return;
                }
                TAILIEU matailieu = db.TAILIEUs.OrderByDescending(a => a.MaTaiLieu).First();
                string matl = (int.Parse(matailieu.MaTaiLieu.ToString()) + 1).ToString();
                
                for (int i = 0;i<soluong;i++)
                {
                    TAILIEU rs = new TAILIEU();
                    rs.TenTaiLieu = tl.TenTaiLieu;
                    rs.MaLoaiTaiLieu = tl.MaLoaiTaiLieu;
                    rs.SoTrang = tl.SoTrang;
                    rs.Gia = tl.Gia;
                    rs.NamXuatBan = tl.NamXuatBan;
                    rs.MaTacGia = tl.MaTacGia;
                    rs.MaNhaXuatBan = tl.MaNhaXuatBan;
                    rs.ThongTinTaiLieu = tl.ThongTinTaiLieu;
                    rs.MaNgonNgu = tl.MaNgonNgu;
                    rs.MaChuDe = tl.MaChuDe;
                    rs.MaTap = tl.MaTap;
                    rs.MaViTri = tl.MaViTri;
                    rs.TinhTrangXoa = false;

                    TAILIEU mavach = db.TAILIEUs.OrderByDescending(a => a.MaVach).First();
                    string mv = (int.Parse(mavach.MaVach.ToString()) + 1).ToString();
                    rs.MaVach = mv;

                    rs.MaTaiLieu = matl;

                    rs.MaDauTaiLieu = (i + 1).ToString();
                    if(!string.IsNullOrEmpty(tl.HinhAnh))
                    {
                        string uploadsPath = System.IO.Path.GetFullPath("..\\..\\..\\");
                        string ext = Path.GetExtension(tl.HinhAnh);
                        uploadsPath += "Images\\TaiLieu\\" + rs.MaVach.ToString()+ ext;
                        if (System.IO.File.Exists(uploadsPath))
                        {
                            System.GC.Collect();
                            System.GC.WaitForPendingFinalizers();
                            try
                            {
                                System.IO.File.Delete(uploadsPath);
                            }
                            catch (Exception ex)
                            {

                            }

                        }
                        try
                        {
                            System.IO.File.Copy(tl.HinhAnh.ToString(), uploadsPath.ToString());
                            rs.HinhAnh = rs.MaVach + "" + ext;
                        }
                        catch(Exception ex)
                        {
                            continue;
                        }
                    }    
                    try
                    {
                        db.TAILIEUs.InsertOnSubmit(rs);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm thành công tài liệu.");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Thêm không thành công tài liệu: " + rs.MaVach.ToString());
                        return;
                    }
                }
            }
            
        }
        
        public string getMaDauTaiLieuByMaTaiLieu(string matl)
        {
            TAILIEU tls = (from tl in db.TAILIEUs
                       where tl.MaTaiLieu == matl
                           select tl).LastOrDefault();
            tls.MaDauTaiLieu = (int.Parse(tls.MaDauTaiLieu) + 1).ToString();
            return tls.MaDauTaiLieu;
        }
        //public void themTaiLieu(TAILIEU para)
        //{
        //    if(string.IsNullOrEmpty(para.MaVach) || string.IsNullOrEmpty(para.MaTaiLieu) || string.IsNullOrEmpty(para.MaLoaiTaiLieu.ToString()) || string.IsNullOrEmpty(para.SoTrang.ToString()) || string.IsNullOrEmpty(para.Gia.ToString()) || string.IsNullOrEmpty(para.NamXuatBan.ToString()) || string.IsNullOrEmpty(para.MaTacGia.ToString()) || string.IsNullOrEmpty(para.MaNhaXuatBan.ToString()) || string.IsNullOrEmpty(para.MaNgonNgu.ToString()) || string.IsNullOrEmpty(para.MaViTri))
        //    {
        //        MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.");
        //        return;
        //    }
        //    string madautailieu = getMaDauTaiLieuByMaTaiLieu(para.MaTaiLieu);
        //    para.MaDauTaiLieu = madautailieu;
        //    try
        //    {
        //        db.TAILIEUs.InsertOnSubmit(para);
        //        db.SubmitChanges();
        //        MessageBox.Show("Thêm thành công.");
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("Thêm không thành công.");
        //        return;
        //    }
        //}
        public void themTacGia(string tentg)
        {
            if(string.IsNullOrEmpty(tentg))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            TACGIA tg = new TACGIA();
            tg.TenTacGia = tentg;
            tg.TinhTrangXoa = false;

            db.TACGIAs.InsertOnSubmit(tg);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công.");
        }
        public void themLoaiTaiLieu(string tentg)
        {
            if (string.IsNullOrEmpty(tentg))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            LOAITAILIEU tg = new LOAITAILIEU();
            tg.TenLoaiTaiLieu = tentg;
            tg.TinhTrangXoa = false;

            db.LOAITAILIEUs.InsertOnSubmit(tg);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công.");
        }
        public void themNgonNgu(string tentg)
        {
            if (string.IsNullOrEmpty(tentg))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            NGONNGU tg = new NGONNGU();
            tg.TenNgonNgu = tentg;
            tg.TinhTrangXoa = false;

            db.NGONNGUs.InsertOnSubmit(tg);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công.");
        }
        public void themChuDe(string tentg)
        {
            if (string.IsNullOrEmpty(tentg))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            CHUDE tg = new CHUDE();
            tg.TenChuDe = tentg;
            tg.TinhTrangXoa = false;

            db.CHUDEs.InsertOnSubmit(tg);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công.");
        }

        public void themNXB(string tenNXB)
        {
            if (string.IsNullOrEmpty(tenNXB))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            NHAXUATBAN tg = new NHAXUATBAN();
            tg.TenNhaXuatBan = tenNXB;
            tg.TinhTrangXoa = false;

            db.NHAXUATBANs.InsertOnSubmit(tg);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công.");
        }

        public void xoaTacGia(string matg)
        {
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TACGIA tg = db.TACGIAs.Where(a => a.MaTacGia == int.Parse(matg)).FirstOrDefault();
                if (tg != null)
                {
                    tg.TinhTrangXoa = true;
                    db.SubmitChanges();
                    MessageBox.Show("Xoá thành công.");

                }
                else
                {
                    MessageBox.Show("Xoá không thành công.");
                    return;
                }
            }
            else
            {
                return;
            }
            
        }
        public void xoaLoaiTaiLieu(string matg)
        {
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                LOAITAILIEU tg = db.LOAITAILIEUs.Where(a => a.MaLoaiTaiLieu == int.Parse(matg)).FirstOrDefault();
                if (tg != null)
                {
                    tg.TinhTrangXoa = true;
                    db.SubmitChanges();
                    MessageBox.Show("Xoá thành công.");

                }
                else
                {
                    MessageBox.Show("Xoá không thành công.");
                    return;
                }
            }
            else
            {
                return;
            }

        }
        public void xoaNgonNgu(string matg)
        {
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                NGONNGU tg = db.NGONNGUs.Where(a => a.MaNgonNgu == int.Parse(matg)).FirstOrDefault();
                if (tg != null)
                {
                    tg.TinhTrangXoa = true;
                    db.SubmitChanges();
                    MessageBox.Show("Xoá thành công.");

                }
                else
                {
                    MessageBox.Show("Xoá không thành công.");
                    return;
                }
            }
            else
            {
                return;
            }

        }
        public void xoaNXB(string matg)
        {
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                NHAXUATBAN tg = db.NHAXUATBANs.Where(a => a.MaNhaXuatBan == int.Parse(matg)).FirstOrDefault();
                if (tg != null)
                {
                    tg.TinhTrangXoa = true;
                    db.SubmitChanges();
                    MessageBox.Show("Xoá thành công.");

                }
                else
                {
                    MessageBox.Show("Xoá không thành công.");
                    return;
                }
            }
            else
            {
                return;
            }

        }
        public void xoaChuDe(string matg)
        {
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                CHUDE tg = db.CHUDEs.Where(a => a.MaChuDe == int.Parse(matg)).FirstOrDefault();
                if (tg != null)
                {
                    tg.TinhTrangXoa = true;
                    db.SubmitChanges();
                    MessageBox.Show("Xoá thành công.");

                }
                else
                {
                    MessageBox.Show("Xoá không thành công.");
                    return;
                }
            }
            else
            {
                return;
            }

        }

        public void suaTacGia(string matg, string tentg)
        {
            if (string.IsNullOrEmpty(tentg))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            TACGIA tg = db.TACGIAs.Where(a => a.MaTacGia == int.Parse(matg)).FirstOrDefault();
            if(tg != null)
            {
                tg.TenTacGia = tentg;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công.");
            }
            else
            {
                MessageBox.Show("Sửa không thành công.");
                return;
            }    
        }
        public void suaLoaiTaiLieu(string matg, string tentg)
        {
            if (string.IsNullOrEmpty(tentg))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            LOAITAILIEU tg = db.LOAITAILIEUs.Where(a => a.MaLoaiTaiLieu == int.Parse(matg)).FirstOrDefault();
            if (tg != null)
            {
                tg.TenLoaiTaiLieu = tentg;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công.");
            }
            else
            {
                MessageBox.Show("Sửa không thành công.");
                return;
            }
        }
        public void suaNgonNgu(string matg, string tentg)
        {
            if (string.IsNullOrEmpty(tentg))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            NGONNGU tg = db.NGONNGUs.Where(a => a.MaNgonNgu == int.Parse(matg)).FirstOrDefault();
            if (tg != null)
            {
                tg.TenNgonNgu = tentg;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công.");
            }
            else
            {
                MessageBox.Show("Sửa không thành công.");
                return;
            }
        }
        public void suaChuDe(string matg, string tentg)
        {
            if (string.IsNullOrEmpty(tentg))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            CHUDE tg = db.CHUDEs.Where(a => a.MaChuDe == int.Parse(matg)).FirstOrDefault();
            if (tg != null)
            {
                tg.TenChuDe = tentg;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công.");
            }
            else
            {
                MessageBox.Show("Sửa không thành công.");
                return;
            }
        }
        public void suaNXB(string matg, string tentg)
        {
            if (string.IsNullOrEmpty(tentg))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            NHAXUATBAN tg = db.NHAXUATBANs.Where(a => a.MaNhaXuatBan == int.Parse(matg)).FirstOrDefault();
            if (tg != null)
            {
                tg.TenNhaXuatBan = tentg;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công.");
            }
            else
            {
                MessageBox.Show("Sửa không thành công.");
                return;
            }
        }
        public IQueryable loadTacGias()
        {
            var tgs = from tg in db.TACGIAs
                      where tg.TinhTrangXoa == false
                      select new { tg.MaTacGia, tg.TenTacGia };
            return tgs;
        }
        public IQueryable loadLoaiTaiLieus()
        {
            var tgs = from tg in db.LOAITAILIEUs
                      where tg.TinhTrangXoa == false
                      select new { tg.MaLoaiTaiLieu, tg.TenLoaiTaiLieu };
            return tgs;
        }
        public IQueryable loadNgonNgus()
        {
            var tgs = from tg in db.NGONNGUs
                      where tg.TinhTrangXoa == false
                      select new { tg.MaNgonNgu, tg.TenNgonNgu };
            return tgs;
        }
        public IQueryable loadNXBs()
        {
            var tgs = from tg in db.NHAXUATBANs
                      where tg.TinhTrangXoa == false
                      select new { tg.MaNhaXuatBan, tg.TenNhaXuatBan };
            return tgs;
        }
        public IQueryable loadCHUDEs()
        {
            var tgs = from tg in db.CHUDEs
                      where tg.TinhTrangXoa == false
                      select new { tg.MaChuDe, tg.TenChuDe };
            return tgs;
        }

        public void updateMaDauTaiLieu(string matailieu)
        {
            var tls = from tl in db.TAILIEUs
                      where tl.MaTaiLieu == matailieu
                      orderby tl.MaVach
                      select tl;
            string prev = "";
            if(tls != null)
            {
                
                foreach(TAILIEU tl in tls)
                {
                    if(tl.TinhTrangXoa == false)
                    {
                        if(string.IsNullOrEmpty(prev))
                        {
                            prev = "1";
                            tl.MaDauTaiLieu = prev;
                            prev = (int.Parse(prev) +1).ToString();
                        }
                        else
                        {
                            tl.MaDauTaiLieu = prev;
                            prev = (int.Parse(prev) + 1).ToString();
                        }
                    }
                    else
                    {
                        tl.MaDauTaiLieu = "0";
                    }
                    
                }
                db.SubmitChanges();
                
            }
        }

        public IQueryable timKiemMaVachTaiLieu(string mavach)
        {
            var tl = from tls in db.TAILIEUs
                     join cd in db.CHUDEs on tls.MaChuDe equals cd.MaChuDe
                     join nn in db.NGONNGUs on tls.MaNgonNgu equals nn.MaNgonNgu
                     join loaitl in db.LOAITAILIEUs on tls.MaLoaiTaiLieu equals loaitl.MaLoaiTaiLieu
                     join tg in db.TACGIAs on tls.MaTacGia equals tg.MaTacGia
                     join nxb in db.NHAXUATBANs on tls.MaNhaXuatBan equals nxb.MaNhaXuatBan
                     join vt in db.VITRIs on tls.MaViTri equals vt.MaViTri
                     where (tls.TinhTrangXoa == false) && (tls.MaVach.Contains(mavach))
                     select new { tls.MaVach, loaitl.TenLoaiTaiLieu, tls.TenTaiLieu, cd.TenChuDe, tls.MaTap, nn.TenNgonNgu, nxb.TenNhaXuatBan, tg.TenTacGia, tls.SoTrang, tls.Gia, tls.NamXuatBan, tls.ThongTinTaiLieu, tls.MaViTri, tls.HinhAnh, tls.MaTaiLieu };
            return tl;
        }
        public bool xoaVT(string mavt)
        {
             
            VITRI vt = db.VITRIs.Where(a => a.MaViTri == mavt).FirstOrDefault();
            if (vt != null)
            {
                vt.TinhTrangXoa = true;
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool suaVT(string mavt, string tang, string ke)
        {
            VITRI vt = db.VITRIs.Where(a => a.MaViTri == mavt).FirstOrDefault();
            if(vt != null)
            {
                string mavitri = getMaViTri(tang, ke);
                if(!string.IsNullOrEmpty(mavitri))
                {
                    vt.MaViTri = mavitri;
                    if (tang == "Tầng 1")
                    {
                        vt.Tang = 1;
                    }
                    else if (tang == "Tầng 2")
                    {
                        vt.Tang = 2;
                    }
                    else if (tang == "Tầng 3")
                    {
                        vt.Tang = 3;
                    }
                    else
                    {
                        vt.Tang = 4;
                    }
                    vt.Ke = ke;
                    try
                    {
                        db.SubmitChanges();
                        return true;
                    }
                    catch(Exception ex)
                    {
                        return false;
                    }
                }   
                else
                {
                    return false;
                }
            }

            return false;
        }
    }
}
