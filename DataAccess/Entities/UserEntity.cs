using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities;

public class UserEntity :BaseModelEntity
{
   

    [Required, EmailAddress]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    public string FullName { get; set; }
    public string Phone { get; set; }
    public string ProfileImage { get; set; }
    public string Role { get; set; } // "Admin", "Customer", "Craftsman"
    public bool IsActive { get; set; }
   

    
    public virtual ICollection<CraftsmanEntity>? CraftsmenProfiles { get; set; }

    public virtual ICollection<ReviewEntity>? ReviewsWritten { get; set; }
    public virtual ICollection<ReportEntity>? ReportsFiled { get; set; }
}
