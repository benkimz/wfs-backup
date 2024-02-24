namespace MilesAhead.Components;

public class PrimeRoot : WireFrame
{
    // ~ benkimz: MetaData will hold the metadata for the page, favicon, title, etc.
    public WireFrame? MetaData { get; set; }
    public List<string> ExternalStyleSheets { get; set; } = [];
    public List<string> ExternalScripts { get; set; } = [];
}
