﻿using Microsoft.EntityFrameworkCore;

namespace WireFrames.Core;

public class RecursiveReader : IRecursiveReader
{
    private readonly WireFramesDbContext _context;

    public RecursiveReader(WireFramesDbContext context)
    {
        _context = context;
    }

    public Task<PrimeRoot?> BuildAsync(string rootGuid)
    {
        var nodes = _context.WireFrames.FromSqlRaw(@"
                        WITH tree AS (
                            SELECT 
                                wf.*
                            FROM 
                                render.WireFrames AS wf
                            WHERE 
                                wf.Discriminator = 'PrimeRoot' AND wf.Guid = {0}

                            UNION ALL

                            SELECT 
                                wf.*
                            FROM 
                                render.WireFrames AS wf
                            INNER JOIN 
                                tree ON wf.WireFrameId = tree.Id
                        )
                        SELECT * FROM tree", rootGuid).ToList();

        var root = nodes.FirstOrDefault() as PrimeRoot;
        var rootinfo = _context.PrimeRoots
                .Where(r => r.Guid.ToString() == rootGuid)
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

    public Task<PrimeRoot?> GetRootById(int id)
    {
        var nodes = _context.WireFrames.FromSqlRaw(@"
                        WITH tree AS (
                            SELECT 
                                wf.*
                            FROM 
                                render.WireFrames AS wf
                            WHERE 
                                wf.Discriminator = 'PrimeRoot' AND wf.Id = {0}

                            UNION ALL

                            SELECT 
                                wf.*
                            FROM 
                                render.WireFrames AS wf
                            INNER JOIN 
                                tree ON wf.WireFrameId = tree.Id
                        )
                        SELECT * FROM tree", id).ToList();

        var root = nodes.FirstOrDefault() as PrimeRoot;
        var rootinfo = _context.PrimeRoots
                .Where(r => r.Id == id)
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

    public Task<WireFrame?> GetWfsById(int id)
    {
        var nodes = _context.WireFrames.FromSqlRaw(@"
                        WITH tree AS (
                            SELECT 
                                wf.*
                            FROM 
                                render.WireFrames AS wf
                            WHERE 
                                wf.Discriminator = 'WireFrame' AND wf.Id = {0}

                            UNION ALL

                            SELECT 
                                wf.*
                            FROM 
                                render.WireFrames AS wf
                            INNER JOIN 
                                tree ON wf.WireFrameId = tree.Id
                        )
                        SELECT * FROM tree", id).ToList();

        var rootWfs = nodes.FirstOrDefault();
        return Task.FromResult(rootWfs);
    }

    public void DeleteRootById(int id)
    {
        _context.Database.ExecuteSqlRaw(@"
        WITH tree AS (
            SELECT 
                wf.*
            FROM 
                render.WireFrames AS wf
            WHERE 
                wf.Discriminator = 'PrimeRoot' AND wf.Id = {0}

            UNION ALL

            SELECT 
                wf.*
            FROM 
                render.WireFrames AS wf
            INNER JOIN 
                tree ON wf.WireFrameId = tree.Id
        )
        DELETE FROM render.WireFrames WHERE Id IN (SELECT Id FROM tree)", id);
        _context.SaveChanges();
    }

    public void DeleteWfsById(int id)
    {
        _context.Database.ExecuteSqlRaw(@"
        WITH tree AS (
            SELECT 
                wf.*
            FROM 
                render.WireFrames AS wf
            WHERE 
                wf.Discriminator = 'WireFrame' AND wf.Id = {0}

            UNION ALL

            SELECT 
                wf.*
            FROM 
                render.WireFrames AS wf
            INNER JOIN 
                tree ON wf.WireFrameId = tree.Id
        )
        DELETE FROM render.WireFrames WHERE Id IN (SELECT Id FROM tree)", id);
        _context.SaveChanges();
    }

}