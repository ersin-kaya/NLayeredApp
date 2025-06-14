using NLayeredApp.Core.DTOs.Common;
using NLayeredApp.Core.DTOs.Identity;
using NLayeredApp.Core.DTOs.Identity.Requests;
using NLayeredApp.Core.DTOs.Identity.Responses;

namespace NLayeredApp.Core.Interfaces.Services.Identity;

public interface IRoleService
{
    Task<IEnumerable<RoleDto>> GetAllAsync();
    Task<RoleDto?> GetByIdAsync(int id);
    Task<RoleDto?> GetByNameAsync(string name);
    Task<RoleResponse> CreateAsync(CreateRoleRequest request);
    Task<ApiResponse> UpdateAsync(int id, UpdateRoleRequest request);
    Task<ApiResponse> DeleteAsync(int id);
    Task<IEnumerable<UserDto>> GetUsersInRoleAsync(string roleName);
}