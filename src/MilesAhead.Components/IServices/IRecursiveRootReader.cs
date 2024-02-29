namespace MilesAhead.Components;

public interface IRecursiveRootReader
{
    Task<PrimeRoot?> BuildAsync(string rootName);
}
