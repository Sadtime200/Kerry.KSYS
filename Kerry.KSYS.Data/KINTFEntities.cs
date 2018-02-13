namespace Kerry.KSYS.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KINTFEntities : DbContext
    {
        public KINTFEntities()
            : base("name=KINTFEntities")
        {
        }

        public virtual DbSet<ACTION_JOB> ACTION_JOB { get; set; }
        public virtual DbSet<SUPPLYMENT_JOB_LINK_HISTORY> SUPPLYMENT_JOB_LINK_HISTORY { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACTION_JOB>()
                .Property(e => e.UNID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTION_JOB>()
                .Property(e => e.SHPNO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTION_JOB>()
                .Property(e => e.CONSOLNO)
                .IsUnicode(false);

            modelBuilder.Entity<ACTION_JOB>()
                .Property(e => e.BIZTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTION_JOB>()
                .Property(e => e.SHPTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<ACTION_JOB>()
                .Property(e => e.OWNERID)
                .IsUnicode(false);

            modelBuilder.Entity<ACTION_JOB>()
                .Property(e => e.ACTION)
                .IsUnicode(false);

            modelBuilder.Entity<ACTION_JOB>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<ACTION_JOB>()
                .Property(e => e.CREATEBY)
                .IsUnicode(false);

            modelBuilder.Entity<ACTION_JOB>()
                .Property(e => e.UPDATEBY)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLYMENT_JOB_LINK_HISTORY>()
                .Property(e => e.UNID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SUPPLYMENT_JOB_LINK_HISTORY>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

        }
    }
}
