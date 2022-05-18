try
{
    double x;
    Console.Write("x=");
    x = Convert.ToDouble(Console.ReadLine());
    double result = f(x);

    Console.WriteLine($"f = {result}");
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

double f(double x)
{
  if(x > -3 & x <= -1)
  {
    return x*2;
  } else if(x > -1 & x < 3)
  {
    return -2 / x;
  }
  return x;
}