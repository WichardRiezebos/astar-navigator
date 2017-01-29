using System.Collections.Generic;

namespace AStar.Providers
{
    public interface INeighborProvider
    {
        IReadOnlyCollection<Tile> GetNeighbors(Tile tile);
    }
}
