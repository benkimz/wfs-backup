namespace MilesAhead.Components;

public interface IBaseWireFrame
{
    public int Id { get; set; }
    public string Name { get; set; } // name of the component
    public string Segment { get; set; } // target component or html element
    public string? Attributes { get; set; } // segment attributes as a JSON string
    public DataSource DataSource { get; set; } // data source
    public string? Content { get; set; } // content to be rendered
    public FetchData? FetchContent { get; set; } // data to be fetched and rendered
}
