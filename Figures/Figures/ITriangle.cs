
using Microsoft.VisualBasic;

namespace Figures
{

    public interface ITriangle : IFigure
    {
        double SideA { get; }
        double SideB { get; }
        double SideC { get; }

        bool IsRightTriangle();
    }

    public class Triangle : ITriangle
    {
        private double eps = 1e-7;

        /// <exception cref="ArgumentException"></exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < eps)
                throw new ArgumentException("Неверно указана сторона.", nameof(sideA));

            if (sideB < eps)
                throw new ArgumentException("Неверно указана сторона.", nameof(sideB));

            if (sideC < eps)
                throw new ArgumentException("Неверно указана сторона.", nameof(sideC));

            var maxEdge = Math.Max(sideA, Math.Max(sideB, sideC));
            var perimeter = sideA + sideB + sideC;
            if ((perimeter - maxEdge) - maxEdge < eps)
                throw new ArgumentException("Такой треугольник не может существовать");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }


        public bool IsRightTriangle()
        {
            double maxSide = SideA, b = SideB, c = SideC;
            if (b - maxSide > eps)
                Swap(ref maxSide, ref b);

            if (c - maxSide > eps)
                Swap(ref maxSide, ref c);

            return Math.Abs(Math.Pow(maxSide, 2) - Math.Pow(b, 2) - Math.Pow(c, 2)) < eps;
        }

        public double GetSquare()
        {
            var P = (SideA + SideB + SideC) / 2d;
            var square = Math.Sqrt(P * (P - SideA) * (P - SideB) * (P - SideC));
            return square;
        }


        private void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
