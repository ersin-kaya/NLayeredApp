using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Constants;
using NLayeredApp.Core.DTOs.Common;
using NLayeredApp.Core.DTOs.Identity;
using NLayeredApp.Core.DTOs.Identity.Requests;
using NLayeredApp.Core.Interfaces.Services.Identity;
using NLayeredApp.DataAccess.Identity;

namespace NLayeredApp.API.Services;

public class RoleService : IRoleService
{
    private readonly RoleManager<ApplicationRole> _roleManager;
    private readonly UserManager<ApplicationUser> _userManager;

    public RoleService(
        RoleManager<ApplicationRole> roleManager,
        UserManager<ApplicationUser> userManager)
    {
        _roleManager = roleManager;
        _userManager = userManager;
    }
    
    public async Task<IEnumerable<RoleDto>> GetAllAsync()
    {
        var roles = await _roleManager.Roles
            .Where(r => r.IsActive)
            .ToListAsync();

        return roles.Select(r => new RoleDto
        {
            Id = r.Id,
            Name = r.Name,
            Description = r.Description,
            IsActive = r.IsActive,
            CreatedAt = r.CreatedAt
        });
    }

    public async Task<RoleDto?> GetByIdAsync(int id)
    {
        var role = await _roleManager.FindByIdAsync(id.ToString());
        if (role == null || !role.IsActive) return null;

        return new RoleDto
        {
            Id = role.Id,
            Name = role.Name,
            Description = role.Description,
            IsActive = role.IsActive,
            CreatedAt = role.CreatedAt
        };
    }

    public async Task<RoleDto?> GetByNameAsync(string name)
    {
        var role = await _roleManager.FindByNameAsync(name);
        if (role == null || !role.IsActive) return null;

        return new RoleDto
        {
            Id = role.Id,
            Name = role.Name,
            Description = role.Description,
            IsActive = role.IsActive,
            CreatedAt = role.CreatedAt
        };
    }

    public async Task<ApiResponse<RoleDto?>> CreateAsync(CreateRoleRequest request)
    {
        var role = new ApplicationRole
        {
            Name = request.Name,
            Description = request.Description,
            CreatedAt = DateTimeOffset.UtcNow
        };
        
        var result = await _roleManager.CreateAsync(role);
        if (!result.Succeeded)
        {
            return ApiResponse<RoleDto?>.ErrorResponse(result.Errors.Select(e => e.Description).ToList());
        }

        return ApiResponse<RoleDto?>.SuccessResponse(
            new RoleDto
            {
                Id = role.Id,
                Name = role.Name,
                Description = role.Description,
                IsActive = role.IsActive,
                CreatedAt = role.CreatedAt
            },
            Messages.Role.Success.Created
        );
    }

    public async Task<ApiResponse> UpdateAsync(int id, UpdateRoleRequest request)
    {
        var role = await _roleManager.FindByIdAsync(id.ToString());
        if (role == null)
        {
            return ApiResponse.ErrorResponse(Messages.Role.Error.NotFound);
        }
        
        role.Description = request.Description;
        role.IsActive = request.IsActive;
        
        var result = await _roleManager.UpdateAsync(role);
        if (!result.Succeeded)
        {
            return ApiResponse.ErrorResponse(result.Errors.Select(e => e.Description).ToList());
        }
        
        return ApiResponse.SuccessResponse(Messages.Role.Success.Updated);
    }

    public async Task<ApiResponse> DeleteAsync(int id)
    {
        var role = await _roleManager.FindByIdAsync(id.ToString());
        if (role == null)
        {
            return ApiResponse.ErrorResponse(Messages.Role.Error.NotFound);
        }
        
        role.IsActive = false;
        
        var result = await _roleManager.UpdateAsync(role);
        if (!result.Succeeded)
        {
            return ApiResponse.ErrorResponse(result.Errors.Select(e => e.Description).ToList());
        }
        
        return ApiResponse.SuccessResponse(Messages.Role.Success.Deleted);
    }

    public async Task<IEnumerable<UserDto>> GetUsersInRoleAsync(string roleName)
    {
        var users = await _userManager.GetUsersInRoleAsync(roleName);
        var activeUsers = users.Where(u => !u.IsDeleted && u.IsActive);

        return activeUsers.Select(u => new UserDto
        {
            Id = u.Id,
            Username = u.UserName,
            Email = u.Email,
            FirstName = u.FirstName,
            LastName = u.LastName,
            IsActive = u.IsActive,
            EmailConfirmed = u.EmailConfirmed,
            CreatedAt = u.CreatedAt
        });
    }
}