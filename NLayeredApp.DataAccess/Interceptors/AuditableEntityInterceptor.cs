using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using NLayeredApp.Core.Common;
using NLayeredApp.Core.Interfaces.Services.Auth;

namespace NLayeredApp.DataAccess.Interceptors;

public class AuditableEntityInterceptor : SaveChangesInterceptor
{
    private readonly ICurrentUserService _currentUserService;

    public AuditableEntityInterceptor(ICurrentUserService currentUserService) 
    {
        _currentUserService = currentUserService;    
    }

    public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData, 
        InterceptionResult<int> result, 
        CancellationToken cancellationToken = default)
    {
        var context = eventData.Context;
        if (context == null) return result;
        
        var currentUsername = _currentUserService?.Username ?? "system";
        var currentTime = DateTimeOffset.UtcNow;

        foreach (var entry in context.ChangeTracker.Entries<AuditableEntity>())
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedAt = currentTime;
                entry.Entity.CreatedBy = currentUsername;
            }
            else if (entry.State == EntityState.Modified)
            {
                entry.Entity.LastModifiedAt = currentTime;
                entry.Entity.LastModifiedBy = currentUsername;
            }
        }
        
        return result;
    }
}