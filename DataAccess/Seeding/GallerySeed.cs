using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedGalleries(ModelBuilder modelBuilder)
        {
            var list = new List<GalleryEntity>();
            int id = 1;
            for (int c = 1; c <= 30; c++)
            {
                list.Add(new GalleryEntity
                {
                    Id = id++,
                    CraftsmanId = c,
                    MediaUrl = $"/uploads/gallery/c{c}_1.jpg",
                    MediaType = "Image",
                    Title = $"Work sample {c}",
                    Description = $"Sample gallery image for craftsman {c}"
                });
            }

            modelBuilder.Entity<GalleryEntity>().HasData(list.ToArray());
        }
    }
}
