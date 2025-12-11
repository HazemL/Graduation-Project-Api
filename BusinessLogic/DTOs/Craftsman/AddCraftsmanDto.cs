using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs.Craftsman
{
    internal class AddCraftsmanDto
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string FullName { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public int GovernorateId { get; set; }

        [Required]
        public int ProfessionId { get; set; }

        [Range(0, 50)]
        public int YearsOfExperience { get; set; }

        public List<int> SkillIds { get; set; }
    }
}
