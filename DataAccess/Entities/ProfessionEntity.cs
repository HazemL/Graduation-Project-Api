namespace DataAccess.Entities;

public class ProfessionEntity : BaseModelEntity
{
    public string Name { get; set; }
    public string ArabicName { get; set; }
    public string Description { get; set; }

    // Navigation
    public virtual ICollection<CraftsmanEntity>? Craftsmen { get; set; }
}
