using AStar.Algorithms;
using AStar.Providers;
using Moq;
using NUnit.Framework;

namespace AStar
{
    [TestFixture]
    public class TilePathfinderTests
    {
        [Test]
        public void FindRoute_WhenStraightLine_ReturnsExpectedValues()
        {
            var sut = new TilePathfinder(
                new EmptyBlockedProvider(),
                new DiagonalNeighborProvider(),
                new PythagorasAlgorithm(),
                new ManhattanHeuristicAlgorithm()
            );

            var from = new Tile(0, 0);
            var to = new Tile(0, 2);

            var result = sut.FindRoute(from, to);

            var expected = new[]
            {
                new Tile(0, 1),
                new Tile(0, 2)
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void FindRoute_WhenDiagonal_ReturnsExpectedValues()
        {
            var sut = new TilePathfinder(
                new EmptyBlockedProvider(),
                new DiagonalNeighborProvider(),
                new PythagorasAlgorithm(),
                new ManhattanHeuristicAlgorithm()
            );

            var from = new Tile(0, 0);
            var to = new Tile(2, 2);

            var result = sut.FindRoute(from, to);

            var expected = new[]
            {
                new Tile(1, 1),
                new Tile(2, 2)
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void FindRoute_WhenRouteIsBlocked_ReturnsNull()
        {
            var blockedMock = new Mock<IBlockedProvider>();

            blockedMock
                .Setup(m => m.IsBlocked(It.IsAny<Tile>()))
                .Returns(true);

            var sut = new TilePathfinder(
                blockedMock.Object,
                new DiagonalNeighborProvider(),
                new PythagorasAlgorithm(),
                new ManhattanHeuristicAlgorithm()
            );

            var from = new Tile(0, 0);
            var to = new Tile(2, 2);

            var result = sut.FindRoute(from, to);

            Assert.That(result, Is.EqualTo(null));
        }
    }
}
