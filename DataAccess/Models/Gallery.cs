using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Gallery : BaseModel
    {
       

        [ForeignKey("Craftsmens")]
        public int CraftsmanId { get; set; }
        public virtual Craftsman? Craftsman { get; set; }

        public string MediaUrl { get; set; }
        public string MediaType { get; set; } // Image, Video
        public string Title { get; set; }
        public string Description { get; set; }
        
    }
}
