using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDanhBaDu.ViewModel
{
    public enum KetQuas
    {
        TrungMa,
        ThanhCong
    }

    public class NhomViewModel
    {
        public int MaNhom { get; set; }
        public string TenNhom { get; set; }
    }
}

