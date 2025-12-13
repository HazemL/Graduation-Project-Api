namespace Domain.Common
{
    public abstract class BaseModel
    {
        public int Id { get; set; }

        // Soft Delete
        public bool IsDeleted { get; set; } = false;

        // Audit Fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
