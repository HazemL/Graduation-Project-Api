using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using System.Collections.Generic;
using System;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedCraftsmanSubscriptions(ModelBuilder modelBuilder)
        {
            var subs = new List<CraftsmanSubscriptionEntity>();
            int id = 1;
            // Assign subscription plan 2 or 3 to craftsmen 1..20
            for (int c = 1; c <= 20; c++)
            {
                subs.Add(new CraftsmanSubscriptionEntity
                {
                    Id = id++,
                    CraftsmanId = c,
                    PlanId = (c % 2 == 0) ? 2 : 3,
                    StartDate = DateTime.UtcNow.AddDays(-(c * 3)),
                    EndDate = DateTime.UtcNow.AddDays(30),
                    IsActive = true,
                    Status = "Active"
                });
            }

            modelBuilder.Entity<CraftsmanSubscriptionEntity>().HasData(subs.ToArray());
        }
    }
}
