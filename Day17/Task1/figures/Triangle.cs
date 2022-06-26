using System;

namespace task1
{
    public class Triangle
    {

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double TriPerimetr(double SideA, double SideB, double SideC)
        {
            return SideA + SideB + SideC;
        }
        public string TriangleForm(double one, double two, double three)
        {
            if (one <= 0 || two <= 0 || three <= 0 || one + two <= three || one + three <= two || two + three <= one)
            {
                return "Треугольника с такими сторонами не существует!!!";
            }
            if (one == two && one == three && two == three)
            {
                double s = (Math.Pow(one, 2) * Math.Sqrt(3)) / 4;
                return $"Треугольник равносторонний!\nПлощадь треугольника равна {s}";
            }
            else if ((one == two && one != three) || (two == three && two != one) || (one == three && one != two))
            {
                double s = (three * Math.Sqrt(4 * Math.Pow(one, 2) - Math.Pow(two, 2))) / 4;
                return $"Треугольник равнобедренный!\nПлощадь треугольника равна {s}";
            }
            else
            {
                double p = TriPerimetr(one, two, three) / 2;
                double s = Math.Sqrt(p * (p - one) * (p - two) * (p - three));
                return $"Треугольник разносторонний!\nПлощадь треугольника равна {s}";
            }
        }
    }
}