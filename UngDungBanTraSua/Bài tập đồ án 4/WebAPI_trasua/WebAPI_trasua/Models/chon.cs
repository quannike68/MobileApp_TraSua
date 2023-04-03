namespace WebAPI_trasua.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chon")]
    public partial class chon
    {
        [Key]
        public int id_l { get; set; }

        public string the_loai { get; set; }

        public string ten { get; set; }

        public string tien { get; set; }

        public string ghichu { get; set; }
    }
}
