using static System.Console;
using static System.Math;
using System.Threading;

namespace task3
{
    class Program
    {
        static void Sum()
        {
            Write("Введите A: ");
            int a = Int16.Parse(ReadLine());

            Write("Введите N: ");
            int n = Int16.Parse(ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(a, i);
            }

            WriteLine(sum);
        }

        static void Mult()
        {
            Write("Введите A: ");
            int a = Int16.Parse(ReadLine());

            Write("Введите N: ");
            int n = Int16.Parse(ReadLine());

            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum *= Pow(a, i);
            }

            WriteLine(sum);
        }
        
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(Sum));
            Thread thread2 = new Thread(new ThreadStart(Sum));
            Thread thread3 = new Thread(new ThreadStart(Mult));
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}