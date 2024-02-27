using Microsoft.EntityFrameworkCore;

namespace MilesAhead.Components;

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
            return result.Entity;
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
            return Task.FromResult(entity ?? null);
        }
        return Task.FromResult<T?>(null);
    }

    public Task<T?> FilterSingle(Func<T, bool> predicate)
    {
        return Task.FromResult(_dbSet.Where(predicate).FirstOrDefault());
    }

    public Task<IEnumerable<T>?> GetAll()
    {
        return Task.FromResult(_dbSet.AsEnumerable() ?? null);
    }

    public Task<T?> GetById(int id)
    {
        return Task.FromResult(_dbSet.Find(id) ?? null);
    }

    public Task<T?> Update(T entity)
    {
        var result = _dbSet.Update(entity);
        if (result.State == EntityState.Modified)
        {
            _context.SaveChanges();
            return Task.FromResult(result.Entity ?? null);
        }
        return Task.FromResult<T?>(null);
    }

    public Task<T?> Upsert(T entity)
    {
        var entry = _dbSet.Entry(entity);
        switch (entry.State)
        {
            case EntityState.Detached:
                entry = _dbSet.Add(entity);
                break;
            case EntityState.Modified:
                entry = _dbSet.Update(entity);
                break;
            default: break;
        }
        _context.SaveChanges();
        return Task.FromResult(entry.Entity ?? null);
    }
}
