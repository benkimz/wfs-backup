using wireframes.render.services;

namespace MilesAhead.Web;

public class BaseBuilder
{
    // ~ helpers:
    public static string AsJson<T>(T obj)
    {
        return WireframeParser.JsonFromObject(obj);
    }
}
