namespace WireFrames.Core;

public class WireFramesRepository : IWireFramesRepository
{
    private readonly IGenericRepository<WireFrame> _genericRepository;

    public WireFramesRepository(IGenericRepository<WireFrame> genericRepository)
    {
        _genericRepository = genericRepository;
    }

    public Task<WireFrame?> Add(WireFrame entity)
    {
        return _genericRepository.Add(entity);
    }

    public Task<WireFrame?> Delete(int id)
    {
        return _genericRepository.Delete(id);
    }

    public Task<WireFrame?> FilterSingle(Func<WireFrame, bool> predicate)
    {
        return _genericRepository.FilterSingle(predicate);
    }

    public Task<IEnumerable<WireFrame>?> GetAll()
    {
        return _genericRepository.GetAll();
    }

    public Task<WireFrame?> GetById(int id)
    {
        return _genericRepository.GetById(id);
    }

    public Task<WireFrame?> Update(WireFrame entity)
    {
        return _genericRepository.Update(entity);
    }

}
