namespace ClassLibrary2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        public int maHD { get; set; }

        public int? maKH { get; set; }

        public int? tongtien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaylap { get; set; }

        public virtual ChiTietHoaDon ChiTietHoaDon { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
