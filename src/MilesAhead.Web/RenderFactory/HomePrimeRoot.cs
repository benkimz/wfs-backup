using MilesAhead.Components;

namespace MilesAhead.Web;

public class HomePrimeRoot
{
    protected PrimeRoot Root { get; set; } = new PrimeRoot { RootName = nameof(HomePrimeRoot) };
    public PrimeRoot Build()
    {
        Console.WriteLine($"Building {Root.RootName} PrimeRoot");
        // Root.MetaData = new WireFrame
        // {
        //     Name = "Home MetaData",
        //     Segment = "head",
        //     Children = new List<WireFrame>
        //     {
        //         new WireFrame
        //         {
        //             Name = "Meta",
        //             Segment = "meta",
        //             Attributes = new List<WireFrameAttribute>
        //             {
        //                 new WireFrameAttribute { Name = "charset", Value = "UTF-8" }
        //             }
        //         },
        //         new WireFrame
        //         {
        //             Name = "Meta",
        //             Segment = "meta",
        //             Attributes = new List<WireFrameAttribute>
        //             {
        //                 new WireFrameAttribute { Name = "name", Value = "viewport" },
        //                 new WireFrameAttribute { Name = "content", Value = "width=device-width, initial-scale=1" }
        //             }
        //         },
        //         new WireFrame
        //         {
        //             Name = "Title",
        //             Segment = "title",
        //             Data = new RenderData { FallbackRenderData = [
        //                 new RenderDataItem { Name = "Text", Value = "Miles Ahead" }
        //             ] }
        //         }
        //     }
        // };
        return Root;
    }
}
