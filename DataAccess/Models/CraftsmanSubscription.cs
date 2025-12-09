using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class CraftsmanSubscription : BaseModel
    {
        

        [ForeignKey("Craftsmens")]
        public int CraftsmanId { get; set; }
        public virtual Craftsman? Craftsman { get; set; }

        [ForeignKey("SubscriptionPlans")]
        public int PlanId { get; set; }
        public virtual SubscriptionPlan? Plan { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public string Status { get; set; }


        public virtual ICollection<Payment>? Payments { get; set; }
    }
}
