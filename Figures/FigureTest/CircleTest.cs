using Figures;

namespace FigureTest
{
    internal class CircleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(0)]
        [TestCase(-2)]
        public void GetSquareExceptionTest(double r)
        {
            Assert.Catch<ArgumentException>(() => new Circle(r));
        }

        [Test]
        [TestCase(5)]
        [TestCase(3452)]
        [TestCase(0.4)]
        public void GetSquare(double r)
        {
            var circle = new Circle(r);
            var trueSquare = Math.PI * Math.Pow(r, 2);

            var square = circle.GetSquare();

            Assert.Less(Math.Abs(square - trueSquare), 1e-7);
        }
    }
}
