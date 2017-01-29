using NUnit.Framework;

namespace AStarNavigator
{
    [TestFixture]
    public class TileTests
    {
        [Test]
        public void EqualityOperator_WhenCoordinatesMatch_ReturnsTrue()
        {
            var a = new Tile(1, 1);
            var b = new Tile(1, 1);

            var result = a == b;

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void InequalityOperator_WhenCoordinatesMatch_ReturnsFalse()
        {
            var a = new Tile(1, 1);
            var b = new Tile(1, 1);

            var result = a != b;

            Assert.That(result, Is.EqualTo(false));
        }
    }
}
