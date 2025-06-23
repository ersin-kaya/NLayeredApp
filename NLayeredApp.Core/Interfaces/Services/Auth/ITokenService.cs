using NLayeredApp.Core.DTOs.Auth.Responses;
using NLayeredApp.Core.Entities.Identity;

namespace NLayeredApp.Core.Interfaces.Services.Auth;

public interface ITokenService
{
    Task<RefreshTokenResponse> GenerateTokenAsync(IApplicationUser user);
    string? ValidateToken(string token);
    Task<RefreshToken> GenerateRefreshTokenAsync(int userId);
    Task<bool> ValidateRefreshTokenAsync(string refreshToken);
    Task<RefreshTokenResponse> RefreshTokenAsync(string refreshToken);
    Task<bool> RevokeTokenAsync(string refreshToken);
    Task<bool> RevokeAllUserTokensAsync(int userId);
}