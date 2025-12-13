using DataAccess.Entities;

using DataAccess.Seeding;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        // DbSets
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<CraftsmanEntity> Craftsmen { get; set; }
        public DbSet<CraftsmanCityEntity> CraftsmanCities { get; set; }
        public DbSet<CraftsmanSkillEntity> CraftsmanSkills { get; set; }
        public DbSet<CraftsmanSubscriptionEntity> CraftsmanSubscriptions { get; set; }
        public DbSet<GalleryEntity> Galleries { get; set; }
        public DbSet<GovernorateEntity> Governorates { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }
        public DbSet<ProfessionEntity> Professions { get; set; }
        public DbSet<ReportEntity> Reports { get; set; }
        public DbSet<ReviewEntity> Reviews { get; set; }
        public DbSet<SkillEntity> Skills { get; set; }
        public DbSet<SubscriptionPlanEntity> SubscriptionPlans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply all Fluent API configurations automatically
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Add Seeding
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
