using NLayeredApp.Core.Entities.Identity;

namespace NLayeredApp.Core.Interfaces.Repositories.Auth;

public interface IRefreshTokenRepository : IGenericRepository<RefreshToken>
{
    Task<RefreshToken?> GetByTokenAsync(string token);
    Task<IEnumerable<RefreshToken>> GetActiveTokensByUserIdAsync(int userId);
    Task RevokeAllUserTokensAsync(int userId);
}