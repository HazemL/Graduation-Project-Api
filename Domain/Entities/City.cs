using Domain.Common;

namespace Domain.Entities
{
    public class City : BaseModel
    {
        public int GovernorateId { get; set; }

        public string Name { get; set; }
        public string ArabicName { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
