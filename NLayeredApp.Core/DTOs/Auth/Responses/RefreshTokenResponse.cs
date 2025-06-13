namespace NLayeredApp.Core.DTOs.Auth.Responses;

public class RefreshTokenResponse
{
    public string Token { get; set; } = string.Empty;
    public string RefreshToken { get; set; } = string.Empty;
    public DateTimeOffset ExpiresAt { get; set; }
}