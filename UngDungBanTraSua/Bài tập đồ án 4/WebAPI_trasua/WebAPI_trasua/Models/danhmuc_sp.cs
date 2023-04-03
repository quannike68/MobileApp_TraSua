namespace WebAPI_trasua.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class danhmuc_sp
    {
        [Key]
        public int iddm { get; set; }

        public string tendm { get; set; }

        public string hinhanh { get; set; }

        public string ghichu { get; set; }
    }
}
