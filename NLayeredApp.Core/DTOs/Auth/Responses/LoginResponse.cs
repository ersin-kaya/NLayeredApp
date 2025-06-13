using NLayeredApp.Core.DTOs.Identity;

namespace NLayeredApp.Core.DTOs.Auth.Responses;

public class LoginResponse
{
    public bool IsSuccess { get; set; }
    public string? Token { get; set; }
    public string? RefreshToken { get; set; }
    public DateTimeOffset? ExpiresAt { get; set; }
    public UserDto? User { get; set; }
    public List<string> Errors { get; set; } = new();
}