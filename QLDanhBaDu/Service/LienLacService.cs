using QLDanhBaDu.Model;
using QLDanhBaDu.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDanhBaDu.Service
{

    class LienLacService
    {
        public static List<LienLacViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.LienLac.Select(e => new LienLacViewModel
            {
                MaLienLac = e.MaLienLac,
                TenGoi = e.TenGoi,
                Email = e.Email,
                DiaChi =e.DiaChi,
                SoDienThoai = e.SoDienThoai,
                MaNhom = e.MaNhom
            }).ToList();
            return rs;
        }
        public static List<LienLacViewModel> getByNhom(int MaNhom)
        {
            var list = GetList();
            var rs = list.Where(t => t.MaNhom == MaNhom).ToList();
            return rs;
        }
        public static List<LienLacViewModel> getByTen(String ten,int MaNhom)
        {
            var list = getByNhom(MaNhom);
            var rs = list.Where(t => t.TenGoi.ToUpper().Contains(ten.ToUpper())).ToList();
            return rs;
        }
        public static Boolean kiemTraMaTrung(String TenGoi)
        {
            var list = GetList();
            var rs = list.Where(t => t.TenGoi == TenGoi).ToList();
            if (rs.Count > 0) return true;
            else return false;
        }
        public static int AddLienLac(LienLac ll)
        {
            var db = new AppDBContext();
            int count = db.LienLac.Where(e => e.TenGoi == ll.TenGoi).Count();
            if (count > 0)
            {
                return 0;
            }
            else
            {
                db.LienLac.Add(ll);
                db.SaveChanges();
                return 1;
            }
        }
       
        public static KetQua RemoveLienLac(LienLacViewModel ll)
        {
            var db = new AppDBContext();
            var lienLac = db.LienLac.Where(e => e.MaLienLac == ll.MaLienLac).FirstOrDefault();
            db.LienLac.Remove(lienLac);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }

    }
}



