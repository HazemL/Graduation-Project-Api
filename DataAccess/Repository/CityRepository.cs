using DataAccess.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    public class CraftsmanEntity : BaseModelEntity
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual UserEntity? User { get; set; }

        [ForeignKey("Profession")]
        public int ProfessionId { get; set; }
        public virtual ProfessionEntity? Profession { get; set; }

        public string Bio { get; set; }
        public int ExperienceYears { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal MinPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal MaxPrice { get; set; }

        public bool IsVerified { get; set; }
        public DateTime? VerificationDate { get; set; }

        // Navigation
        public virtual ICollection<CraftsmanCityEntity>? WorkedCities { get; set; }
        public virtual ICollection<CraftsmanSkillEntity>? Skills { get; set; }
        public virtual ICollection<GalleryEntity>? GalleryImages { get; set; }
        public virtual ICollection<ReviewEntity>? Reviews { get; set; }
        public virtual ICollection<CraftsmanSubscriptionEntity>? Subscriptions { get; set; }
    }
}
