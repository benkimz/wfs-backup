using System.ComponentModel.DataAnnotations;

namespace MilesAhead.Components;

public class WireFrameAttribute
{
    public Guid Id { get; set; }
    [MaxLength(100)]
    public required string Name { get; set; }
    [MaxLength(100)]
    public string? Value { get; set; }
}
