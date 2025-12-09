using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Craftsman :BaseModel
    {
       

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public virtual User? User { get; set; }

        [ForeignKey("Professions")]
        public int ProfessionId { get; set; }
        public virtual  Profession? Profession { get; set; }

        public string Bio { get; set; }
        public int ExperienceYears { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal MinPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal MaxPrice { get; set; }

        public bool IsVerified { get; set; }
        public DateTime? VerificationDate { get; set; }
  

        // Relationships
        public  virtual ICollection<CraftsmanCity>? WorkedCities { get; set; }
        public  virtual ICollection<CraftsmanSkill>? Skills { get; set; }
        public  virtual ICollection<Gallery>? GalleryImages { get; set; }
        public  virtual ICollection<Review>? Reviews { get; set; }
        public  virtual ICollection<CraftsmanSubscription>? Subscriptions { get; set; }
    }
}
