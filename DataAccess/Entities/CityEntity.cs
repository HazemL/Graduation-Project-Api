using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

public class CityEntity : BaseModelEntity
{
    [ForeignKey("Governorate")]
    public int GovernorateId { get; set; }

    public virtual GovernorateEntity? Governorate { get; set; }

    public string Name { get; set; }
    public string ArabicName { get; set; }

    [Column(TypeName = "decimal(18,6)")]
    public decimal Latitude { get; set; }

    [Column(TypeName = "decimal(18,6)")]
    public decimal Longitude { get; set; }

    // Navigation
    public virtual ICollection<CraftsmanCityEntity>? CraftsmanCities { get; set; }
}
