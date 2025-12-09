using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Profession: BaseModel
    {
       
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Craftsman>? Craftsmen { get; set; }
    }
}
