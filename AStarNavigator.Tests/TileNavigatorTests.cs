using AStarNavigator.Algorithms;
using AStarNavigator.Providers;
using Moq;
using NUnit.Framework;

namespace AStarNavigator
{
    [TestFixture]
    public class TileNavigatorTests
    {
        [Test]
        public void Navigate_WhenStraightLine_ReturnsExpectedValues()
        {
            var sut = new TileNavigator(
                new EmptyBlockedProvider(),
                new DiagonalNeighborProvider(),
                new PythagorasAlgorithm(),
                new ManhattanHeuristicAlgorithm()
            );

            var from = new Tile(0, 0);
            var to = new Tile(0, 2);

            var result = sut.Navigate(from, to);

            var expected = new[]
            {
                new Tile(0, 1),
                new Tile(0, 2)
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void Navigate_WhenDiagonal_ReturnsExpectedValues()
        {
            var sut = new TileNavigator(
                new EmptyBlockedProvider(),
                new DiagonalNeighborProvider(),
                new PythagorasAlgorithm(),
                new ManhattanHeuristicAlgorithm()
            );

            var from = new Tile(0, 0);
            var to = new Tile(2, 2);

            var result = sut.Navigate(from, to);

            var expected = new[]
            {
                new Tile(1, 1),
                new Tile(2, 2)
            };

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void Navigate_WhenRouteIsBlocked_ReturnsNull()
        {
            var blockedMock = new Mock<IBlockedProvider>();

            blockedMock
                .Setup(m => m.IsBlocked(It.IsAny<Tile>()))
                .Returns(true);

            var sut = new TileNavigator(
                blockedMock.Object,
                new DiagonalNeighborProvider(),
                new PythagorasAlgorithm(),
                new ManhattanHeuristicAlgorithm()
            );

            var from = new Tile(0, 0);
            var to = new Tile(2, 2);

            var result = sut.Navigate(from, to);

            Assert.That(result, Is.EqualTo(null));
        }
    }
}
