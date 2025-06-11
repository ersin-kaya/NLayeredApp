namespace NLayeredApp.Core.Common
{
    public abstract class AuditableEntity : BaseEntity, IAuditable
    {
        public DateTimeOffset CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTimeOffset? LastModifiedAt { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
