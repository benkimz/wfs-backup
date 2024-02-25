namespace MilesAhead.Components;

public interface IBaseWireFrame
{
    public Guid Id { get; set; }
    public string Name { get; set; } // name of the component
    public string Segment { get; set; } // target component or html element
    public List<WireFrameAttribute>? Attributes { get; set; } // segment attributes
    public RenderData? Data { get; set; } // data to be rendered
    public bool IsOpenTag { get; set; } // is the component an open or close tag
}
