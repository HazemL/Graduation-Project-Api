using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Payment : BaseModel
    {
        public int SubscriptionId { get; set; }

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public string ProviderReference { get; set; }

        public PaymentStatus Status { get; set; }
    }
}
