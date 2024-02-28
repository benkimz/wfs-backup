using System.Text.Json;

namespace MilesAhead.Components;

public interface IBaseFetchData
{
    // API fetch URL/ file path/ database query
    public string? Source { get; set; }

    // Optional: Case where we have to call an API with parameters
    public List<DataField>? Parameters { get; set; }
}
