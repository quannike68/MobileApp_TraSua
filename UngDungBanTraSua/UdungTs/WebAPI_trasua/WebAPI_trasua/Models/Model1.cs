using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAPI_trasua.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<chon> chons { get; set; }
        public virtual DbSet<danhmuc_sp> danhmuc_sp { get; set; }
        public virtual DbSet<donhang> donhangs { get; set; }
        public virtual DbSet<giohang> giohangs { get; set; }
        public virtual DbSet<san_pham> san_pham { get; set; }
        public virtual DbSet<tk> tks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
