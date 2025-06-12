using NLayeredApp.Core.Common;

namespace NLayeredApp.Core.Entities.Identity;

public interface IApplicationUser : IEntity, IAuditable, IActivatable, ISoftDeletable
{
    string UserName { get; set; }
    string Email { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    bool EmailConfirmed { get; set; }
}