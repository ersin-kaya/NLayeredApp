using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;
using NLayeredApp.Core.Repositories;

namespace NLayeredApp.DataAccess.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Category>> GetCategoriesWithProductsAsync()
    {
        return await _dbSet
            .Include(c => c.Products)
            .ToListAsync();
    }

    public async Task<Category> GetCategoryWithProductsAsync(int categoryId)
    {
        return await _dbSet
            .Include(c => c.Products)
            .FirstOrDefaultAsync(c => c.Id == categoryId);
    }
}