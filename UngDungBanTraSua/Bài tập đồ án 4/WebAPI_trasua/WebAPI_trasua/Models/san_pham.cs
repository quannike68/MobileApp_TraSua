namespace WebAPI_trasua.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class san_pham
    {
        [Key]
        public int idsp { get; set; }

        public int? iddm { get; set; }

        public string tensp { get; set; }

        public string giatien { get; set; }

        public string hinhanh { get; set; }

        public string ghichu { get; set; }
    }
}
