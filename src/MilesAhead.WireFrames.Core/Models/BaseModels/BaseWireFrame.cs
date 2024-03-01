using System.ComponentModel.DataAnnotations;

namespace MilesAhead.WireFrames.Core;

public class BaseWireFrame : IBaseWireFrame
{
    public int Id { get; set; }
    [MaxLength(255)]
    public string Name { get; set; } = "Dynamic Component";
    [MaxLength(64)]
    public string Segment { get; set; } = "div"; // target component or html element
    [MaxLength(720)]
    public string? Attributes { get; set; } // segment attributes as a JSON string
    public DataSource DataSource { get; set; } // data source
    public string? Content { get; set; } // content to be rendered
    // must have parameters: source (string), parameters (json string )
    public string? FetchData { get; set; } // a JSON string of the data to be fetched
}
