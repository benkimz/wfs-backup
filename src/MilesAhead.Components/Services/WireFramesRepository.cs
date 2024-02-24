
namespace MilesAhead.Components;

public class WireFramesRepository : IWireFramesRepository
{
    private readonly IGenericRepository<WireFrame> _genericRepository;

    public WireFramesRepository(IGenericRepository<WireFrame> genericRepository)
    {
        _genericRepository = genericRepository;
    }

    public Task<WireFrame?> Add(WireFrame entity)
    {
        throw new NotImplementedException();
    }

    public Task<WireFrame?> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<WireFrame>?> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<WireFrame?> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<WireFrame?> Update(WireFrame entity)
    {
        throw new NotImplementedException();
    }
}
