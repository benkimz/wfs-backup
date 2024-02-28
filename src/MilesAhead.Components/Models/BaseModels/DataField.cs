using System.ComponentModel.DataAnnotations;

namespace MilesAhead.Components;

public class DataField
{
    public int Id { get; set; }
    [MaxLength(100)]
    public required string Name { get; set; }
    public string? Value { get; set; }
}
