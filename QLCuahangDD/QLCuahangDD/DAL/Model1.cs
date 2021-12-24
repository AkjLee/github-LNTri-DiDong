using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLCuahangDD.DAL
{
    public partial class QLCuahangModel : DbContext
    {
        public QLCuahangModel()
            : base("name=Model1")
        {
        }

        public virtual DbSet<cty> cties { get; set; }
        public virtual DbSet<Cuahang> Cuahangs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
