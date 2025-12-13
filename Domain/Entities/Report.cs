using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Report : BaseModel
    {
        public int ReporterUserId { get; set; }
        public int CraftsmanId { get; set; }

        public string Message { get; set; }

        public ReportStatus Status { get; set; }
    }
}

