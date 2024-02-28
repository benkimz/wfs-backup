namespace MilesAhead.Components;

public interface IBaseWireFrame
{
    public int Id { get; set; }
    public string Name { get; set; } // name of the component
    public string Segment { get; set; } // target component or html element
    public List<WireFrameAttribute>? Attributes { get; set; } // segment attributes
    public DataSource DataSource { get; set; } // data source
    public string? Content { get; set; } // content to be rendered
    public FetchData? FetchContent { get; set; } // data to be fetched and rendered
}
