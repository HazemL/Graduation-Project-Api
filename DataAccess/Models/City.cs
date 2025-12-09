using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class City :BaseModel
    {
       
       
        [ForeignKey("Governorates")]
        public int GovernorateId { get; set; }
        public  Governorate? Governorate { get; set; }

        public string Name { get; set; }
        public string ArabicName { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        // Navigation
        public virtual ICollection<CraftsmanCity>? CraftsmanCities { get; set; }
    }
}
