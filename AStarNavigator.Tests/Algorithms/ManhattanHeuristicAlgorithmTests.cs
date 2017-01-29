using NUnit.Framework;

namespace AStarNavigator.Algorithms
{
    [TestFixture]
    public class ManhattanHeuristicAlgorithmTests
    {
        [Test]
        public void Calculate_WhenStraightLine_ReturnsExpectedValue()
        {
            var from = new Tile(0, 0);
            var to = new Tile(0, 10);

            var sut = new ManhattanHeuristicAlgorithm();

            var result = sut.Calculate(from, to);

            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Calculate_WhenDiagonal_ReturnsExpectedValue()
        {
            var from = new Tile(0, 0);
            var to = new Tile(10, 10);

            var sut = new ManhattanHeuristicAlgorithm();

            var result = sut.Calculate(from, to);

            Assert.That(result, Is.EqualTo(20));
        }
    }
}
