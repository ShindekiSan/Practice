using static System.Convert;
using static System.Console;

namespace task1
{
    class Town
    {
        public string name;
        public Town()
        {
            this.name = null;
        }
        public virtual void Input()
        {
            Write("Введиете название пункта: ");
            name = ReadLine();
        }
        public virtual void GetInfo()
        {
            WriteLine($"название: {name}");
        }
    }

    class Country : Town
    {
        public int houseCount;
        public double square;
        public int peoplePerHouse;
        public double density;
        public Country()
        {
            this.houseCount = 0;
            this.square = 0.0;
            this.peoplePerHouse = 0;
            this.density = 0.0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Write("Введите количество домов: ");
            houseCount = ToInt32(ReadLine());
            Write("Введите площадь: ");
            square = ToDouble(ReadLine());
            Write("Введите количество людей на дом: ");
            peoplePerHouse = ToInt32(ReadLine());
        }
        public virtual void PopulationDensity()
        {
            density =  houseCount * peoplePerHouse / square;
        }
        public override void GetInfo()
        {
            PopulationDensity();
            WriteLine($"Название: {name}\n Количество домов: {houseCount}\n Площадь: {square}\n Человек на дом: {peoplePerHouse} Плотность населения: {density}");
        }
    }

    class City : Town
    {
        public int population;
        public double square;
        public double density;
        public City()
        {
            this.population = 0;
            this.square = 0.0;
            this.density = 0.0;
            Input();
        }
        public override void Input()
        {
            base.Input();
            Write("Введите площадь: ");
            square = ToDouble(ReadLine());
            Write("Введите популяцию: ");
            population = ToInt32(ReadLine());
        }
        public virtual void PopulationDensity()
        {
            density = population / square;
        }
        public override void GetInfo()
        {
            PopulationDensity();
            WriteLine($"Название: {name}\n Популяция: {population}\n Площадь: {square}\n Плотность: {density}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1.Село\n2.Город");
            WriteLine("Выберите создаваемый объект:");
            int change = ToInt32(ReadLine());
            int i = 0;
            double sum = 0;
            Console.Write("Введите количество городов: ");
            int mascount = ToInt32(ReadLine());
            Town[] towns = new Town[mascount];
            while (i< mascount)
            {
                switch (change)
                {
                    case 1: 
                        Country country = new Country();
                        country.PopulationDensity();
                        sum += country.density;
                        towns[i] = country as Town;++i;
                        break;

                    case 2: 
                        City city = new City();
                        city.PopulationDensity();
                        sum += city.density;
                        towns[i] = city as Town;++i;
                        break;

                    default: 
                        WriteLine("Данного пункта не существует");
                        break;
                }
            }
            for (int t = 0; t < towns.Length; t++)
            {
                if (towns[t] != null)
                {
                    towns[t].GetInfo();
                }
            }
            WriteLine("суммарная плонтность: "+ sum);
        }
    }
}