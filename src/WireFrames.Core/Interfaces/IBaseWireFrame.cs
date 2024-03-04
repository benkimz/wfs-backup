namespace WireFrames.Core;

public interface IBaseWireFrame
{
    public int Id { get; set; }
    public string Name { get; set; } // name of the component
    public string Segment { get; set; } // target component or html element
    public bool IsBlazorComponent { get; set; } // is the segment a blazor component
    public bool IsVisible { get; set; } // is the segment visible
    public string? Attributes { get; set; } // segment attributes as a JSON string
    public DataSource DataSource { get; set; } // data source
    public string? Content { get; set; } // content to be rendered
    public string? FetchData { get; set; } // a JSON string of the data to be fetched
}
