namespace WireFrames.Core;

public interface IRecursiveRootReader
{
    Task<PrimeRoot?> BuildAsync(string rootName);
}
