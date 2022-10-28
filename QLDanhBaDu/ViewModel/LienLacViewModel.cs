using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDanhBaDu.ViewModel
{
    public enum KetQua
    {
        TrungMa,
        ThanhCong
    }
    public class LienLacViewModel
    {
        public int MaLienLac { get; set; }
        public string TenGoi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public int? MaNhom { get; set; }

    }
}
