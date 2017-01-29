namespace AStarNavigator.Providers
{
    public interface IBlockedProvider
    {
        bool IsBlocked(Tile coord);
    }
}
