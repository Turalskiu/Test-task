using Figures;

namespace FigureTest
{
    internal class TriangleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(5, 3, 14)]
        [TestCase(6, 5, 0)]
        [TestCase(6, 5, -2)]
        public void GetSquareExceptionTest(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        [TestCase(5, 3, 4, 6)]
        [TestCase(6, 5, 5, 12)]
        [TestCase(0.4, 0.3, 0.5, 0.06)]
        public void GetSquare(double a, double b, double c, double result)
        {
            var triangle = new Triangle(a, b, c);

            Assert.NotNull(triangle);
            var trueSquare = result;

            var square = triangle.GetSquare();

            Assert.Less(Math.Abs(square - trueSquare), 1e-7);
        }

        [TestCase(5, 4, 3, true)]
        [TestCase(5, 4, 4, false)]
        public void IsRightTriangle(double a, double b, double c, bool result)
        {
            var triangle = new Triangle(a, b, c);

            Assert.NotNull(triangle);
            Assert.AreEqual(result, triangle.IsRightTriangle());

        }
    }
}
