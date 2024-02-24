namespace MilesAhead.Components;

public interface IBaseRenderData
{
    public DataSource DataSource { get; set; }

    // API fetch URL/ file path/ database query
    public string? Source { get; set; }

    // Optional: Case where we have to call an API with parameters
    public Dictionary<string, string>? Parameters { get; set; }

    // data to be rendered of no source is provided
    public Dictionary<string, string>? FallbackRenderData { get; set; }
}
