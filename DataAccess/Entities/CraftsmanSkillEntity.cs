using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

public class CraftsmanSkillEntity : BaseModelEntity
{
    [ForeignKey("Craftsman")]
    public int CraftsmanId { get; set; }
    public virtual CraftsmanEntity? Craftsman { get; set; }

    [ForeignKey("Skill")]
    public int SkillId { get; set; }
    public virtual SkillEntity? Skill { get; set; }

    public string? ProficiencyLevel { get; set; } // Beginner, Expert, etc.
}
