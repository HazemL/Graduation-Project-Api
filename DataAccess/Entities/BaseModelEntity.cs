namespace DataAccess.Entities
{
    public abstract class BaseModelEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
