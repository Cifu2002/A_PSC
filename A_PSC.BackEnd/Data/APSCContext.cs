using A_PSC.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace A_PSC.BackEnd.Data
{
    public class APSCContext : IdentityDbContext<ApplicationUser>
    {
        public APSCContext(DbContextOptions<APSCContext> options) : base(options) { }

        public DbSet<Agreement> Agreements => Set<Agreement>();
        public DbSet<Annex> Annexes => Set<Annex>();
        public DbSet<BeneficiaryPopulation> BeneficiaryPopulations => Set<BeneficiaryPopulation>();
        public DbSet<Canton> Cantons => Set<Canton>();
        public DbSet<CooperatingEntity> CooperatingEntities => Set<CooperatingEntity>();
        public DbSet<CooperatingEntityContribution> CooperatingEntityContributions => Set<CooperatingEntityContribution>();
        public DbSet<Parish> Parishes => Set<Parish>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProjectActivity> ProjectActivities => Set<ProjectActivity>();
        //public DbSet<ProjectContribution> ProjectContributions => Set<ProjectContribution>();
        public DbSet<Province> Provinces => Set<Province>();
        public DbSet<RepresentativeBeneficiary> RepresentativeBeneficiaries => Set<RepresentativeBeneficiary>();
        public DbSet<SpecificObjective> SpecificObjectives => Set<SpecificObjective>();

        // Configuraciones adicionales
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
