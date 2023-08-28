using Core.Enums;

namespace Core.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; } = DateTime.UtcNow;
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}