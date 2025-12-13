using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedCraftsmanSkills(ModelBuilder modelBuilder)
        {
            var list = new List<CraftsmanSkillEntity>();
            int id = 1;
            var craftCount = 30;
            var skillCount = 40; // using first 40 skills from skill seed
            for (int c = 1; c <= craftCount; c++)
            {
                // each craftsman has 2-6 skills
                for (int s = 1; s <= 3; s++)
                {
                    list.Add(new CraftsmanSkillEntity { Id = id++, CraftsmanId = c, SkillId = ((c + s) % skillCount) + 1, ProficiencyLevel = (s % 2 == 0 ? "Expert" : "Good") });
                }
            }

            modelBuilder.Entity<CraftsmanSkillEntity>().HasData(list.ToArray());
        }
    }
}
