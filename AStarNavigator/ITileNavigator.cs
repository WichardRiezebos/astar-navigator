using System.Collections.Generic;

namespace AStarNavigator
{
    /// <summary>
    /// Represents an interface to enable a class to navigate from point A to B.
    /// </summary>
    public interface ITileNavigator
    {
        /// <summary>
        /// Get a list of tiles which represents a route.
        /// </summary>
        /// <param name="from">The tile to navigate from.</param>
        /// <param name="to">The tile to navigate to.</param>
        IReadOnlyCollection<Tile> Navigate(Tile from, Tile to);
    }
}