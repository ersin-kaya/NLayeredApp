using NLayeredApp.Core.Entities;

namespace NLayeredApp.Core.Repositories;

public interface ICategoryRepository : IGenericRepository<Category>
{
    Task<IEnumerable<Category>> GetCategoriesWithProductsAsync();
    Task<Category> GetCategoryWithProductsAsync(int categoryId);
}