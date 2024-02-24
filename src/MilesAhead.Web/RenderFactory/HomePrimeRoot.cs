using MilesAhead.Components;

namespace MilesAhead.Web;

public class HomePrimeRoot
{
    protected PrimeRoot Root { get; set; } = new PrimeRoot();

    protected PrimeRoot Build()
    {
        return Root;
    }
}
