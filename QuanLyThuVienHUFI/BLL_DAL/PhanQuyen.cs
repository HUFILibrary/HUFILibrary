using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class PhanQuyen
    {
        DB_QLTVDataContext db = new DB_QLTVDataContext();
        public IEnumerable<PHANQUYEN> getPhanQuyens(string username)
        {
            NHANVIEN nv = db.NHANVIENs.Where(a => a.MaNhanVien == int.Parse(username)).FirstOrDefault();
            string maloainhanvien = "";
            if(nv != null)
            {
                maloainhanvien = nv.MaLoaiNhanVien.ToString();
            }
            var pqs = from pq in db.PHANQUYENs
                      where pq.MaLoaiNhanVien == int.Parse(maloainhanvien)
                      select pq;
            return pqs;
        }
        #region ManHinh
        public IQueryable loadDgvManHinhs()
        {
            var mhs = from mh in db.MANHINHs
                      select mh;
            return mhs;
        }
        public bool checkMaManHinh(string mamanhinh)
        {
            MANHINH mh = db.MANHINHs.Where(a => a.MaManHinh == mamanhinh).FirstOrDefault();
            if(mh != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool themManHinh(string mamanhinh, string TenManHinh)
        {
            if(checkMaManHinh(mamanhinh))
            {
                return false;
            }
            try
            {
                MANHINH item = new MANHINH();
                item.MaManHinh = mamanhinh;
                item.TenManHinh = TenManHinh;
                var loainhanvien = db.LOAINHANVIENs.ToList();
                if(loainhanvien != null)
                {
                    foreach(LOAINHANVIEN itemLNV in loainhanvien)
                    {
                        PHANQUYEN itemPQ = new PHANQUYEN();
                        itemPQ.MaLoaiNhanVien = itemLNV.MaLoaiNhanVien;
                        itemPQ.MaManHinh = item.MaManHinh;
                        itemPQ.CoQuyen = false;
                        db.PHANQUYENs.InsertOnSubmit(itemPQ);
                    }
                }
                db.MANHINHs.InsertOnSubmit(item);
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool xoaManHinh(string mamanhinh)
        {
            MANHINH mh = db.MANHINHs.Where(a => a.MaManHinh == mamanhinh).FirstOrDefault();
            if(mh != null)
            {
                db.MANHINHs.DeleteOnSubmit(mh);
                var pqs = db.PHANQUYENs.Where(a => a.MaManHinh == mh.MaManHinh).ToList();
                if(pqs != null)
                {
                    foreach(PHANQUYEN itemDel in pqs)
                    {
                        db.PHANQUYENs.DeleteOnSubmit(itemDel);
                    }
                }
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool suaManHinh(string mamanhinh, string tenmanhinh)
        {
            MANHINH mh = db.MANHINHs.Where(a => a.MaManHinh == mamanhinh).FirstOrDefault();
            if (mh != null)
            {
                mh.TenManHinh = tenmanhinh;
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion

        #region PhanQuyen
        public bool suaPhanQuyen(string maloainhanvien, string mamanhinh, bool coquyen)
        {
            PHANQUYEN pq = db.PHANQUYENs.Where(a => a.MaLoaiNhanVien == int.Parse(maloainhanvien) && a.MaManHinh == mamanhinh).FirstOrDefault();
            if(pq != null)
            {
                pq.CoQuyen = coquyen;
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public IQueryable loadDgvPhanQuyen()
        {
            var pqs = from pq in db.PHANQUYENs
                      join lnv in db.LOAINHANVIENs on pq.MaLoaiNhanVien equals lnv.MaLoaiNhanVien
                      join mh in db.MANHINHs on pq.MaManHinh equals mh.MaManHinh
                      select new
                      {
                          lnv.MaLoaiNhanVien,
                          lnv.TenLoaiNhanVien,
                          mh.MaManHinh,
                          mh.TenManHinh,
                          pq.CoQuyen
                      };
            return pqs;

        }
        #endregion
    }
}
