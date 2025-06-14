using NLayeredApp.Core.Interfaces.Repositories;
using NLayeredApp.Core.Interfaces.Repositories.Auth;

namespace NLayeredApp.Core.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; }
        IProductRepository Products { get; }
        IRefreshTokenRepository RefreshTokens { get; }
        
        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitAsync(); 
        Task RollbackAsync();
    }
}
