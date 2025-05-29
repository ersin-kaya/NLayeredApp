using NLayeredApp.Core.Interfaces.Repositories;

namespace NLayeredApp.Core.Interfaces.UnitOfWork
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
