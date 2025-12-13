using DataAccess.Entities;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedUsers(ModelBuilder modelBuilder)
        {
            var names = new[]
            {
                "أحمد علي","محمد حسن","محمود إبراهيم","عبدالله محمود","عمر سامي","كريم صلاح","سارة محمد","نور مصطفى","هند أحمد","ليلى صلاح",
                "منى علي","إيهاب سعيد","مروة سمير","طارق حسن","علي فؤاد","يوسف أحمد","عائشة محمود","مريم علي","خالد محمد","إبراهيم حسن",
                "علياء عمر","نوران خالد","سعد محمود","راغب سمير","إيمان أيمن","ريم أحمد","هشام فتحي","سامي ياسر","أمل محمود","شهد علي",
                "إيناس سامي","مصطفى جمال","حسن يوسف","نبيل عبدالعزيز","شيماء إبراهيم","دنيا حسني","هالة سمير","رنا خالد","نوح أحمد","آدم علي",
                "ملاك حسن","زينة محمود","تامر إيهاب","ماهر صبري","جمال حسين","رامي خالد","بهاء الدين محمد","كرم أحمد","بلال سمير","سلوى علي"
            };

            var list = new List<UserEntity>();
            int id = 1;
            foreach (var full in names)
            {
                var role = (id == 1) ? "Admin" : (id <= 6 ? "Craftsman" : "Customer");
                list.Add(new UserEntity
                {
                    Id = id,
                    FullName = full,
                    Email = $"user{id}@example.com",
                    PasswordHash = "P@ssw0rd!", // replace with real hash
                    Phone = $"010{id:000000}",
                    Role = role,
                    IsActive = true
                });
                id++;
                if (id > 50) break;
            }

            modelBuilder.Entity<UserEntity>().HasData(list.ToArray());
        }
    }
}
