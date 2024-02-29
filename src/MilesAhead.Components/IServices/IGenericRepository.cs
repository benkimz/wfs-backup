using System.Linq.Expressions;

namespace MilesAhead.Components;

public interface IGenericRepository<T>
{
    Task<T?> Add(T entity);
    Task<T?> Delete(int id);
    Task<T?> FilterSingle(Func<T, bool> predicate);
    Task<IEnumerable<T>?> GetAll();
    Task<T?> GetById(int id);
    Task<T?> Update(T entity);
}
