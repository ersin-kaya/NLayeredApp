using Microsoft.AspNetCore.Identity;
using NLayeredApp.Core.Constants;
using NLayeredApp.Core.Entities.Identity;

namespace NLayeredApp.DataAccess.Identity;

public class ApplicationUser : IdentityUser<int>, IApplicationUser
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public bool IsActive { get; set; } = ApplicationConstants.User.IsActiveDefault;
    
    public DateTimeOffset CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTimeOffset? LastModifiedAt { get; set; }
    public string? LastModifiedBy { get; set; }
    
    public DateTimeOffset? DeletedAt { get; set; }
    public string? DeletedBy { get; set; }
    public bool IsDeleted { get; set; } = ApplicationConstants.User.IsDeletedDefault;
}