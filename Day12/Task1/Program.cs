using static System.Console;
using static System.Convert;
using static System.Math;

double radius;
double length, area, volume;

Figures fG;
fG = new Figures();

CalcFigures cF;

Write("Введите радиус окружности: ");
radius = ToDouble(ReadLine());

cF = fG.GetLength;
length = cF(radius);

WriteLine($"Длина окружности = {length}");

cF = fG.GetArea;
area = cF(radius);

WriteLine($"Площадь круга = {area}");

cF = fG.GetVolume;
volume = cF(radius);

WriteLine($"Объём шара = {volume}");

class Figures
{
    public double GetLength(double r)
    {
        double length;
        length = PI * 2 * r;
        return length;
    }

    public double GetArea(double r)
    {
        double area;
        area = PI * Pow(r, 2);
        return area;
    }

    public double GetVolume(double r)
    {
        double volume;
        volume = 4.0 / 3.0 * PI * Pow(r, 3);
        return volume;
    }
}

delegate double CalcFigures(double r);