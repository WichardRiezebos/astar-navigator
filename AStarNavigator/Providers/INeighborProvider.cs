using System.Collections.Generic;

namespace AStarNavigator.Providers
{
    public interface INeighborProvider
    {
        IEnumerable<Tile> GetNeighbors(Tile tile);
    }
}
