using System.ComponentModel.DataAnnotations;

namespace MilesAhead.Components;

public class BaseWireFrame : IBaseWireFrame
{
    public Guid Id { get; set; }
    [MaxLength(255)]
    public string Name { get; set; } = "Dynamic Component";
    [MaxLength(64)]
    public string Segment { get; set; } = "div"; // target component or html element
    public List<WireFrameAttribute>? Attributes { get; set; } // segment attributes
    public RenderData? Data { get; set; } // data to be rendered
    public bool IsOpenTag { get; set; } = false; // is the component an open or close tag
}
