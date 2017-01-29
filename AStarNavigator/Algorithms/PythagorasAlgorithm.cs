using System;

namespace AStarNavigator.Algorithms
{
    public class PythagorasAlgorithm : IDistanceAlgorithm
    {
        public double Calculate(Tile from, Tile to)
        {
            return Math.Sqrt(
                Math.Pow(to.X - from.X, 2) +
                Math.Pow(to.Y - from.Y, 2)
            );
        }
    }
}
