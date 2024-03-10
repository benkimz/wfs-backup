namespace WireFrames.Core;

public interface IRecursiveRootReader
{
    Task<PrimeRoot?> BuildAsync(string rootGuid);

    Task<PrimeRoot?> GetById(int id);

    void DeleteById(int id);
}
