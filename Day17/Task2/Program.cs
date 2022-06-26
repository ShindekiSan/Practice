using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2_animals;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            const int n = 3;
            Animals[] animals = new Animals[n];
            animals[0] = new Animals.ZooAnimal(15, "Петр", "Жираф");
            animals[1] = new Animals.WildAnimal(10, "Белый медведь");
            foreach (Animals elem in animals)
            {
                elem.Description();
            }
        }
    }
}
