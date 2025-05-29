using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Common;
using NLayeredApp.Core.Interfaces.Repositories;
using NLayeredApp.DataAccess.Context;

namespace NLayeredApp.DataAccess.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
{
    protected readonly ApplicationDbContext _context;
    protected readonly DbSet<TEntity> _dbSet;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }
    
    public IQueryable<TEntity> Query()
    {
        return _dbSet.AsQueryable();
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<TEntity> GetByIdNoTrackingAsync(int id)
    {
        return await _dbSet.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }

    public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
    }

    public async Task AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public async Task AddRangeAsync(IEnumerable<TEntity> entities)
    {
        await _dbSet.AddRangeAsync(entities);
    }

    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);
    }

    public void Remove(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        _dbSet.RemoveRange(entities);
    }

    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.AsNoTracking().AnyAsync(predicate);
    }

    public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.AsNoTracking().CountAsync(predicate);
    }
}