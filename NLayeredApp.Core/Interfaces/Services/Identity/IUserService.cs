using NLayeredApp.Core.DTOs.Common;
using NLayeredApp.Core.DTOs.Identity;
using NLayeredApp.Core.DTOs.Identity.Requests;
using NLayeredApp.Core.DTOs.Identity.Responses;

namespace NLayeredApp.Core.Interfaces.Services.Identity;

public interface IUserService
{
    Task<UserDto?> GetByIdAsync(int id);
    Task<UserDto?> GetByEmailAsync(string email);
    Task<UserDto?> GetByUsernameAsync(string username);
    Task<IEnumerable<UserDto>> GetAllAsync();
    Task<PagedResponse<UserDto>> GetPagedAsync(int pageNumber, int pageSize);
    Task<UserResponse> CreateAsync(CreateUserRequest request);
    Task<ApiResponse> UpdateAsync(int id, UpdateUserRequest request);
    Task<ApiResponse> DeleteAsync(int id);
    Task<ApiResponse> ChangePasswordAsync(int id, ChangePasswordRequest request);
    Task<IEnumerable<string>> GetRolesAsync(int userId);
    Task<ApiResponse> AddToRoleAsync(int userId, string role);
    Task<ApiResponse> RemoveFromRoleAsync(int userId, string role);
}