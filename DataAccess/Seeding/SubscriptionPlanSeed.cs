using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedSubscriptionPlans(ModelBuilder modelBuilder)
        {
            var plans = new List<SubscriptionPlanEntity>
            {
                new SubscriptionPlanEntity { Id = 1, Name = "Free", ArabicName = "مجاني", Price = 0, DurationDays = 0, Features = "Free listing (limited)", IsActive = true },
                new SubscriptionPlanEntity { Id = 2, Name = "Basic", ArabicName = "أساسي", Price = 50, DurationDays = 30, Features = "Standard listing + contact", IsActive = true },
                new SubscriptionPlanEntity { Id = 3, Name = "Premium", ArabicName = "مميز", Price = 200, DurationDays = 30, Features = "Featured listing + top search", IsActive = true }
            };

            modelBuilder.Entity<SubscriptionPlanEntity>().HasData(plans.ToArray());
        }
    }
}
