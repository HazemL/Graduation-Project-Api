using Microsoft.EntityFrameworkCore;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedGovernorates(modelBuilder);
            SeedCities(modelBuilder);
            SeedProfessions(modelBuilder);
            SeedSkills(modelBuilder);
            SeedSubscriptionPlans(modelBuilder);
            SeedUsers(modelBuilder);
            SeedCraftsmen(modelBuilder);
            SeedCraftsmanCities(modelBuilder);
            SeedCraftsmanSkills(modelBuilder);
            SeedCraftsmanSubscriptions(modelBuilder);
            SeedPayments(modelBuilder);
            SeedGalleries(modelBuilder);
            SeedReviews(modelBuilder);
            SeedReports(modelBuilder);
        }
    }
}
