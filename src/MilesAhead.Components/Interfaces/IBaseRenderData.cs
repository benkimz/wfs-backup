using System.Text.Json;

namespace MilesAhead.Components;

public interface IBaseRenderData
{
    public DataSource DataSource { get; set; }

    // API fetch URL/ file path/ database query
    public string? Source { get; set; }

    // Optional: Case where we have to call an API with parameters
    public List<DataField>? Parameters { get; set; }

    // data to be rendered of no source is provided
    public List<RenderDataItem>? FallbackRenderData { get; set; }
}
