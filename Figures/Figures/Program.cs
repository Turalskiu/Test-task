namespace Figures
{
    public class Program
    {
        static void Main(string[] args)
        {
            IFigure figure = new Triangle(5, 2, 4);

            Console.WriteLine(figure.GetSquare());
        }
    }
}
