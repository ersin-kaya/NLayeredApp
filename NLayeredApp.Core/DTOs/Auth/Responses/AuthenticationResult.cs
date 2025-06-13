namespace NLayeredApp.Core.DTOs.Auth.Responses;

public class AuthenticationResult
{
    public bool Succeeded { get; set; }
    public string? Token { get; set; }
    public int? UserId { get; set; }
    public List<string> Errors { get; set; } = new();
}