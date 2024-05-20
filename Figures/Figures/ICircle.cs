using Microsoft.VisualBasic;

namespace Figures
{
    public class ICircle
    {
        public double Radius { get; }
    }

    public class Circle : IFigure
    {
        public const double MinRadius = 1e-6;

        private double eps = 1e-7;

        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius - MinRadius < eps)
                throw new ArgumentException("Неверно указан радиус круга.", nameof(radius));
            Radius = radius;
        }

        public double Radius { get; }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }
    }
}
