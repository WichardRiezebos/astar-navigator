using NUnit.Framework;

namespace AStar.Algorithms
{
    [TestFixture]
    public class PythagorasAlgorithmTests
    {
        [Test]
        public void Calculate_WhenStraightLine_ReturnsExpectedValue()
        {
            var from = new Tile(0, 0);
            var to = new Tile(0, 10);

            var sut = new PythagorasAlgorithm();

            var result = sut.Calculate(from, to);

            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Calculate_WhenDiagonal_ReturnsExpectedValue()
        {
            var from = new Tile(0, 0);
            var to = new Tile(3, 4);

            var sut = new PythagorasAlgorithm();

            var result = sut.Calculate(from, to);

            Assert.That(result, Is.EqualTo(5));
        }
    }
}
