using Microsoft.AspNetCore.Identity;

namespace NLayeredApp.DataAccess.Identity;

public class ApplicationUserRole : IdentityUserRole<int>
{
    public virtual ApplicationUser User { get; set; } = null!;
    public virtual ApplicationRole Role { get; set; } = null!;
    public DateTimeOffset AssignedAt { get; set; }
    public string? AssignedBy { get; set; }
}