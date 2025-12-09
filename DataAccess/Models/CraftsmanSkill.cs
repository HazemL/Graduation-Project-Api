using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    
    public class CraftsmanSkill: BaseModel
    {
        

        [ForeignKey("Craftsmens")]
        public int CraftsmanId { get; set; }
        public virtual Craftsman? Craftsman { get; set; }

        [ForeignKey("Skills")]
        public int SkillId { get; set; }
        public virtual Skill? Skill { get; set; }

        public string? ProficiencyLevel { get; set; } // Beginner, Expert, etc.
    }
}
