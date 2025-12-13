using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedReports(ModelBuilder modelBuilder)
        {
            var list = new List<ReportEntity>();
            int id = 1;
            for (int i = 0; i < 40; i++)
            {
                list.Add(new ReportEntity
                {
                    Id = id++,
                    CraftsmanId = (i % 30) + 1,
                    ReporterUserId = ((i + 3) % 50) + 1,
                    Message = $"Report reason #{i + 1}",
                    Status = (i % 3 == 0) ? "Pending" : "Resolved"
                });
            }

            modelBuilder.Entity<ReportEntity>().HasData(list.ToArray());
        }
    }
}
