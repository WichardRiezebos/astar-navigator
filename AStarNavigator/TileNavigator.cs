using AStarNavigator.Algorithms;
using AStarNavigator.Providers;
using System.Collections.Generic;
using System.Linq;

namespace AStarNavigator
{
    public class TileNavigator : ITileNavigator
    {
        private readonly IBlockedProvider blockedProvider;
        private readonly INeighborProvider neighborProvider;

        private readonly IDistanceAlgorithm distanceAlgorithm;
        private readonly IDistanceAlgorithm heuristicAlgorithm;

        public TileNavigator(
            IBlockedProvider blockedProvider,
            INeighborProvider neighborProvider,
            IDistanceAlgorithm distanceAlgorithm,
            IDistanceAlgorithm heuristicAlgorithm)
        {
            this.blockedProvider = blockedProvider;
            this.neighborProvider = neighborProvider;

            this.distanceAlgorithm = distanceAlgorithm;
            this.heuristicAlgorithm = heuristicAlgorithm;
        }

        public IEnumerable<Tile> Navigate(Tile from, Tile to)
        {
            var closed = new List<Tile>();
            var open = new List<Tile>() { from };

            var path = new Dictionary<Tile, Tile>();

            var gScore = new Dictionary<Tile, double>();
            gScore[from] = 0;

            var fScore = new Dictionary<Tile, double>();
            fScore[from] = heuristicAlgorithm.Calculate(from, to);

            while (open.Any())
            {
                var current = open
                    .OrderBy(c => fScore[c])
                    .First();

                if (current == to)
                {
                    return ReconstructPath(path, current);
                }

                open.Remove(current);
                closed.Add(current);

                foreach (Tile neighbor in neighborProvider.GetNeighbors(current))
                {
                    if (closed.Contains(neighbor) || blockedProvider.IsBlocked(neighbor))
                    {
                        continue;
                    }

                    var tentativeG = gScore[current] + distanceAlgorithm.Calculate(current, neighbor);

                    if (!open.Contains(neighbor))
                    {
                        open.Add(neighbor);
                    }
                    else if (tentativeG >= gScore[neighbor])
                    {
                        continue;
                    }

                    path[neighbor] = current;

                    gScore[neighbor] = tentativeG;
                    fScore[neighbor] = gScore[neighbor] + heuristicAlgorithm.Calculate(neighbor, to);
                }
            }

            return null;
        }

        private IEnumerable<Tile> ReconstructPath(
            IDictionary<Tile, Tile> path,
            Tile current)
        {
            List<Tile> totalPath = new List<Tile>() { current };

            while (path.ContainsKey(current))
            {
                current = path[current];
                totalPath.Add(current);
            }

            totalPath.Reverse();
            totalPath.RemoveAt(0);

            return totalPath;
        }
    }
}
