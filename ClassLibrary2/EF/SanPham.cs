namespace ClassLibrary2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        public int maSP { get; set; }

        [StringLength(250)]
        public string tenSP { get; set; }

        public int? dongia { get; set; }

        [StringLength(50)]
        public string donvi { get; set; }

        [StringLength(150)]
        public string hinhanh { get; set; }

        [StringLength(250)]
        public string mota { get; set; }

        [StringLength(150)]
        public string hinhanhchitiet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
