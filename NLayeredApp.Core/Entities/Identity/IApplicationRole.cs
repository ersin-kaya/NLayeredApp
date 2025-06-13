using NLayeredApp.Core.Common;

namespace NLayeredApp.Core.Entities.Identity;

public interface IApplicationRole  : IEntity, IAuditable, IActivatable, ISoftDeletable
{
    string Name { get; set; }
    string? Description { get; set; }
}