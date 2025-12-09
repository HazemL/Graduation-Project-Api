using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Report: BaseModel
    {
       

        [ForeignKey("Users")]
        public int ReporterUserId { get; set; }
        public virtual User? Reporter { get; set; }

        [ForeignKey("Craftsmens")]
        public int CraftsmanId { get; set; }
        public virtual Craftsman? ReportedCraftsman { get; set; }

        public string Message { get; set; }
        public string Status { get; set; } // Pending, Resolved
       
    }
}
