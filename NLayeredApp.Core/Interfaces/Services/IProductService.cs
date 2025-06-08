using NLayeredApp.Core.DTOs.Common;
using NLayeredApp.Core.DTOs.Product;
using NLayeredApp.Core.DTOs.Product.Responses;

namespace NLayeredApp.Core.Interfaces.Services;

public interface IProductService
{
    Task<PagedResponse<ProductDto>> GetAllAsync(int pageNumber = 1, int pageSize = 10, bool includeInactive = false);
    Task<ProductDetailDto> GetByIdAsync(int id);
    Task<ProductDto> CreateAsync(CreateProductDto dto);
    Task<ProductDto> UpdateAsync(UpdateProductDto dto);
    Task DeleteAsync(int id);
    Task RestoreAsync(int id);
    Task<PagedResponse<ProductDto>> GetByCategoryIdAsync(int categoryId, int pageNumber = 1, int pageSize = 10);
    Task<bool> UpdateStockAsync(int productId, int quantity);
    Task<bool> CheckStockAsync(int productId, int requestedQuantity);
    Task<List<ProductDto>> GetLowStockProductsAsync(int threshold = 10);
    Task<PagedResponse<ProductDto>> SearchProductsAsync(string searchTerm, int pageNumber = 1, int pageSize = 10);
}