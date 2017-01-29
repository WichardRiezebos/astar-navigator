using System.Collections.Generic;

namespace AStarNavigator.Providers
{
    public interface INeighborProvider
    {
        IReadOnlyCollection<Tile> GetNeighbors(Tile tile);
    }
}
