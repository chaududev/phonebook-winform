using QLDanhBaDu.Model;
using QLDanhBaDu.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDanhBaDu
{
    class NhomService
    {
        public static List<NhomViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.Nhom.Select(e => new NhomViewModel
            {
                MaNhom = e.MaNhom,
                TenNhom = e.TenNhom
            }).ToList();
            return rs;
        }
        public static Boolean kiemTraMaTrung(int MaNhom)
        {
            var list = GetList();
            var rs = list.Where(t => t.MaNhom == MaNhom).ToList();
            if (rs.Count > 0) return true;
            else return false;
        }


        public static KetQuas AddNhom(Nhom lop)
        {
            var db = new AppDBContext();
            int count = db.Nhom.Where(e => e.TenNhom == lop.TenNhom).Count();
            if (count > 0)
            {
                return KetQuas.TrungMa;
            }
            else
            {
                db.Nhom.Add(lop);
                db.SaveChanges();
                return KetQuas.ThanhCong;
            }
        }
        public static KetQuas UpdateNhom(NhomViewModel lop)
        {
            var db = new AppDBContext();
            var Nhom = db.Nhom.Where(e => e.MaNhom == lop.MaNhom).FirstOrDefault();
            Nhom.TenNhom = lop.TenNhom;
            db.SaveChanges();
            return KetQuas.ThanhCong;
        }
        public static KetQuas RemoveNhom(NhomViewModel lop)
        {
            var db = new AppDBContext();
            var lienLac = db.LienLac.Where(e => e.MaNhom == lop.MaNhom).FirstOrDefault();
            if (lienLac != null)
            {
                db.LienLac.Remove(lienLac);
                db.SaveChanges();
            }
            
            var Nhom = db.Nhom.Where(e => e.MaNhom == lop.MaNhom).FirstOrDefault();
            db.Nhom.Remove(Nhom);
            db.SaveChanges();
            return KetQuas.ThanhCong;
        }


    }
}
