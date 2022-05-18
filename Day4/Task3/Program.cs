try
{
    double b1 = 1.1, b2 = 2.2, b3 = 3.3, b4 = 4.4, b5 = 5.5;

    Console.WriteLine($"b1(1.1)^3 = {PowerA3(b1)}");
    Console.WriteLine($"b2(2.2)^3 = {PowerA3(b2)}");
    Console.WriteLine($"b3(3.3)^3 = {PowerA3(b3)}");
    Console.WriteLine($"b4(4.4)^3 = {PowerA3(b4)}");
    Console.WriteLine($"b5(5.5)^3 = {PowerA3(b5)}");
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

double PowerA3(double a)
{
  return Math.Round(Math.Pow(a, 3), 4);
}