using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedGovernorates(ModelBuilder modelBuilder)
        {
            var data = new List<GovernorateEntity>
            {
                new GovernorateEntity { Id = 1, Name = "Cairo", ArabicName = "القاهرة" },
                new GovernorateEntity { Id = 2, Name = "Giza", ArabicName = "الجيزة" },
                new GovernorateEntity { Id = 3, Name = "Alexandria", ArabicName = "الإسكندرية" },
                new GovernorateEntity { Id = 4, Name = "Suez", ArabicName = "السويس" },
                new GovernorateEntity { Id = 5, Name = "Port Said", ArabicName = "بورسعيد" },
                new GovernorateEntity { Id = 6, Name = "Damietta", ArabicName = "دمياط" },
                new GovernorateEntity { Id = 7, Name = "Daqahlia", ArabicName = "الدقهلية" },
                new GovernorateEntity { Id = 8, Name = "Sharqia", ArabicName = "الشرقية" },
                new GovernorateEntity { Id = 9, Name = "Gharbia", ArabicName = "الغربية" },
                new GovernorateEntity { Id = 10, Name = "Kafr El Sheikh", ArabicName = "كفر الشيخ" },
                new GovernorateEntity { Id = 11, Name = "Beheira", ArabicName = "البحيرة" },
                new GovernorateEntity { Id = 12, Name = "Fayoum", ArabicName = "الفيوم" },
                new GovernorateEntity { Id = 13, Name = "Beni Suef", ArabicName = "بني سويف" },
                new GovernorateEntity { Id = 14, Name = "Minya", ArabicName = "المنيا" },
                new GovernorateEntity { Id = 15, Name = "Asyut", ArabicName = "أسيوط" },
                new GovernorateEntity { Id = 16, Name = "Sohag", ArabicName = "سوهاج" },
                new GovernorateEntity { Id = 17, Name = "Qena", ArabicName = "قنا" },
                new GovernorateEntity { Id = 18, Name = "Luxor", ArabicName = "الأقصر" },
                new GovernorateEntity { Id = 19, Name = "Aswan", ArabicName = "أسوان" },
                new GovernorateEntity { Id = 20, Name = "Red Sea", ArabicName = "البحر الأحمر" },
                new GovernorateEntity { Id = 21, Name = "New Valley", ArabicName = "الوادي الجديد" },
                new GovernorateEntity { Id = 22, Name = "Matrouh", ArabicName = "مطروح" },
                new GovernorateEntity { Id = 23, Name = "North Sinai", ArabicName = "شمال سيناء" },
                new GovernorateEntity { Id = 24, Name = "South Sinai", ArabicName = "جنوب سيناء" },
                new GovernorateEntity { Id = 25, Name = "Ismailia", ArabicName = "الإسماعيلية" },
                new GovernorateEntity { Id = 26, Name = "Kafr El Sheikh (alt)", ArabicName = "كفر الشيخ" },
                new GovernorateEntity { Id = 27, Name = "Luxor (alt)", ArabicName = "الأقصر" } 
            };

            modelBuilder.Entity<GovernorateEntity>().HasData(data.ToArray());
        }
    }
}
