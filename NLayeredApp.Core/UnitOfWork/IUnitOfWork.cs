using NLayeredApp.Core.Repositories;

namespace NLayeredApp.Core.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; }
        IProductRepository Products { get; }
        
        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitAsync(); 
        Task RollbackAsync();
    }
}
