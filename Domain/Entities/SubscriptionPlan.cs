using Domain.Common;

namespace Domain.Entities
{
    public class SubscriptionPlan : BaseModel
    {
        public string Name { get; set; }
        public string ArabicName { get; set; }

        public decimal Price { get; set; }

        public int DurationDays { get; set; }

        public string Features { get; set; }

        public bool IsActive { get; set; }
    }
}

