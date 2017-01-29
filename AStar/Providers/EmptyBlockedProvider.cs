namespace AStar.Providers
{
    public class EmptyBlockedProvider : IBlockedProvider
    {
        public bool IsBlocked(Tile coord) => false;
    }
}
