namespace AStar.Providers
{
    public interface IBlockedProvider
    {
        bool IsBlocked(Tile coord);
    }
}
