using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedProfessions(ModelBuilder modelBuilder)
        {
            var list = new List<ProfessionEntity>
            {
                new ProfessionEntity{ Id=1, Name="Electrician", ArabicName="فني كهرباء", Description="Electrical installation & repair" },
                new ProfessionEntity{ Id=2, Name="Plumber", ArabicName="سباك", Description="Plumbing & pipe repair" },
                new ProfessionEntity{ Id=3, Name="Carpenter", ArabicName="نجار", Description="Wood works & furniture" },
                new ProfessionEntity{ Id=4, Name="Painter", ArabicName="دهان", Description="Interior & exterior painting" },
                new ProfessionEntity{ Id=5, Name="AC Technician", ArabicName="فنى تكييف", Description="AC repair & maintenance" },
                new ProfessionEntity{ Id=6, Name="Tile Setter", ArabicName="عامل بلاط", Description="Tiles & flooring" },
                new ProfessionEntity{ Id=7, Name="Roofer", ArabicName="عامل سقوف", Description="Roofing and waterproofing" },
                new ProfessionEntity{ Id=8, Name="Locksmith", ArabicName="مفتاحجي", Description="Locks & keys services" },
                new ProfessionEntity{ Id=9, Name="Mechanic", ArabicName="ميكانيكي", Description="Vehicle repair" },
                new ProfessionEntity{ Id=10, Name="Welder", ArabicName="لحام", Description="Metal works & welding" },
                new ProfessionEntity{ Id=11, Name="Gardener", ArabicName="بستاني", Description="Gardening & landscaping" },
                new ProfessionEntity{ Id=12, Name="Cleaner", ArabicName="عامل نظافة", Description="Home & office cleaning" },
                new ProfessionEntity{ Id=13, Name="Decorator", ArabicName="ديكور", Description="Interior decoration" },
                new ProfessionEntity{ Id=14, Name="Pest Control", ArabicName="مكافحة حشرات", Description="Pest control services" },
                new ProfessionEntity{ Id=15, Name="Glass Installer", ArabicName="تركيب زجاج", Description="Glass & windows" },
                new ProfessionEntity{ Id=16, Name="Floor Polisher", ArabicName="تلميع أرضيات", Description="Floor polishing" },
                new ProfessionEntity{ Id=17, Name="Ceramic Specialist", ArabicName="تخصص سيراميك", Description="Ceramic work" },
                new ProfessionEntity{ Id=18, Name="HVAC Engineer", ArabicName="مهندس تكييف", Description="HVAC systems" },
                new ProfessionEntity{ Id=19, Name="Home Appliance Tech", ArabicName="فني أجهزة منزلية", Description="Appliance repair" },
                new ProfessionEntity{ Id=20, Name="Painter (Spray)", ArabicName="دهان سبراي", Description="Spray painting" }
            };

            modelBuilder.Entity<ProfessionEntity>().HasData(list.ToArray());
        }
    }
}
