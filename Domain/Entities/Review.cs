using Domain.Common;

namespace Domain.Entities
{
    public class Review : BaseModel
    {
        public int UserId { get; set; }

        public int CraftsmanId { get; set; }

        public int Stars { get; set; }

        public string Comment { get; set; }

        public bool IsVerified { get; set; }
    }
}
