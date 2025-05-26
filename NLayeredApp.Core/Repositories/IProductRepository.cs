using NLayeredApp.Core.Entities;

namespace NLayeredApp.Core.Repositories;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<IEnumerable<Product>> GetProductsWithCategoryAsync();
    Task<Product> GetProductWithCategoryAsync(int productId);
    Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId);
}