using Domain.Common;

namespace Domain.Entities
{
    public class CraftsmanSubscription : BaseModel
    {
        public int CraftsmanId { get; set; }
        public int PlanId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }

        public SubscriptionStatus Status { get; set; }
    }
}
