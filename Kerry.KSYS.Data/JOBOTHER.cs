namespace Kerry.KSYS.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JOBOTHER")]
    public partial class JOBOTHER
    {
        public bool? ISASSEMBLY { get; set; }

        public bool? ISLCSHP { get; set; }

        [StringLength(10)]
        public string HANDLING_PARTY { get; set; }

        [StringLength(70)]
        public string HANDLINGNAME { get; set; }

        [StringLength(3)]
        public string HANDLINGCITY { get; set; }

        [StringLength(2)]
        public string HANDLINGCTRY { get; set; }

        [StringLength(45)]
        public string HANDLING_PIC { get; set; }

        [StringLength(45)]
        public string HANDLING_TEL { get; set; }

        [StringLength(45)]
        public string HANDLING_FAX { get; set; }

        [StringLength(1024)]
        public string WHINSTRUCTION { get; set; }

        [StringLength(10)]
        public string LOCATION { get; set; }

        [StringLength(10)]
        public string CSIND { get; set; }

        public decimal? TOTPP { get; set; }

        public decimal? TOTCC { get; set; }

        public decimal? TOTCCLC { get; set; }

        public decimal? TOTFRTFC { get; set; }

        public decimal? TOTFRTLC { get; set; }

        public decimal? TOTREV { get; set; }

        public decimal? TOTCOST { get; set; }

        public decimal? TOTTAX { get; set; }

        public decimal? TOTPPLC { get; set; }

        [StringLength(10)]
        public string COMMCODE { get; set; }

        [StringLength(70)]
        public string COMM { get; set; }

        [StringLength(200)]
        public string COMMLOCALDESC { get; set; }

        [StringLength(200)]
        public string DGCLASS { get; set; }

        [StringLength(20)]
        public string DGCODEPAGE { get; set; }

        [StringLength(20)]
        public string DGUNNO { get; set; }

        public decimal? FLASHPOINT { get; set; }

        [StringLength(1)]
        public string FLASHPOINTUOM { get; set; }

        [StringLength(10)]
        public string REFRIGERATION { get; set; }

        [StringLength(10)]
        public string INSURANCETYPE { get; set; }

        public DateTime? INSURANCEDATE { get; set; }

        public decimal? ALLOCATEDCOST { get; set; }

        public decimal? ALLOCATEDREV { get; set; }

        public bool? ISPARTSHP { get; set; }

        [StringLength(10)]
        public string BKCARRIER { get; set; }

        [StringLength(50)]
        public string BKVESSELFLT { get; set; }

        public int? BKPCS { get; set; }

        [StringLength(3)]
        public string BKPCS_UT { get; set; }

        public decimal? BKGNETWGT { get; set; }

        public decimal? BKGWGT { get; set; }

        [StringLength(3)]
        public string BKGWGT_UT { get; set; }

        public decimal? BKGVOL { get; set; }

        [StringLength(3)]
        public string BKGVOL_UT { get; set; }

        [StringLength(10)]
        public string STATISTIC_PARTY { get; set; }

        [StringLength(2)]
        public string INVIND { get; set; }

        [StringLength(15)]
        public string EXPORTTO { get; set; }

        public bool TRIANGLE { get; set; }

        [StringLength(2)]
        public string TRANSHIPTYPE { get; set; }

        [StringLength(1024)]
        public string ALLOCATIONNO { get; set; }

        public byte? PRTCNT { get; set; }

        public bool? ISFOB { get; set; }

        [StringLength(30)]
        public string BRONO { get; set; }

        public DateTime? RELEASE { get; set; }

        [StringLength(10)]
        public string PARTYID_BANK { get; set; }

        [StringLength(70)]
        public string BANKNAME { get; set; }

        [StringLength(500)]
        public string BROREMARK { get; set; }

        [StringLength(10)]
        public string BROCREATEBY { get; set; }

        public DateTime? BROCREATEDATE { get; set; }

        [StringLength(10)]
        public string BROUPDATEBY { get; set; }

        public DateTime? BROUPDATEDATE { get; set; }

        [StringLength(10)]
        public string TAXSTATUS { get; set; }

        [StringLength(1)]
        public string MANIFESTGRP { get; set; }

        [StringLength(10)]
        public string PARTYID_BROKER { get; set; }

        [StringLength(70)]
        public string BROKERNAME { get; set; }

        [StringLength(20)]
        public string INTOWHNO { get; set; }

        [StringLength(10)]
        public string WHCODE { get; set; }

        public DateTime? WHINDATE { get; set; }

        [StringLength(4)]
        public string WHINTIME { get; set; }

        public DateTime? WHOUTDATE { get; set; }

        [StringLength(4)]
        public string WHOUTTIME { get; set; }

        [StringLength(200)]
        public string FLEXIFLD1 { get; set; }

        [StringLength(200)]
        public string FLEXIFLD2 { get; set; }

        [StringLength(200)]
        public string FLEXIFLD3 { get; set; }

        public bool? ISCOMBINED { get; set; }

        [StringLength(10)]
        public string SOURCE { get; set; }

        [StringLength(1)]
        public string BOOKSTATUS { get; set; }

        [StringLength(10)]
        public string BOOKPROCESSBY { get; set; }

        [StringLength(10)]
        public string THIRDPARTYPS { get; set; }

        [StringLength(3)]
        public string PSCURRCODE { get; set; }

        public decimal? PSEXRATE { get; set; }

        [StringLength(256)]
        public string PS_RATE { get; set; }

        [StringLength(1)]
        public string PS_TYPE { get; set; }

        public bool? ISSUBCONOUT { get; set; }

        [StringLength(10)]
        public string PARTYID_SUBCONOUT { get; set; }

        [StringLength(70)]
        public string SUBCONOUTNAME { get; set; }

        [StringLength(10)]
        public string PARTYID_UNION { get; set; }

        [StringLength(20)]
        public string UNIONCONTRACTNO { get; set; }

        [StringLength(20)]
        public string UNIONPAYMENTTERM { get; set; }

        [StringLength(20)]
        public string PSCONNO { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long JOB_UNID { get; set; }

        [StringLength(4000)]
        public string BKGMARKS { get; set; }

        [StringLength(4000)]
        public string BKGGOODDESC { get; set; }

        [StringLength(2)]
        public string COLOAD { get; set; }

        [StringLength(10)]
        public string PARTYID_COL { get; set; }

        [StringLength(3)]
        public string SERVICETYPE { get; set; }

        public DateTime? PROMISEDELVYDATE { get; set; }

        [StringLength(10)]
        public string SERVICELEVEL { get; set; }

        [StringLength(20)]
        public string LANE { get; set; }

        [StringLength(10)]
        public string ROUTEID { get; set; }

        [StringLength(10)]
        public string INCOTERM { get; set; }

        [StringLength(500)]
        public string SERVICEREQ { get; set; }

        [StringLength(500)]
        public string SPECIALREQ { get; set; }

        [StringLength(20)]
        public string TARIFFNO { get; set; }

        [StringLength(10)]
        public string CUSTDEPT { get; set; }

        [StringLength(45)]
        public string CUST_PIC { get; set; }

        [StringLength(45)]
        public string CUST_TEL { get; set; }

        [StringLength(45)]
        public string CUST_FAX { get; set; }

        [StringLength(10)]
        public string PARTYID_3PRATING { get; set; }

        [StringLength(70)]
        public string THIRDPRATINGNAME { get; set; }

        [StringLength(1)]
        public string RLJ { get; set; }

        [StringLength(10)]
        public string SALES { get; set; }

        [StringLength(10)]
        public string SALESDEPT { get; set; }

        [StringLength(10)]
        public string CSUSERID { get; set; }

        [StringLength(10)]
        public string CONSOLEUSERID { get; set; }

        [StringLength(10)]
        public string EIQRTNUSERID { get; set; }

        [StringLength(10)]
        public string CUSTOMDECLUSERID { get; set; }

        [StringLength(10)]
        public string CTNLPUSERID { get; set; }

        [StringLength(10)]
        public string OPUSERID { get; set; }

        [StringLength(10)]
        public string ACCOUNTUSERID { get; set; }

        [StringLength(45)]
        public string SHPRADDR1 { get; set; }

        [StringLength(45)]
        public string SHPRADDR2 { get; set; }

        [StringLength(45)]
        public string SHPRADDR3 { get; set; }

        [StringLength(45)]
        public string SHPRADDR4 { get; set; }

        [StringLength(45)]
        public string SHPR_PIC { get; set; }

        [StringLength(45)]
        public string SHPR_TEL { get; set; }

        [StringLength(45)]
        public string SHPR_FAX { get; set; }

        [StringLength(3)]
        public string SHPRCITYCODE { get; set; }

        [StringLength(2)]
        public string SHPRCTRYCODE { get; set; }

        [StringLength(10)]
        public string SHPRPOSTALCODE { get; set; }

        [StringLength(15)]
        public string SHPRSTATEPROV { get; set; }

        [StringLength(20)]
        public string SHPRCOUNTY { get; set; }

        [StringLength(10)]
        public string SHPRZONE { get; set; }

        [StringLength(10)]
        public string PARTYID_CSGNONWB { get; set; }

        [StringLength(70)]
        public string CSGNNAMEONWB { get; set; }

        [StringLength(45)]
        public string CSGNADDR1 { get; set; }

        [StringLength(45)]
        public string CSGNADDR2 { get; set; }

        [StringLength(45)]
        public string CSGNADDR3 { get; set; }

        [StringLength(45)]
        public string CSGNADDR4 { get; set; }

        [StringLength(45)]
        public string CSGN_PIC { get; set; }

        [StringLength(45)]
        public string CSGN_TEL { get; set; }

        [StringLength(45)]
        public string CSGN_FAX { get; set; }

        [StringLength(3)]
        public string CSGNCITYCODE { get; set; }

        [StringLength(2)]
        public string CSGNCTRYCODE { get; set; }

        [StringLength(10)]
        public string CSGNPOSTALCODE { get; set; }

        [StringLength(15)]
        public string CSGNSTATEPROV { get; set; }

        [StringLength(20)]
        public string CSGNCOUNTY { get; set; }

        [StringLength(10)]
        public string CSGNZONE { get; set; }

        [StringLength(10)]
        public string PARTYID_NTFY { get; set; }

        [StringLength(70)]
        public string NTFYNAME { get; set; }

        [StringLength(45)]
        public string NTFYADDR1 { get; set; }

        [StringLength(45)]
        public string NTFYADDR2 { get; set; }

        [StringLength(45)]
        public string NTFYADDR3 { get; set; }

        [StringLength(45)]
        public string NTFYADDR4 { get; set; }

        [StringLength(45)]
        public string NTFY_PIC { get; set; }

        [StringLength(45)]
        public string NTFY_TEL { get; set; }

        [StringLength(45)]
        public string NTFY_FAX { get; set; }

        [StringLength(10)]
        public string PARTYID_ANTFY { get; set; }

        [StringLength(70)]
        public string ANTFYNAME { get; set; }

        [StringLength(45)]
        public string ANTFYADDR1 { get; set; }

        [StringLength(45)]
        public string ANTFYADDR2 { get; set; }

        [StringLength(45)]
        public string ANTFYADDR3 { get; set; }

        [StringLength(45)]
        public string ANTFYADDR4 { get; set; }

        [StringLength(45)]
        public string ANTFY_PIC { get; set; }

        [StringLength(45)]
        public string ANTFY_TEL { get; set; }

        [StringLength(45)]
        public string ANTFY_FAX { get; set; }

        public decimal? FRTRATE { get; set; }

        [StringLength(2)]
        public string FRTTYPE { get; set; }

        public bool? ISALLIN { get; set; }

        [StringLength(50)]
        public string FRTTERM { get; set; }

        [StringLength(2)]
        public string OTHTYPE { get; set; }

        [StringLength(3)]
        public string PPCURRCODE { get; set; }

        public decimal? PPEXRATE { get; set; }

        [StringLength(3)]
        public string CCCURRCODE { get; set; }

        public decimal? CCEXRATE { get; set; }

        [StringLength(10)]
        public string SERVICEPLANTMPL { get; set; }

        public decimal? CARGOVALUE { get; set; }

        [StringLength(3)]
        public string CARGOVALUE_CURR { get; set; }

        [Required]
        [StringLength(1)]
        public string SHPCATEGORY { get; set; }

        [StringLength(12)]
        public string BKVOYAGE { get; set; }

        [StringLength(10)]
        public string PARTYID_QRTN { get; set; }

        [StringLength(10)]
        public string PARTYID_TRUCKCOMPANY { get; set; }

        [StringLength(500)]
        public string BKGLOCALGOODDESC { get; set; }

        [StringLength(10)]
        public string OPDEPT { get; set; }

        public bool? REQBRO { get; set; }

        public DateTime? ETDDATE { get; set; }

        [StringLength(4)]
        public string ETDTIME { get; set; }

        public bool? ISFINCOMMPAID { get; set; }

        public int? SKUQTY { get; set; }

        public DateTime? FINCOMMPAIDDATE { get; set; }

        public DateTime? BKONBOARDDATE { get; set; }

        [StringLength(45)]
        public string CSGNHANDPHONE { get; set; }

        [StringLength(10)]
        public string FINCOMMPAIDBY { get; set; }

        public short? SORTORDER { get; set; }

        public decimal? KPIDLVRYDATE { get; set; }

        [StringLength(1)]
        public string KPIDLVRYDATEUT { get; set; }

        public decimal? KPIRETURNDATE { get; set; }

        [StringLength(1)]
        public string KPIRETURNDATEUT { get; set; }

        public DateTime? RETURNORDERDATE { get; set; }

        [StringLength(4)]
        public string RETURNORDERTIME { get; set; }

        [StringLength(10)]
        public string TRADETYPE { get; set; }

        [StringLength(10)]
        public string CUSTOMSDECLTYPE { get; set; }

        [StringLength(10)]
        public string QRTNTYPE { get; set; }

        [StringLength(10)]
        public string CHRGAPPROVEBY { get; set; }

        public DateTime? CHRGAPPROVEDATE { get; set; }

        [StringLength(10)]
        public string WFBOOKINGSTATUS { get; set; }

        [StringLength(35)]
        public string CSGNZONENAME { get; set; }

        public bool? ISFINISHEDCHRG { get; set; }

        [StringLength(10)]
        public string POSTBY { get; set; }

        public DateTime? POSTDATE { get; set; }

        [StringLength(10)]
        public string VOUCHERBY { get; set; }

        public DateTime? VOUCHERDATE { get; set; }

        [StringLength(15)]
        public string VOUCHERNO { get; set; }

        [StringLength(1)]
        public string SETTLEMENTSTATUS { get; set; }

        public bool? FOLLOWCONSOLE { get; set; }

        [StringLength(70)]
        public string WHNAME { get; set; }

        [StringLength(50)]
        public string BKVESSELFLTLOCAL { get; set; }

        [StringLength(2)]
        public string BKFRTTYPE { get; set; }

        [StringLength(2)]
        public string BKOTHTYPE { get; set; }

        [StringLength(30)]
        public string DONO { get; set; }

        [StringLength(10)]
        public string CUSTOMSPORT { get; set; }

        [StringLength(10)]
        public string DISPATCHWH { get; set; }

        [StringLength(70)]
        public string DISPATCHWHNAME { get; set; }

        public int? DOCHANGEDCNT { get; set; }

        public bool? ISMANICHANGED { get; set; }

        [StringLength(10)]
        public string PARTYID_INSURANCE { get; set; }

        [StringLength(70)]
        public string INSURNAME { get; set; }

        [StringLength(100)]
        public string INSUROUTCOVERAGE { get; set; }

        public bool? ISCHARGEDAINSUR { get; set; }

        [StringLength(10)]
        public string PARTYID_TPTINSUR { get; set; }

        [StringLength(70)]
        public string TPTNAME { get; set; }

        [StringLength(10)]
        public string INSURANCENO { get; set; }

        [StringLength(10)]
        public string PICSELFPICKUP { get; set; }

        [StringLength(100)]
        public string SELFPICKUPCONTACT { get; set; }

        public DateTime? SELFPICKUPREQDATE { get; set; }

        [StringLength(4)]
        public string SELFPICKUPREQTIME { get; set; }

        public DateTime? SELFPICKUPPLANDATE { get; set; }

        [StringLength(4)]
        public string SELFPICKUPPLANTIME { get; set; }

        [StringLength(1000)]
        public string SELFPICKUPREMARK { get; set; }

        public DateTime? EXCHANGEWBDATE { get; set; }

        [StringLength(20)]
        public string VTARIFFNO { get; set; }

        [StringLength(1000)]
        public string MANICHANGETEXT { get; set; }

        public bool? SKIPCSI { get; set; }

        public bool? CSIMASTER { get; set; }

        public long? CTRFHDR_UNID { get; set; }

        public long? VTRFHDR_UNID { get; set; }

        public bool? ISOUTSOURCE { get; set; }

        public bool? ISPICKUPDONE { get; set; }

        public bool? ISWBEXCHANGED { get; set; }

        [StringLength(10)]
        public string TPTTYPE { get; set; }

        public DateTime? REQETADATE { get; set; }

        [StringLength(4)]
        public string REQETATIME { get; set; }

        public bool? ISREQINSURANCE { get; set; }

        [StringLength(1024)]
        public string INSURANCETERM { get; set; }

        [StringLength(1)]
        public string FOBSTAGE { get; set; }

        public decimal? HIGHESTTEMP { get; set; }

        public decimal? LOWESTTEMP { get; set; }

        public decimal? SETTEMP { get; set; }

        [StringLength(1)]
        public string TEMPUOM { get; set; }

        public bool? HASDOC { get; set; }

        [StringLength(10)]
        public string PARTYID_ANTFY2 { get; set; }

        [StringLength(140)]
        public string ANTFYNAME2 { get; set; }

        [StringLength(45)]
        public string ANTFYADDR21 { get; set; }

        [StringLength(45)]
        public string ANTFYADDR22 { get; set; }

        [StringLength(45)]
        public string ANTFYADDR23 { get; set; }

        [StringLength(45)]
        public string ANTFYADDR24 { get; set; }

        [StringLength(45)]
        public string ANTFY_PIC2 { get; set; }

        [StringLength(45)]
        public string ANTFY_TEL2 { get; set; }

        [StringLength(45)]
        public string ANTFY_FAX2 { get; set; }

        [StringLength(20)]
        public string ACCRUEDBY { get; set; }

        public DateTime? ACCRUEDDATE { get; set; }

        [StringLength(2)]
        public string FOBTYPE { get; set; }

        [StringLength(2)]
        public string INSURANCEPPCC { get; set; }

        public bool? ISSKIPBALANCE { get; set; }

        [StringLength(50)]
        public string OPSTATUS { get; set; }

        [StringLength(10)]
        public string FOURTHPARTYPS { get; set; }

        [StringLength(10)]
        public string PRSETTLEMENTTYPE { get; set; }

        [StringLength(512)]
        public string HAZARDDESC { get; set; }

        [StringLength(1)]
        public string HAZARDCODEQUALIFIER { get; set; }

        [StringLength(30)]
        public string HAZARDLABEL { get; set; }

        [StringLength(30)]
        public string HAZARDCLASSIFICATION { get; set; }

        [StringLength(30)]
        public string HAZARDCONTACT { get; set; }

        [StringLength(10)]
        public string DGPACKINGGROUP { get; set; }

        public decimal? BUYINGFRTRATE { get; set; }

        [StringLength(1)]
        public string QUOTESTATUS { get; set; }

        public bool? REQUESTTOSEND { get; set; }

        public DateTime? SENTDATETIME { get; set; }

        [StringLength(20)]
        public string EXPCUSTOMOFFICE { get; set; }

        [StringLength(20)]
        public string IMPCUSTOMOFFICE { get; set; }

        [StringLength(1)]
        public string WBCONFIRM { get; set; }

        [StringLength(10)]
        public string PARTYID_IMPBROKER { get; set; }

        [StringLength(70)]
        public string IMPBROKER { get; set; }

        [StringLength(64)]
        public string LCNO { get; set; }

        public DateTime? LCISSUEDATE { get; set; }

        public DateTime? LCEXPIRYDATE { get; set; }

        [StringLength(2)]
        public string SEAOFTPAYCTRY { get; set; }

        [StringLength(3)]
        public string SEAOFTPAYCITY { get; set; }

        [StringLength(10)]
        public string BORDERSPORT { get; set; }

        [StringLength(15)]
        public string CUSTECVATNO { get; set; }

        [StringLength(15)]
        public string SHPRECVATNO { get; set; }

        [StringLength(15)]
        public string CSGNECVATNO { get; set; }

        [StringLength(15)]
        public string NTFYECVATNO { get; set; }

        [StringLength(15)]
        public string ANTFYECVATNO { get; set; }

        [StringLength(15)]
        public string ANTFYECVATNO2 { get; set; }

        [StringLength(15)]
        public string THIRDPARTYPSECVATNO { get; set; }

        [StringLength(15)]
        public string FOURTHPARTYPSECVATNO { get; set; }

        [StringLength(17)]
        public string SHPRREGNO { get; set; }

        [StringLength(1)]
        public string SHPRREGNOTYPE { get; set; }

        [StringLength(12)]
        public string SHPRIRSNO { get; set; }

        [StringLength(1)]
        public string SHPRIRSNOTYPE { get; set; }

        [StringLength(17)]
        public string CSGNREGNO { get; set; }

        [StringLength(1)]
        public string CSGNREGNOTYPE { get; set; }

        [StringLength(12)]
        public string CSGNIRSNO { get; set; }

        [StringLength(1)]
        public string CSGNIRSNOTYPE { get; set; }

        [StringLength(17)]
        public string NTFYREGNO { get; set; }

        [StringLength(1)]
        public string NTFYREGNOTYPE { get; set; }

        [StringLength(12)]
        public string NTFYIRSNO { get; set; }

        [StringLength(1)]
        public string NTFYIRSNOTYPE { get; set; }

        [StringLength(17)]
        public string ANTFYREGNO { get; set; }

        [StringLength(1)]
        public string ANTFYREGNOTYPE { get; set; }

        [StringLength(12)]
        public string ANTFYIRSNO { get; set; }

        [StringLength(1)]
        public string ANTFYIRSNOTYPE { get; set; }

        [StringLength(17)]
        public string ANTFY2REGNO { get; set; }

        [StringLength(1)]
        public string ANTFY2REGNOTYPE { get; set; }

        [StringLength(12)]
        public string ANTFY2IRSNO { get; set; }

        [StringLength(1)]
        public string ANTFY2IRSNOTYPE { get; set; }

        [StringLength(17)]
        public string CUSTREGNO { get; set; }

        [StringLength(1)]
        public string CUSTREGNOTYPE { get; set; }

        [StringLength(12)]
        public string CUSTIRSNO { get; set; }

        [StringLength(1)]
        public string CUSTIRSNOTYPE { get; set; }

        public bool? ECSHOLDSTATUS { get; set; }

        public DateTime? VALIDATEECSTIME { get; set; }

        [StringLength(1)]
        public string WHADJTYPE { get; set; }

        [StringLength(20)]
        public string PRONUMBER { get; set; }

        public decimal? FRTAMOUNT { get; set; }

        [StringLength(45)]
        public string WHADDR1 { get; set; }

        [StringLength(45)]
        public string WHADDR2 { get; set; }

        [StringLength(45)]
        public string WHADDR3 { get; set; }

        [StringLength(45)]
        public string WHADDR4 { get; set; }

        [StringLength(45)]
        public string WH_PIC { get; set; }

        [StringLength(45)]
        public string WH_TEL { get; set; }

        [StringLength(45)]
        public string WH_FAX { get; set; }

        [StringLength(3)]
        public string WHCITYCODE { get; set; }

        [StringLength(2)]
        public string WHCTRYCODE { get; set; }

        [StringLength(10)]
        public string WHPOSTALCODE { get; set; }

        [StringLength(15)]
        public string WHSTATEPROV { get; set; }

        [StringLength(10)]
        public string WHZONE { get; set; }

        public decimal? ACTUALTOTREV { get; set; }

        public decimal? ACTUALTOTCOST { get; set; }

        public decimal? ACTUALALLOCATEDREV { get; set; }

        public decimal? ACTUALALLOCATEDCOST { get; set; }

        [StringLength(50)]
        public string INCOTERMLOCATION { get; set; }

        [StringLength(22)]
        public string HSCODE { get; set; }

        [StringLength(10)]
        public string REASONCODE { get; set; }

        [StringLength(500)]
        public string REASONREMARK { get; set; }

        [StringLength(10)]
        public string KNOWNSTATUS { get; set; }

        public bool? SHPRKNOWN { get; set; }

        public decimal? CONVBKGWGT { get; set; }

        [StringLength(3)]
        public string CONVBKGWGT_UT { get; set; }

        public decimal? CONVBKGVOL { get; set; }

        [StringLength(3)]
        public string CONVBKGVOL_UT { get; set; }

        public DateTime? ONBOARDDATE { get; set; }

        public DateTime? RELEASEDATE { get; set; }

        [StringLength(10)]
        public string RELEASEDBY { get; set; }

        public DateTime? DORELEASEDATE { get; set; }

        [StringLength(10)]
        public string BIZSCOPE { get; set; }

        public bool? ISALLINMOREPARTY { get; set; }

        public DateTime? CARGOREADYDATE { get; set; }

        public bool? MCCSHIPMENT { get; set; }

        [StringLength(45)]
        public string CSGN2ADDR1 { get; set; }

        [StringLength(45)]
        public string CSGN2ADDR2 { get; set; }

        [StringLength(45)]
        public string CSGN2ADDR3 { get; set; }

        [StringLength(45)]
        public string CSGN2ADDR4 { get; set; }

        [StringLength(45)]
        public string CSGN2_PIC { get; set; }

        [StringLength(45)]
        public string CSGN2_TEL { get; set; }

        [StringLength(45)]
        public string CSGN2_FAX { get; set; }

        [StringLength(3)]
        public string CSGN2CITYCODE { get; set; }

        [StringLength(2)]
        public string CSGN2CTRYCODE { get; set; }

        [StringLength(10)]
        public string CSGN2POSTALCODE { get; set; }

        [StringLength(15)]
        public string CSGN2STATEPROV { get; set; }

        [StringLength(20)]
        public string CSGN2COUNTY { get; set; }

        [StringLength(10)]
        public string CSGN2ZONE { get; set; }

        [StringLength(17)]
        public string CSGN2REGNO { get; set; }

        [StringLength(1)]
        public string CSGN2REGNOTYPE { get; set; }

        [StringLength(12)]
        public string CSGN2IRSNO { get; set; }

        [StringLength(1)]
        public string CSGN2IRSNOTYPE { get; set; }

        [StringLength(15)]
        public string CSGN2ECVATNO { get; set; }

        [StringLength(3)]
        public string FTZTXTYPEA { get; set; }

        [StringLength(3)]
        public string FTZTXTYPEL { get; set; }

        public bool? ISCUSTOMDECL { get; set; }

        [StringLength(30)]
        public string DECLNO { get; set; }

        [StringLength(35)]
        public string DECLPLACE { get; set; }

        public DateTime? DECLDATE { get; set; }

        public DateTime? LASTFREEDATE { get; set; }

        [StringLength(4)]
        public string LASTFREETIME { get; set; }

        [StringLength(30)]
        public string SHPRBEFUNCTION { get; set; }

        [StringLength(15)]
        public string SHPRSITECODE { get; set; }

        [StringLength(30)]
        public string CSGNBEFUNCTION { get; set; }

        [StringLength(15)]
        public string CSGNSITECODE { get; set; }

        [StringLength(30)]
        public string NTFYBEFUNCTION { get; set; }

        [StringLength(15)]
        public string NTFYSITECODE { get; set; }

        [StringLength(1)]
        public string ALLOCATESTATUS { get; set; }

        [StringLength(30)]
        public string CSGN2BEFUNCTION { get; set; }

        [StringLength(15)]
        public string CSGN2SITECODE { get; set; }

        [StringLength(10)]
        public string CUSTCATE { get; set; }

        [StringLength(10)]
        public string SHPRCATE { get; set; }

        [StringLength(10)]
        public string CSGNCATE { get; set; }

        [StringLength(10)]
        public string CSGN2CATE { get; set; }

        [StringLength(20)]
        public string RMBRTARIFFNO { get; set; }

        [StringLength(50)]
        public string RMBRAGREEMENTNO { get; set; }

        [StringLength(30)]
        public string RMBRAMENDNO { get; set; }

        [StringLength(20)]
        public string RMSRTARIFFNO { get; set; }

        [StringLength(30)]
        public string RMSRAMENDNO { get; set; }

        [StringLength(20)]
        public string DECLSTATUS { get; set; }

        public DateTime? PRICINGDATE { get; set; }

        public bool? CUSTGOODS { get; set; }

        public long? SOURCEUNID { get; set; }

        public bool? ISDAMAGED { get; set; }

        public bool? ISMISSING { get; set; }

        [StringLength(1000)]
        public string DAMAGEDREASON { get; set; }

        [StringLength(1000)]
        public string MISSINGREASON { get; set; }

        [StringLength(50)]
        public string MASTATUS { get; set; }

        [StringLength(20)]
        public string MAPROCESSSTATUS { get; set; }

        public decimal? PURPINSURANCEVAL { get; set; }

        public decimal? PREMIUMPERC { get; set; }

        [StringLength(3)]
        public string PREMIUMCURR { get; set; }

        public decimal? PREMIUMAMT { get; set; }

        [StringLength(3)]
        public string ADMINFEECURR { get; set; }

        public decimal? ADMINFEEAMT { get; set; }

        public decimal? TOTINSURANCEAMT { get; set; }

        [StringLength(3)]
        public string TOTINSURANCECURR { get; set; }

        [StringLength(20)]
        public string INSURANCESTATUS { get; set; }

        public byte? PRTFCRCNT { get; set; }

        public DateTime? FULFILLMENTDATE { get; set; }

        [StringLength(20)]
        public string SCREENMETHOD { get; set; }

        public DateTime? INSPECTDATE { get; set; }

        [StringLength(50)]
        public string INSPECTBY { get; set; }

        [StringLength(20)]
        public string SHPRKNOWNTYPE { get; set; }

        [StringLength(35)]
        public string SHPRREGISTRATIONNO { get; set; }

        public DateTime? SHPREXPIRYDATE { get; set; }

        [StringLength(1024)]
        public string SCREENMETHODTEXT { get; set; }

        public decimal? MIXALLOCATEDREV { get; set; }

        public decimal? MIXALLOCATEDCOST { get; set; }

        [StringLength(3)]
        public string INSCURRCODE { get; set; }

        [StringLength(2)]
        public string INSFROMCTRY { get; set; }

        [StringLength(8)]
        public string INSFROMPLACE { get; set; }

        [StringLength(2)]
        public string INSTOCTRY { get; set; }

        [StringLength(8)]
        public string INSTOPLACE { get; set; }

        [StringLength(4)]
        public string ONBOARDTIME { get; set; }

        [StringLength(3)]
        public string NTFYCITYCODE { get; set; }

        [StringLength(2)]
        public string NTFYCTRYCODE { get; set; }

        [StringLength(10)]
        public string NTFYPOSTALCODE { get; set; }

        [StringLength(15)]
        public string NTFYSTATEPROV { get; set; }

        [StringLength(10)]
        public string NTFYZONE { get; set; }

        [StringLength(4)]
        public string DECLTIME { get; set; }

        [StringLength(4)]
        public string INSPECTTIME { get; set; }

        [StringLength(20)]
        public string COMMODITY { get; set; }

        [StringLength(10)]
        public string CSRCODE { get; set; }

        [StringLength(4)]
        public string CARGOREADYTIME { get; set; }

        public virtual JOB JOB { get; set; }
    }
}
