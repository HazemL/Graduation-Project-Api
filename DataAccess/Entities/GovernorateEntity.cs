namespace DataAccess.Entities;

public class GovernorateEntity : BaseModelEntity
{
    public string Name { get; set; }
    public string ArabicName { get; set; }

    // Navigation
    public virtual ICollection<CityEntity>? Cities { get; set; }
}
