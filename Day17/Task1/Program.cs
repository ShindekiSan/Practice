using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Triangle triag = new Triangle();

            Console.WriteLine("Введите стороны треугольника:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"Периметр треугльника равен {triag.TriPerimetr(a, b, c)}");
            Console.WriteLine(triag.TriangleForm(a, b, c));

            Console.WriteLine("Введите стороны прямоугольника:");
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());

            Console.WriteLine(rec.RecPerimetr(a1, b1));
            Console.WriteLine(rec.RecSquare(a1, b1));
        }
    }
}
