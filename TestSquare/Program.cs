using AreaCalc;

namespace TestSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure triangle = new Triangle(20, 20, 35);
            Console.WriteLine(triangle.Form);
            Console.WriteLine(triangle.Rectangular);
            Console.WriteLine(triangle.GetSquare());

            Figure circle = new Circle(50);
            Console.WriteLine($"{circle.Form}, {circle.Rectangular}, {circle.GetSquare()} , {(circle as Circle).Radius}");
        }
    }
}