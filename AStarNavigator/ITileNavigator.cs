using System.Collections.Generic;

namespace AStarNavigator
{
    public interface ITileNavigator
    {
        IReadOnlyCollection<Tile> Navigate(Tile from, Tile to);
    }
}