using System.ComponentModel.DataAnnotations;

namespace WireFrames.Core;

public class PrimeRoot : WireFrame
{
    public Guid Guid { get; set; }
    [MaxLength(255)]
    public string? PageTitle { get; set; }
    [MaxLength(255)]
    public string? FaviconUrl { get; set; }
    public List<string> ExternalStyleSheets { get; set; } = [];
    public List<string> HeadScripts { get; set; } = [];
    public List<string> BodyScripts { get; set; } = [];

    public PrimeRoot()
    {
        Guid = Guid.NewGuid();
    }
}