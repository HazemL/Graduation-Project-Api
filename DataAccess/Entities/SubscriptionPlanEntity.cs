using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

public class SubscriptionPlanEntity : BaseModelEntity
{
    public string Name { get; set; }
    public string ArabicName { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    public int DurationDays { get; set; }
    public string Features { get; set; }
    public bool IsActive { get; set; }

    // Navigation
    public virtual ICollection<CraftsmanSubscriptionEntity>? Subscriptions { get; set; }
}
