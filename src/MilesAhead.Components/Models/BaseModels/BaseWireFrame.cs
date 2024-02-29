using System.ComponentModel.DataAnnotations;

namespace MilesAhead.Components;

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
    public virtual FetchData? FetchContent { get; set; } // data to be rendered
}
