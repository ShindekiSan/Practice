using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace task3
{
    class Plants
    {
        public string name;
        public int count;
        public Plants(string name, int count)
        {
            this.name = name;
            this.count = count;
        }
        virtual public void PrintInfoAboutPlant()
        {
            Console.WriteLine($"Название растения: '{name}' На планете их осталось: {count}");
        }
    }
    class InfoObj
    {
        public static void Info<tip>(tip obj)
        where tip : Plants
        {
            obj.PrintInfoAboutPlant();
        }
    }
    class Pl : IEnumerable
    {
        private ArrayList list;
        public Pl()
        {
            list = new ArrayList();
        }
        public Pl(ArrayList a)
        {
            list = a;
        }
        public void Add(Animals m)
        {
            list.Add(m);
        }
        public Pl Clone()
        {
            return new Pl(list);
        }
        public void RemoveAt(int i)
        {
            list.RemoveAt(i);
        }
        public void Clear()
        {
            list.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пример: ");
            Animals dem = new Animals("Ромашка", 5000000);
            InfoObj.Info<Animals>(dem);
            Pl plan_list = new Pl();
            Dictionary <int, string>hike = new Dictionary<int, string>(3);
            for (int i = 0; i <3; i++)
            {
                Console.Write("Введите название растения: ");
                string w = null;
                w = Console.ReadLine();
                Console.Write("Введите сколько их осталось на земле: ");
                int g =Convert.ToInt32(Console.ReadLine());
                
                plan_list.Add(new Animals(w, g));
                hike[i + 1] = w;
            }
            Console.WriteLine("============ ");
            foreach (KeyValuePair < int, string> keyValue in hike)
            {
                Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");
            }
            Console.WriteLine("============ ");
            foreach (Animals x in plan_list)
                x.PrintInfoAboutAnimal();
            plan_list.RemoveAt(1);
            Console.WriteLine("============ ");
            Pl pl = (Pl)plan_list.Clone();
            foreach (Animals x in pl) x.PrintInfoAboutAnimal();
            Console.ReadLine();
        }
    }
}