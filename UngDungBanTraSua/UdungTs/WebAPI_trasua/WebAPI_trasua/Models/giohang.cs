namespace WebAPI_trasua.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("giohang")]
    public partial class giohang
    {
        [Key]
        public int idgh { get; set; }

        public int? idtk { get; set; }

        public int? idsp { get; set; }

        public int? sl { get; set; }

        public string chon { get; set; }

        public string giax1 { get; set; }

        public int? tongtien { get; set; }

        public string ghichu { get; set; }
    }
}
