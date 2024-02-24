
using System.ComponentModel.DataAnnotations;

namespace MilesAhead.Components;

public class RenderData : IBaseRenderData
{
    public DataSource DataSource { get; set; }
    [MaxLength(255)]
    public string? Source { get; set; }
    public Dictionary<string, string>? Parameters { get; set; }
    public Dictionary<string, string>? FallbackRenderData { get; set; }
}
