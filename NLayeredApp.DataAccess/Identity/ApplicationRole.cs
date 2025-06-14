using Microsoft.AspNetCore.Identity;
using NLayeredApp.Core.Constants;
using NLayeredApp.Core.Entities.Identity;

namespace NLayeredApp.DataAccess.Identity;

public class ApplicationRole : IdentityRole<int>, IApplicationRole
{
    public string? Description { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModifiedAt { get; set; }
    public string? LastModifiedBy { get; set; }
    
    public bool IsActive { get; set; } = ApplicationConstants.Identity.Role.IsActiveDefault;
    
    public DateTimeOffset? DeletedAt { get; set; }
    public string? DeletedBy { get; set; }
    public bool IsDeleted { get; set; } = ApplicationConstants.Identity.Role.IsDeletedDefault;
    
    public virtual ICollection<ApplicationUserRole> UserRoles { get; set; } = new List<ApplicationUserRole>();
}