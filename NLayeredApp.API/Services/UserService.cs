using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.DTOs.Common;
using NLayeredApp.Core.DTOs.Identity;
using NLayeredApp.Core.DTOs.Identity.Requests;
using NLayeredApp.Core.DTOs.Identity.Responses;
using NLayeredApp.Core.Interfaces.Services.Auth;
using NLayeredApp.Core.Interfaces.Services.Identity;
using NLayeredApp.DataAccess.Identity;

namespace NLayeredApp.API.Services;

public class UserService : IUserService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ICurrentUserService _currentUserService;

    public UserService(
        UserManager<ApplicationUser> userManager,
        ICurrentUserService currentUserService)
    {
        _userManager = userManager;
        _currentUserService = currentUserService;
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

    public Task<UserResponse> CreateAsync(CreateUserRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse> UpdateAsync(int id, UpdateUserRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse> ChangePasswordAsync(int id, ChangePasswordRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<string>> GetRolesAsync(int userId)
    {
        throw new NotImplementedException();
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