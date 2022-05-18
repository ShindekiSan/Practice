try
{
    int x;
    Console.Write("x=");
    x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"a) result = {a(x)}");
    Console.WriteLine($"b) result = {b(x)}");
}
catch (DivideByZeroException divideEx)
{
  Console.WriteLine(divideEx.Message);
}
catch (FormatException formatEx)
{
  Console.WriteLine(formatEx.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

double a(double x)
{
    return Math.Round(((Math.Cos(x*x) / (9*x - 9)) + Math.Pow(Math.Sin(x), 3)), 4);
}

double b(double x)
{
    return Math.Round((Math.Pow(Math.Sin(x), 3) / Math.Pow(x, 3)), 4);
}