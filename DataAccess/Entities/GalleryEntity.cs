using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

public class GalleryEntity : BaseModelEntity
{
    [ForeignKey("Craftsman")]
    public int CraftsmanId { get; set; }
    public virtual CraftsmanEntity? Craftsman { get; set; }

    public string MediaUrl { get; set; }
    public string MediaType { get; set; } // Image, Video

    public string Title { get; set; }
    public string Description { get; set; }
}
