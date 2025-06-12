using NLayeredApp.Core.Common;

namespace NLayeredApp.Core.Entities.Identity;

public class RefreshToken : AuditableEntity
{
    public string Token { get; set; } = string.Empty;
    public int UserId { get; set; }
    public DateTimeOffset ExpiresAt { get; set; }
    public bool IsRevoked { get; set; }
    public DateTimeOffset? RevokedAt { get; set; }
}