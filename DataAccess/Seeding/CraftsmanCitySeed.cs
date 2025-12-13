using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedCraftsmanCities(ModelBuilder modelBuilder)
        {
            var list = new List<CraftsmanCityEntity>();
            int id = 1;
            // give each craftsman 1-3 cities (IDs small set from city seed)
            var craftCount = 30;
            var cityIds = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var rnd = new System.Random(42);
            for (int c = 1; c <= craftCount; c++)
            {
                int primary = cityIds[rnd.Next(cityIds.Length)];
                list.Add(new CraftsmanCityEntity { CraftsmanId = c, CityId = primary, IsPrimary = true });
                // add another city sometimes
                if (rnd.NextDouble() > 0.6)
                {
                    list.Add(new CraftsmanCityEntity {  CraftsmanId = c, CityId = cityIds[rnd.Next(cityIds.Length)], IsPrimary = false });
                }
            }

            modelBuilder.Entity<CraftsmanCityEntity>().HasData(list.ToArray());
        }
    }
}
