using NLayeredApp.Core.DTOs.Auth.Requests;
using NLayeredApp.Core.DTOs.Auth.Responses;

namespace NLayeredApp.Core.Interfaces.Services.Auth;

public interface IAuthService
{
    Task<LoginResponse> LoginAsync(LoginRequest request);
    Task<RegisterResponse> RegisterAsync(RegisterRequest request);
    Task LogoutAsync();
    Task<RefreshTokenResponse> RefreshTokenAsync(string refreshToken);
    Task<bool> RevokeTokenAsync(string refreshToken);
    Task<bool> ConfirmEmailAsync(ConfirmEmailRequest request);
    Task<bool> ForgotPasswordAsync(ForgotPasswordRequest request);
    Task<bool> ResetPasswordAsync(ResetPasswordRequest request);
}