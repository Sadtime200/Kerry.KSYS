namespace Kerry.KSYS.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JOBLINK")]
    public partial class JOBLINK
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SOURCE_UNID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string TYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long JOB_UNID { get; set; }
    }
}
