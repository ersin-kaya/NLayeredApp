using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Constants;
using NLayeredApp.Core.DTOs.Common;
using NLayeredApp.Core.DTOs.Identity;
using NLayeredApp.Core.DTOs.Identity.Requests;
using NLayeredApp.Core.Interfaces.Services.Identity;
using NLayeredApp.DataAccess.Identity;

namespace NLayeredApp.API.Services;

public class UserService : IUserService
{
    private readonly UserManager<ApplicationUser> _userManager;

    public UserService(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }
    
    public async Task<UserDto?> GetByIdAsync(int id)
    {
        var user  = await _userManager.FindByIdAsync(id.ToString());
        if (user == null || user.IsDeleted) return null;
        
        return await MapToDto(user);
    }

    public async Task<UserDto?> GetByEmailAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null || user.IsDeleted) return null;
        
        return await MapToDto(user);
    }

    public async Task<UserDto?> GetByUsernameAsync(string username)
    {
        var user = await _userManager.FindByNameAsync(username);
        if (user == null || user.IsDeleted) return null;
        
        return await MapToDto(user);
    }

    public async Task<IEnumerable<UserDto>> GetAllAsync()
    {
        var users = await _userManager.Users
            .Where(u => !u.IsDeleted)
            .ToListAsync();
        
        
        var userDtos = new List<UserDto>();
        foreach (var user in users)
        {
            userDtos.Add(await MapToDto(user));
        }
        return userDtos;
    }

    public async Task<PagedResponse<UserDto>> GetPagedAsync(int pageNumber, int pageSize)
    {
        var query = _userManager.Users.Where(u => !u.IsDeleted);
        
        var totalCount = await query.CountAsync();
        var users = await query
            .OrderBy(u => u.UserName)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        
        var userDtos = new List<UserDto>();
        foreach (var user in users)
        {
            userDtos.Add(await MapToDto(user));
        }

        return new PagedResponse<UserDto>(userDtos, totalCount, pageNumber, pageSize);
    }

    public async Task<ApiResponse<UserDto?>> CreateAsync(CreateUserRequest request)
    {
        var user = new ApplicationUser
        {
            UserName = request.Username,
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName
        };
        
        var result = await _userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        {
            return ApiResponse<UserDto?>.ErrorResponse(result.Errors.Select(e => e.Description).ToList());
        }

        if (request.Roles?.Any() == true)
        {
            await _userManager.AddToRolesAsync(user, request.Roles);
        }
        
        return ApiResponse<UserDto?>.SuccessResponse(await MapToDto(user), Messages.User.Success.Created);
    }

    public async Task<ApiResponse> UpdateAsync(int id, UpdateUserRequest request)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user == null || user.IsDeleted)
            return ApiResponse.ErrorResponse(Messages.User.Error.NotFound);
        
        user.FirstName = request.FirstName;
        user.LastName = request.LastName;
        user.IsActive = request.IsActive;
        
        var result = await _userManager.UpdateAsync(user);
        if (!result.Succeeded)
        {
            return ApiResponse.ErrorResponse(result.Errors.Select(e => e.Description).ToList());
        }
        
        return ApiResponse.SuccessResponse(Messages.User.Success.Updated);
    }

    public async Task<ApiResponse> DeleteAsync(int id)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user == null || user.IsDeleted)
            return ApiResponse.ErrorResponse(Messages.User.Error.NotFound);
        
        var result = await _userManager.UpdateAsync(user);
        if (!result.Succeeded)
        {
            return ApiResponse.ErrorResponse(result.Errors.Select(e => e.Description).ToList());
        }
        
        return ApiResponse.SuccessResponse(Messages.User.Success.Deleted);
    }

    public async Task<ApiResponse> ChangePasswordAsync(int id, ChangePasswordRequest request)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());
        if (user == null || user.IsDeleted)
            return ApiResponse.ErrorResponse(Messages.User.Error.NotFound);
        
        var result = await _userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);
        if (!result.Succeeded)
        {
            return ApiResponse.ErrorResponse(result.Errors.Select(e => e.Description).ToList());
        }
        
        return ApiResponse.SuccessResponse(Messages.User.Success.PasswordChanged);
    }

    public async Task<IEnumerable<string>> GetRolesAsync(int userId)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());
        if (user == null || user.IsDeleted)
            return Enumerable.Empty<string>();
        
        return await _userManager.GetRolesAsync(user);
    }

    public Task<ApiResponse> AddToRoleAsync(int userId, string role)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse> RemoveFromRoleAsync(int userId, string role)
    {
        throw new NotImplementedException();
    }
}