namespace QLCuahangDD.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cty")]
    public partial class cty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cty()
        {
            Cuahangs = new HashSet<Cuahang>();
        }

        [Key]
        public int MaCty { get; set; }

        [StringLength(50)]
        public string TenCty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuahang> Cuahangs { get; set; }
    }
}
