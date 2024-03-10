namespace WireFrames.Core;

public interface IRecursiveRootReader
{
    Task<PrimeRoot?> BuildAsync(string rootGuid);

    Task<PrimeRoot?> GetRootById(int id);

    Task<WireFrame?> GetWfsById(int id);

    void DeleteRootById(int id);

    void DeleteWfsById(int id);
}
