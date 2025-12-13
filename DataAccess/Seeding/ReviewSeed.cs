using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using System.Collections.Generic;
using System;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedReviews(ModelBuilder modelBuilder)
        {
            var list = new List<ReviewEntity>();
            int id = 1;
            var rnd = new Random(100);
            // generate ~120 reviews across craftsmen 1..30
            for (int i = 0; i < 120; i++)
            {
                int craftsmanId = (i % 30) + 1;
                int userId = (i % 50) + 1;
                list.Add(new ReviewEntity
                {
                    Id = id++,
                    CraftsmanId = craftsmanId,
                    UserId = userId,
                    Stars = rnd.Next(3, 6),
                    Comment = $"Review {i + 1} for craftsman {craftsmanId}",
                    IsVerified = (rnd.NextDouble() > 0.2)
                });
            }

            modelBuilder.Entity<ReviewEntity>().HasData(list.ToArray());
        }
    }
}
