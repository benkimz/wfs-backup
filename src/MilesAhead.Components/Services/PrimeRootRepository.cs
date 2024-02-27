

namespace MilesAhead.Components;

public class PrimeRootRepository : IPrimeRootRepository
{
    private readonly IGenericRepository<PrimeRoot> _genericRepository;

    public PrimeRootRepository(IGenericRepository<PrimeRoot> genericRepository)
    {
        _genericRepository = genericRepository;
    }

    public Task<PrimeRoot?> Add(PrimeRoot entity)
    {
        return _genericRepository.Add(entity);
    }

    public Task<PrimeRoot?> Delete(int id)
    {
        return _genericRepository.Delete(id);
    }

    public Task<PrimeRoot?> FilterSingle(Func<PrimeRoot, bool> predicate)
    {
        return _genericRepository.FilterSingle(predicate);
    }

    public Task<IEnumerable<PrimeRoot>?> GetAll()
    {
        return _genericRepository.GetAll();
    }

    public Task<PrimeRoot?> GetById(int id)
    {
        return _genericRepository.GetById(id);
    }

    public Task<PrimeRoot?> Update(PrimeRoot entity)
    {
        return _genericRepository.Update(entity);
    }

    public Task<PrimeRoot?> Upsert(PrimeRoot entity)
    {
        return _genericRepository.Upsert(entity);
    }
}
