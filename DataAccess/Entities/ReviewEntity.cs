
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

public class ReviewEntity : BaseModelEntity
{
    [ForeignKey("Reviewer")]
    public int? UserId { get; set; }
    public virtual UserEntity? Reviewer { get; set; }

    [ForeignKey("Craftsman")]
    public int CraftsmanId { get; set; }
    public virtual CraftsmanEntity? Craftsman { get; set; }

    public int Stars { get; set; }
    public string Comment { get; set; }

    public bool IsVerified { get; set; }
}
