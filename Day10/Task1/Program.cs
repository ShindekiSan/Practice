using static System.Console;
using static System.Convert;

namespace task_1
{
    class Apartament
    {
        public string name { get; set; }
        public double square_meter_price { get; set; }
        public double square { get; set; }

        public Apartament(string apartamentName, double apartament_square, double price_for_meter)
        {
            name = apartamentName;
            square_meter_price = price_for_meter;
            square = apartament_square;
        }

        public double GetPrice()
        {
            double price = square_meter_price * square;

            return price;
        }
    }

    class CentralApartament : Apartament
    {
        public CentralApartament(string apartamentName, double apartament_square, double price_for_meter) : base(apartamentName, apartament_square, price_for_meter)
        {
            name = apartamentName;
            square_meter_price = price_for_meter;
            square = apartament_square;
        }
        public double IncreasePrice()
        {
            double price = base.GetPrice() * 0.01 + base.GetPrice();
            return price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите название квартиры: ");
            string name = ReadLine();

            Write("Введите цену за квадратный метр: ");
            double price_for_meter = ToDouble(ReadLine());

            Write("Введите площадь: ");
            double square = ToDouble(ReadLine());

            Apartament apartament = new Apartament(name, square, price_for_meter);
            CentralApartament centralApartament = new CentralApartament(name, square, price_for_meter);

            WriteLine($"{apartament.GetPrice()}");
            WriteLine($"{centralApartament.IncreasePrice()}");
        }
    }
}