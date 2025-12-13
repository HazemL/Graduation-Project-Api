using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class User : BaseModel
    {
        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string FullName { get; set; }

        public string Phone { get; set; }

        public string ProfileImage { get; set; }

        public UserRole Role { get; set; }

        public bool IsActive { get; set; }
    }
}
