using NLayeredApp.Core.DTOs.Category;
using NLayeredApp.Core.DTOs.Category.Responses;
using NLayeredApp.Core.DTOs.Common;

namespace NLayeredApp.Core.Interfaces.Services;

public interface ICategoryService
{
    Task<PagedResponse<CategoryDto>> GetAllAsync(int pageNumber = 1, int pageSize = 10, bool includeInactive = false);
    Task<CategoryDetailDto> GetByIdAsync(int id);
    Task<CategoryDto> CreateAsync(CreateCategoryRequest request);
    Task<CategoryDto> UpdateAsync(UpdateCategoryRequest request);
    Task DeleteAsync(int id);
    Task<List<CategoryDto>> GetActiveCategoriesAsync();
    Task<bool> ExistsAsync(int id);
    Task<int> GetProductCountAsync(int categoryId);
}