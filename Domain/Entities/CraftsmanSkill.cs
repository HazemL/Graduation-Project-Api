using Domain.Common;

namespace Domain.Entities
{
    public class CraftsmanSkill : BaseModel
    {
        public int CraftsmanId { get; set; }
        public int SkillId { get; set; }

        public string? ProficiencyLevel { get; set; }
    }
}
