using System.ComponentModel.DataAnnotations;

namespace MilesAhead.Components;

public class WireFrameAttribute
{
    public int Id { get; set; }
    [MaxLength(100)]
    public required string Name { get; set; }
    [MaxLength(320)]
    public string? Value { get; set; }
}
