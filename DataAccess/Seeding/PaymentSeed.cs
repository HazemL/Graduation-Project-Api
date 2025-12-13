using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedPayments(ModelBuilder modelBuilder)
        {
            var lst = new List<PaymentEntity>();
            int id = 1;
            // create payments for subscriptions 1..20
            for (int sub = 1; sub <= 20; sub++)
            {
                lst.Add(new PaymentEntity
                {
                    Id = id++,
                    SubscriptionId = sub,
                    Amount = (sub % 2 == 0) ? 120 : 200,
                    Currency = "EGP",
                    PaymentMethod = (sub % 2 == 0) ? "VodafoneCash" : "CreditCard",
                    ProviderReference = $"TXN{sub:00000}",
                    Status = "Paid"
                });
            }

            modelBuilder.Entity<PaymentEntity>().HasData(lst.ToArray());
        }
    }
}
