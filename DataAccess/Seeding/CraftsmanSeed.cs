using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedCraftsmen(ModelBuilder modelBuilder)
        {
            var list = new List<CraftsmanEntity>();
            int id = 1;
            // map some users to craftsmen
            var randomProf = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int userId = 2; userId <= 31; userId++)
            {
                list.Add(new CraftsmanEntity
                {
                    Id = id++,
                    UserId = userId,
                    ProfessionId = randomProf[(userId - 2) % randomProf.Length],
                    Bio = $" Skilled professional #{userId}",
                    ExperienceYears = 2 + ((userId - 2) % 15),
                    MinPrice = 100 + ((userId - 2) * 10) % 400,
                    MaxPrice = 200 + ((userId - 2) * 20) % 800,
                    IsVerified = ((userId % 3) == 0)
                });
            }

            modelBuilder.Entity<CraftsmanEntity>().HasData(list.ToArray());
        }
    }
}
