namespace Kerry.KSYS.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("K35INTF.SUPPLYMENT_JOB_LINK_HISTORY")]
    public partial class SUPPLYMENT_JOB_LINK_HISTORY
    {
        [Key]
        public decimal UNID { get; set; }

        public long JOB_UNID { get; set; }

        public long SOURCE_UNID { get; set; }

        [Required]
        [StringLength(1)]
        public string TYPE { get; set; }

        public DateTime? CREATEDATE { get; set; }


    }
}
