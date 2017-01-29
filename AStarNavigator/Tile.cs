namespace AStarNavigator
{
    public struct Tile
    {
        public double X { get; private set; }

        public double Y { get; private set; }

        public Tile(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(Tile a, Tile b) => a.X == b.X && a.Y == b.Y;

        public static bool operator !=(Tile a, Tile b) => !(a == b);

        public override bool Equals(object obj) => (this == (Tile)obj);

        public override int GetHashCode() => X.GetHashCode() ^ Y.GetHashCode();
    }
}
