

using System.ComponentModel.DataAnnotations;

namespace MilesAhead.Components;

public class BaseWireFrame : IBaseWireFrame
{
    public Guid Id { get; set; }
    [MaxLength(255)]
    public string Name { get; set; } = "Dynamic Component";
    [MaxLength(64)]
    public required string Segment { get; set; } // target component or html element
    public Dictionary<string, string>? Attributes { get; set; } // segment attributes
    public RenderData? Data { get; set; } // data to be rendered
}
