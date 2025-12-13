using Domain.Common;

namespace Domain.Entities
{
    public class Profession : BaseModel
    {
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public string Description { get; set; }
    }
}

