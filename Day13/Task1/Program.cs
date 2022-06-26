using static System.Console;

namespace task1_2
{
    class Program
    {
        public delegate void Functions();

        static void Sum()
        {
            WriteLine(1 + 2);
        }
        static void Mult()
        {
            WriteLine(4 - 1);
        }
        static void Div()
        {
            WriteLine(5 - 1);
        }

        static void CallDelegate(Functions functions)
        {
            functions();
        }
        static void Main(string[] args)
        {
            Functions functions = new Functions(Sum);
            functions += Mult;
            functions += Div;
            CallDelegate(functions);
        }
    }
}