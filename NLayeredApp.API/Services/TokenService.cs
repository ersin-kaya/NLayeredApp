using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NLayeredApp.Core.Constants;
using NLayeredApp.Core.DTOs.Auth.Responses;
using NLayeredApp.Core.Entities.Identity;
using NLayeredApp.Core.Interfaces.Services.Auth;
using NLayeredApp.Core.Interfaces.UnitOfWork;
using NLayeredApp.Core.Settings;
using NLayeredApp.DataAccess.Identity;
using RefreshToken = NLayeredApp.Core.Entities.Identity.RefreshToken;

namespace NLayeredApp.API.Services;

public class TokenService : ITokenService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly JwtSettings _jwtSettings;

    public TokenService(
        IUnitOfWork unitOfWork,
        UserManager<ApplicationUser> userManager,
        IOptions<JwtSettings> jwtSettings)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
        _jwtSettings = jwtSettings.Value;
    }
    
    public async Task<RefreshTokenResponse> GenerateTokenAsync(IApplicationUser user)
    {
        var applicationUser = await _userManager.FindByIdAsync(user.Id.ToString());
        if (applicationUser == null)
            throw new ArgumentException(Messages.User.Error.InvalidUser);
        
        var roles = await _userManager.GetRolesAsync(applicationUser);
        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new(ClaimTypes.Name, user.UserName),
            new(ClaimTypes.Email, user.Email),
            new("FirstName", user.FirstName),
            new("LastName", user.LastName)
        };
        claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expires = DateTimeOffset.UtcNow.AddMinutes(Convert.ToDouble(_jwtSettings.DurationInMinutes)).UtcDateTime;

        var token = new JwtSecurityToken(
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            claims: claims,
            expires: expires,
            signingCredentials: creds
        );

        var refreshToken = await GenerateRefreshTokenAsync(user.Id);

        return new RefreshTokenResponse
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            RefreshToken = refreshToken.Token,
            ExpiresAt = expires
        };
    }

    public string? ValidateToken(string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_jwtSettings.Key);

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = true,
                ValidIssuer = _jwtSettings.Issuer,
                ValidateAudience = true,
                ValidAudience = _jwtSettings.Audience,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };
            
            var principal = tokenHandler.ValidateToken(token, validationParameters, out _);
            return principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
        catch
        {
            return null;
        }
    }

    public async Task<RefreshToken> GenerateRefreshTokenAsync(int userId)
    {
        // Revoke existing tokens
        await _unitOfWork.RefreshTokens.RevokeAllUserTokensAsync(userId);

        var refreshToken = new RefreshToken
        {
            Token = GenerateRefreshTokenString(),
            UserId = userId,
            CreatedAt = DateTimeOffset.UtcNow,
            ExpiresAt = DateTimeOffset.UtcNow.AddDays(7),
            IsRevoked = false
        };
        
        await _unitOfWork.RefreshTokens.AddAsync(refreshToken);
        await _unitOfWork.SaveChangesAsync();
        
        return refreshToken;
    }

    public Task<bool> ValidateRefreshTokenAsync(string refreshToken)
    {
        throw new NotImplementedException();
    }

    public Task<RefreshTokenResponse> RefreshTokenAsync(string refreshToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RevokeTokenAsync(string refreshToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RevokeAllUserTokensAsync(int userId)
    {
        throw new NotImplementedException();
    }

    private string GenerateRefreshTokenString()
    {
        var randomNumber = new byte[64];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }
}