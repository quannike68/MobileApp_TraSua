namespace WebAPI_trasua.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("donhang")]
    public partial class donhang
    {
        [Key]
        public int iddh { get; set; }

        public int? idtk { get; set; }

        public int? idgh { get; set; }

        public string loinhan { get; set; }

        public string ngaygio { get; set; }

        public string hanhchinh { get; set; }

        public string ghichu { get; set; }
    }
}
