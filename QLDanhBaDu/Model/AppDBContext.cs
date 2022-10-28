using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLDanhBaDu.Model
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
            : base("name=AppDBContext")
        {
        }

        public virtual DbSet<LienLac> LienLac { get; set; }
        public virtual DbSet<Nhom> Nhom { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
