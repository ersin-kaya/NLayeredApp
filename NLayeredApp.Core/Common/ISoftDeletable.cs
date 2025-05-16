namespace NLayeredApp.Core.Common
{
    public interface ISoftDeletable
    {
        DateTimeOffset? DeletedAt { get; set; }
        string? DeletedBy { get; set; }
        bool IsDeleted { get; set; }
    }
}
