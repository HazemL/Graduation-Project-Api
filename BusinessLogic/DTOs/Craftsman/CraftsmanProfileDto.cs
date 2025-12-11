public class CraftsmanProfileDto
{
    public int Id { get; set; }

    // User Info
    public string FullName { get; set; }
    public string ProfileImage { get; set; }
    public string Phone { get; set; }

    // Basic Info
    public string Bio { get; set; }
    public string Profession { get; set; }
    public int ExperienceYears { get; set; }

    // Pricing
    public decimal MinPrice { get; set; }
    public decimal MaxPrice { get; set; }

    // Verification
    public bool IsVerified { get; set; }
    public DateTime? VerificationDate { get; set; }

    // Location
    public string City { get; set; }

    // Skills
    public List<string> Skills { get; set; }

    // Photos
    public List<string> Photos { get; set; }

    // Reviews
    public double AverageRating { get; set; }
    public List<ReviewDto> Reviews { get; set; }
}

public class ReviewDto
{
    public string Username { get; set; }
    public int Stars { get; set; }
    public string Comment { get; set; }
}
