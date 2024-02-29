namespace MilesAhead.Components;

public class PrimeRoot : WireFrame
{
    // ~ benkimz: MetaData will hold the metadata for the page, favicon, title, etc.
    public required string RootName { get; set; }
    public string? PageTitle { get; set; }
    public string? FaviconUrl { get; set; }
    public List<string> ExternalStyleSheets { get; set; } = [];
    public List<string> HeadScripts { get; set; } = [];
    public List<string> BodyScripts { get; set; } = [];
}
