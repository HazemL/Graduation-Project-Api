using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedSkills(ModelBuilder modelBuilder)
        {
            var skills = new List<SkillEntity>();
            var names = new[]
            {
                "Wiring","Circuit Diagnosis","Panel Installation","Lighting","Power Outlets","Pipe Fixing","Drain Unclog",
                "Faucet Repair","Soldering","Wood Cutting","Cabinet Making","Door Repair","Interior Painting","Exterior Painting",
                "AC Repair","AC Gas Recharge","Tile Laying","Grouting","Roof Leak Repair","Shutter Installation","Lock Installation",
                "Lock Repair","Car Engine Repair","Brake Repair","Battery Replacement","Welding Mild Steel","Welding Stainless",
                "Garden Pruning","Lawn Mowing","Pressure Washing","Deep Cleaning","Wallpaper Installation","Decorative Plaster",
                "Pest Termite","Pest Rodent","Glass Cutting","Mirror Fitting","Polish Floors","Marble Polishing","Ceramic Fixing",
                "HVAC Ductwork","Fridge Repair","Washing Machine Repair","Oven Repair","Microwave Repair","Satellite Installation",
                "Home Theater Setup","Smart Home Install","Fence Repair","Gutter Cleaning","Pool Maintenance","Solar Panel Install",
                "Battery Storage","Insulation Install","Security Camera Install","Access Control","Door Frame Repair","Skirting Fix",
                "Bathroom Renovation","Kitchen Renovation","Countertop Install","Tile Cutting","Plumbing Inspection","Septic Repair",
                "Sealing & Caulking","Concrete Repair","Foundation Patch","Bricklaying","Masonry Repair","Window Repair","Curtain Rod",
                "Upholstery Repair","Sofa Cleaning","Mattress Cleaning","Chimney Sweep","Fireplace Repair","Smoke Alarm Install"
            };

            int id = 1;
            foreach (var n in names)
            {
                skills.Add(new SkillEntity { Id = id++, Name = n, ArabicName = n });
            }

            modelBuilder.Entity<SkillEntity>().HasData(skills.ToArray());
        }
    }
}
