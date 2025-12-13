using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

public class PaymentEntity : BaseModelEntity
{
    [ForeignKey("Subscription")]
    public int SubscriptionId { get; set; }
    public virtual CraftsmanSubscriptionEntity? Subscription { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }

    public string Currency { get; set; }
    public string PaymentMethod { get; set; }
    public string ProviderReference { get; set; }  // Stripe ID, PayPal ID etc.
    public string Status { get; set; }             // Paid, Failed
}
