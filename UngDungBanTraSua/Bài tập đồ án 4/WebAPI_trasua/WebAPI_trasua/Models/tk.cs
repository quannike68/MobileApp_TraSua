namespace WebAPI_trasua.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tk")]
    public partial class tk
    {
        [Key]
        public int idtk { get; set; }

        public string hoten { get; set; }

        public string email { get; set; }

        public string mk { get; set; }

        public string sdt { get; set; }

        public string diachi { get; set; }
    }
}
