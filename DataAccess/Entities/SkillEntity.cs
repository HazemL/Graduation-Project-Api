namespace DataAccess.Entities;

public class SkillEntity : BaseModelEntity
{
    public string Name { get; set; }
    public string ArabicName { get; set; }

    // Navigation
    public virtual ICollection<CraftsmanSkillEntity>? CraftsmanSkills { get; set; }
}
