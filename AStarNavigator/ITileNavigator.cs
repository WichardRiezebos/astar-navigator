using System.Collections.Generic;

namespace AStarNavigator
{
    public interface ITileNavigator
    {
        IEnumerable<Tile> Navigate(Tile from, Tile to);
    }
}