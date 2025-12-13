using Domain.Common;

namespace Domain.Entities
{
    public class Governorate : BaseModel
    {
        public string Name { get; set; }
        public string ArabicName { get; set; }
    }
}
