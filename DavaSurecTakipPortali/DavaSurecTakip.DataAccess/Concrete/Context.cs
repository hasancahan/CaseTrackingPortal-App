using DavaSurecTakip.Entities.DbEntitiesModels;
using Microsoft.EntityFrameworkCore;

namespace DavaSurecTakip.DataAccess.Concrete
{
    public class Context : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Case>()
        .HasKey(nameof(Case.CaseId));

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=HasanCahan\\SQLEXPRESS; database=DavaSurecTakipPortalDB; integrated security=true;");
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Authority> authorities { get; set; }
        public DbSet<Case> cases  { get; set; }
        public DbSet<PaidDamages> paidDamages { get; set; }
        public DbSet<UserAuthorization> userAuthorizations { get; set; }
        public DbSet<LookupAttornerL> lookupAttornerL  { get; set; }
        public DbSet<LookupLevyInfoL> lookupLevyInfoL  { get; set; }
        public DbSet<LookupCaseSubjectL> lookupCaseSubjectL    { get; set; }
        public DbSet<LookupCaseResultL> lookupCaseResultL  { get; set; }
        public DbSet<LookupCourtInfoL> lookupCourtInfoL  { get; set; }
        public DbSet<LookupDamageTypeL> lookupDamageTypeL  { get; set; }
        public DbSet<LookupFileDamageStatusL> lookupFileDamageStatusL  { get; set; }
        public DbSet<LookupFileStageL> lookupFileStageL  { get; set; }
        public DbSet<LookupInsuranceExplanationL> lookupInsuranceExplanationL  { get; set; }
        public DbSet<LookupPaymentTypeL> lookupPaymentTypeL  { get; set; }
        public DbSet<LookupProvinceL> lookupProvinceL  { get; set; }
        public DbSet<LookupWorkAreaL> lookupWorkAreaL  { get; set; }


    }
}
