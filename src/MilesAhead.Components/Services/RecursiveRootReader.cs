
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MilesAhead.Components;

public class RecursiveRootReader : IRecursiveRootReader
{
    private readonly WireFramesDbContext _context;

    public RecursiveRootReader(WireFramesDbContext context)
    {
        _context = context;
    }

    public Task<PrimeRoot?> BuildAsync(string rootName)
    {
        var nodes = _context.WireFrames.FromSqlRaw(@"
                        WITH tree AS (
                            SELECT 
                                wf.*
                            FROM 
                                render.WireFrames AS wf
                            WHERE 
                                wf.Discriminator = 'PrimeRoot' AND wf.RootName = {0}

                            UNION ALL

                            SELECT 
                                wf.*
                            FROM 
                                render.WireFrames AS wf
                            INNER JOIN 
                                tree ON wf.WireFrameId = tree.Id
                        )
                        SELECT * FROM tree", rootName).ToList();

        var root = nodes.FirstOrDefault() as PrimeRoot;
        var rootinfo = _context.PrimeRoots
                .Where(r => r.RootName == rootName)
                .Select(r => new { PageTitle = r.PageTitle, FaviconUrl = r.FaviconUrl, ExternalStyleSheets = r.ExternalStyleSheets, HeadScripts = r.HeadScripts, BodyScripts = r.BodyScripts })
                .FirstOrDefault();
        if (rootinfo != null && root != null)
        {
            root.PageTitle = rootinfo.PageTitle;
            root.FaviconUrl = rootinfo.FaviconUrl;
            root.ExternalStyleSheets = rootinfo.ExternalStyleSheets;
            root.HeadScripts = rootinfo.HeadScripts;
            root.BodyScripts = rootinfo.BodyScripts;
        }
        return Task.FromResult(root);
    }

}