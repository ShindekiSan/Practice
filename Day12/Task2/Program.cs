using static System.Console;
using static System.Convert;

string a = " ";
while (a.Length > 0)
{
    try
    {
        WriteLine("Введите действие -  \n Cложение(+)\n Вычитание(-)\n Умножение(*)\n Деление(/)");
        a = ReadLine();
        WriteLine();
        if (a.Length > 0)
        {
            Console.Write("Первое число: ");
            int x = ToInt32(ReadLine());
            Write("Второе число: ");
            int y = ToInt32(ReadLine());
            WriteLine();
            switch (a)
            {
                case "+":
                    MyDelegat myDelegat = (c, b) => { return c + b; };
                    double del = myDelegat(x, y);
                    WriteLine($"Ответ:{del}\n");
                    break;
                case "-":
                    MyDelegat myDelegat1 = (c, b) => { return c - b; };
                    double del1 = myDelegat1(x, y);
                    WriteLine($"Ответ:{del1}\n");
                    break;
                case "*":
                    MyDelegat myDelegat2 = (c, b) => { return c * b; };
                    double del2 = myDelegat2(x, y);
                    WriteLine($"Ответ:{del2}\n");
                    break;
                case "/":
                    MyDelegat myDelegat3 = (c, b) => { return b == 0 ? throw new DivideByZeroException() : c / b; };
                    double del3 = myDelegat3(x, y);
                    WriteLine($"Ответ:{del3}\n");
                    break;
                default:
                    WriteLine("Выберите из предложенного");
                    break;

            }
        }
    }
    catch (Exception ex)
    {
        WriteLine(ex.Message);
    }

}

public delegate double MyDelegat(int a, int b);