namespace QLDanhBaDu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LienLac")]
    public partial class LienLac
    {
        [Key]
        public int MaLienLac { get; set; }

        [StringLength(100)]
        public string TenGoi { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        public int? MaNhom { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        public virtual Nhom Nhom { get; set; }
    }
}
