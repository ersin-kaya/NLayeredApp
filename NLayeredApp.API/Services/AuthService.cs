using Microsoft.AspNetCore.Identity;
using NLayeredApp.Core.DTOs.Auth.Requests;
using NLayeredApp.Core.DTOs.Auth.Responses;
using NLayeredApp.Core.DTOs.Identity;
using NLayeredApp.Core.Interfaces.Services.Auth;
using NLayeredApp.DataAccess.Identity;

namespace NLayeredApp.API.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly ITokenService _tokenService;
    
    public AuthService(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        ITokenService tokenService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _tokenService = tokenService;
    }
    
    public async Task<LoginResponse> LoginAsync(LoginRequest request)
    {
        var user = await _userManager.FindByNameAsync(request.UsernameOrEmail)
                   ?? await _userManager.FindByEmailAsync(request.UsernameOrEmail);

        if (user == null || user.IsDeleted)
        {
            return new LoginResponse()
            {
                IsSuccess = false,
                Errors = new List<string> { "Invalid username or password." }
            };
        }

        if (!user.IsActive)
        {
            return new LoginResponse
            {
                IsSuccess = false,
                Errors = new List<string> { "Account is not active." }
            };
        }

        var result = await _signInManager.PasswordSignInAsync(
            user, request.Password, request.RememberMe, lockoutOnFailure: true);

        if (!result.Succeeded)
        {
            var errors = new List<string>();
            if (result.IsLockedOut)
                errors.Add("Account is locked out.");
            else if (result.IsNotAllowed)
                errors.Add("Email confirmation required.");
            else
                errors.Add("Invalid username or password.");

            return new LoginResponse { IsSuccess = false, Errors = errors };
        }
        
        var tokenResponse = await _tokenService.GenerateTokenAsync(user);
        var roles = await _userManager.GetRolesAsync(user);

        return new LoginResponse
        {
            IsSuccess = true,
            Token = tokenResponse.Token,
            RefreshToken = tokenResponse.RefreshToken,
            ExpiresAt = tokenResponse.ExpiresAt,
            User = new UserDto
            {
                Id = user.Id,
                Username = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsActive = user.IsActive,
                EmailConfirmed = user.EmailConfirmed,
                CreatedAt = user.CreatedAt,
                Roles = roles.ToList()
            }
        };
    }

    public async Task<RegisterResponse> RegisterAsync(RegisterRequest request)
    {
        // Check existing email
        if (await _userManager.FindByEmailAsync(request.Email) != null)
        {
            return new RegisterResponse
            {
                IsSuccess = false,
                Errors = new List<string> { "Email already exists." }
            };
        }
        
        // Check existing username
        if (await _userManager.FindByNameAsync(request.Username) != null)
        {
            return new RegisterResponse
            {
                IsSuccess = false,
                Errors = new List<string> { "Username already exists." }
            };
        }

        var user = new ApplicationUser
        {
            UserName = request.Username,
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            CreatedAt = DateTimeOffset.Now,
        };
        
        var result = await _userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        {
            return new RegisterResponse
            {
                IsSuccess = false,
                Errors = result.Errors.Select(e => e.Description).ToList()
            };
        }
        
        // Add to default role
        await _userManager.AddToRoleAsync(user, "User");
        
        // Generate email confirmation token (TODO: Send email)
        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

        return new RegisterResponse
        {
            IsSuccess = true,
            User = new UserDto
            {
                Id = user.Id,
                Username = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsActive = user.IsActive,
                EmailConfirmed = user.EmailConfirmed,
                CreatedAt = user.CreatedAt,
                Roles = new List<string> { "User" }
            }
        };
    }

    public async Task LogoutAsync()
    {
        await _signInManager.SignOutAsync();
    }

    public async Task<RefreshTokenResponse> RefreshTokenAsync(string refreshToken)
    {
        var isValid = await _tokenService.ValidateRefreshTokenAsync(refreshToken);
        if (!isValid)
        {
            throw new UnauthorizedAccessException("Invalid refresh token.");
        }
        
        return await _tokenService.RefreshTokenAsync(refreshToken);
    }

    public async Task<bool> RevokeTokenAsync(string refreshToken)
    {
        return await _tokenService.RevokeTokenAsync(refreshToken);
    }

    public async Task<bool> ConfirmEmailAsync(ConfirmEmailRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);
        if (user == null)
            return false;

        var result = await _userManager.ConfirmEmailAsync(user, request.Token);
        return result.Succeeded;
    }

    public async Task<bool> ForgotPasswordAsync(ForgotPasswordRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);
        if (user == null || !user.IsActive || user.IsDeleted)
            return true; // Don't reveal if user exists

        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        // TODO: Send email with token

        return true;
    }

    public async Task<bool> ResetPasswordAsync(ResetPasswordRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);
        if (user == null || !user.IsActive || user.IsDeleted)
            return true; // Don't reveal if user exists
        
        var result = await _userManager.ResetPasswordAsync(user, request.Token, request.NewPassword);
        return result.Succeeded;
    }
}