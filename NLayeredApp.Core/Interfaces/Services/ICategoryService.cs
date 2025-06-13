using NLayeredApp.Core.DTOs.Category;
using NLayeredApp.Core.DTOs.Category.Requests;
using NLayeredApp.Core.DTOs.Category.Responses;
using NLayeredApp.Core.DTOs.Common;

namespace NLayeredApp.Core.Interfaces.Services;

public interface ICategoryService
{
    Task<PagedResponse<CategoryDto>> GetAllAsync(GetCategoriesRequest request);
    Task<CategoryDetailResponse> GetByIdAsync(int id);
    Task<CategoryDto> CreateAsync(CreateCategoryRequest request);
    Task<CategoryDto> UpdateAsync(UpdateCategoryRequest request);
    Task DeleteAsync(int id);
    Task<List<CategoryDto>> GetActiveCategoriesAsync();
    Task<bool> ExistsAsync(int id);
    Task<int> GetProductCountAsync(int categoryId);
}