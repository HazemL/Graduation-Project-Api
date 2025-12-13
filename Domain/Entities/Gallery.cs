using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Gallery : BaseModel
    {
        public int CraftsmanId { get; set; }

        public string MediaUrl { get; set; }

        public MediaType MediaType { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
