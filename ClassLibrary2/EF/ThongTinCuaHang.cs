namespace ClassLibrary2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinCuaHang")]
    public partial class ThongTinCuaHang
    {
        [Key]
        [StringLength(50)]
        public string tenCH { get; set; }

        [StringLength(250)]
        public string diachi { get; set; }

        [StringLength(50)]
        public string sdt { get; set; }

        [StringLength(200)]
        public string website { get; set; }
    }
}
