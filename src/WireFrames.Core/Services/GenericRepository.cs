using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace WireFrames.Core;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly WireFramesDbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(WireFramesDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<T?> Add(T entity)
    {
        var result = await _dbSet.AddAsync(entity);
        if (result.State == EntityState.Added)
        {
            await _context.SaveChangesAsync();
            entity = result.Entity;
            _context.Entry(entity).State = EntityState.Detached;
            return entity;
        }
        return null;
    }

    public Task<T?> Delete(int id)
    {
        var entity = _dbSet.Find(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
            _context.Entry(entity).State = EntityState.Detached;
            return Task.FromResult(entity ?? null);
        }
        return Task.FromResult<T?>(null);
    }

    public Task<T?> FilterSingle(Func<T, bool> predicate)
    {
        return Task.FromResult(_dbSet.AsNoTracking().Where(predicate).FirstOrDefault());
    }

    public Task<IEnumerable<T>?> GetAll()
    {
        return Task.FromResult(_dbSet.AsNoTracking().AsEnumerable() ?? null);
    }

    public Task<T?> GetById(int id)
    {
        var entity = _dbSet.Find(id);
        if (entity is not null)
        {
            _context.Entry(entity).State = EntityState.Detached;
        }
        return Task.FromResult(entity ?? null);
    }

    public Task<T?> Update(T entity)
    {
        var result = _dbSet.Update(entity);
        if (result.State == EntityState.Modified)
        {
            _context.SaveChanges();
            entity = result.Entity;
            _context.Entry(entity).State = EntityState.Detached;
            return Task.FromResult(entity ?? null);
        }
        return Task.FromResult<T?>(null);
    }

}
