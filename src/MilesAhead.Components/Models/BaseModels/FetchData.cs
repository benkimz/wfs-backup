using System.ComponentModel.DataAnnotations;

namespace MilesAhead.Components;

public class FetchData : IBaseFetchData
{
    public int Id { get; set; }
    [MaxLength(255)]
    public string? Source { get; set; }
    public List<DataField>? Parameters { get; set; }
}
