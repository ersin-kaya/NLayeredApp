using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using NLayeredApp.Core.Common;
using NLayeredApp.Core.Interfaces.Services.Auth;

namespace NLayeredApp.DataAccess.Interceptors;

public class SoftDeleteInterceptor : SaveChangesInterceptor
{
    private readonly ICurrentUserService _currentUserService;

    public SoftDeleteInterceptor(ICurrentUserService currentUserService)
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
        
        var currentUserId = _currentUserService?.UserId?.ToString() ?? "System";
        var currentTime = DateTimeOffset.UtcNow;
        
        foreach (var entry in context.ChangeTracker.Entries<ISoftDeletable>())
        {
            if (entry.State == EntityState.Deleted)
            {
                entry.State = EntityState.Modified;
                entry.Entity.IsDeleted = true;
                entry.Entity.DeletedAt = currentTime;
                entry.Entity.DeletedBy = currentUserId;
            }
        }

        return result;
    }
}