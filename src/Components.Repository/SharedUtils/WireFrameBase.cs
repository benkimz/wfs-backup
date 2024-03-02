using Microsoft.AspNetCore.Components;
using WireFrames.Core;

namespace Components.Repository;

public class WireFrameBase : ComponentBase
{
    [Parameter]
    public string? Name { get; set; }
    [Parameter]
    public DataSource? DataSource { get; set; }
    [Parameter]
    public string? Content { get; set; }
    [Parameter]
    public string? FetchData { get; set; }
}
