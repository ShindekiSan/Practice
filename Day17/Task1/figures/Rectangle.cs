using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task1
{
    public class Rectangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public string RecPerimetr(double SideA, double SideB)
        {
            double p = (SideA + SideB) * 2;
            return $"Периметр прямоугольника равен {p}";
        }
        public string RecSquare(double SideA, double SideB)
        {
            double s = SideA * SideB;
            return $"Площадь прямоугольника равна {s}";
        }
    }
}