using NUnit.Framework;

namespace AStarNavigator.Providers
{
    [TestFixture]
    public class DiagonalNeighborProviderTests
    {
        [Test]
        public void GetNeighbors_WhenCalled_ReturnsExpectedValues()
        {
            var sut = new DiagonalNeighborProvider();

            var tile = new Tile(1, 1);

            var result = sut.GetNeighbors(tile);

            var expected = new[]
            {
                new Tile(0, 0),
                new Tile(0, 1),
                new Tile(0, 2),
                new Tile(1, 2),
                new Tile(2, 2),
                new Tile(2, 1),
                new Tile(2, 0),
                new Tile(1, 0),
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}
