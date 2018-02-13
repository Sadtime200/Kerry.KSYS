namespace Kerry.KSYS.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("K35INTF.ACTION_JOB")]
    public partial class ACTION_JOB
    {
        [Key]
        public decimal UNID { get; set; }

        public long JOB_UNID { get; set; }

        [StringLength(30)]
        public string SHPNO { get; set; }

        [StringLength(30)]
        public string CONSOLNO { get; set; }

        public long? CONSOLLOT_UNID { get; set; }

        [StringLength(2)]
        public string BIZTYPE { get; set; }

        [StringLength(1)]
        public string SHPTYPE { get; set; }

        [StringLength(10)]
        public string OWNERID { get; set; }

        [StringLength(2)]
        public string ACTION { get; set; }

        [StringLength(2)]
        public string STATUS { get; set; }

        [StringLength(20)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(20)]
        public string UPDATEBY { get; set; }

        public DateTime? UPDATEDATE { get; set; }
    }
}
