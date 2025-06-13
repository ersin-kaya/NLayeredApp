namespace NLayeredApp.Core.Interfaces.Services.Auth;

public interface ICurrentUserService
{
    int? UserId { get; }
    string? Username { get; }
    string? Email { get; }
    bool IsAuthenticated { get; }
    IEnumerable<string> Roles { get; }
    bool IsInRole(string role);
}