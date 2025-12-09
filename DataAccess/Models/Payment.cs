using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Payment : BaseModel
    {
        

        [ForeignKey("CraftsmansSubscriptions")]
        public int SubscriptionId { get; set; }
        public virtual CraftsmanSubscription? Subscription { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public string Currency { get; set; }
        public string PaymentMethod { get; set; }
        public string ProviderReference { get; set; } // Stripe ID, PayPal ID etc.
        public string Status { get; set; } // Paid, Failed
  
    }
}
