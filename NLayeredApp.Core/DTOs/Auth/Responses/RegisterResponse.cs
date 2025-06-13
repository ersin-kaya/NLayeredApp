using NLayeredApp.Core.DTOs.Identity;

namespace NLayeredApp.Core.DTOs.Auth.Responses;

public class RegisterResponse
{
    public bool IsSuccess { get; set; }
    public UserDto? User { get; set; }
    public List<string> Errors { get; set; } = new();
}