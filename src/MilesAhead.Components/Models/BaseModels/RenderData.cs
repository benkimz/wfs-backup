
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace MilesAhead.Components;

public class RenderData : IBaseRenderData
{
    public Guid Id { get; set; }
    public DataSource DataSource { get; set; }
    [MaxLength(255)]
    public string? Source { get; set; }
    public List<DataField>? Parameters { get; set; }
    public List<RenderDataItem>? FallbackRenderData { get; set; }
}
