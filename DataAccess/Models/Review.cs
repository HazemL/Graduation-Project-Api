using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Review : BaseModel
    {
       

        [ForeignKey("Users")]
        public int? UserId { get; set; } 
        public virtual User? Reviewer { get; set; }

        [ForeignKey("Craftsmens")]
        public int CraftsmanId { get; set; } 
        public virtual Craftsman? Craftsman { get; set; }

        public int Stars { get; set; }
        public string Comment { get; set; }
        public bool IsVerified { get; set; } 
       
    }
}
