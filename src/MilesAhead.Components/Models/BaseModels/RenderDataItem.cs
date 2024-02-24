﻿using System.ComponentModel.DataAnnotations;

namespace MilesAhead.Components;

public class RenderDataItem
{
    public Guid Id { get; set; }
    [MaxLength(100)]
    public required string Name { get; set; }
    [MaxLength(100)]
    public required string Value { get; set; }
}