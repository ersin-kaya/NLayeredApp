using NLayeredApp.Core.DTOs.Common;
using NLayeredApp.Core.DTOs.Product;
using NLayeredApp.Core.DTOs.Product.Requests;
using NLayeredApp.Core.DTOs.Product.Responses;

namespace NLayeredApp.Core.Interfaces.Services;

public interface IProductService
{
    Task<PagedResponse<ProductDto>> GetAllAsync(GetProductsRequest request);
    Task<ProductDetailDto> GetByIdAsync(int id);
    Task<ProductDto> CreateAsync(CreateProductRequest request);
    Task<ProductDto> UpdateAsync(UpdateProductRequest request);
    Task DeleteAsync(int id);
    Task RestoreAsync(int id);
    Task<PagedResponse<ProductDto>> GetByCategoryIdAsync(GetProductsRequest request);
    Task<bool> UpdateStockAsync(int productId, int quantity);
    Task<bool> CheckStockAsync(int productId, int requestedQuantity);
    Task<List<ProductDto>> GetLowStockProductsAsync(int threshold = 10);
    Task<PagedResponse<ProductDto>> SearchProductsAsync(GetProductsRequest request);
}