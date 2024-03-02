namespace MilesAhead.Web;

public class RootBuildHelpers
{
    public static string AsJson<T>(T obj)
    {
        return WireframeParser.JsonFromObject(obj);
    }
}
