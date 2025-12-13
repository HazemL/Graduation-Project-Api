using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

public class CraftsmanSubscriptionEntity : BaseModelEntity
{
    [ForeignKey("Craftsman")]
    public int CraftsmanId { get; set; }
    public virtual CraftsmanEntity? Craftsman { get; set; }

    [ForeignKey("SubscriptionPlan")]
    public int PlanId { get; set; }
    public virtual SubscriptionPlanEntity? Plan { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive { get; set; }
    public string Status { get; set; } // Pending, Active, Expired, Cancelled

    // Navigation
    public virtual ICollection<PaymentEntity>? Payments { get; set; }
}
