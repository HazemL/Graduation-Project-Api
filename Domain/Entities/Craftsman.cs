using Domain.Common;

namespace Domain.Entities
{
    public class Craftsman : BaseModel
    {
        public int UserId { get; set; }
        public int ProfessionId { get; set; }

        public string Bio { get; set; }
        public int ExperienceYears { get; set; }

        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }

        public bool IsVerified { get; set; }
        public DateTime? VerificationDate { get; set; }
    }
}
