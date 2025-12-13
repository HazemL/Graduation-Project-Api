using Domain.Common;

namespace Domain.Entities
{
    public class CraftsmanCity : BaseModel
    {
        public int CraftsmanId { get; set; }
        public int CityId { get; set; }

        // هل هذه المدينة هي الأساسية للعامل؟
        public bool IsPrimary { get; set; }
    }
}
