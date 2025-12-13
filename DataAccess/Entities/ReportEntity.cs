
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

public class ReportEntity : BaseModelEntity
{
    [ForeignKey("Reporter")]
    public int ReporterUserId { get; set; }
    public virtual UserEntity? Reporter { get; set; }

    [ForeignKey("Craftsman")]
    public int CraftsmanId { get; set; }
    public virtual CraftsmanEntity? Craftsman { get; set; }

    public string Message { get; set; }
    public string Status { get; set; }  // Pending, Resolved
}
