using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        {
        }
        public DbSet<Models.City> Citys { get; set; }
        public DbSet<Models.Craftsman> Craftsmens { get; set; }
        public DbSet<Models.CraftsmanCity> CraftsmansCity { get; set; }
        public DbSet<Models.CraftsmanSkill> CraftsmansSkills { get; set; }
        public DbSet<Models.CraftsmanSubscription> CraftsmansSubscriptions { get; set; }
        public DbSet<Models.Gallery> Gallerys { get; set; }
        public DbSet<Models.Governorate> Governorates { get; set; }
        public DbSet<Models.Payment> Payments { get; set; } 
        public DbSet<Models.Profession> Professions { get; set; }
        public DbSet<Models.Report> Reports { get; set; }
        public DbSet<Models.Review> Reviews { get; set; }
        public DbSet<Models.Skill> Skills { get; set; }
        public DbSet<Models.SubscriptionPlan> SubscriptionPlans { get; set; }
        public DbSet<Models.User> Users { get; set; }
      




    }
}
