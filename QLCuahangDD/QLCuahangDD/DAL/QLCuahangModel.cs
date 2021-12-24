using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuahangDD.DAL
{
    public partial class QLCuahangDD : DbContext
    {
        public QLCuahangDD()
            : base("name=AppConnecSting")
        {
        }

        public virtual DbSet<Cuahang> Cuahangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
