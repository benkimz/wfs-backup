﻿using System.ComponentModel.DataAnnotations;

namespace WireFrames.Core;

public class BaseWireFrame : IBaseWireFrame
{
    public int Id { get; set; }
    [MaxLength(255)]
    public string Name { get; set; } = "WireFrame Component";
    [MaxLength(64)]
    public string Segment { get; set; } = "div"; // target component or html element
    public bool IsBlazorComponent { get; set; } = false; // is the segment a blazor component
    public bool IsVisible { get; set; } = true; // is the segment visible
    public string? Attributes { get; set; } // segment attributes as a JSON string
    public DataSource DataSource { get; set; } // data source
    public string? Content { get; set; } // content to be rendered
    // must have parameters: source (string), parameters (json string )
    public string? FetchData { get; set; } // a JSON string of the data to be fetched
}
