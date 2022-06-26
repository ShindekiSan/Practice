using static System.Console;

namespace task3
{
    class MyInfo
    {
        private string name = "Максим";
        public delegate void MyInfoDel(string message);
        public event MyInfoDel? Call;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                Call?.Invoke($"Значение поля name измененно с {name} на {value}");
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyInfo m = new MyInfo();
            m.Call += DisplayMessage;
            m.Name = "Максим Абельчук";
            void DisplayMessage(string message) => WriteLine(message);
        }
    }
}