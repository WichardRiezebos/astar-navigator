using System;

namespace AStarNavigator.Algorithms
{
    public class ManhattanHeuristicAlgorithm : IDistanceAlgorithm
    {
        public double Calculate(Tile from, Tile to) => 
            Math.Abs(from.X - to.X) + Math.Abs(from.Y - to.Y);
    }
}
