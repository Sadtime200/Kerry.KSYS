namespace Kerry.KSYS.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JOB")]
    public partial class JOB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UNID { get; set; }

        public long? VV_UNID { get; set; }

        public long? VVSECOND_UNID { get; set; }

        [Required]
        [StringLength(10)]
        public string OWNERID { get; set; }

        [Required]
        [StringLength(30)]
        public string GSHPID { get; set; }

        [StringLength(2)]
        public string BIZTYPE { get; set; }

        [StringLength(20)]
        public string BOOKINGNO { get; set; }

        public DateTime? BOOKINGDATE { get; set; }

        [StringLength(30)]
        public string SHPNO { get; set; }

        [StringLength(30)]
        public string CONSOLNO { get; set; }

        public long? CONSOLLOT_UNID { get; set; }

        [StringLength(20)]
        public string JOBNO { get; set; }

        public DateTime? JOBDATE { get; set; }

        [StringLength(20)]
        public string PROJECTNO { get; set; }

        [StringLength(1)]
        public string SHPTYPE { get; set; }

        [StringLength(10)]
        public string OAGENT { get; set; }

        [StringLength(10)]
        public string PARTYID_CUST { get; set; }

        [StringLength(70)]
        public string CUSTNAME { get; set; }

        [StringLength(10)]
        public string CARRIERID { get; set; }

        [StringLength(10)]
        public string CARRIERCODE { get; set; }

        [StringLength(10)]
        public string PARTYID_SHPR { get; set; }

        [StringLength(70)]
        public string SHPRNAME { get; set; }

        [StringLength(10)]
        public string PARTYID_CSGN { get; set; }

        [StringLength(70)]
        public string CSGNNAME { get; set; }

        [StringLength(3)]
        public string PORCITY { get; set; }

        [StringLength(2)]
        public string PORCTRY { get; set; }

        [StringLength(35)]
        public string PORNAME { get; set; }

        [StringLength(10)]
        public string PORMODE { get; set; }

        [StringLength(3)]
        public string POLCITY { get; set; }

        [StringLength(2)]
        public string POLCTRY { get; set; }

        [StringLength(35)]
        public string POLNAME { get; set; }

        [StringLength(3)]
        public string VIACITY { get; set; }

        [StringLength(2)]
        public string VIACTRY { get; set; }

        [StringLength(3)]
        public string PODCITY { get; set; }

        [StringLength(2)]
        public string PODCTRY { get; set; }

        [StringLength(35)]
        public string PODNAME { get; set; }

        [StringLength(3)]
        public string DESTCITY { get; set; }

        [StringLength(2)]
        public string DESTCTRY { get; set; }

        [StringLength(35)]
        public string DESTNAME { get; set; }

        [StringLength(3)]
        public string DEVRYCITY { get; set; }

        [StringLength(2)]
        public string DEVRYCTRY { get; set; }

        [StringLength(35)]
        public string DEVRYNAME { get; set; }

        public DateTime? FLTDATE { get; set; }

        [StringLength(4)]
        public string FLTTIME { get; set; }

        public int? TOTPCS { get; set; }

        [StringLength(8)]
        public string TOTPCS_UT { get; set; }

        public decimal? TOTGWGT { get; set; }

        [StringLength(3)]
        public string TOTGWGT_UT { get; set; }

        public decimal? TOTCWGT { get; set; }

        [StringLength(3)]
        public string TOTCWGT_UT { get; set; }

        public decimal? VWGT { get; set; }

        [StringLength(3)]
        public string VWGT_UT { get; set; }

        public DateTime? AWBBLDATE { get; set; }

        [StringLength(10)]
        public string ORGID { get; set; }

        [StringLength(1)]
        public string JOBSTAGECODE { get; set; }

        [StringLength(10)]
        public string CURRENTSTATUS { get; set; }

        [StringLength(10)]
        public string CURRENTSTAGE { get; set; }

        [StringLength(1)]
        public string PROCESSSTATUS { get; set; }

        [StringLength(2000)]
        public string USERHLEVEL { get; set; }

        [StringLength(10)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(10)]
        public string UPDATEBY { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        [StringLength(50)]
        public string TIMEZONE { get; set; }

        public decimal? TOTVOL { get; set; }

        [StringLength(3)]
        public string TOTVOL_UT { get; set; }

        [StringLength(10)]
        public string VOIDBY { get; set; }

        public DateTime? VOIDDATE { get; set; }

        public bool? ISBOOKING { get; set; }

        public bool? ISSHP { get; set; }

        public decimal? TOTNWGT { get; set; }

        [StringLength(3)]
        public string TOTNWGT_UT { get; set; }

        public decimal? TOTINNERPCS { get; set; }

        [StringLength(3)]
        public string TOTINNERPCS_UT { get; set; }

        public DateTime? CONCLOSEDATE { get; set; }

        [StringLength(10)]
        public string CONCLOSEBY { get; set; }

        public DateTime? FINCLOSEDATE { get; set; }

        [StringLength(10)]
        public string FINCLOSEBY { get; set; }

        public DateTime? PODATE { get; set; }

        [StringLength(4)]
        public string POTIME { get; set; }

        [StringLength(4)]
        public string BOOKINGTIME { get; set; }

        [StringLength(20)]
        public string CONSOLBKNO { get; set; }

        [StringLength(50)]
        public string SUREFNO { get; set; }

        [StringLength(50)]
        public string SPREFNO { get; set; }

        [StringLength(1)]
        public string VOIDTYPE { get; set; }

        public DateTime? REVCLOSEDATE { get; set; }

        [StringLength(10)]
        public string REVCLOSEBY { get; set; }

        public DateTime? COSTCLOSEDATE { get; set; }

        [StringLength(10)]
        public string COSTCLOSEBY { get; set; }

        public decimal? TOTNVOL { get; set; }

        public bool? ISCWGTBASENET { get; set; }

        [StringLength(10)]
        public string JOBTYPE { get; set; }

        [StringLength(35)]
        public string VIANAME { get; set; }

        [StringLength(20)]
        public string QUOTENO { get; set; }

        [StringLength(10)]
        public string QUOTESUBNO { get; set; }

        public long? QUOTE_UNID { get; set; }

        public DateTime? VALIDFROM { get; set; }

        public DateTime? VALIDTO { get; set; }

        public DateTime? EFFECTVALIDTO { get; set; }

        [StringLength(20)]
        public string QUOTETYPE { get; set; }

        public DateTime? PORETADATE { get; set; }

        [StringLength(4)]
        public string PORETATIME { get; set; }

        public DateTime? DEVRYETDDATE { get; set; }

        [StringLength(4)]
        public string DEVRYETDTIME { get; set; }

        public DateTime? PORETDDATE { get; set; }

        [StringLength(4)]
        public string PORETDTIME { get; set; }

        public DateTime? DEVRYETADATE { get; set; }

        [StringLength(4)]
        public string DEVRYETATIME { get; set; }

        [StringLength(10)]
        public string SENDERID { get; set; }

        public DateTime? POSTDATETOBE { get; set; }

        public DateTime? CLOSINGDATE { get; set; }

        public decimal? TOBASEEXRATE { get; set; }

        public decimal? FROMBASEEXRATE { get; set; }

        public long? SHIPMENTUNID { get; set; }

        public decimal? CONVTOTGWGT { get; set; }

        [StringLength(3)]
        public string CONVTOTGWGT_UT { get; set; }

        public decimal? CONVTOTNWGT { get; set; }

        [StringLength(3)]
        public string CONVTOTNWGT_UT { get; set; }

        public decimal? CONVTOTVOL { get; set; }

        [StringLength(3)]
        public string CONVTOTVOL_UT { get; set; }

        public decimal? CONVTOTNVOL { get; set; }

        public DateTime? POLETDDATE { get; set; }

        public DateTime? PODETADATE { get; set; }

        public DateTime? FINALDESTETADATE { get; set; }

        public long? VVTHIRD_UNID { get; set; }

        public bool? RECOGNITION { get; set; }

        public int? POLPORTSNO { get; set; }

        public int? PODPORTSNO { get; set; }

        public long? POLVVUNID { get; set; }

        public long? PODVVUNID { get; set; }

        [StringLength(10)]
        public string VIAZONE { get; set; }

        [StringLength(3)]
        public string TSPCITY { get; set; }

        [StringLength(2)]
        public string TSPCTRY { get; set; }

        [StringLength(35)]
        public string TSPNAME { get; set; }

        public bool? ISBTBSHP { get; set; }

        public bool? ISLOCALJOB { get; set; }

        public bool? ISHUB { get; set; }

        [StringLength(10)]
        public string READYCLOSEBY { get; set; }

        [StringLength(4)]
        public string POLETDTIME { get; set; }

        [StringLength(4)]
        public string PODETATIME { get; set; }

        public DateTime? LASTRECDATE { get; set; }

        [StringLength(4)]
        public string LASTRECTIME { get; set; }

        //public bool? IS3RDPARTYLOAD { get; set; }

        //[StringLength(10)]
        //public string READY4FINCLOSEBY { get; set; }

        public virtual JOBOTHER JOBOTHER { get; set; }
    }
}
