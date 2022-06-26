using static System.Console;
using System.Threading;
using System.Diagnostics;

namespace task2
{
    class Program
    {
        static void Calculation()
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            int sum = 0;
            for (int i = 1; i < 11; i++)
            {
                sum += i;
                Thread.Sleep(10);
            }
            WriteLine(sum);
            sWatch.Stop();
            WriteLine($"Время на выполнение {Thread.CurrentThread.Name}: {sWatch.ElapsedMilliseconds}");

        }
        
        static void Main(string[] args)
        {
            
            Thread thread1 = new Thread(new ThreadStart(Calculation));
            thread1.Name = "поток 1";
            Thread thread2 = new Thread(new ThreadStart(Calculation));
            thread2.Name = "поток 2";
            thread1.Start();
            Thread.Sleep(100);
            thread2.Start();
        }
    }
}