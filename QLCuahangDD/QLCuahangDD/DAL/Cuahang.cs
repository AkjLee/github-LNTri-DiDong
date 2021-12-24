namespace QLCuahangDD.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cuahang")]
    public partial class Cuahang
    {
        [Key]
        public int MaCH { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Diachi { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        public int? Macty { get; set; }

        public virtual cty cty { get; set; }
    }
}
