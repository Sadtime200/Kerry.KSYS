namespace Kerry.KSYS.Data
{
    using System.Data.Entity;
    using System.Linq;

    public partial class KEntities : DbContext
    {
        public KEntities()
            : base("name=KEntities")
        {
        }

        public virtual DbSet<JOB> JOB { get; set; }
        public virtual DbSet<JOBLINK> JOBLINK { get; set; }
        public virtual DbSet<JOBOTHER> JOBOTHER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // get current schema to allow auto switch to another schema.
            LoadCurrentSchema(modelBuilder);

            modelBuilder.Entity<JOB>()
                .Property(e => e.OWNERID)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.GSHPID)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.BIZTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.BOOKINGNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.SHPNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CONSOLNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.JOBNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PROJECTNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.SHPTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.OAGENT)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PARTYID_CUST)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CUSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CARRIERID)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CARRIERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PARTYID_SHPR)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.SHPRNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PARTYID_CSGN)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CSGNNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PORCITY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PORCTRY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PORMODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.POLCITY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.POLCTRY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.POLNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.VIACITY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.VIACTRY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PODCITY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PODCTRY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PODNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.DESTCITY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.DESTCTRY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.DESTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.DEVRYCITY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.DEVRYCTRY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.DEVRYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.FLTTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TOTPCS_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TOTGWGT)
                .HasPrecision(14, 4);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TOTGWGT_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TOTCWGT)
                .HasPrecision(14, 4);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TOTCWGT_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.VWGT)
                .HasPrecision(13, 3);

            modelBuilder.Entity<JOB>()
                .Property(e => e.VWGT_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.ORGID)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.JOBSTAGECODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CURRENTSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CURRENTSTAGE)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PROCESSSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.USERHLEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CREATEBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.UPDATEBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TIMEZONE)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TOTVOL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TOTVOL_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.VOIDBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TOTNWGT)
                .HasPrecision(13, 3);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TOTNWGT_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TOTINNERPCS)
                .HasPrecision(14, 4);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TOTINNERPCS_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CONCLOSEBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.FINCLOSEBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.POTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.BOOKINGTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CONSOLBKNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.SUREFNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.SPREFNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.VOIDTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.REVCLOSEBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.COSTCLOSEBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TOTNVOL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<JOB>()
                .Property(e => e.JOBTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.VIANAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.QUOTENO)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.QUOTESUBNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.QUOTETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PORETATIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.DEVRYETDTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PORETDTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.DEVRYETATIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.SENDERID)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TOBASEEXRATE)
                .HasPrecision(14, 7);

            modelBuilder.Entity<JOB>()
                .Property(e => e.FROMBASEEXRATE)
                .HasPrecision(14, 7);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CONVTOTGWGT)
                .HasPrecision(14, 4);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CONVTOTGWGT_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CONVTOTNWGT)
                .HasPrecision(13, 3);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CONVTOTNWGT_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CONVTOTVOL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CONVTOTVOL_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.CONVTOTNVOL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<JOB>()
                .Property(e => e.VIAZONE)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TSPCITY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TSPCTRY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.TSPNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.READYCLOSEBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.POLETDTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.PODETATIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .Property(e => e.LASTRECTIME)
                .IsUnicode(false);

            //modelBuilder.Entity<JOB>()
            //    .Property(e => e.READY4FINCLOSEBY)
            //    .IsUnicode(false);

            modelBuilder.Entity<JOB>()
                .HasOptional(e => e.JOBOTHER)
                .WithRequired(e => e.JOB)
                .WillCascadeOnDelete();

            modelBuilder.Entity<JOBLINK>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HANDLING_PARTY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HANDLINGNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HANDLINGCITY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HANDLINGCTRY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HANDLING_PIC)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HANDLING_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HANDLING_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHINSTRUCTION)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.LOCATION)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSIND)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TOTPP)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TOTCC)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TOTCCLC)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TOTFRTFC)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TOTFRTLC)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TOTREV)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TOTCOST)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TOTTAX)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TOTPPLC)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.COMMCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.COMM)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.COMMLOCALDESC)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.DGCLASS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.DGCODEPAGE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.DGUNNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FLASHPOINT)
                .HasPrecision(9, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FLASHPOINTUOM)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.REFRIGERATION)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSURANCETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ALLOCATEDCOST)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ALLOCATEDREV)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKCARRIER)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKVESSELFLT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKPCS_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKGNETWGT)
                .HasPrecision(13, 3);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKGWGT)
                .HasPrecision(14, 4);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKGWGT_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKGVOL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKGVOL_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.STATISTIC_PARTY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INVIND)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.EXPORTTO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TRANSHIPTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ALLOCATIONNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BRONO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_BANK)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BANKNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BROREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BROCREATEBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BROUPDATEBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TAXSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.MANIFESTGRP)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_BROKER)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BROKERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INTOWHNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHINTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHOUTTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FLEXIFLD1)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FLEXIFLD2)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FLEXIFLD3)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SOURCE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BOOKSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BOOKPROCESSBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.THIRDPARTYPS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PSCURRCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PSEXRATE)
                .HasPrecision(14, 7);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PS_RATE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PS_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_SUBCONOUT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SUBCONOUTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_UNION)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.UNIONCONTRACTNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.UNIONPAYMENTTERM)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PSCONNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKGMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKGGOODDESC)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.COLOAD)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_COL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SERVICETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SERVICELEVEL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.LANE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ROUTEID)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INCOTERM)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SERVICEREQ)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SPECIALREQ)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TARIFFNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CUSTDEPT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CUST_PIC)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CUST_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CUST_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_3PRATING)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.THIRDPRATINGNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.RLJ)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SALES)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SALESDEPT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CONSOLEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.EIQRTNUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CUSTOMDECLUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CTNLPUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.OPUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ACCOUNTUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRADDR1)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRADDR2)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRADDR3)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRADDR4)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPR_PIC)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPR_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPR_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRCITYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRCTRYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRPOSTALCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRSTATEPROV)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRCOUNTY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRZONE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_CSGNONWB)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNNAMEONWB)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNADDR1)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNADDR2)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNADDR3)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNADDR4)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN_PIC)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNCITYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNCTRYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNPOSTALCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNSTATEPROV)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNCOUNTY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNZONE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_NTFY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYADDR1)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYADDR2)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYADDR3)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYADDR4)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFY_PIC)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFY_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFY_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_ANTFY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYADDR1)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYADDR2)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYADDR3)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYADDR4)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFY_PIC)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFY_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFY_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FRTRATE)
                .HasPrecision(13, 3);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FRTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FRTTERM)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.OTHTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PPCURRCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PPEXRATE)
                .HasPrecision(14, 7);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CCCURRCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CCEXRATE)
                .HasPrecision(14, 7);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SERVICEPLANTMPL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CARGOVALUE_CURR)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPCATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKVOYAGE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_QRTN)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_TRUCKCOMPANY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKGLOCALGOODDESC)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.OPDEPT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ETDTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNHANDPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FINCOMMPAIDBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.KPIDLVRYDATE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.KPIDLVRYDATEUT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.KPIRETURNDATE)
                .HasPrecision(12, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.KPIRETURNDATEUT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.RETURNORDERTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TRADETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CUSTOMSDECLTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.QRTNTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CHRGAPPROVEBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WFBOOKINGSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNZONENAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.POSTBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.VOUCHERBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.VOUCHERNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SETTLEMENTSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKVESSELFLTLOCAL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKFRTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BKOTHTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.DONO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CUSTOMSPORT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.DISPATCHWH)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.DISPATCHWHNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_INSURANCE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSUROUTCOVERAGE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_TPTINSUR)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSURANCENO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PICSELFPICKUP)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SELFPICKUPCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SELFPICKUPREQTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SELFPICKUPPLANTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SELFPICKUPREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.VTARIFFNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.MANICHANGETEXT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TPTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.REQETATIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSURANCETERM)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FOBSTAGE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HIGHESTTEMP)
                .HasPrecision(9, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.LOWESTTEMP)
                .HasPrecision(9, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SETTEMP)
                .HasPrecision(9, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TEMPUOM)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_ANTFY2)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYNAME2)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYADDR21)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYADDR22)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYADDR23)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYADDR24)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFY_PIC2)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFY_TEL2)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFY_FAX2)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ACCRUEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FOBTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSURANCEPPCC)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.OPSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FOURTHPARTYPS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PRSETTLEMENTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HAZARDDESC)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HAZARDCODEQUALIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HAZARDLABEL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HAZARDCLASSIFICATION)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HAZARDCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.DGPACKINGGROUP)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BUYINGFRTRATE)
                .HasPrecision(13, 3);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.QUOTESTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.EXPCUSTOMOFFICE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.IMPCUSTOMOFFICE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WBCONFIRM)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PARTYID_IMPBROKER)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.IMPBROKER)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.LCNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SEAOFTPAYCTRY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SEAOFTPAYCITY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BORDERSPORT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CUSTECVATNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRECVATNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNECVATNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYECVATNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYECVATNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYECVATNO2)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.THIRDPARTYPSECVATNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FOURTHPARTYPSECVATNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRREGNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRREGNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRIRSNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRIRSNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNREGNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNREGNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNIRSNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNIRSNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYREGNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYREGNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYIRSNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYIRSNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYREGNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYREGNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYIRSNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFYIRSNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFY2REGNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFY2REGNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFY2IRSNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ANTFY2IRSNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CUSTREGNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CUSTREGNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CUSTIRSNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CUSTIRSNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHADJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PRONUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FRTAMOUNT)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHADDR1)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHADDR2)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHADDR3)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHADDR4)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WH_PIC)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WH_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WH_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHCITYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHCTRYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHPOSTALCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHSTATEPROV)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.WHZONE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ACTUALTOTREV)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ACTUALTOTCOST)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ACTUALALLOCATEDREV)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ACTUALALLOCATEDCOST)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INCOTERMLOCATION)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.HSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.REASONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.REASONREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.KNOWNSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CONVBKGWGT)
                .HasPrecision(14, 4);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CONVBKGWGT_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CONVBKGVOL)
                .HasPrecision(14, 4);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CONVBKGVOL_UT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.RELEASEDBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.BIZSCOPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2ADDR1)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2ADDR2)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2ADDR3)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2ADDR4)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2_PIC)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2_FAX)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2CITYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2CTRYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2POSTALCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2STATEPROV)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2COUNTY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2ZONE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2REGNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2REGNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2IRSNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2IRSNOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2ECVATNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FTZTXTYPEA)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.FTZTXTYPEL)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.DECLNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.DECLPLACE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.LASTFREETIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRBEFUNCTION)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRSITECODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNBEFUNCTION)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNSITECODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYBEFUNCTION)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYSITECODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ALLOCATESTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2BEFUNCTION)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2SITECODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CUSTCATE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRCATE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGNCATE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSGN2CATE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.RMBRTARIFFNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.RMBRAGREEMENTNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.RMBRAMENDNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.RMSRTARIFFNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.RMSRAMENDNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.DECLSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.DAMAGEDREASON)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.MISSINGREASON)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.MASTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.MAPROCESSSTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PURPINSURANCEVAL)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PREMIUMPERC)
                .HasPrecision(5, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PREMIUMCURR)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.PREMIUMAMT)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ADMINFEECURR)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ADMINFEEAMT)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TOTINSURANCEAMT)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.TOTINSURANCECURR)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSURANCESTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SCREENMETHOD)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSPECTBY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRKNOWNTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SHPRREGISTRATIONNO)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.SCREENMETHODTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.MIXALLOCATEDREV)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.MIXALLOCATEDCOST)
                .HasPrecision(14, 2);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSCURRCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSFROMCTRY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSFROMPLACE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSTOCTRY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSTOPLACE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.ONBOARDTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYCITYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYCTRYCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYPOSTALCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYSTATEPROV)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.NTFYZONE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.DECLTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.INSPECTTIME)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.COMMODITY)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CSRCODE)
                .IsUnicode(false);

            modelBuilder.Entity<JOBOTHER>()
                .Property(e => e.CARGOREADYTIME)
                .IsUnicode(false);
        }

        private void LoadCurrentSchema(DbModelBuilder modelBuilder)
        {
            var schema = this.GetCurrentSchema();

            modelBuilder.HasDefaultSchema(schema);
        }

        private  string GetCurrentSchema()
        {
            var connstr = System.Configuration.ConfigurationManager.ConnectionStrings["KEntities"].ToString();
            var conlist = connstr.Split(';');
            var userNameParir = conlist.Where(t => t.Contains("USER")).FirstOrDefault();
            var schema = userNameParir.Substring(8);
            return schema;
        }
    }
}
