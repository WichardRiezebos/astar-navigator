namespace AStarNavigator.Algorithms
{
    public interface IDistanceAlgorithm
    {
        double Calculate(Tile from, Tile to);
    }
}
